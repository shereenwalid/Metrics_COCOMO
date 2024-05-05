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
        protected BasicCOCOMO(CoProjectType type, int kloc = 0) : base(type, kloc)
        {
            m_mode = new BasicCoMode();
        }

        protected override float GetEffort()
        {
            CoModeCeof coefs = GetCoefficients();

            return KLOC * coefs.A + coefs.B;
        }

        protected override float GetTDEV()
        {
            throw new NotImplementedException();
        }
    }
}
