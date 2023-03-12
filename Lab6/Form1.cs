namespace Lab6;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        listBox1.Items.Add("Hello, world!");
        listBox1.Items.Add("Some short text");
        listBox1.Items.Add("And here is a longer one");
        listBox1.Items.Add("Also a very long sentense just for proof I know all letters on my keyboard");
        listBox1.Items.Add("And  one    with     multiple          spaces between    words");
        listBox1.Items.Add("01001010101001010");
        listBox1.Items.Add("00000111010100111");
        listBox1.Items.Add("11111111111110001");
        listBox1.Items.Add("1001010100101001010101001010100101");
        listBox1.Items.Add("00000000111111111111110000000010010100000000000000011111111");
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var selectedText = listBox1.SelectedItem?.ToString();
        if (selectedText is null) return;
        var spacesCount = 0;
        var zerosCount = 0;
        var onesCount = 0;
        for (var i = 0; i < selectedText.Length; ++i)
        {
            switch (selectedText[i])
            {
                case ' ':
                    ++spacesCount;
                    break;
                case '0':
                    ++zerosCount;
                    break;
                case '1':
                    ++onesCount;
                    break;
            }
        }


        label1.Text = $"Количество пробелов: {spacesCount}";
        label2.Text = $"Количество нулей: {zerosCount}";
        label3.Text = $"Количество единиц: {onesCount}";
    }
}