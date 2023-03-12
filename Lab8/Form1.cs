namespace Lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 4;
            var a = new int[3, 4];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                {
                    a[i, j] = Random.Shared.Next(-100, 100);
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j];
                }
            var result = string.Empty;
            for (var i = 0; i < 3; ++i)
            {
                var min = int.MaxValue;
                for (var j = 0; j < 4; ++j)
                    min = Math.Min(min, a[i, j]);
                result += min.ToString() + " ";
            }
            label1.Text = result;
        }
    }
}