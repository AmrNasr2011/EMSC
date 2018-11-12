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
    public partial class ControlAuxiliaries : Form
    {
        static public bool exist = false;
        static public ControlAuxiliaries obj;
        public ControlAuxiliaries()
        {
            InitializeComponent();
        }

        private void ControlAuxiliaries_Load(object sender, EventArgs e)
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
            Des8.Tag = colomn_name[8];
            Des9.Tag = colomn_name[9];

            Ref1.Tag = colomn_name[10];
            Ref2.Tag = colomn_name[10];
            Ref3.Tag = colomn_name[10];
            Ref4.Tag = colomn_name[10];

            Des1.DataSource = aa.GetData(aa.Dic_in, table.Text, Des1.Tag.ToString());//data source accept list
            Des3.DataSource = aa.GetData(aa.Dic_in, table.Text, Des3.Tag.ToString());//data source accept list
            Des5.DataSource = aa.GetData(aa.Dic_in, table.Text, Des5.Tag.ToString());//data source accept list
            Des7.DataSource = aa.GetData(aa.Dic_in, table.Text, Des7.Tag.ToString());//data source accept list

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
            if (Des2.SelectedIndex > 0)

            {
                Ref1.Text = aa.GetData(aa.Dic_in, table.Text, Ref1.Tag.ToString())[1];
            }
            else
            {
                Ref1.Text = "";
            }
        }

        private void Des3_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des3.Tag.ToString(), Des3.Text);

            Des4.DataSource = aa.GetData(aa.Dic_in, table.Text, Des4.Tag.ToString());//data source accept list
        }

        private void Des4_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des3.Tag.ToString(), Des3.Text);
            aa.Dic_in.Add(Des4.Tag.ToString(), Des4.Text);
            if (Des4.SelectedIndex > 0)

            {
                Ref2.Text = aa.GetData(aa.Dic_in, table.Text, Ref2.Tag.ToString())[1];
            }
            else
            {
                Ref2.Text = "";
            }
        }


        private void radButton3_Click(object sender, EventArgs e)
        {
            this.SetDesktopLocation(0, 0);
            Excel_interface z = new Excel_interface();
            z.Add_new_line(new List<string> { Des1.Text, Des2.Text }, Ref1.Text, Qty1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SetDesktopLocation(0, 0);
            Excel_interface z = new Excel_interface();
            z.Add_new_line(new List<string> { Des3.Text, Des4.Text }, Ref2.Text, Qty2.Text);
        }


        private void ControlAuxiliaries_FormClosed(object sender, FormClosedEventArgs e)
        {
            ControlAuxiliaries.exist = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccessDBC.connection_str = AccessDBC.Database_LOC("MV.accdb");
            AccessDBC a = new AccessDBC();

            ToExcelC c = new ToExcelC();
            DataTable tablex = new DataTable();
            List<string> list = new List<string>() { Des1.Tag.ToString(), Des2.Tag.ToString(), Ref1.Tag.ToString() };
            tablex = a.Read_DataSet(null, table.Text, list);
            c.ExportToExcel(tablex, "Control");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccessDBC.connection_str = AccessDBC.Database_LOC("MV.accdb");
            AccessDBC a = new AccessDBC();

            ToExcelC c = new ToExcelC();
            DataTable tablex = new DataTable();
            List<string> list = new List<string>() { Des3.Tag.ToString(), Des4.Tag.ToString(), Ref1.Tag.ToString() };
            tablex = a.Read_DataSet(null, table.Text, list);
            c.ExportToExcel(tablex, "Auxiliaries");
        }



        private void button4_Click(object sender, EventArgs e)
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

        private void ControlAuxiliaries_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(Properties.Settings.Default.LampFile))
            {
                Excel_interface.OpenFile(Properties.Settings.Default.LampFile);
            }
            else
            {
                MessageBox.Show("File you try to open is no longer at its location");
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.SetDesktopLocation(0, 0);
            Excel_interface z = new Excel_interface();
            z.Add_new_line(new List<string> { Des5.Text, Des6.Text }, Ref3.Text, Qty3.Text);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccessDBC.connection_str = AccessDBC.Database_LOC("MV.accdb");
            AccessDBC a = new AccessDBC();

            ToExcelC c = new ToExcelC();
            DataTable tablex = new DataTable();
            List<string> list = new List<string>() { Des5.Tag.ToString(), Des6.Tag.ToString(), Ref3.Tag.ToString() };
            tablex = a.Read_DataSet(null, table.Text, list);
            c.ExportToExcel(tablex, "MIMIC");
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
            Des9.DataSource = aa.GetData(aa.Dic_in, table.Text, Des9.Tag.ToString());//data source accept list
        }

        private void Des9_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des7.Tag.ToString(), Des7.Text);
            aa.Dic_in.Add(Des8.Tag.ToString(), Des8.Text);
            aa.Dic_in.Add(Des9.Tag.ToString(), Des9.Text);
            if (Des9.SelectedIndex > 0)

            {
                Ref4.Text = aa.GetData(aa.Dic_in, table.Text, Ref4.Tag.ToString())[1];
            }
            else
            {
                Ref4.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.SetDesktopLocation(0, 0);
            Excel_interface z = new Excel_interface();
            z.Add_new_line(new List<string> { Des7.Text, Des8.Text, Des9.Text }, Ref4.Text, Qty4.Text);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccessDBC.connection_str = AccessDBC.Database_LOC("MV.accdb");
            AccessDBC a = new AccessDBC();

            ToExcelC c = new ToExcelC();
            DataTable tablex = new DataTable();
            List<string> list = new List<string>() { Des7.Tag.ToString(), Des8.Tag.ToString(), Des9.Tag.ToString(), Ref4.Tag.ToString() };
            tablex = a.Read_DataSet(null, table.Text, list);
            c.ExportToExcel(tablex, "VPIS");
        }

        private void to_catelog_Click(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add("Name", "ControlAux");
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
    }
}
