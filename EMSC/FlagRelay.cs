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
    public partial class FlagRelay : Form
    {
        public FlagRelay()
        {
            InitializeComponent();
        }

        private void FlagRelay_Load(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            List<string> colomn_name;
            colomn_name = aa.GetTableColumnNames(table.Text);
            Des1.Tag = colomn_name[1];
            Des2.Tag = colomn_name[2];
            Ref1.Tag = colomn_name[3];
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

            if (Des2.SelectedIndex > 0)

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
            z.Add_new_line(new List<string> { Des1.Text, Des2.Text }, Ref1.Text, Qty1.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            AccessDBC.connection_str = AccessDBC.Database_LOC("MV.accdb");
            AccessDBC a = new AccessDBC();

            ToExcelC c = new ToExcelC();
            DataTable tablex = new DataTable();
            List<string> list = new List<string>() { Des1.Tag.ToString(), Des2.Tag.ToString(), Ref1.Tag.ToString() };
            tablex = a.Read_DataSet(null, table.Text, list);
            c.ExportToExcel(tablex, "Flag Relay");
        }
    }
}
