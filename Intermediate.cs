using Metrics_COCOMO.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Metrics_COCOMO.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Metrics_COCOMO
{
    public partial class Intermediate : Form
    {
        private Intermediate_class inter;
        public Intermediate()
        {
            InitializeComponent();
            inter = new Intermediate_class();
        }

        void Form1_Load(object sender, EventArgs e)
        {


        }


        private void button1_Click(object sender, EventArgs e)
        {
            CostDrivers costDrivers_form = new CostDrivers(this, this.inter);
            costDrivers_form.Show();
        }
        public void UpdateEAFValue(double value)
        {
            inter.EAF = value;
            textBox4.Text = inter.EAF.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMode = mode_comboBox.SelectedItem.ToString();

            switch (selectedMode)
            {
                case "Organic":
                    inter.setMode("Organic");
                    break;
                case "Semidetached":
                    inter.setMode("Semidetached");
                    break;
                case "Embedded":
                    inter.setMode("Embedded");
                    break;
                default:
                    // not possible
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int kloc))
            {
                if (kloc >= 2 && kloc < 50)
                {
                    inter.setMode("Organic");
                }
                else if (kloc >= 50 && kloc < 300)
                {
                    inter.setMode("Semidetached");
                }
                else if (kloc >= 300)
                {
                    inter.setMode("Embedded");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int kloc);
            double eaf = inter.EAF;
            textBox2.Text = inter.calculateEffort(kloc, eaf).ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = inter.calculateTDEV().ToString();
        }

    }
}
