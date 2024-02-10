using System;
using System.Windows.Forms;
using Polymorphism.Help;
using Polymorphism.Points;
using Polymorphism.TwoDimensionalShapes;

namespace Polymorphism
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnHelpClicked(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm("Help/Help.rtf");
            helpForm.Show();
        }

        private void OnCloseClicked(object sender, EventArgs e)
        {
            Close();
        }

        private void OnStartClicked(object sender, EventArgs e)
        {
            _startButton.Enabled = false;

            ShowSquareInfo();
            ShowRhombusInfo();
            ShowPointInfo();
            ShowCircleInfo();
            ShowSphereInfo();
            ShowConeInfo();
            ShowSnowmanInfo();
        }

        private void ShowSquareInfo()
        {
            if (double.TryParse(_squareSide.Text, out double side) == false)
                return;

            Square square = new Square(side);
            ShowInfo(_logInformation, "Квадрат", square.GetDescription());
        }

        private void ShowRhombusInfo()
        {
            if (double.TryParse(_rhombusFirstDiagonal.Text, out double firstDiagonal) == false ||
                double.TryParse(_rhombusSecondDiagonal.Text, out double secondDiagonal) == false)
                return;

            Rhombus rhombus = new Rhombus((firstDiagonal, secondDiagonal));

            ShowInfo(_logInformation, "Ромб", rhombus.GetDescription());
        }

        private void ShowPointInfo()
        {
            if (double.TryParse(_pointX.Text, out double x) == false || double.TryParse(_pointY.Text, out double y) == false)
                return;

            Point point = new Point
            {
                PointX = x,
                PointY = y
            };

            ShowInfo(_logInformation, "Точка", point);
        }

        private void ShowCircleInfo()
        {
            if (double.TryParse(_circleX.Text, out double x) == false ||
                double.TryParse(_circleY.Text, out double y) == false ||
                double.TryParse(_circleRadius.Text, out double radius) == false)
                return;

            Circle circle = new Circle(x, y)
            {
                Radius = radius
            };

            ShowInfo(_logInformation, "Круг", circle);
        }

        private void ShowSphereInfo()
        {
            if (double.TryParse(_sphereX.Text, out double x) == false ||
                double.TryParse(_sphereY.Text, out double y) == false ||
                double.TryParse(_sphereRadius.Text, out double radius) == false)
                return;

            Sphere sphere = new Sphere(x, y, radius);

            ShowInfo(_logInformation, "Сфера", sphere);
        }

        private void ShowConeInfo()
        {
            if (double.TryParse(_coneX.Text, out double x) == false ||
                double.TryParse(_coneY.Text, out double y) == false ||
                double.TryParse(_coneRadius.Text, out double radius) == false ||
                double.TryParse(_coneHeight.Text, out double height) == false)
                return;

            Cone cone = new Cone(x, y, radius)
            {
                Height = height
            };

            ShowInfo(_logInformation, "Конус", cone);
        }

        private void ShowSnowmanInfo()
        {
            if (double.TryParse(_bucketHeight.Text, out double bucketHeight) == false ||
                double.TryParse(_bucketRadius.Text, out double bucketRadius) == false ||
                double.TryParse(_headRadius.Text, out double headRadius) == false ||
                double.TryParse(_bodyRadius.Text, out double bodyRadius) == false ||
                double.TryParse(_botomRadius.Text, out double bottomRadius) == false)
                return;

            Snowman nightKing = new Snowman
            {
                Bucket = { Height = bucketHeight, Radius = bucketRadius },
                Head = { Radius = headRadius },
                AverageBody = { Radius = bodyRadius },
                LowerBody = { Radius = bottomRadius }
            };

            _logInformation.Text += $@"Снеговик-ходок{Environment.NewLine}";
            _logInformation.Text += $@"Объем снеговика-ходока: {nightKing.Volume:F3}{Environment.NewLine}";
            _logInformation.Text += $@"Площадь поверхности снеговика-ходока: {nightKing.SurfaceArea:F3}{Environment.NewLine}";
        }

        private static void ShowInfo(Control control, string header, Point point)
        {
            ShowInfo(control, header, point.GetDescription());
        }

        private static void ShowInfo(Control control, string header, string body)
        {
            control.Text += $@"{header}{Environment.NewLine}{body}{Environment.NewLine}{Environment.NewLine}";
        }

        private void OnResetClicked(object sender, EventArgs e)
        {
            _logInformation.Clear();
            _startButton.Enabled = true;
        }
    }
}