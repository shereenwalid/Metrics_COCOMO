using Metrics_COCOMO.COCOMO.Modes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metrics_COCOMO.COCOMO.Models
{
    internal class IntermediateCOCOMO : COCOMO
    {
        protected IntermediateCOCOMO(int kloc = 0) : base(kloc)
        {
            m_mode = new IntermediateCoMode();
        }

        protected override float GetEffort()
        {
            throw new NotImplementedException();
        }

        protected override float GetTDEV()
        {
            throw new NotImplementedException();
        }
    }
}
