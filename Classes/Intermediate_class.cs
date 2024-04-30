using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metrics_COCOMO.Classes
{
    public class Intermediate_class
    {
        public double EAF { get; set; }
        public double effort;
        public double tdev;
        public double[] Organic { get; private set; }
        public double[] Semidetached { get; private set; }
        public double[] Embedded { get; private set; }

        public double[] Mode { get; set; }

        public Intermediate_class() {
            Organic = new double[] { 3.2, 1.05, 2.5, 0.38 };
            Semidetached = new double[] { 3.0, 1.12, 2.5, 0.35 };
            Embedded = new double[] { 2.8, 1.20, 2.5, 0.32 };
        }

        public void setMode(string mode)
        {
            if(mode.ToLower() == "organic")
            {
                Mode = Organic;
            }
            else if(mode.ToLower() == "semidetached")
            {
                Mode = Semidetached;
            }
            else if (mode.ToLower() == "embedded")
            {
                Mode = Embedded;
            }
            else{ 
                throw new ArgumentException("Invalid mode. Please choose 'organic', 'semidetached', or 'embedded'.");
            }
        }

        public double calculateEffort(int kloc,double eaf)
        {
            effort = kloc * eaf;
            return effort;
        }

        public double calculateTDEV()
        {
            return tdev;
        }
    }
}
