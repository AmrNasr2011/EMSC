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
    public partial class PIXVT : Form
    {
        static bool Status = false; //represent status if form has data = true otherwise = false@
        static bool intialized = false;//table of fields initalized@
        public static DataTable Fieldtable;//table that will contain all history of windowform@
        int current = 0;

        string NoteCol;

        public PIXVT()
        {
            InitializeComponent();
        }
    
        private void Des1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContainerActions.DisableInterupt)
            {
                return;
            }
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des1.Tag.ToString(), Des1.Text);
            Des2.DataSource = aa.GetData(aa.Dic_in, table.Text, Des2.Tag.ToString());//data source accept list
        }

        private void Des2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContainerActions.DisableInterupt)
            {
                return;
            }
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des1.Tag.ToString(), Des1.Text);
            aa.Dic_in.Add(Des2.Tag.ToString(), Des2.Text);
            Des3.DataSource = aa.GetData(aa.Dic_in, table.Text, Des3.Tag.ToString());//data source accept list
        }

        private void Des3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContainerActions.DisableInterupt)
            {
                return;
            }
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des1.Tag.ToString(), Des1.Text);
            aa.Dic_in.Add(Des2.Tag.ToString(), Des2.Text);
            aa.Dic_in.Add(Des3.Tag.ToString(), Des3.Text);
            Des4.DataSource = aa.GetData(aa.Dic_in, table.Text, Des4.Tag.ToString());//data source accept list
        }

        private void Des4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContainerActions.DisableInterupt)
            {
                return;
            }
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des1.Tag.ToString(), Des1.Text);
            aa.Dic_in.Add(Des2.Tag.ToString(), Des2.Text);
            aa.Dic_in.Add(Des3.Tag.ToString(), Des3.Text);
            aa.Dic_in.Add(Des4.Tag.ToString(), Des4.Text);
            Des5.DataSource = aa.GetData(aa.Dic_in, table.Text, Des5.Tag.ToString());//data source accept list
        }

        private void Des5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContainerActions.DisableInterupt)
            {
                return;
            }
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
            if (ContainerActions.DisableInterupt)
            {
                return;
            }
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
            if (ContainerActions.DisableInterupt)
            {
                return;
            }
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des1.Tag.ToString(), Des1.Text);
            aa.Dic_in.Add(Des2.Tag.ToString(), Des2.Text);
            aa.Dic_in.Add(Des3.Tag.ToString(), Des3.Text);
            aa.Dic_in.Add(Des4.Tag.ToString(), Des4.Text);
            aa.Dic_in.Add(Des5.Tag.ToString(), Des5.Text);
            aa.Dic_in.Add(Des6.Tag.ToString(), Des6.Text);
            aa.Dic_in.Add(Des7.Tag.ToString(), Des7.Text);
            if (Des7.SelectedIndex > 0)

            {
                Ref1.Text = aa.GetData(aa.Dic_in, table.Text, Ref1.Tag.ToString())[1];
                try
                {
                    string asd = aa.GetData(aa.Dic_in, table.Text, NoteCol)[1];
                    if (!string.IsNullOrWhiteSpace(asd))
                    {
                        MessageBox.Show(asd);
                    }

                }
                catch (Exception)
                {
                }
            }
            else
            {
                Ref1.Text = "";
            }

        }

        private void Des8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContainerActions.DisableInterupt)
            {
                return;
            }
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des8.Tag.ToString(), Des8.Text);
            Des9.DataSource = aa.GetData(aa.Dic_in, table.Text, Des9.Tag.ToString());//data source accept list
        }

        private void Des9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContainerActions.DisableInterupt)
            {
                return;
            }
            AccessDB aa = new AccessDB();
            aa.Dic_in.Add(Des8.Tag.ToString(), Des8.Text);
            aa.Dic_in.Add(Des9.Tag.ToString(), Des9.Text);
            if (Des9.SelectedIndex > 0)

            {
                Ref2.Text = aa.GetData(aa.Dic_in, table.Text, Ref2.Tag.ToString())[1];
            }
            else
            {
                Ref2.Text = "";
            }
        }

        private void Add1_Click(object sender, EventArgs e)
        {
            this.SetDesktopLocation(0, 0);
            Excel_interface z = new Excel_interface();
            z.Add_new_line(new List<string> { Des1.Text, Des2.Text, Des3.Text, Des4.Text, Des5.Text, Des6.Text, Des7.Text }, Ref1.Text, Qty1.Text);

        }

        private void Add2_Click(object sender, EventArgs e)
        {
            this.SetDesktopLocation(0, 0);
            Excel_interface z = new Excel_interface();
            z.Add_new_line(new List<string> { Des8.Text, Des9.Text }, Ref2.Text, Qty1.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccessDBC.connection_str = AccessDBC.Database_LOC("MV.accdb");
            AccessDBC a = new AccessDBC();
            ToExcelC c = new ToExcelC();
            DataTable tablex = new DataTable();
            List<string> list = new List<string>() { Des1.Tag.ToString(), Des2.Tag.ToString(), Des3.Tag.ToString(), Des4.Tag.ToString(), Des5.Tag.ToString(), Des6.Tag.ToString(), Des7.Tag.ToString(), Ref1.Tag.ToString() };
            tablex = a.Read_DataSet(null, table.Text, list);
            c.ExportToExcel(tablex, "Voltage Transformers");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccessDBC.connection_str = AccessDBC.Database_LOC("MV.accdb");
            AccessDBC a = new AccessDBC();

            ToExcelC c = new ToExcelC();
            DataTable tablex = new DataTable();
            List<string> list = new List<string>() { Des8.Tag.ToString(), Des9.Tag.ToString(), Ref2.Tag.ToString() };
            tablex = a.Read_DataSet(null, table.Text, list);
            c.ExportToExcel(tablex, "Open Delta");
        }

        private void PIX_Load(object sender, EventArgs e)
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
            NoteCol = colomn_name[11];
            Des1.DataSource = aa.GetData(aa.Dic_in, table.Text, Des1.Tag.ToString());//data source accept list
            Des8.DataSource = aa.GetData(aa.Dic_in, table.Text, Des8.Tag.ToString());//data source accept list
            //@
            if (! intialized)
            {
                Fieldtable = ContainerActions.AllcontrolNamesToDatatable(this);
                intialized = true;
            }
            current = Fieldtable.Rows.Count;
            index.Text = string.Format("{0} / {1}", Fieldtable.Rows.Count, current);
           //@
        }

        private void to_catelog_Click(object sender, EventArgs e)
        {

            AccessDB aa = new AccessDB();
            aa.Dic_in.Add("Name", "PTPIX");
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
        //@
        private void Reset1_Click(object sender, EventArgs e)
        {
            //need to make generic function to loop over all control component in this groupbox and remove text
            //of all combobox and text box
            ContainerActions.ClearGroupBox((GroupBox)((Button)sender).Parent);
        }

        private void Reset2_Click(object sender, EventArgs e)
        {
            ContainerActions.ClearGroupBox((GroupBox)((Button)sender).Parent);
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (current == Fieldtable.Rows.Count)
            {//here no next exist
                return;
            }
            else if (current == Fieldtable.Rows.Count-1)
            {
                current++;
                ContainerActions.ClearFieldsInForm(this);
                updateStatus();

            }else
            {
                //load specific row to data fields
                current++;
                ContainerActions.LoadFieldsFromRow(this,Fieldtable.Rows[current+1]);
                updateStatus();
            }

        }
        void updateStatus()
        {
            index.Text = string.Format("{0} / {1}", Fieldtable.Rows.Count, current);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (current==0)
            {
                return;//no value remaining
            }
            else
            {
                current--;
                ContainerActions.LoadFieldsFromRow(this, Fieldtable.Rows[current]);
                updateStatus();
            }
        }

        private void Save_Next_Click(object sender, EventArgs e)
        {
            if (!ContainerActions.CheckSelectionhappen(this))
            {//here two cases may happed
                //1 at last so no need to make any update
                //before last so this lead to cancel already made form
                if (current == Fieldtable.Rows.Count)
                {
                    MessageBox.Show("Kindly make selection for reference");
                    return;
                }
                else
                {
                    //show no modification happened here do you want to delete 
                    DialogResult dialogResult = MessageBox.Show("No modification happen on this screen do you want to delete it", "Form Deletion", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //delete row at index
                        Fieldtable.Rows.RemoveAt(current );
                        if (current == Fieldtable.Rows.Count)
                        {
                            ContainerActions.ClearFieldsInForm(this);

                        }
                        else
                        {
                            ContainerActions.LoadFieldsFromRow(this, Fieldtable.Rows[current ]);
                        }
                        updateStatus();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
               
            }
            else if(current == Fieldtable.Rows.Count)//last element
	        {
                ContainerActions.SaveFields(this, ref Fieldtable);
                current++;
                updateStatus();
                ContainerActions.ClearFieldsInForm(this);
            }
            else
            {
                //here i need to update 
                ContainerActions.UpdateFieldsInForm(this, Fieldtable,current);

                Next.PerformClick();////
            }
        }

        private void Save_Close_Click(object sender, EventArgs e)
        {
            if (!ContainerActions.CheckSelectionhappen(this))
            {//here two cases may happed
                //1 at last so no need to make any update
                //before last so this lead to cancel already made form
                if (current == Fieldtable.Rows.Count)
                {
                    CloseForm();
                }
                else
                {
                    //show no modification happened here do you want to delete 
                    DialogResult dialogResult = MessageBox.Show("No modification happen on this screen do you want to delete it", "Form Deletion", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //delete row at index
                        Fieldtable.Rows.RemoveAt(current);
                        if (current == Fieldtable.Rows.Count)
                        {
                            ContainerActions.ClearFieldsInForm(this);

                        }
                        else
                        {
                            ContainerActions.LoadFieldsFromRow(this, Fieldtable.Rows[current]);
                        }
                        CloseForm();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }

            }
            else if (current == Fieldtable.Rows.Count)//last element
            {
                ContainerActions.SaveFields(this, ref Fieldtable);
                CloseForm();
            }
            else
            {
                //here i need to update 
                ContainerActions.UpdateFieldsInForm(this, Fieldtable, current);

                CloseForm();
            }
        }
        void CloseForm()
        {
            bool check;
            DialogResult dialogResult = MessageBox.Show("Do you want to close this Selection Form", "Form Closing", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (Fieldtable.Rows.Count>0)
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
                ContainerActions.FormStatus= check;
                this.Close();

            }
            //@
        }
    }
}
