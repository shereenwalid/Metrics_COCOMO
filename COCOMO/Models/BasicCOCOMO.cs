using Metrics_COCOMO.COCOMO.Modes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metrics_COCOMO.COCOMO.Models
{
    internal class BasicCOCOMO : COCOMO
    {
        public BasicCOCOMO(CoProjectType type, int kloc = 0) : base(type, kloc)
        {
            m_mode = new BasicCoMode();
        }

        public float CalculateEffort()
        {
            return GetEffort();
        }

        public float CalculateTDEV()
        {
            return GetTDEV();
        }

        protected override float GetEffort()
        {
            CoModeCeof coefs = GetCoefficients();
            double effort = coefs.A * Math.Pow(KLOC, coefs.B);

            return (float)effort;
        }

        protected override float GetTDEV()
        {
            CoModeCeof coefs = GetCoefficients();
            double tdev = coefs.C * Math.Pow(GetEffort(), coefs.D);


            return (float)tdev;
        }
    }
}
