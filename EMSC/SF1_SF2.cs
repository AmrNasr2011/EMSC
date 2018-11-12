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
    public partial class SF1_SF2 : Form
    {
        static public bool exist = false;
        static public SF1_SF2 obj;
        public SF1_SF2()
        {
            InitializeComponent();
        }

        private void SF1_SF2_Load(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            List<string> colomn_name;
            colomn_name = aa.GetTableColumnNames(table.Text);
            Des1.Tag = colomn_name[1];
            Des2.Tag = colomn_name[2];
            Des3.Tag = colomn_name[3];
            Des4.Tag = colomn_name[4];
            Des5.Tag = colomn_name[5];
            Des6.Tag = colomn_name[6];
            Des7.Tag = colomn_name[7];


            Ref1.Tag = colomn_name[8];
            Ref2.Tag = colomn_name[8];
            Ref3.Tag = colomn_name[8];
            Ref4.Tag = colomn_name[8];



            Des1.DataSource = aa.GetData(aa.Dic_in, table.Text, Des1.Tag.ToString());//data source accept list
            Des5.DataSource = aa.GetData(aa.Dic_in, table.Text, Des5.Tag.ToString());//data source accept list
            Des6.DataSource = aa.GetData(aa.Dic_in, table.Text, Des6.Tag.ToString());//data source accept list
            Des7.DataSource = aa.GetData(aa.Dic_in, table.Text, Des7.Tag.ToString());//data source accept list



            AccessDBC a = new AccessDBC();
            Dictionary<string, string> asd = new Dictionary<string, string>();
            asd.Add("file", "SFfile");
            Object xob = a.Get_single_Data(asd, "file_modif", "modified");
            DateTime file_database_date = DateTime.Parse(xob.ToString());

            //check if date of actual not equal of date in database then diable all control and show enable all control
            if (!System.IO.File.Exists(Properties.Settings.Default.SFfile))
            {
                MessageBox.Show("Cannot reach ADD file location, please check that you have internet connection and also you connected to Schneider Network to proceed please check on \"work with outdate file\" ", "Folder Location Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                enable.Enabled = true;
                //show all data
                Des1.Enabled = false;
                Des2.Enabled = false;
                Des3.Enabled = false;
                Des4.Enabled = false;
                Des5.Enabled = false;
                Des6.Enabled = false;
                Des7.Enabled = false;

                Ref1.Enabled = false;
                Ref2.Enabled = false;
                Ref3.Enabled = false;
                Ref4.Enabled = false;

                linkLabel1.Enabled = false;
                Add1.Enabled = false;
                Add2.Enabled = false;
                Add3.Enabled = false;
                Add4.Enabled = false;

                button3.Enabled = false;
                Qty1.Enabled = false;
                Qty2.Enabled = false;
                Qty3.Enabled = false;
                Qty4.Enabled = false;

                enable.Visible = true;

                return;
            }
            DateTime file_actual_date = System.IO.File.GetLastWriteTime(Properties.Settings.Default.SFfile).Date;
            if (DateTime.Compare(file_database_date, file_actual_date) != 0)
            {
                // MessageBox.Show("Please note that ADD file is outdated, to proceed please check on \"work with outdate file\" ");
                MessageBox.Show("Please note that ADD file is outdated, to proceed please check on \"work with outdate file\" ", "Outdate Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                enable.Enabled = true;
                //show all data
                Des1.Enabled = false;
                Des2.Enabled = false;
                Des3.Enabled = false;
                Des4.Enabled = false;
                Des5.Enabled = false;
                Des6.Enabled = false;
                Des7.Enabled = false;

                Ref1.Enabled = false;
                Ref2.Enabled = false;
                Ref3.Enabled = false;
                Ref4.Enabled = false;

                linkLabel1.Enabled = false;
                Add1.Enabled = false;
                Add2.Enabled = false;
                Add3.Enabled = false;
                Add4.Enabled = false;

                button3.Enabled = false;
                Qty1.Enabled = false;
                Qty2.Enabled = false;
                Qty3.Enabled = false;
                Qty4.Enabled = false;

                enable.Visible = true;

            }
            else
            {
                version.Text = file_actual_date.ToShortDateString();
            }
        }

        private void Des1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des1.Tag.ToString(), Des1.Text);
            Des2.DataSource = aa.GetData(aa.Dic_in, table.Text, Des2.Tag.ToString());//data source accept list
        }

        private void Des2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des1.Tag.ToString(), Des1.Text);
            aa.Dic_in.Add(Des2.Tag.ToString(), Des2.Text);
            Des3.DataSource = aa.GetData(aa.Dic_in, table.Text, Des3.Tag.ToString());//data source accept list
        }

        private void Des3_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des1.Tag.ToString(), Des1.Text);
            aa.Dic_in.Add(Des2.Tag.ToString(), Des2.Text);
            aa.Dic_in.Add(Des3.Tag.ToString(), Des3.Text);
            Des4.DataSource = aa.GetData(aa.Dic_in, table.Text, Des4.Tag.ToString());//data source accept list
        }

        private void Des4_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des1.Tag.ToString(), Des1.Text);
            aa.Dic_in.Add(Des2.Tag.ToString(), Des2.Text);
            aa.Dic_in.Add(Des3.Tag.ToString(), Des3.Text);
            aa.Dic_in.Add(Des4.Tag.ToString(), Des4.Text);
            if (Des4.SelectedIndex > 0)

            {
                Ref1.Text = aa.GetData(aa.Dic_in, table.Text, Ref1.Tag.ToString())[1];
            }
            else
            {
                Ref1.Text = "";
            }
        }

        private void Des5_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();

            aa.Dic_in.Add(Des5.Tag.ToString(), Des5.Text);
            if (Des5.SelectedIndex > 0)

            {
                Ref2.Text = aa.GetData(aa.Dic_in, table.Text, Ref2.Tag.ToString())[1];
            }
            else
            {
                Ref2.Text = "";
            }

        }

        private void Des6_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();

            aa.Dic_in.Add(Des6.Tag.ToString(), Des6.Text);
            if (Des6.SelectedIndex > 0)

            {
                Ref3.Text = aa.GetData(aa.Dic_in, table.Text, Ref3.Tag.ToString())[1];
            }
            else
            {
                Ref3.Text = "";
            }

        }

        private void Des7_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();

            aa.Dic_in.Add(Des7.Tag.ToString(), Des7.Text);
            if (Des6.SelectedIndex > 0)

            {
                Ref4.Text = aa.GetData(aa.Dic_in, table.Text, Ref4.Tag.ToString())[1];
            }
            else
            {
                Ref4.Text = "";
            }
        }

        private void Add1_Click(object sender, EventArgs e)
        {
            this.SetDesktopLocation(0, 0);
            Excel_interface z = new Excel_interface();
            z.Add_new_line(new List<string> { Des1.Text, Des2.Text, Des3.Text, Des4.Text }, Ref1.Text, Qty1.Text);
        }

        private void Add2_Click(object sender, EventArgs e)
        {
            this.SetDesktopLocation(0, 0);
            Excel_interface z = new Excel_interface();
            z.Add_new_line(new List<string> { Des5.Text }, Ref2.Text, Qty2.Text);
        }

        private void Add3_Click(object sender, EventArgs e)
        {
            this.SetDesktopLocation(0, 0);
            Excel_interface z = new Excel_interface();
            z.Add_new_line(new List<string> { Des6.Text }, Ref3.Text, Qty3.Text);
        }

        private void Add4_Click(object sender, EventArgs e)
        {
            this.SetDesktopLocation(0, 0);
            Excel_interface z = new Excel_interface();
            z.Add_new_line(new List<string> { Des7.Text }, Ref4.Text, Qty4.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccessDBC.connection_str = AccessDBC.Database_LOC("MV.accdb");
            AccessDBC a = new AccessDBC();
            ToExcelC c = new ToExcelC();
            DataTable tablex = new DataTable();
            List<string> list = new List<string>() { Des1.Tag.ToString(), Des2.Tag.ToString(), Des3.Tag.ToString(), Des4.Tag.ToString(), Ref1.Tag.ToString() };
            tablex = a.Read_DataSet(null, table.Text, list);
            c.ExportToExcel(tablex, "C.B with coils and motor");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Commnet a = new Commnet();
            a.ShowDialog();
            if (Commnet.comment_t != "")
            {
                Excel_interface x = new Excel_interface();
                x.Add_new_Comment(Commnet.comment_t);
                Commnet.comment_t = "";
            }
        }

        private void SF1_SF2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void to_add_Click(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add("Name", "SFADD");
            string locat = aa.GetData(aa.Dic_in, "Locations", "Loc")[1];
            if (System.IO.Directory.Exists(locat))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = locat,
                    UseShellExecute = true,
                    Verb = "open"
                });
            }
            else
            {
                MessageBox.Show("Folder you try to open is no longer at its location");
            }
        }

        private void to_catelog_Click(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add("Name", "SFCAT");
            string locat = aa.GetData(aa.Dic_in, "Locations", "Loc")[1];
            if (System.IO.Directory.Exists(locat))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = locat,
                    UseShellExecute = true,
                    Verb = "open"
                });
            }
            else
            {
                MessageBox.Show("Folder you try to open is no longer at its location");
            }
        }

        private void enable_CheckedChanged(object sender, EventArgs e)
        {
            if (enable.Checked == true)
            {
                MessageBox.Show("Some of exist referernces may be change. please validated extracted refernces", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                enable.Enabled = false;
                //show all data
                Des1.Enabled = true;
                Des2.Enabled = true;
                Des3.Enabled = true;
                Des4.Enabled = true;
                Des5.Enabled = true;
                Des6.Enabled = true;
                Des7.Enabled = true;

                Ref1.Enabled = true;
                Ref2.Enabled = true;
                Ref3.Enabled = true;
                Ref4.Enabled = true;

                linkLabel1.Enabled = true;
                Add1.Enabled = true;
                Add2.Enabled = true;
                Add3.Enabled = true;
                Add4.Enabled = true;

                button3.Enabled = true;
                Qty1.Enabled = true;
                Qty2.Enabled = true;
                Qty3.Enabled = true;
                Qty4.Enabled = true;
            }
        }
    }
}
