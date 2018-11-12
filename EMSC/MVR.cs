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
    public partial class EMSC : Form
    {
        public EMSC()
        {
            InitializeComponent();
            this.SetDesktopLocation(20, 20);
        }



        private void start_Click(object sender, EventArgs e)
        {
            Menu x = new Menu();
            if (UpdateTool.Update())
            {
                this.Close();
            }
            this.Visible = false;
            x.ShowDialog();
            this.Close();

        }


    }
}
