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
    public partial class Metering : Form
    {
        static public bool exist = false;
        static public Metering obj;
        public Metering()
        {
            InitializeComponent();
        }

        private void ProtectionRelaysMetering_Load(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            List<string> colomn_name;
            colomn_name = aa.GetTableColumnNames(table.Text);
            Des5.Tag = colomn_name[1];
            Des6.Tag = colomn_name[2];
            Des7.Tag = colomn_name[3];
            Des8.Tag = colomn_name[4];


            Ref4.Tag = colomn_name[5];
            Ref3.Tag = colomn_name[5];


            Des5.DataSource = aa.GetData(aa.Dic_in, table.Text, Des5.Tag.ToString());//data source accept list
            Des7.DataSource = aa.GetData(aa.Dic_in, table.Text, Des7.Tag.ToString());//data source accept list

        }


        private void Des5_SelectedIndexChanged(object sender, EventArgs e)
        {

            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des5.Tag.ToString(), Des5.Text);

            Des6.DataSource = aa.GetData(aa.Dic_in, table.Text, Des6.Tag.ToString());//data source accept list
        }

        private void Des6_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des5.Tag.ToString(), Des5.Text);
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

            Des8.DataSource = aa.GetData(aa.Dic_in, table.Text, Des8.Tag.ToString());//data source accept list
        }

        private void Des8_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des7.Tag.ToString(), Des7.Text);
            aa.Dic_in.Add(Des8.Tag.ToString(), Des8.Text);

            if (Des8.SelectedIndex > 0)

            {
                Ref4.Text = aa.GetData(aa.Dic_in, table.Text, Ref4.Tag.ToString())[1];
            }
            else
            {
                Ref4.Text = "";
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.SetDesktopLocation(0, 0);
            Excel_interface z = new Excel_interface();
            z.Add_new_line(new List<string> { Des5.Text, Des6.Text }, Ref3.Text, Qty3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.SetDesktopLocation(0, 0);
            Excel_interface z = new Excel_interface();
            z.Add_new_line(new List<string> { Des7.Text, Des8.Text }, Ref4.Text, Qty4.Text);
        }


        private void ProtectionRelaysMetering_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProtectionRelaysMetering.exist = false;
        }










        private void button6_Click(object sender, EventArgs e)
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

        private void ProtectionRelaysMetering_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void to_cat_Click(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add("Name", "ProtectionCAT");
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

        private void SheetOpen_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(Properties.Settings.Default.AmeterFile))
            {
                Excel_interface.OpenFile(Properties.Settings.Default.AmeterFile);
            }
            else
            {
                MessageBox.Show("File you try to open is no longer at its location");
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccessDBC.connection_str = AccessDBC.Database_LOC("MV.accdb");
            AccessDBC a = new AccessDBC();
            ToExcelC c = new ToExcelC();
            DataTable tablex = new DataTable();
            List<string> list = new List<string>() { Des5.Tag.ToString(), Des6.Tag.ToString(), Ref3.Tag.ToString() };
            tablex = a.Read_DataSet(null, table.Text, list);
            c.ExportToExcel(tablex, "Metering Devices");
        }

        private void to_catelog_Click(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add("Name", "Metering");
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
    }
}
