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
    public partial class CTMCSET123 : Form
    {
        public CTMCSET123()
        {
            InitializeComponent();
        }

        private void CTMCSET123_Load(object sender, EventArgs e)
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

            Ref1.Tag = colomn_name[9];


            Des1.DataSource = aa.GetData(aa.Dic_in, table.Text, Des1.Tag.ToString());//data source accept list
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
            Des6.DataSource = aa.GetData(aa.Dic_in, table.Text, Des6.Tag.ToString());//data source accept list
        }

        private void Des6_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des1.Tag.ToString(), Des1.Text);
            aa.Dic_in.Add(Des2.Tag.ToString(), Des2.Text);
            aa.Dic_in.Add(Des3.Tag.ToString(), Des3.Text);
            aa.Dic_in.Add(Des4.Tag.ToString(), Des4.Text);
            aa.Dic_in.Add(Des5.Tag.ToString(), Des5.Text);
            aa.Dic_in.Add(Des6.Tag.ToString(), Des6.Text);
            Des7.DataSource = aa.GetData(aa.Dic_in, table.Text, Des7.Tag.ToString());//data source accept list
        }

        private void Des7_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des1.Tag.ToString(), Des1.Text);
            aa.Dic_in.Add(Des2.Tag.ToString(), Des2.Text);
            aa.Dic_in.Add(Des3.Tag.ToString(), Des3.Text);
            aa.Dic_in.Add(Des4.Tag.ToString(), Des4.Text);
            aa.Dic_in.Add(Des5.Tag.ToString(), Des5.Text);
            aa.Dic_in.Add(Des6.Tag.ToString(), Des6.Text);
            aa.Dic_in.Add(Des7.Tag.ToString(), Des7.Text);
            Des8.DataSource = aa.GetData(aa.Dic_in, table.Text, Des8.Tag.ToString());//data source accept list
        }

        private void Des8_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des1.Tag.ToString(), Des1.Text);
            aa.Dic_in.Add(Des2.Tag.ToString(), Des2.Text);
            aa.Dic_in.Add(Des3.Tag.ToString(), Des3.Text);
            aa.Dic_in.Add(Des4.Tag.ToString(), Des4.Text);
            aa.Dic_in.Add(Des5.Tag.ToString(), Des5.Text);
            aa.Dic_in.Add(Des6.Tag.ToString(), Des6.Text);
            aa.Dic_in.Add(Des7.Tag.ToString(), Des7.Text);
            aa.Dic_in.Add(Des8.Tag.ToString(), Des8.Text);
            if (Des8.SelectedIndex > 0)

            {
                Ref1.Text = aa.GetData(aa.Dic_in, table.Text, Ref1.Tag.ToString())[1];
            }
            else
            {
                Ref1.Text = "";
            }
        }

        private void Add1_Click(object sender, EventArgs e)
        {
            this.SetDesktopLocation(0, 0);
            Excel_interface z = new Excel_interface();
            z.Add_new_line(new List<string> { Des1.Text, Des2.Text, Des3.Text, Des4.Text, Des5.Text, Des6.Text, Des7.Text, Des8.Text }, Ref1.Text, Qty1.Text);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccessDBC.connection_str = AccessDBC.Database_LOC("MV.accdb");
            AccessDBC a = new AccessDBC();
            ToExcelC c = new ToExcelC();
            DataTable tablex = new DataTable();
            List<string> list = new List<string>() { Des1.Tag.ToString(), Des2.Tag.ToString(), Des3.Tag.ToString(), Des4.Tag.ToString(), Des5.Tag.ToString(), Des6.Tag.ToString(), Des7.Tag.ToString(), Des8.Tag.ToString(), Ref1.Tag.ToString() };
            tablex = a.Read_DataSet(null, table.Text, list);
            c.ExportToExcel(tablex, "CTMCSET123");
        }

        private void to_catelog_Click(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add("Name", "CTMCSET123");
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
