namespace Lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = -1.25;
            var b = -1.5;
            var c = 0.75;

            var xMin = double.Parse(textBox1.Text);
            var xMax = double.Parse(textBox2.Text);
            var step = double.Parse(textBox3.Text);

            var count = (int)Math.Ceiling((xMax - xMin) / step) + 1;

            var x = new double[count];
            var y = new double[count];

            for (var i = 0; i < count; i++)
            {
                x[i] = xMin + step * i;
                y[i] = 1 / 100 * b * c / x[i] + Math.Cos(Math.Sqrt(a * a * a * x[i]));
            }

            chart1.ChartAreas[0].AxisX.Minimum = xMin;
            chart1.ChartAreas[0].AxisX.Maximum = xMax;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = step;

            chart1.Series[0].Points.DataBindXY(x, y);
        }
    }
}