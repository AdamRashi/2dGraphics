namespace _2dGraphics
{
    public class Points
    {
        public static Color DEFAULT_POINT_COLOR = Color.Red;

        public static Color DEFAULT_LINE_COLOR = Color.ForestGreen;

        // список точек
        public List<Point> List = new List<Point>();

        // флаги нарисованных фигур
        public bool BrokenLine { get; set; } = false;
        public bool Curve { get; set; } = false;
        public bool Beziers { get; set; } = false;
        public bool Filling { get; set; } = false;

        // радиус точки
        public int Radius { get; set; } = 5;
        public int LineWidth { get; set; } = 5;

        // цвета точки и линий
        public Color PointColor { get; set; } = DEFAULT_POINT_COLOR;
        public Color LineColor { get; set; } = DEFAULT_LINE_COLOR;

        // смещение по иксу и игрику на форме для каждой точки отдельно
        public (int, int)[] deltas = new (int, int)[] { };

        public Points() { }

        public void Clear()
        {
            List.Clear();
            BrokenLine = Curve = Beziers = Filling = false;
        }

        public Point[] ToArray() => List.ToArray();
    }
}
