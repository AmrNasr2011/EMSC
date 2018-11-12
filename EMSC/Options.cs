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
    public partial class Options : Form
    {
        static public bool exist = false;
        static public Options obj;
        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            List<string> colomn_name;
            colomn_name = aa.GetTableColumnNames(table.Text);

            Des10.Tag = colomn_name[10];
            Des11.Tag = colomn_name[11];
            Des12.Tag = colomn_name[12];
            Des13.Tag = colomn_name[13];
            Des14.Tag = colomn_name[14];
            Des15.Tag = colomn_name[15];

            Ref9.Tag = colomn_name[16];
            Ref10.Tag = colomn_name[16];
            Ref11.Tag = colomn_name[16];
            Ref12.Tag = colomn_name[16];
            Ref13.Tag = colomn_name[16];
            Ref14.Tag = colomn_name[16];


            Des10.DataSource = aa.GetData(aa.Dic_in, table.Text, Des10.Tag.ToString());//data source accept list
            Des11.DataSource = aa.GetData(aa.Dic_in, table.Text, Des11.Tag.ToString());//data source accept list
            Des12.DataSource = aa.GetData(aa.Dic_in, table.Text, Des12.Tag.ToString());//data source accept list
            Des13.DataSource = aa.GetData(aa.Dic_in, table.Text, Des13.Tag.ToString());//data source accept list
            Des14.DataSource = aa.GetData(aa.Dic_in, table.Text, Des14.Tag.ToString());//data source accept list
            Des15.DataSource = aa.GetData(aa.Dic_in, table.Text, Des15.Tag.ToString());//data source accept list

        }

        private void Des10_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des10.Tag.ToString(), Des10.Text);
            if (Des10.SelectedIndex > 0)

            {
                Ref9.Text = aa.GetData(aa.Dic_in, table.Text, Ref9.Tag.ToString())[1];
            }
            else
            {
                Ref9.Text = "";
            }
        }

        private void Des11_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des11.Tag.ToString(), Des11.Text);
            if (Des11.SelectedIndex > 0)

            {
                Ref10.Text = aa.GetData(aa.Dic_in, table.Text, Ref10.Tag.ToString())[1];
            }
            else
            {
                Ref10.Text = "";
            }
        }

        private void Des12_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des12.Tag.ToString(), Des12.Text);
            if (Des12.SelectedIndex > 0)

            {
                Ref11.Text = aa.GetData(aa.Dic_in, table.Text, Ref11.Tag.ToString())[1];
            }
            else
            {
                Ref11.Text = "";
            }
        }

        private void Des13_SelectedIndexChanged(object sender, EventArgs e)
        {

            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des13.Tag.ToString(), Des13.Text);
            if (Des13.SelectedIndex > 0)

            {
                Ref12.Text = aa.GetData(aa.Dic_in, table.Text, Ref12.Tag.ToString())[1];
            }
            else
            {
                Ref12.Text = "";
            }
        }

        private void Des14_SelectedIndexChanged(object sender, EventArgs e)
        {

            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des14.Tag.ToString(), Des14.Text);
            if (Des14.SelectedIndex > 0)

            {
                Ref13.Text = aa.GetData(aa.Dic_in, table.Text, Ref13.Tag.ToString())[1];
            }
            else
            {
                Ref13.Text = "";
            }
        }

        private void Des15_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des15.Tag.ToString(), Des15.Text);
            if (Des15.SelectedIndex > 0)

            {
                Ref14.Text = aa.GetData(aa.Dic_in, table.Text, Ref14.Tag.ToString())[1];
            }
            else
            {
                Ref14.Text = "";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.SetDesktopLocation(0, 0);
            Excel_interface z = new Excel_interface();
            z.Add_new_line(new List<string> { Des10.Text }, Ref9.Text, Qty9.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.SetDesktopLocation(0, 0);
            Excel_interface z = new Excel_interface();
            z.Add_new_line(new List<string> { Des11.Text }, Ref10.Text, Qty10.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.SetDesktopLocation(0, 0);
            Excel_interface z = new Excel_interface();
            z.Add_new_line(new List<string> { Des12.Text }, Ref11.Text, Qty11.Text);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.SetDesktopLocation(0, 0);
            Excel_interface z = new Excel_interface();
            z.Add_new_line(new List<string> { Des13.Text }, Ref12.Text, Qty12.Text);

        }

        private void button12_Click(object sender, EventArgs e)
        {

            this.SetDesktopLocation(0, 0);
            Excel_interface z = new Excel_interface();
            z.Add_new_line(new List<string> { Des14.Text }, Ref13.Text, Qty13.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.SetDesktopLocation(0, 0);
            Excel_interface z = new Excel_interface();
            z.Add_new_line(new List<string> { Des15.Text }, Ref14.Text, Qty14.Text);
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccessDBC.connection_str = AccessDBC.Database_LOC("MV.accdb");
            AccessDBC a = new AccessDBC();
            ToExcelC c = new ToExcelC();
            DataTable tablex = new DataTable();
            List<string> list = new List<string>() { Des10.Tag.ToString(), Ref9.Tag.ToString() };
            tablex = a.Read_DataSet(null, table.Text, list);
            c.ExportToExcel(tablex, "Closing Solenoid");
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccessDBC.connection_str = AccessDBC.Database_LOC("MV.accdb");
            AccessDBC a = new AccessDBC();
            ToExcelC c = new ToExcelC();
            DataTable tablex = new DataTable();
            List<string> list = new List<string>() { Des11.Tag.ToString(), Ref10.Tag.ToString() };
            tablex = a.Read_DataSet(null, table.Text, list);
            c.ExportToExcel(tablex, "triping Release");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccessDBC.connection_str = AccessDBC.Database_LOC("MV.accdb");
            AccessDBC a = new AccessDBC();
            ToExcelC c = new ToExcelC();
            DataTable tablex = new DataTable();
            List<string> list = new List<string>() { Des12.Tag.ToString(), Ref11.Tag.ToString() };
            tablex = a.Read_DataSet(null, table.Text, list);
            c.ExportToExcel(tablex, "Voltage Release");
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccessDBC.connection_str = AccessDBC.Database_LOC("MV.accdb");
            AccessDBC a = new AccessDBC();
            ToExcelC c = new ToExcelC();
            DataTable tablex = new DataTable();
            List<string> list = new List<string>() { Des13.Tag.ToString(), Ref12.Tag.ToString() };
            tablex = a.Read_DataSet(null, table.Text, list);
            c.ExportToExcel(tablex, "Untipumping Relay");
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccessDBC.connection_str = AccessDBC.Database_LOC("MV.accdb");
            AccessDBC a = new AccessDBC();
            ToExcelC c = new ToExcelC();
            DataTable tablex = new DataTable();
            List<string> list = new List<string>() { Des14.Tag.ToString(), Ref13.Tag.ToString() };
            tablex = a.Read_DataSet(null, table.Text, list);
            c.ExportToExcel(tablex, "Blocking Coil");
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccessDBC.connection_str = AccessDBC.Database_LOC("MV.accdb");
            AccessDBC a = new AccessDBC();
            ToExcelC c = new ToExcelC();
            DataTable tablex = new DataTable();
            List<string> list = new List<string>() { Des15.Tag.ToString(), Ref14.Tag.ToString() };
            tablex = a.Read_DataSet(null, table.Text, list);
            c.ExportToExcel(tablex, "General requirments");
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

        private void Options_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
