using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metrics_COCOMO.COCOMO.Modes
{
    internal class CoModeCeof
    {
        public float A { get; set; }
        public float B { get; set; }
        public float C { get; set; }
        public float D { get; set; }

        public CoModeCeof() : this(0, 0, 0, 0)
        {
        }

        public CoModeCeof(float a, float b, float c, float d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }
    }
}
