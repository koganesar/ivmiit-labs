using System.Drawing;

namespace Lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            var size = 100;
            e.Graphics.FillPolygon(Brushes.Aquamarine, new Point[] { new Point(150, 20), new Point(150 - size, 20 + (int)(size * Math.Sqrt(3))), new Point(150 + size, 20 + (int)(size * Math.Sqrt(3))) });

            var radius = 100;
            g.DrawEllipse(new Pen(Brushes.Red), 200 - radius, 200 - radius,
                     radius + radius, radius + radius);


            g.FillRectangle(Brushes.Blue, 250, 150, 200, 200);
        }
    }
}