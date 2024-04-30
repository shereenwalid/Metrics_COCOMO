using Metrics_COCOMO.COCOMO;
using Metrics_COCOMO.COCOMO.Modes;

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
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Intermediate inter_form = new Intermediate();
            inter_form.Show();
            Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CoMode bmode = new BasicCoMode();
            CoModeCeof? becoefs = bmode[CoProjectType.Embedded];
            
            if (becoefs != null)
                MessageBox.Show(string.Format("[Basic COCOMO] Coefficients - Embedded access example:\n\nA = {0}\nB = {1}\nC = {2}\nD = {3}", becoefs.A, becoefs.B, becoefs.C, becoefs.D));



            CoMode imode = new IntermediateCoMode();
            CoModeCeof? iocoefs = imode[CoProjectType.Organic];

            if (iocoefs != null)
                MessageBox.Show(string.Format("[Intermediate COCOMO] Coefficients - Organic access example:\n\nA = {0}\nB = {1}\nC = {2}\nD = {3}", iocoefs.A, iocoefs.B, iocoefs.C, iocoefs.D));
        }
    }
}
