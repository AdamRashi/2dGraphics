using Timer = System.Windows.Forms.Timer;

namespace _2dGraphics
{
    public partial class FormCurves : Form
    {
        private static Color DEFAULT_BUTTON_COLOR = Color.White;
        
        private static Color BLOCKED_BUTTON_COLOR = Color.DarkGray;

        private static Color CHOSEN_BUTTON_COLOR = Color.ForestGreen;

        //������ ���� �����, ������������ ��� ����������
        public List<Points> savedFigures = new List<Points>();

        //// ������ ����� � ������� ������
        public Points points = new Points();

        //// ����, ���������� �� ����� ���������� �����
        private bool isAddingPoints;


        //// ���������� ��� �������� ��������������� �����
        private Point dragPoint; // ��������������� �����
        private int indexOfDragPoint = -1; // ������ ����� � ������
        private bool isDraggingPoints; // ����, ���������� �� �������� �����

        //// ����������, ���������� �� ������������� ���������� ������ ������
        private readonly Timer timerForMoving;
        private int tick = 50;
        private bool isFigureMoving; // ����, ���������� �� �������� ������

        //�����, ���������� ����������� ������������� ������
        private bool isBeizersAvailable;
        private bool isCurveAvailable;
        private bool isBrokenLineAvailable;
        private bool isFillingAvailable;

        // ���� ����������
        private ParamsForm paramsWindow;
        private bool isParamsOpen;

        public bool IsParamsOpen { get => isParamsOpen; set => isParamsOpen = value; }


        public FormCurves()
        {
            InitializeComponent();

            UpdateButtons();
            PaintButton(btnPoints, !isAddingPoints);

            // ��������� �������
            timerForMoving = new Timer();
            timerForMoving.Interval = 1000; // 1000 - 1 �������
            timerForMoving.Tick += MoveFigureInDiffDir;

            KeyPreview = true;

            myPictureBox1.Paint += MainDraw;
            myPictureBox1.Paint += DrawSavedFigures;
        }

       
        // ������� �������� � ������ ������������
        private void MoveFigureInDiffDir(object sender, EventArgs e)
        {
            var temp = new List<Point>();

            for (var i = 0; i < points.List.Count; i++)
            {
                var dx = points.deltas[i].Item1;
                var dy = points.deltas[i].Item2;
                var point = new Point(points.List[i].X + dx, points.List[i].Y + dy);

                if (point.X - points.Radius <= myPictureBox1.ClientRectangle.Left ||
                    point.X + points.Radius >= myPictureBox1.ClientRectangle.Right)
                {
                    points.deltas[i] = (-dx, dy);
                    point.X -= dx;
                    point.Y -= dy;
                }

                if (point.Y - points.Radius <= myPictureBox1.ClientRectangle.Top ||
                    point.Y + points.Radius >= myPictureBox1.ClientRectangle.Bottom)
                {
                    points.deltas[i] = (dx, -dy);
                    point.X -= dx;
                    point.Y -= dy;
                }

                temp.Add(point);
            }

            points.List = temp;
            Refresh();

            if (!isFigureMoving)
                timerForMoving.Stop();
        }

        // ������� MouseMove
        private void MovePoint(object sender, MouseEventArgs e)
        {
            // ���������� ������� �������
            var cursor = e.Location;

            // ���� ����� ��������� ����� ������������ � �����-����, ������� �� ������
            if (points.List.Any(point => 
                cursor.X >= point.X - points.Radius * 2 && 
                cursor.X <= point.X + points.Radius * 2 && 
                cursor.Y >= point.Y - points.Radius * 2 &&
                cursor.Y <= point.Y + points.Radius * 2))
                return;

            // ���� ���� ������������ �� ������� ��� �� �������� ������� ����, ������� �� ������
            if (!isDraggingPoints || isOutOfBox(cursor, points.Radius)) return;

            // �������������� �������� ��������������� �����
            dragPoint = cursor;
            points.List[indexOfDragPoint] = cursor;
            Refresh();
        }

