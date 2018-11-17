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
    public partial class Voltage_Transformers : Form
    {
        public Voltage_Transformers()
        {
            InitializeComponent();
        }

        private void MCSET4_Click(object sender, EventArgs e)
        {
            MCSET4 std = new MCSET4();
            this.Visible = false;
            std.ShowDialog();

            this.Visible = true;
        }

        private void MCSET123_Click(object sender, EventArgs e)
        {
            MCST123 std = new MCST123();
            this.Visible = false;
            std.ShowDialog();

            this.Visible = true;
        }

        private void PIX_Click(object sender, EventArgs e)
        {
            PIXVT std = new PIXVT();
            this.Visible = false;
            std.ShowDialog();

            this.Visible = true;
        }

        private void SM6_Click(object sender, EventArgs e)
        {
            SM6 std = new SM6();
            this.Visible = false;
            std.ShowDialog();

            this.Visible = true;
        }
    }
}
