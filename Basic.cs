using Metrics_COCOMO.COCOMO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metrics_COCOMO
{
    public partial class Basic : Form
    {
        public Basic()
        {
            InitializeComponent();
        }

        private void Basic_Load(object sender, EventArgs e)
        {
            ModeBox.SelectedIndex = 0;
        }

        private CoProjectType GetCoMode()
        {
            if (ModeBox.SelectedIndex != -1)
            {
                if (ModeBox.SelectedIndex > 0)
                    return (CoProjectType)ModeBox.SelectedIndex;

                else if (KLOC_Effort.Value >= 2 && KLOC_Effort.Value <= 50)
                    return CoProjectType.Organic;

                else if (KLOC_Effort.Value > 50 && KLOC_Effort.Value <= 300)
                    return CoProjectType.SemiDetached;

                else if (KLOC_Effort.Value > 300)
                    return CoProjectType.Embedded;
            }
            return CoProjectType.None;
        }
    }
}
