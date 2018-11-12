using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMSC
{
    public partial class CTView : Form
    {
        public CTView()
        {
            InitializeComponent();
        }

        private void MCSET123_Click(object sender, EventArgs e)
        {
            CTMCSET123 std = new CTMCSET123();
            this.Visible = false;
            std.ShowDialog();

            this.Visible = true;
        }

        private void Other_Click(object sender, EventArgs e)
        {
            CTOther std = new CTOther();
            this.Visible = false;
            std.ShowDialog();

            this.Visible = true;
        }
    }
}
