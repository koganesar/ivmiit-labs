namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private readonly int[] _mas = new int[20];


        private static void UpdateByMas(int[] mas, ListBox.ObjectCollection objectCollection)
        {
            objectCollection.Clear();
            for (var i = 0; i < mas.Length; i++)
                objectCollection.Add($"Mas[{i}] = {mas[i]}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < _mas.Length; i++)
                _mas[i] = Random.Shared.Next(-100, 100);
            UpdateByMas(_mas, listBox1.Items);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var max = _mas.Max();
            var min = _mas.Min();
            var maxindex = 0;
            for (var i = 0; i < _mas.Length; i++)
                if (_mas[i] == max)
                {
                    maxindex = i;
                    break;
                }
            var minindex = 0;
            for (var i = 0; i < _mas.Length; i++)
                if (_mas[i] == min)
                {
                    minindex = i;
                    break;
                }
            _mas[minindex] = max;
            _mas[maxindex] = min;
            UpdateByMas(_mas, listBox2.Items);
        }
    }
}