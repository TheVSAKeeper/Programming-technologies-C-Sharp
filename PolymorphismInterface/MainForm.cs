using System;
using System.Windows.Forms;
using PolymorphismInterface.Help;
using PolymorphismInterface.Interfaces;

namespace PolymorphismInterface
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnStartClicked(object sender, EventArgs e)
        {
            _startButton.Enabled = false;

            try
            {
                ShowSquareInfo();
                ShowRhombusInfo();
                ShowPointInfo();
                ShowCircleInfo();
                ShowSphereInfo();
                ShowConeInfo();
                ShowSnowmanInfo();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source);
            }
        }

        private void OnResetClicked(object sender, EventArgs e)
        {
            _logInformation.Clear();
            _startButton.Enabled = true;
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

        private void ShowSquareInfo()
        {
            if (float.TryParse(_squareSide.Text, out float side) == false)
                return;

            Square square = new Square(side);

            ShowInfo("Квадрат", square);
        }

        private void ShowRhombusInfo()
        {
            if ((float.TryParse(_rhombusSide.Text, out float side) && float.TryParse(_rhombusAngle.Text, out float angle)) == false)
                return;

            Rhombus rhombus = new Rhombus(side, angle);

            ShowInfo("Ромб", rhombus);
        }

        private void ShowPointInfo()
        {
            if ((float.TryParse(_pointX.Text, out float x) && float.TryParse(_pointY.Text, out float y)) == false)
                return;

            Point point = new Point(x, y);

            ShowInfo("Точка", point);
        }

        private void ShowCircleInfo()
        {
            if ((float.TryParse(_circleX.Text, out float x) &&
                 float.TryParse(_circleY.Text, out float y) &&
                 float.TryParse(_circleRadius.Text, out float radius)) ==
                false)
                return;

            Circle circle = new Circle(new Point(x, y), radius);

            ShowInfo("Круг", circle);
        }

        private void ShowSphereInfo()
        {
            if ((float.TryParse(_sphereX.Text, out float x) &&
                 float.TryParse(_sphereY.Text, out float y) &&
                 float.TryParse(_sphereRadius.Text, out float radius)) ==
                false)
                return;

            Sphere sphere = new Sphere(new Point(x, y), radius);

            ShowInfo("Сфера", sphere);
        }

        private void ShowConeInfo()
        {
            if ((float.TryParse(_coneX.Text, out float x) &&
                 float.TryParse(_coneY.Text, out float y) &&
                 float.TryParse(_coneRadius.Text, out float radius) &&
                 float.TryParse(_coneHeight.Text, out float height)) ==
                false)
                return;

            Cone cone = new Cone(new Point(x, y), radius, height);

            ShowInfo("Конус", cone);
        }

        private void ShowSnowmanInfo()
        {
            if ((float.TryParse(_bucketHeight.Text, out float bucketHeight) &&
                 float.TryParse(_bucketRadius.Text, out float bucketRadius) &&
                 float.TryParse(_headRadius.Text, out float headRadius) &&
                 float.TryParse(_bodyRadius.Text, out float bodyRadius) &&
                 float.TryParse(_botomRadius.Text, out float bottomRadius)) ==
                false)
                return;

            Snowman snowman = new Snowman(new Cone(bucketRadius, bucketHeight),
                new Sphere(headRadius),
                new Sphere(bodyRadius),
                new Sphere(bottomRadius));

            ShowInfo("Снеговик-ходок", snowman);
        }

        private void ShowInfo(string header, IDescribing describing)
        {
            _logInformation.Text += $@"{header}{Environment.NewLine}{describing.Description}{Environment.NewLine}{Environment.NewLine}";
        }
    }
}