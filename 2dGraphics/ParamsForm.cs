namespace _2dGraphics
{
    public partial class ParamsForm : Form
    {
        private FormCurves parent;

        public ParamsForm(FormCurves parentForm)
        {
            InitializeComponent();
            
            parent = parentForm;

            trcbarPointSize.Value = parent.points.Radius;
            trcbarWidth.Value = parent.points.LineWidth;

            trcbarPointSize.ValueChanged += new EventHandler(saveChangedValue);
            trcbarWidth.ValueChanged += new EventHandler(saveChangedValue);
        }
       
        //Дополнительноe задание - кнопка сохранения значений
        void saveChangedValue(object sender, EventArgs e)
        {
            parent.points.Radius = trcbarPointSize.Value;
            parent.points.LineWidth = trcbarWidth.Value;
            parent.Refresh();
        }

        private void btnPointColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = Points.DEFAULT_POINT_COLOR;
            colorDialog.FullOpen = true;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (parent.myPictureBox1.BackColor == colorDialog.Color)
                    return;
                parent.points.PointColor = colorDialog.Color;
                parent.Refresh();
            }
        }

        private void btnLineColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.FullOpen = true;
            colorDialog.Color = Points.DEFAULT_LINE_COLOR;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (parent.myPictureBox1.BackColor == colorDialog.Color)
                    return;
                parent.points.LineColor = colorDialog.Color;
                parent.Refresh();
            }

        }

        private void ParamsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.IsParamsOpen = false;
            parent.UpdateButtons();

        }
    }
}
