using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMSC
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LF123.exist)
            {
                LF123.obj.Activate();
                LF123.obj.WindowState = FormWindowState.Normal;
            }
            else
            {
                LF123.obj = new LF123();
                LF123.exist = true;
                LF123.obj.Show();
            }

        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (LF123.exist)
            {
                LF123.obj.Activate();
                LF123.obj.WindowState = FormWindowState.Normal;
            }
            else
            {
                LF123.obj = new LF123();
                LF123.exist = true;
                LF123.obj.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MiniatureCircuit.exist)
            {
                MiniatureCircuit.obj.Activate();
                MiniatureCircuit.obj.WindowState = FormWindowState.Normal;
            }
            else
            {
                MiniatureCircuit.obj = new MiniatureCircuit();
                MiniatureCircuit.exist = true;
                MiniatureCircuit.obj.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //if (MotorStartersx.exist)
            //{
            //    MotorStartersx.obj.Activate();
            //    MotorStartersx.obj.WindowState = FormWindowState.Normal;
            //}
            //else
            //{
            //    MotorStartersx.obj = new MotorStartersx();
            //    MotorStartersx.exist = true;
            //    MotorStartersx.obj.Show();
            //}
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //if (SoftStartersx.exist)
            //{
            //    SoftStartersx.obj.Activate();
            //    SoftStartersx.obj.WindowState = FormWindowState.Normal;
            //}
            //else
            //{
            //    SoftStartersx.obj = new SoftStartersx();
            //    SoftStartersx.exist = true;
            //    SoftStartersx.obj.Show();
            //}
        }



        private void button9_Click(object sender, EventArgs e)
        {

            if (ControlAuxiliaries.exist)
            {
                ControlAuxiliaries.obj.Activate();
                ControlAuxiliaries.obj.WindowState = FormWindowState.Normal;
            }
            else
            {
                ControlAuxiliaries.obj = new ControlAuxiliaries();
                ControlAuxiliaries.exist = true;
                ControlAuxiliaries.obj.Show();
            }
        }





        private void button12_Click(object sender, EventArgs e)
        {

            if (ProtectionRelaysMetering.exist)
            {
                ProtectionRelaysMetering.obj.Activate();
                ProtectionRelaysMetering.obj.WindowState = FormWindowState.Normal;
            }
            else
            {
                ProtectionRelaysMetering.obj = new ProtectionRelaysMetering();
                ProtectionRelaysMetering.exist = true;
                ProtectionRelaysMetering.obj.Show();
            }
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            //TODO 1update as appropriate or make it a parameter
            //TODO 2update file verion from properties application
            //TODO 3update "UpdateVersion" and put same value in Update.csv

            version.Text = Properties.Settings.Default.UpdateVersion;
            int x;
            do
            {
                x = check_DB();
            } while (x == 1);
            if (x == 3)
            {
                this.Close();
            }
        }
        void update_DB()
        {
            int current_version;
            int remote_version;
            //check current Database index
            current_version = AccessDBC.version_num(Properties.Settings.Default.LocalDB);
            if (current_version <= 0)
            {
                MessageBox.Show("error in geting currrent DB index");

            }
            else
            {
                DB_index.Text = current_version.ToString();
            }

            //check remote Database index
            remote_version = AccessDBC.version_num(Properties.Settings.Default.RemoteDB);
            //check if two are the same
            if (remote_version <= 0 || remote_version == current_version)
            {
                //do nothing you are in recent updated verion
                MessageBox.Show("No Update Happened you are in last index");
            }
            else if (remote_version > current_version)
            {//here you need to update your database
                //copy and replace
                string local_file = Application.StartupPath + "\\MV.accdb";
                string remote_file = Properties.Settings.Default.Remote_file;
                File.Delete(local_file);
                //apply cablok modif
                File.Copy(remote_file, local_file, true);
                MessageBox.Show("DataBase update From index: " + DB_index.Text + "to index: " + remote_version.ToString());
                DB_index.Text = remote_version.ToString();

            }
        }

        private void btnversion_Click(object sender, EventArgs e)
        {
            DB_Location DB_loc = new DB_Location();
            DB_Location.status = "normal";
            DB_loc.ShowDialog();
            if (DB_Location.save_pressed == 1)
            {
                DB_Location.save_pressed = 0;
                loop_DB_check();
            }
            //   update_DB();
        }
        void loop_DB_check()
        {
            int x;
            do
            {
                x = check_DB();
            } while (x == 1);
        }
        int check_DB()
        {
            //here i should test if local db exist by check its index
            int current_version;
            int remote_version;
            //below function will return -1 in case of error
            current_version = AccessDB.version_num(Properties.Settings.Default.LocalDB);
            if (current_version < 0)
            {   //check if no link to remote DB exist
                if (Properties.Settings.Default.Remote_file == "")
                {
                    //call DB_location form with close status
                    DB_Location.status = "close";
                    DB_Location.comment = "Local Database is not exist, and no valid link to remote database. Note if you press cancel or close this window application will automatically close.";
                    DB_Location DB_loc = new DB_Location();
                    DB_loc.ShowDialog();
                    if (DB_Location.app_close == 1)
                    {
                        return 3;
                    }
                    return 1;
                }
                else
                {
                    string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Properties.Settings.Default.Remote_file;
                    //check if we can access remote DB
                    remote_version = AccessDB.version_num(connectionString);
                    if (remote_version < 0)
                    {
                        //not valid link 
                        DB_Location.status = "close";
                        DB_Location.comment = "Local Database is not exist, and current link to remote database is not valid. Note if you press cancel or close this window application will automatically close.";
                        DB_Location DB_loc = new DB_Location();
                        DB_loc.ShowDialog();
                        if (DB_Location.app_close == 1)
                        {
                            return 3;
                        }
                        return 1;
                    }
                    else
                    {
                        //here i should copy remote database to local directory.
                        string local_file = Application.StartupPath + "\\MV.accdb";
                        string remote_file = Properties.Settings.Default.Remote_file;
                        try
                        {
                            File.Copy(remote_file, local_file, true);
                        }
                        catch (Exception)
                        {
                            //incase of error in copying aplication should close
                            MessageBox.Show("Error happen while updating local Database, Please make sure you run this application as adminstrator");
                            this.Close();
                        }
                        DB_index.Text = remote_version.ToString();
                        DB_status.Text = "Online";
                        MessageBox.Show("DataBase update to index: " + remote_version.ToString());
                        return 0;
                    }

                }
            }
            else
            {
                //if local database exist,check if link exist
                if (Properties.Settings.Default.Remote_file == "")
                {
                    DB_status.Text = "Offline";
                    DB_index.Text = current_version.ToString();
                    MessageBox.Show("No valid link for remote DB, Please update link from (DB Location) Button below. You now can work with local database, but it may be not the last update!!");
                    return 0;
                }
                else
                {
                    //link exist let's check if it works
                    string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Properties.Settings.Default.Remote_file;
                    //check if we can access remote DB
                    remote_version = AccessDB.version_num(connectionString);
                    if (remote_version < 0)
                    {
                        DB_status.Text = "Offline";
                        DB_index.Text = current_version.ToString();
                        MessageBox.Show("error in connection to Database, Please update link from (DB Location) button below or check your network connection. You now can work with local database, but it may be not the last update!!");
                        return 0;
                    }
                    else
                    {
                        //here local DB exist and remote DB exist
                        //lets validate
                        if (remote_version > current_version)
                        {
                            //here should replace local database
                            string local_file = Application.StartupPath + "\\MV.accdb";
                            string remote_file = Properties.Settings.Default.Remote_file;
                            try
                            {
                                File.Delete(local_file);
                                File.Copy(remote_file, local_file, true);

                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Error happen while updating local Database, Please make sure you run this application as adminstrator");
                                this.Close();
                            }

                            MessageBox.Show("DataBase update From index: " + current_version.ToString() + " to index: " + remote_version.ToString());
                            DB_index.Text = remote_version.ToString();
                            DB_status.Text = "Online";
                            return 0;
                        }
                        else
                        {
                            DB_index.Text = remote_version.ToString();
                            DB_status.Text = "Online";
                            return 0;
                        }
                    }

                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Standard_Sheets std = new Standard_Sheets();
            this.Visible = false;
            std.ShowDialog();

            this.Visible = true;
        }

        private void protection_relay_Click(object sender, EventArgs e)
        {
            ProtectionRelaysMetering std = new ProtectionRelaysMetering();
            this.Visible = false;
            std.ShowDialog();

            this.Visible = true;
        }

        private void auxulary_menu_Click(object sender, EventArgs e)
        {
            Auxulary_menu std = new Auxulary_menu();
            this.Visible = false;
            std.ShowDialog();

            this.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Circuit_Breaker_menu std = new Circuit_Breaker_menu();
            this.Visible = false;
            std.ShowDialog();

            this.Visible = true;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Metering std = new Metering();
            this.Visible = false;
            std.ShowDialog();

            this.Visible = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


        private void button6_Click_1(object sender, EventArgs e)
        {
            InternalLighting std = new InternalLighting();
            this.Visible = false;
            std.ShowDialog();

            this.Visible = true;
        }

        private void VT_Click(object sender, EventArgs e)
        {
            Voltage_Transformers std = new Voltage_Transformers();
            this.Visible = false;
            std.ShowDialog();

            this.Visible = true;
        }

        private void StdCT_Click(object sender, EventArgs e)
        {
            CTView std = new CTView();
            this.Visible = false;
            std.ShowDialog();

            this.Visible = true;

        }

        private void CompleteSolution_Click(object sender, EventArgs e)
        {
            FlagRelay std = new FlagRelay();
            this.Visible = false;
            std.ShowDialog();

            this.Visible = true;
        }
    }
}
