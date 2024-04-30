using Metrics_COCOMO.COCOMO.Modes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metrics_COCOMO.COCOMO.Models
{
    abstract class COCOMO
    {
        protected CoMode m_mode;

        protected int KLOC { get; set; }

        protected COCOMO(int kloc = 0)
        {
            KLOC = kloc;
        }

        protected abstract float GetEffort();
        protected abstract float GetTDEV();

        protected float GetCost(float avgsalary)
        {
            return GetTDEV() * avgsalary;
        }
    }
}
