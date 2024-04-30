using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metrics_COCOMO.COCOMO.Modes
{
    internal class BasicCoMode : CoMode
    {
        protected override void LoadCoefficients()
        {
            LoadCoefficients(CoProjectType.Organic, new CoModeCeof
            {
                A = 2.4f,
                B = 1.05f,
                C = 2.5f,
                D = 0.38f
            });

            LoadCoefficients(CoProjectType.SemiDetached, new CoModeCeof
            {
                A = 3.0f,
                B = 1.12f,
                C = 2.5f,
                D = 0.35f
            });

            LoadCoefficients(CoProjectType.Embedded, new CoModeCeof
            {
                A = 3.6f,
                B = 1.2f,
                C = 2.5f,
                D = 0.32f
            });
        }
    }
}
