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
    public partial class Additiona_coils : Form
    {
        static public bool exist = false;
        static public Additiona_coils obj;
        public Additiona_coils()
        {
            InitializeComponent();

        }

        private void Additiona_coils_Load(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            List<string> colomn_name;
            colomn_name = aa.GetTableColumnNames(table.Text);

            Des8.Tag = colomn_name[8];
            Des9.Tag = colomn_name[9];

            Ref7.Tag = colomn_name[16];
            Ref8.Tag = colomn_name[16];

            Des8.DataSource = aa.GetData(aa.Dic_in, table.Text, Des8.Tag.ToString());//data source accept list
            Des9.DataSource = aa.GetData(aa.Dic_in, table.Text, Des9.Tag.ToString());//data source accept list


        }

        private void Des8_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des8.Tag.ToString(), Des8.Text);
            if (Des8.SelectedIndex > 0)

            {
                Ref7.Text = aa.GetData(aa.Dic_in, table.Text, Ref7.Tag.ToString())[1];
            }
            else
            {
                Ref7.Text = "";
            }
        }

        private void Des9_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des9.Tag.ToString(), Des9.Text);
            if (Des9.SelectedIndex > 0)

            {
                Ref8.Text = aa.GetData(aa.Dic_in, table.Text, Ref8.Tag.ToString())[1];
            }
            else
            {
                Ref8.Text = "";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            this.SetDesktopLocation(0, 0);
            Excel_interface z = new Excel_interface();
            z.Add_new_line(new List<string> { Des8.Text }, Ref7.Text, Qty7.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.SetDesktopLocation(0, 0);
            Excel_interface z = new Excel_interface();
            z.Add_new_line(new List<string> { Des9.Text }, Ref8.Text, Qty8.Text);
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccessDBC.connection_str = AccessDBC.Database_LOC("MV.accdb");
            AccessDBC a = new AccessDBC();
            ToExcelC c = new ToExcelC();
            DataTable tablex = new DataTable();
            List<string> list = new List<string>() { Des8.Tag.ToString(), Ref7.Tag.ToString() };
            tablex = a.Read_DataSet(null, table.Text, list);
            c.ExportToExcel(tablex, "Second Shunt");
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccessDBC.connection_str = AccessDBC.Database_LOC("MV.accdb");
            AccessDBC a = new AccessDBC();
            ToExcelC c = new ToExcelC();
            DataTable tablex = new DataTable();
            List<string> list = new List<string>() { Des9.Tag.ToString(), Ref8.Tag.ToString() };
            tablex = a.Read_DataSet(null, table.Text, list);
            c.ExportToExcel(tablex, "Under voltage");
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

        private void Additiona_coils_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


    }
}
