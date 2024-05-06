using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Metrics_COCOMO.Classes;

namespace Metrics_COCOMO
{
    public partial class CostDrivers : Form
    {
        private Dictionary<ComboBox, Dictionary<string, double>> valueMaps;
        public Intermediate_class intermediateClass;

        public Intermediate intermediateForm;
        public CostDrivers(Intermediate intermediateForm, Intermediate_class inter_class)
        {
            this.intermediateForm = intermediateForm;
            this.intermediateClass = inter_class;
            InitializeComponent();
            InitializeValueMaps();
        }

        private void InitializeValueMaps()
        {
            valueMaps = new Dictionary<ComboBox, Dictionary<string, double>>
            {
                { comboBox1, new Dictionary<string, double>
                    {
                        { "Very low", 0.75 },
                        { "low", 0.88 },
                        { "Nominal", 1 },
                        { "High", 1.15 },
                        { "Very high", 1.40 }
                    }
                },
                { comboBox2, new Dictionary<string, double>
                    {
                        { "low", 0.94 },
                        { "Nominal", 1 },
                        { "High", 1.08 },
                        { "Very high", 1.16 }
                    }
                },

                { comboBox3, new Dictionary<string, double>
                    {
                        { "Very low", 0.70 },
                        { "low", 0.85 },
                        { "Nominal", 1 },
                        { "High", 1.15 },
                        { "Very high", 1.30 },
                        { "Extra high", 1.65 }
                    }
                },
                { comboBox4, new Dictionary<string, double>
                    {
                        { "Nominal", 1 },
                        { "High", 1.11 },
                        { "Very high", 1.30 },
                        { "Extra high", 1.66 }
                    }
                },

                { comboBox5, new Dictionary<string, double>
                    {
                        { "Nominal", 1 },
                        { "High", 1.06 },
                        { "Very high", 1.21 },
                        { "Extra high", 1.56 }
                    }
                },

                { comboBox6, new Dictionary<string, double>
                    {
                        { "low", 0.87 },
                        { "Nominal", 1 },
                        { "High", 1.15 },
                        { "Very high", 1.30 }
                    }
                },

                { comboBox7, new Dictionary<string, double>
                    {
                        { "low", 0.87 },
                        { "Nominal", 1 },
                        { "High", 1.07 },
                        { "Very high", 1.15 }
                    }
                },

                { comboBox8, new Dictionary<string, double>
                    {
                        { "Very low", 1.24 },
                        { "low", 1.10 },
                        { "Nominal", 1 },
                        { "High", 0.91 },
                        { "Very high", 0.83 }
                    }
                },
                { comboBox9, new Dictionary<string, double>
                    {
                        { "Very low", 1.24 },
                        { "low", 1.10 },
                        { "Nominal", 1 },
                        { "High", 0.91 },
                        { "Very high", 0.82 }
                    }
                },

                { comboBox10, new Dictionary<string, double>
                    {
                        { "Very low", 1.14 },
                        { "low", 1.07 },
                        { "Nominal", 1 },
                        { "High", 0.95 }
                    }
                },

                { comboBox11, new Dictionary<string, double>
                    {
                        { "Very low", 1.21 },
                        { "low", 1.10 },
                        { "Nominal", 1 },
                        { "High", 0.90 }
                    }
                },

                { comboBox12, new Dictionary<string, double>
                    {
                        { "Very low", 1.42 },
                        { "low", 1.17 },
                        { "Nominal", 1 },
                        { "High", 0.86 },
                        { "Very high", 0.70 }
                    }
                },

                { comboBox13, new Dictionary<string, double>
                    {
                        { "Very low", 1.29 },
                        { "low", 1.13 },
                        { "Nominal", 1 },
                        { "High", 0.91 },
                        { "Very high", 0.82 }
                    }
                },

                { comboBox14, new Dictionary<string, double>
                    {
                        { "Very low", 1.46 },
                        { "low", 1.19 },
                        { "Nominal", 1 },
                        { "High", 0.86 },
                        { "Very high", 0.71 }
                    }
                },

                { comboBox15, new Dictionary<string, double>
                    {
                        { "Very low", 1.23 },
                        { "low", 1.08 },
                        { "Nominal", 1 },
                        { "High", 1.04 },
                        { "Very high", 1.10 }
                    }
                },

            };
        }

        private double GetSelectedValue(ComboBox comboBox)
        {
            string selectedOption = comboBox.SelectedItem.ToString();
            return valueMaps[comboBox][selectedOption];
        }

        private double CalculateTotal()
        {
            double total = 1;

            foreach (ComboBox comboBox in valueMaps.Keys)
            {
                if (comboBox.SelectedItem != null)
                {
                    double selectedValue = GetSelectedValue(comboBox);
                    total *= selectedValue;
                }
            }

            return total;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double total = CalculateTotal();
            textBox1.Text = total.ToString();

            if (intermediateForm != null)
            {
                this.intermediateForm.UpdateEAFValue((double) total);
            }
            else
            {
                MessageBox.Show("Intermediate form instance is null.");
            }
        }

    }
}

