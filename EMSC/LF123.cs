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
    public partial class LF123 : Form
    {
        static public bool exist = false;
        static public LF123 obj;
        public LF123()
        {
            InitializeComponent();
        }

        private void Compact_NSX_Load(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            List<string> colomn_name;
            colomn_name = aa.GetTableColumnNames(table.Text);
            Des1.Tag = colomn_name[1];
            Des2.Tag = colomn_name[2];
            Des3.Tag = colomn_name[3];
            Des4.Tag = colomn_name[4];
            Des5.Tag = colomn_name[5];
            Des6.Tag = colomn_name[2];
            Des7.Tag = colomn_name[6];
            Des8.Tag = colomn_name[7];
            Des9.Tag = colomn_name[8];
            Des10.Tag = colomn_name[9];
            Ref1.Tag = colomn_name[10];
            Ref2.Tag = colomn_name[10];
            Ref3.Tag = colomn_name[10];
            Com1.Tag = colomn_name[11];
            Com2.Tag = colomn_name[11];
            Com3.Tag = colomn_name[11];
            Des1.DataSource = aa.GetData(aa.Dic_in, table.Text, Des1.Tag.ToString());//data source accept list
            Des6.DataSource = aa.GetData(aa.Dic_in, table.Text, Des6.Tag.ToString());//data source accept list
            Des9.DataSource = aa.GetData(aa.Dic_in, table.Text, Des9.Tag.ToString());//data source accept list
                                                                                     //validate that database is to final modification date
                                                                                     //read data from database and compare with below date
                                                                                     //read date
            AccessDBC a = new AccessDBC();
            Dictionary<string, string> asd = new Dictionary<string, string>();
            asd.Add("file", "LF123file");
            Object xob = a.Get_single_Data(asd, "file_modif", "modified");
            DateTime file_database_date = DateTime.Parse(xob.ToString());

            //check if date of actual not equal of date in database then diable all control and show enable all control
            if (!System.IO.File.Exists(Properties.Settings.Default.LF123file))
            {
                MessageBox.Show("Cannot reach ADD file location, please check that you have internet connection and also you connected to Schneider Network to proceed please check on \"work with outdate file\" ", "Folder Location Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Des1.Enabled = false;
                Des2.Enabled = false;
                Des3.Enabled = false;
                Des4.Enabled = false;
                Des5.Enabled = false;
                Des6.Enabled = false;
                Des7.Enabled = false;
                Des8.Enabled = false;
                Des9.Enabled = false;
                Des10.Enabled = false;
                Ref1.Enabled = false;
                Ref2.Enabled = false;
                Ref3.Enabled = false;
                Com1.Enabled = false;
                Com2.Enabled = false;
                Com3.Enabled = false;
                radButton3.Enabled = false;
                linkLabel1.Enabled = false;
                linkLabel2.Enabled = false;
                linkLabel3.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                enable.Visible = true;
                Qty1.Enabled = false;
                Qty2.Enabled = false;
                Qty3.Enabled = false;
                return;
            }
            DateTime file_actual_date = System.IO.File.GetLastWriteTime(Properties.Settings.Default.LF123file).Date;
            if (DateTime.Compare(file_database_date, file_actual_date) != 0)
            {
                //MessageBox.Show("actual date "+ file_actual_date.ToString() + " Database date " + file_database_date.ToString());
                MessageBox.Show("Please note that ADD file is outdated, to proceed please check on \"work with outdate file\" ", "Outdate Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Des1.Enabled = false;
                Des2.Enabled = false;
                Des3.Enabled = false;
                Des4.Enabled = false;
                Des5.Enabled = false;
                Des6.Enabled = false;
                Des7.Enabled = false;
                Des8.Enabled = false;
                Des9.Enabled = false;
                Des10.Enabled = false;
                Ref1.Enabled = false;
                Ref2.Enabled = false;
                Ref3.Enabled = false;
                Com1.Enabled = false;
                Com2.Enabled = false;
                Com3.Enabled = false;
                radButton3.Enabled = false;
                linkLabel1.Enabled = false;
                linkLabel2.Enabled = false;
                linkLabel3.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                enable.Visible = true;
                Qty1.Enabled = false;
                Qty2.Enabled = false;
                Qty3.Enabled = false;
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
            Des6.Text = Des2.Text;
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
            Des5.DataSource = aa.GetData(aa.Dic_in, table.Text, Des5.Tag.ToString());//data source accept list

        }

        private void Des5_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des1.Tag.ToString(), Des1.Text);
            aa.Dic_in.Add(Des2.Tag.ToString(), Des2.Text);
            aa.Dic_in.Add(Des3.Tag.ToString(), Des3.Text);
            aa.Dic_in.Add(Des4.Tag.ToString(), Des4.Text);
            aa.Dic_in.Add(Des5.Tag.ToString(), Des5.Text);
            if (Des5.SelectedIndex > 0)

            {
                Ref1.Text = aa.GetData(aa.Dic_in, table.Text, Ref1.Tag.ToString())[1];
                Com1.Text = aa.GetData(aa.Dic_in, table.Text, Com1.Tag.ToString())[1];
            }
            else
            {
                Ref1.Text = "";
                Com1.Text = "";
            }
        }

        private void CB_6_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des6.Tag.ToString(), Des6.Text);
            Des7.DataSource = aa.GetData(aa.Dic_in, table.Text, Des7.Tag.ToString());//data source accept list
        }

        private void Des7_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des6.Tag.ToString(), Des6.Text);
            aa.Dic_in.Add(Des7.Tag.ToString(), Des7.Text);
            Des8.DataSource = aa.GetData(aa.Dic_in, table.Text, Des8.Tag.ToString());//data source accept list
        }
        private void Des8_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des6.Tag.ToString(), Des6.Text);
            aa.Dic_in.Add(Des7.Tag.ToString(), Des7.Text);
            aa.Dic_in.Add(Des8.Tag.ToString(), Des8.Text);
            if (Des8.SelectedIndex > 0)

            {
                Ref2.Text = aa.GetData(aa.Dic_in, table.Text, Ref2.Tag.ToString())[1];
                Com2.Text = aa.GetData(aa.Dic_in, table.Text, Com2.Tag.ToString())[1];
            }
            else
            {
                Ref2.Text = "";
                Com2.Text = "";
            }
        }
        private void Des9_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des9.Tag.ToString(), Des9.Text);
            Des10.DataSource = aa.GetData(aa.Dic_in, table.Text, Des10.Tag.ToString());//data source accept list

        }

        private void Des10_SelectedIndexChanged(object sender, EventArgs e)
        {

            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des9.Tag.ToString(), Des9.Text);
            aa.Dic_in.Add(Des10.Tag.ToString(), Des10.Text);
            if (Des10.SelectedIndex > 0)

            {
                Ref3.Text = aa.GetData(aa.Dic_in, table.Text, Ref3.Tag.ToString())[1];
                Com3.Text = aa.GetData(aa.Dic_in, table.Text, Com3.Tag.ToString())[1];
            }
            else
            {
                Ref3.Text = "";
                Com3.Text = "";
            }
        }
        private void radButton3_Click(object sender, EventArgs e)
        {
            this.SetDesktopLocation(0, 0);
            Excel_interface z = new Excel_interface();
            z.Add_new_line(new List<string> { Des1.Text, Des2.Text, Des3.Text, Des4.Text, Des5.Text, Com1.Text }, Ref1.Text, Qty1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SetDesktopLocation(0, 0);
            Excel_interface z = new Excel_interface();
            z.Add_new_line(new List<string> { Des6.Text, Des7.Text, Des8.Text, Com2.Text }, Ref2.Text, Qty2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.SetDesktopLocation(0, 0);
            Excel_interface z = new Excel_interface();
            z.Add_new_line(new List<string> { Des9.Text, Des10.Text, Com3.Text }, Ref3.Text, Qty3.Text);
        }

        private void Compact_NSX_FormClosed(object sender, FormClosedEventArgs e)
        {
            LF123.exist = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccessDBC.connection_str = AccessDBC.Database_LOC("MV.accdb");
            AccessDBC a = new AccessDBC();

            ToExcelC c = new ToExcelC();
            DataTable tablex = new DataTable();
            List<string> list = new List<string>() { Des1.Tag.ToString(), Des2.Tag.ToString(), Des3.Tag.ToString(), Des4.Tag.ToString(), Des5.Tag.ToString(), Com1.Tag.ToString(), Ref1.Tag.ToString() };
            tablex = a.Read_DataSet(null, table.Text, list);
            c.ExportToExcel(tablex, "Capsule");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccessDBC.connection_str = AccessDBC.Database_LOC("MV.accdb");
            AccessDBC a = new AccessDBC();

            ToExcelC c = new ToExcelC();
            DataTable tablex = new DataTable();
            List<string> list = new List<string>() { Des6.Tag.ToString(), Des7.Tag.ToString(), Des8.Tag.ToString(), Com2.Tag.ToString(), Ref2.Tag.ToString() };
            tablex = a.Read_DataSet(null, table.Text, list);
            c.ExportToExcel(tablex, "Standard Coils");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            AccessDBC.connection_str = AccessDBC.Database_LOC("MV.accdb");
            AccessDBC a = new AccessDBC();

            ToExcelC c = new ToExcelC();
            DataTable tablex = new DataTable();
            List<string> list = new List<string>() { Des9.Tag.ToString(), Des10.Tag.ToString(), Com3.Tag.ToString(), Ref3.Tag.ToString() };
            tablex = a.Read_DataSet(null, table.Text, list);
            c.ExportToExcel(tablex, "Additional Coils");
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

        private void Compact_NSX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void to_add_Click(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add("Name", "LF123ADD");
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
                MessageBox.Show("Folder you try to open is no longer at its location", "Folder Location Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void to_catelog_Click(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add("Name", "LF123CAT");
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
                MessageBox.Show("Folder you try to open is no longer at its location", "Folder Location Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //read data from database and compare with below date
            //read date
            // AccessDBC a = new AccessDBC();
            // Dictionary<string, string> asd = new Dictionary<string, string>();
            // asd.Add("file", "add");
            // Object xob = a.Get_single_Data(asd, "file_modif", "modified");
            // MessageBox.Show(xob.ToString());
            //DateTime x =  DateTime.Parse(xob.ToString());
            // MessageBox.Show(DateTime.Compare(x, System.IO.File.GetLastWriteTime(@"D:\Master analysis\Shift.pdf").Date).ToString());
            // MessageBox.Show(System.IO.File.GetLastWriteTime(@"D:\Master analysis\Shift.pdf").Date.ToString());
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
                Des8.Enabled = true;
                Des9.Enabled = true;
                Des10.Enabled = true;
                Ref1.Enabled = true;
                Ref2.Enabled = true;
                Ref3.Enabled = true;
                Com1.Enabled = true;
                Com2.Enabled = true;
                Com3.Enabled = true;
                radButton3.Enabled = true;
                linkLabel1.Enabled = true;
                linkLabel2.Enabled = true;
                linkLabel3.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                Qty1.Enabled = true;
                Qty2.Enabled = true;
                Qty3.Enabled = true;

            }
        }
    }
}