        // ������� MouseUp
        private void ShiftPoint(object sender, MouseEventArgs e)
        {

            if (!isDraggingPoints) return;

            // ��������� ��������� ����� � ������
            points.List[indexOfDragPoint] = dragPoint;
            indexOfDragPoint = -1; // ���������� ������ ��������������� �����
            isDraggingPoints = false; // ���������� ���� ��������������
            Refresh();
            UpdateButtons();
        }

        // ������� MouseDown
        private void ChoosePoint(object sender, MouseEventArgs e)
        {
            if (isFigureMoving) return;

            var cursor = e.Location;

            for (var i = 0; i < points.List.Count; i++)
            {
                var point = points.List[i];

                // ���� ������ ����� � ����������� �����-���� �����
                if (cursor.X >= point.X - points.Radius &&
                    cursor.X <= point.X + points.Radius &&
                    cursor.Y >= point.Y - points.Radius &&
                    cursor.Y <= point.Y + points.Radius)
                {
                    // ���������� ����� � ������� �� ������
                    isDraggingPoints = true;
                    dragPoint = point;
                    indexOfDragPoint = i;
                    return;
                }
            }

            UpdateButtons();
        }

        // ����������� ����� � �����
        private void MainDraw(object sender, PaintEventArgs e)
        {
            DrawFigures(points, e);
        }
        
        // ��������� �����
        private void DrawFigures(Points figure, PaintEventArgs e)
        {
            Pen pen = new Pen(figure.PointColor);
            SolidBrush brush = new SolidBrush(figure.PointColor);

            foreach (var point in figure.List)
            {
                e.Graphics.DrawEllipse(pen, point.X - figure.Radius, point.Y - figure.Radius, figure.Radius * 2, figure.Radius * 2);
                e.Graphics.FillEllipse(brush, point.X - figure.Radius, point.Y - figure.Radius, figure.Radius * 2, figure.Radius * 2);
            }


            pen.Color = figure.LineColor;
            brush.Color = figure.LineColor;
            pen.Width = figure.LineWidth;

            if (figure.BrokenLine && figure.List.Count >= 2)
                e.Graphics.DrawPolygon(pen, figure.ToArray());
            else figure.BrokenLine = false;

            if (figure.Curve && figure.List.Count >= 3)
                e.Graphics.DrawClosedCurve(pen, figure.ToArray());
            else figure.Curve = false;

            if (figure.Beziers && figure.List.Count % 3 == 1)
                e.Graphics.DrawBeziers(pen, figure.ToArray());
            else figure.Beziers = false;

            if (figure.Filling && figure.List.Count >= 3)
                e.Graphics.FillClosedCurve(brush, figure.ToArray());
            else figure.Filling = false;


            // ���������� ������ ��� �������� ������
            if (figure.List.Count >= 2)
            {
                isBrokenLineAvailable = true;
                if (figure.List.Count >= 3)
                {
                    isFillingAvailable = true;
                    isCurveAvailable = true;
                }
                if (figure.List.Count % 3 == 1)
                    isBeizersAvailable = true;
                else
                    isBeizersAvailable = false;
            }
            else
            {
                isBeizersAvailable = false;
                isCurveAvailable = false;
                isBrokenLineAvailable = false;
                isFillingAvailable = false;
            }
        }

        private void DrawSavedFigures(object? sender, PaintEventArgs e)
        {
            for (int i = 0; i < savedFigures.Count; i++)
            {
                DrawFigures(savedFigures[i], e);
            }

        }

