namespace cs0510
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "押された";
            button1.Left = 0;
            button1.Visible = false;
            MessageBox.Show("こんにちは");
            //int a = 1;
            //int b = 10 / a;
        }
    }
}