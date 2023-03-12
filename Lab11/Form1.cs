namespace Lab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private int x1, y1, x2, y2;
        private double a, t, fi;
        private Pen pen = new Pen(Color.Red, 2);

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private int currentSize = 200;
        private bool grow = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (grow)
                currentSize += 4;
            else currentSize -= 1;

            if (currentSize >= 300)
                grow = false;
            if (currentSize <= 200)
                grow = true;

            heartPictureBox1.Size = new Size(currentSize, currentSize);
            heartPictureBox1.Refresh();
        }
    }
}