        // ������� MouseClick
        private void DrawPoint(object sender, MouseEventArgs e)
        {
            // ���� ����� ������ �� ���������� ����� ��� ���������� �������������� �����, �� ������� �� ������
            if (isAddingPoints == false || isDraggingPoints || isFigureMoving) return;

            if (e.Button == MouseButtons.Right)
                return;

            // ���������� ��������� �������
            var cursor = new Point(e.Location.X, e.Location.Y);


            // ���� ����� ����� ������������ � ��� ������������, �� �� ���������
            if (points.List.Any(point => cursor.X >= point.X - points.Radius * 2 &&
                                         cursor.X <= point.X + points.Radius * 2 &&
                                         cursor.Y >= point.Y - points.Radius * 2 &&
                                         cursor.Y <= point.Y + points.Radius * 2))
                return;

            // ��������� ����� � ������
            points.List.Add(new Point(cursor.X, cursor.Y));

            Refresh();
            UpdateButtons();
        }

        // ������ �������� ������
        private void PaintButton(Button button, bool flag)
        {
            button.BackColor = flag ? DEFAULT_BUTTON_COLOR : BLOCKED_BUTTON_COLOR;

        }

        private void PaintActiveButton(Button button, bool flag,
                                        bool flag2 = true)
        {

            if (flag)
            {
                button.BackColor = CHOSEN_BUTTON_COLOR;
            }
            else
            {
                PaintButton(button, flag2);
            }
        }

        // ����� ����� �������� ��� ���� ������
        internal void UpdateButtons()
        {
            bool isMovementAvailable = points.List.Count > 0;
            bool isSavingAvailable = points.List.Count > 0 && !isFigureMoving;
            bool isCleanAvailable = savedFigures.Count > 0 || points.List.Count > 0;
    

            PaintActiveButton(btnPoints, isAddingPoints);
            PaintActiveButton(btnBrokenLine, points.BrokenLine, isBrokenLineAvailable);
            PaintActiveButton(btnCurve, points.Curve, isCurveAvailable);
            PaintActiveButton(btnBeizers, points.Beziers, isBeizersAvailable);
            PaintActiveButton(btnFill, points.Filling, isFillingAvailable);
            PaintActiveButton(btnMovement, isFigureMoving, isMovementAvailable);
            PaintActiveButton(btnParams, IsParamsOpen);
            PaintButton(btnSave, isSavingAvailable);
            PaintButton(btnClean, isCleanAvailable);

            btnBrokenLine.Enabled = btnBrokenLine.BackColor == BLOCKED_BUTTON_COLOR ? false : true;
            btnBeizers.Enabled = btnBeizers.BackColor == BLOCKED_BUTTON_COLOR ? false : true;
            btnClean.Enabled = btnClean.BackColor == BLOCKED_BUTTON_COLOR ? false : true;
            btnCurve.Enabled = btnCurve.BackColor == BLOCKED_BUTTON_COLOR ? false : true;
            btnFill.Enabled = btnFill.BackColor == BLOCKED_BUTTON_COLOR ? false : true;
            btnSave.Enabled = btnSave.BackColor == BLOCKED_BUTTON_COLOR ? false : true;
            btnMovement.Enabled = btnMovement.BackColor == BLOCKED_BUTTON_COLOR ? false : true;

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // ������� KeyDown ��� �������
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (isFigureMoving) return false;

            switch (keyData)
            {
                case Keys.Left:
                    MoveFigures(ref points, -points.Radius, 0);
                    break;

                case Keys.Right:
                    MoveFigures(ref points, points.Radius, 0);
                    break;

                case Keys.Up:
                    MoveFigures(ref points, 0, -points.Radius);
                    break;

                case Keys.Down:
                    MoveFigures(ref points, 0, points.Radius);
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void MoveFigures(ref Points figure, int x, int y)
        {
            var temp = new List<Point>();

            foreach (var point in figure.List.Select(t => new Point(t.X + x, t.Y + y)))
            {
                if (isOutOfBox(point, figure.Radius))
                    return;

                temp.Add(point);
            }

            figure.List = temp;
            Refresh();
        }

        // ����� �������� ������ �� ������� PictureBox
        private bool isOutOfBox(Point point, int r)
        {
            return point.X - r <= myPictureBox1.ClientRectangle.Left ||
                   point.Y - r <= myPictureBox1.ClientRectangle.Top ||
                   point.X + r >= myPictureBox1.ClientRectangle.Right ||
                   point.Y + r >= myPictureBox1.ClientRectangle.Bottom;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isFigureMoving) return;
            if (points.List.Count <= 0) return;
            savedFigures.Add(points);
            points = new Points();
            isAddingPoints = false;


            isBeizersAvailable = false;
            isCurveAvailable = false;
            isBrokenLineAvailable = false;
            isFillingAvailable = false;
            UpdateButtons();

        }

        private void btnPoints_Click(object sender, EventArgs e)
        {
            // ����������� ����������� ��������� �����
            if (isFigureMoving) return;
            isAddingPoints = !isAddingPoints;
            UpdateButtons();
        }

        private void btnParams_Click(object sender, EventArgs e)
        {
            IsParamsOpen = !IsParamsOpen;
            if (IsParamsOpen)
            {
                paramsWindow = new ParamsForm(this);
                paramsWindow.Show();
            }
            else
                paramsWindow.Close();
            UpdateButtons();
        }

        private void btnBeizers_Click(object sender, EventArgs e)
        {
            if (points.List.Count == 1 || points.List.Count % 3 != 1) 
                return;

            points.Beziers = !points.Beziers;
            Refresh();
            UpdateButtons();
        }

        private void btnBrokenLine_Click(object sender, EventArgs e)
        {
            if (points.List.Count < 2) return;
            points.BrokenLine = !points.BrokenLine;
            Refresh();
            UpdateButtons();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            if (points.List.Count < 3) return;
            points.Filling = !points.Filling;
            Refresh();
            UpdateButtons();
        }

        private void btnCurve_Click(object sender, EventArgs e)
        {
            if (points.List.Count < 3) return;
            points.Curve = !points.Curve;
            Refresh();
            UpdateButtons();
        }

        //����. ������� ��� ����������
        private void form�urves_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    btnClean_Click(sender, e);
                    break;

                case Keys.Space:
                    btnMovement_Click(sender, e);
                    break;

                case Keys.Oemplus:
                    if (timerForMoving.Interval - tick > 0)
                        timerForMoving.Interval -= tick;
                    break;

                case Keys.OemMinus:
                    timerForMoving.Interval += tick;
                    break;
            }

