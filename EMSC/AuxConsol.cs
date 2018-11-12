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
    public partial class AuxConsol : Form
    {
        public AuxConsol()
        {
            InitializeComponent();
        }

        private void AuxConsol_Load(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            List<string> colomn_name;
            colomn_name = aa.GetTableColumnNames(table.Text);

            Des4.Tag = colomn_name[1];
            Des5.Tag = colomn_name[2];

            Ref2.Tag = colomn_name[3];

            Des4.DataSource = aa.GetData(aa.Dic_in, table.Text, Des4.Tag.ToString());//data source accept list
        }


        private void Des4_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des4.Tag.ToString(), Des4.Text);

            Des5.DataSource = aa.GetData(aa.Dic_in, table.Text, Des5.Tag.ToString());//data source accept list
        }
        private void Des5_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des4.Tag.ToString(), Des4.Text);
            aa.Dic_in.Add(Des5.Tag.ToString(), Des5.Text);
            if (Des4.SelectedIndex > 0)

            {
                Ref2.Text = aa.GetData(aa.Dic_in, table.Text, Ref2.Tag.ToString())[1];
            }
            else
            {
                Ref2.Text = "";
            }
        }


        private void Add2_Click(object sender, EventArgs e)
        {
            this.SetDesktopLocation(0, 0);
            Excel_interface z = new Excel_interface();
            z.Add_new_line(new List<string> { Des4.Text, Des5.Text }, Ref2.Text, Qty2.Text);
        }



        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccessDBC.connection_str = AccessDBC.Database_LOC("MV.accdb");
            AccessDBC a = new AccessDBC();

            ToExcelC c = new ToExcelC();
            DataTable tablex = new DataTable();
            List<string> list = new List<string>() { Des4.Tag.ToString(), Des5.Tag.ToString(), Ref2.Tag.ToString() };
            tablex = a.Read_DataSet(null, table.Text, list);
            c.ExportToExcel(tablex, "Auxiliaries");
        }

        private void to_catelog_Click(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add("Name", "AuxConsol");
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
