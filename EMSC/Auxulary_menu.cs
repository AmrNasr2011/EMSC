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
    public partial class Auxulary_menu : Form
    {
        public Auxulary_menu()
        {
            InitializeComponent();
        }

        private void MiniatureCircuit_Click(object sender, EventArgs e)
        {
            MiniatureCircuit std = new MiniatureCircuit();
            this.Visible = false;
            std.ShowDialog();

            this.Visible = true;
        }

        private void ProtectionRelaysMetering_Click(object sender, EventArgs e)
        {
            ProtectionRelaysMetering std = new ProtectionRelaysMetering();
            this.Visible = false;
            std.ShowDialog();

            this.Visible = true;
        }

        private void ControlAuxiliaries_Click(object sender, EventArgs e)
        {
            ControlAuxiliaries std = new ControlAuxiliaries();
            this.Visible = false;
            std.ShowDialog();

            this.Visible = true;
        }

        private void Auxulary_menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


        private void Lockout_Click(object sender, EventArgs e)
        {
            AuxLock std = new AuxLock();
            this.Visible = false;
            std.ShowDialog();

            this.Visible = true;
        }

        private void TripCircuit_Click(object sender, EventArgs e)
        {
            AuxTrip std = new AuxTrip();
            this.Visible = false;
            std.ShowDialog();

            this.Visible = true;
        }

        private void Consol_Click(object sender, EventArgs e)
        {
            AuxConsol std = new AuxConsol();
            this.Visible = false;
            std.ShowDialog();

            this.Visible = true;
        }
    }
}
