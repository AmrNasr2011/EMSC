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
    public partial class Configure_Electrical : Form
    {
        public Configure_Electrical()
        {
            InitializeComponent();
        }

        private void Protection_Relay_Click(object sender, EventArgs e)
        {
           
        }

        private void Volatge_Transformers_Click(object sender, EventArgs e)
        {
            PIXVT std = new PIXVT();
            this.Visible = false;
            std.ShowDialog();
            Volatge_TransformersCB.Checked = ContainerActions.FormStatus;
            this.Visible = true;
        }
    }
}
