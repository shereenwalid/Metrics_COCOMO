using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metrics_COCOMO.COCOMO.Modes
{
    abstract class CoMode
    {
        private Dictionary<CoProjectType, CoModeCeof> m_coefficients;

        protected CoMode()
        {
            m_coefficients = new Dictionary<CoProjectType, CoModeCeof>();

            LoadCoefficients();
        }

        protected abstract void LoadCoefficients();

        protected void LoadCoefficients(CoProjectType type, CoModeCeof coef)
        {
            m_coefficients[type] = coef;
        }

        private CoModeCeof? GetCoefficient(CoProjectType type)
        {
            CoModeCeof? coef = null;

            m_coefficients.TryGetValue(type, out coef);
            return coef;
        }

        public CoModeCeof? this[CoProjectType type]
        {
            get => GetCoefficient(type);
        }
    }
}