            e.Handled = true;
        }

        private void btnMovement_Click(object sender, EventArgs e)
        {
            isFigureMoving = !isFigureMoving;
            if (isFigureMoving)
            {
                isAddingPoints = false;
            }

            if (!isFigureMoving) { UpdateButtons(); return; }


            var rndDir = new[] { -points.Radius, 0, points.Radius };
            var rnd = new Random();

            #region DiffDirection_CurrentFigure

            points.deltas = new (int, int)[points.List.Count];

            for (int i = 0; i < points.deltas.Length; i++)
            {
                while (points.deltas[i].Item1 == 0 && points.deltas[i].Item2 == 0)
                    points.deltas[i] = (rndDir[rnd.Next(0, 3)], rndDir[rnd.Next(0, 3)]);
            }

            #endregion
            UpdateButtons();
            timerForMoving.Start();

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            // ������� ������ �����
            points.Clear();
            savedFigures.Clear();

            // ��������� ����� ��� ������
            isFigureMoving = false;
            if (IsParamsOpen)
            {
                IsParamsOpen = false;
                paramsWindow.Close();
            }
            if (isAddingPoints)
            {
                isAddingPoints = false;
            }

            isBeizersAvailable = false;
            isCurveAvailable = false;
            isBrokenLineAvailable = false;
            isFillingAvailable = false;

            Refresh();
            UpdateButtons();
        }
    }

    public class MyPictureBox : PictureBox
    {
        public MyPictureBox()
        {
            DoubleBuffered = true;
        }
    }
}

