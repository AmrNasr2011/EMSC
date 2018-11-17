using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMSC
{
    class ContainerActions
        
    {
        public static bool FormStatus;
        public static bool DisableInterupt = false;
        public static Dictionary<string, bool> FormStatusAll = new Dictionary<string, bool>();
        public static void ClearGroupBox(GroupBox control)
        {
            foreach (ListBox listBox in control.Controls.OfType<ListBox>())
            {
                listBox.Items.Clear();
                // do more ListBox cleanup
            }
            foreach (CheckedListBox listBox in control.Controls.OfType<CheckedListBox>())
            {
                listBox.Items.Clear();
                // do more CheckedListBox cleanup
            }
            foreach (ListView listView in control.Controls.OfType<ListView>())
            {
                listView.Items.Clear();
                // do more ListView cleanup
            }
            foreach (CheckBox checkBox in control.Controls.OfType<CheckBox>())
            {
                checkBox.Checked = false;
                // do more CheckBox cleanup
            }
            foreach (TextBox textbox in control.Controls.OfType<TextBox>())
            {
                textbox.Text = "";
            }
            foreach (ComboBox combo in control.Controls.OfType<ComboBox>())
            {
                combo.SelectedIndex = 0;
            }
            foreach (ComboBox combo in control.Controls.OfType<ComboBox>())
            {
                combo.Text = "";
            }
        }
        /// <summary>
        /// get all testbox and comboboxes in windowsform and add them as colomn in dataform
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static DataTable AllcontrolNamesToDatatable(Form control)
        {
            DataTable table = new DataTable();
            //foreach (ListBox listBox in control.Controls.OfType<ListBox>())
            //{
            //    listBox.Items.Clear();
            //    // do more ListBox cleanup
            //}
            //foreach (CheckedListBox listBox in control.Controls.OfType<CheckedListBox>())
            //{
            //    listBox.Items.Clear();
            //    // do more CheckedListBox cleanup
            //}
            //foreach (ListView listView in control.Controls.OfType<ListView>())
            //{
            //    listView.Items.Clear();
            //    // do more ListView cleanup
            //}
            //foreach (CheckBox checkBox in control.Controls.OfType<CheckBox>())
            //{
            //    checkBox.Checked = false;
            //    // do more CheckBox cleanup
            //}
            foreach (TextBox textbox in control.Controls.OfType<TextBox>())
            {
                table.Columns.Add(textbox.Name, typeof(string));
                
            }
            foreach (ComboBox combo in control.Controls.OfType<ComboBox>())
            {
                table.Columns.Add(combo.Name, typeof(string));
            }
            foreach (GroupBox box in control.Controls.OfType<GroupBox>())
            {
                foreach (TextBox textbox in box.Controls.OfType<TextBox>())
                {
                    table.Columns.Add(textbox.Name, typeof(string));

                }
                foreach (ComboBox combo in box.Controls.OfType<ComboBox>())
                {
                    table.Columns.Add(combo.Name, typeof(string));
                }
               
            }
            return table;
        }
        /// <summary>
        /// This function that no selection made inside window form, but need all "AccessibleDescription" of all 
        /// reference fields to be equel "Ref"
        /// </summary>
        /// <param name="control"> used as This</param>
        /// <returns>true in case of selectionFalse Otherwise </returns>
        public static bool CheckSelectionhappen(Form control)
        {
           
            foreach (TextBox textbox in control.Controls.OfType<TextBox>())
            {
                if (textbox.AccessibleDescription == "Ref")
                {
                    if (! string.IsNullOrWhiteSpace(textbox.Text))
                    {
                        return true;
                    }
                }

            }
       
            foreach (GroupBox box in control.Controls.OfType<GroupBox>())
            {
                foreach (TextBox textbox in box.Controls.OfType<TextBox>())
                {
                    if (textbox.AccessibleDescription == "Ref")
                    {
                        if (!string.IsNullOrWhiteSpace(textbox.Text))
                        {
                            return true;
                        }
                    }

                } 
            }
            return false;
        }
        /// <summary>
        /// save new row but you must check first that selection happened 
        /// </summary>
        /// <param name="control">refer to This</param>
        /// <param name="table"> Refer to table of fields</param>
        public static void SaveFields(Form control, ref DataTable table)
        {
            DataRow row = table.NewRow();
            foreach (TextBox textbox in control.Controls.OfType<TextBox>())
            {
                row[textbox.Name] = textbox.Text;

            }
            foreach (ComboBox combo in control.Controls.OfType<ComboBox>())
            {
                row[combo.Name] = combo.Text;
            }
            foreach (GroupBox box in control.Controls.OfType<GroupBox>())
            {
                foreach (TextBox textbox in box.Controls.OfType<TextBox>())
                {
                    row[textbox.Name] = textbox.Text;

                }
                foreach (ComboBox combo in box.Controls.OfType<ComboBox>())
                {
                    row[combo.Name] = combo.Text;
                }
            }
            table.Rows.Add(row);
        }
        /// <summary>
        /// load all data in form from datatable row
        /// </summary>
        /// <param name="control">form which its control will be loaded</param>
        /// <param name="row">row that contain data</param>
        public static void LoadFieldsFromRow(Form control, DataRow row)
        {
            DisableInterupt = true;
            foreach (TextBox textbox in control.Controls.OfType<TextBox>())
            {
                textbox.Text= row[textbox.Name].ToString() ;

            }
            foreach (ComboBox combo in control.Controls.OfType<ComboBox>())
            {
                combo.Text = row[combo.Name].ToString();
            }
            foreach (GroupBox box in control.Controls.OfType<GroupBox>())
            {
                foreach (TextBox textbox in box.Controls.OfType<TextBox>())
                {
                    textbox.Text = row[textbox.Name].ToString();

                }
                foreach (ComboBox combo in box.Controls.OfType<ComboBox>())
                {
                    combo.Text = row[combo.Name].ToString();
                }
            }
            DisableInterupt = false;
        }
        /// <summary>
        /// clear all fields in form
        /// </summary>
        /// <param name="control"></param>
        /// <param name="row"></param>
        public static void ClearFieldsInForm(Form control)
        {
            foreach (TextBox textbox in control.Controls.OfType<TextBox>())
            {
                textbox.Text = "";

            }
            foreach (ComboBox combo in control.Controls.OfType<ComboBox>())
            {
                combo.Text = "";
            }
            foreach (GroupBox box in control.Controls.OfType<GroupBox>())
            {
                foreach (TextBox textbox in box.Controls.OfType<TextBox>())
                {
                    textbox.Text ="";

                }
                foreach (ComboBox combo in box.Controls.OfType<ComboBox>())
                {
                    combo.Text = "";
                }
            }
        }
        //update at specific row index
        /// <summary>
        /// update table at specific row index
        /// </summary>
        /// <param name="control"> used as This</param>
        /// <param name="table">FeildsTable</param>
        /// <param name="index">used as row index required to be updated</param>
        public static void UpdateFieldsInForm(Form control, DataTable table , int index)
        {
            foreach (TextBox textbox in control.Controls.OfType<TextBox>())
            {
                table.Rows[index][textbox.Name] = textbox.Text;

            }
            foreach (ComboBox combo in control.Controls.OfType<ComboBox>())
            {
                table.Rows[index][combo.Name] = combo.Text;
            }
            foreach (GroupBox box in control.Controls.OfType<GroupBox>())
            {
                foreach (TextBox textbox in box.Controls.OfType<TextBox>())
                {
                    table.Rows[index][textbox.Name] = textbox.Text;

                }
                foreach (ComboBox combo in box.Controls.OfType<ComboBox>())
                {
                    table.Rows[index][combo.Name] = combo.Text;
                }
            }
        }
    }
}
