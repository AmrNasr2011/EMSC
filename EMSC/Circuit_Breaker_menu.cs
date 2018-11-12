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
    public partial class Circuit_Breaker_menu : Form
    {
        public Circuit_Breaker_menu()
        {
            InitializeComponent();
            // AddAnimation(LF123);
        }

        private void LF123_Click(object sender, EventArgs e)
        {
            LF123 std = new LF123();
            this.Visible = false;
            std.ShowDialog();

            this.Visible = true;
        }

        private void HVX_Click(object sender, EventArgs e)
        {
            Standard_Sheets std = new Standard_Sheets();
            this.Visible = false;
            std.ShowDialog();

            this.Visible = true;

        }

        private void sf1_sf2_Click(object sender, EventArgs e)
        {
            SF1_SF2 std = new SF1_SF2();
            this.Visible = false;
            std.ShowDialog();

            this.Visible = true;
        }

        private void Circuit_Breaker_menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        public void AddAnimation(Button button)
        {
            var expandTimer = new System.Windows.Forms.Timer();
            var contractTimer = new System.Windows.Forms.Timer();

            expandTimer.Interval = 10;//can adjust to determine the refresh rate
            contractTimer.Interval = 10;

            DateTime animationStarted = DateTime.Now;

            //TODO update as appropriate or make it a parameter
            TimeSpan animationDuration = TimeSpan.FromMilliseconds(250);
            int initialWidth = button.Width;
            int initialhight = button.Height;
            int initialTop = button.Top;
            int initialLeft = button.Left;
            int endWidth = (int)(button.Width * 1.1);
            int endhight = (int)(button.Width * 1.1);
            int endTop = (int)(button.Top * .9);
            int endLeft = (int)(button.Left * .9);

            button.MouseHover += (_, args) =>
            {
                contractTimer.Stop();
                expandTimer.Start();
                animationStarted = DateTime.Now;
                //button.BackColor = Color.DimGray;
            };

            button.MouseLeave += (_, args) =>
            {
                expandTimer.Stop();
                contractTimer.Start();
                animationStarted = DateTime.Now;
                // button.BackColor = Color.Red;
            };

            expandTimer.Tick += (_, args) =>
            {
                double percentComplete = (DateTime.Now - animationStarted).Ticks
                    / (double)animationDuration.Ticks;

                if (percentComplete >= 1)
                {
                    expandTimer.Stop();
                }
                else
                {
                    button.Width = (int)(initialWidth +
                        (endWidth - initialWidth) * percentComplete);

                    button.Height = (int)(initialhight +
                        (endhight - initialhight) * percentComplete);

                    button.Top = (int)(initialTop +
                       (endTop - initialTop) * percentComplete * .5);
                    button.Left = (int)(initialLeft +
                       (endLeft - initialLeft) * percentComplete * .5);
                }
            };

            contractTimer.Tick += (_, args) =>
            {
                double percentComplete = (DateTime.Now - animationStarted).Ticks
                    / (double)animationDuration.Ticks;

                if (percentComplete >= 1)
                {
                    contractTimer.Stop();
                }
                else
                {
                    button.Width = (int)(endWidth -
                        (endWidth - initialWidth) * percentComplete);
                    button.Height = (int)(endhight -
                       (endhight - initialhight) * percentComplete);

                    button.Top = (int)(initialTop -
                      (endTop - initialTop) * percentComplete * .5);
                    button.Left = (int)(initialLeft -
                       (endLeft - initialLeft) * percentComplete * .5);
                }
            };
        }
    }
}
