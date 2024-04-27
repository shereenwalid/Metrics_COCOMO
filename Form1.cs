namespace Metrics_COCOMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Basic basic_form = new Basic();
            basic_form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Intermediate inter_form = new Intermediate();
            inter_form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
