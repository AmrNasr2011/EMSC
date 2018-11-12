namespace EMSC
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.DB_index = new System.Windows.Forms.Label();
            this.btnversion = new System.Windows.Forms.Button();
            this.DB_status = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CompleteSolution = new System.Windows.Forms.Button();
            this.VT = new System.Windows.Forms.Button();
            this.StdCT = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.protection_relay = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.auxulary_menu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.version = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(272, 642);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 205;
            this.label1.Text = "DB Index:";
            // 
            // DB_index
            // 
            this.DB_index.AutoSize = true;
            this.DB_index.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DB_index.ForeColor = System.Drawing.Color.LawnGreen;
            this.DB_index.Location = new System.Drawing.Point(349, 642);
            this.DB_index.Name = "DB_index";
            this.DB_index.Size = new System.Drawing.Size(14, 13);
            this.DB_index.TabIndex = 206;
            this.DB_index.Text = "1";
            // 
            // btnversion
            // 
            this.btnversion.BackColor = System.Drawing.Color.Maroon;
            this.btnversion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnversion.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnversion.Location = new System.Drawing.Point(393, 639);
            this.btnversion.Name = "btnversion";
            this.btnversion.Size = new System.Drawing.Size(145, 23);
            this.btnversion.TabIndex = 207;
            this.btnversion.Text = "Change DB Location";
            this.btnversion.UseVisualStyleBackColor = false;
            this.btnversion.Click += new System.EventHandler(this.btnversion_Click);
            // 
            // DB_status
            // 
            this.DB_status.AutoSize = true;
            this.DB_status.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DB_status.ForeColor = System.Drawing.Color.LawnGreen;
            this.DB_status.Location = new System.Drawing.Point(201, 642);
            this.DB_status.Name = "DB_status";
            this.DB_status.Size = new System.Drawing.Size(42, 13);
            this.DB_status.TabIndex = 210;
            this.DB_status.Text = "Online";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(130, 641);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 209;
            this.label3.Text = "DB Status:";
            // 
            // CompleteSolution
            // 
            this.CompleteSolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.CompleteSolution.FlatAppearance.BorderSize = 0;
            this.CompleteSolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompleteSolution.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.CompleteSolution.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CompleteSolution.Image = global::EMSC.Properties.Resources.Flag_RelayTallx1_;
            this.CompleteSolution.Location = new System.Drawing.Point(705, 321);
            this.CompleteSolution.Name = "CompleteSolution";
            this.CompleteSolution.Size = new System.Drawing.Size(202, 233);
            this.CompleteSolution.TabIndex = 221;
            this.CompleteSolution.Tag = "ff";
            this.CompleteSolution.Text = "Flag Relays && Lockout Flag Relay";
            this.CompleteSolution.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CompleteSolution.UseVisualStyleBackColor = false;
            this.CompleteSolution.Click += new System.EventHandler(this.CompleteSolution_Click);
            // 
            // VT
            // 
            this.VT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.VT.FlatAppearance.BorderSize = 0;
            this.VT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VT.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.VT.ForeColor = System.Drawing.Color.MidnightBlue;
            this.VT.Image = global::EMSC.Properties.Resources.voltage_trs_view;
            this.VT.Location = new System.Drawing.Point(243, 321);
            this.VT.Name = "VT";
            this.VT.Size = new System.Drawing.Size(202, 233);
            this.VT.TabIndex = 220;
            this.VT.Tag = "wq";
            this.VT.Text = "Indoor Voltage Transformer";
            this.VT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.VT.UseVisualStyleBackColor = false;
            this.VT.Click += new System.EventHandler(this.VT_Click);
            // 
            // StdCT
            // 
            this.StdCT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.StdCT.FlatAppearance.BorderSize = 0;
            this.StdCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StdCT.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.StdCT.ForeColor = System.Drawing.Color.MidnightBlue;
            this.StdCT.Image = global::EMSC.Properties.Resources.CT_View;
            this.StdCT.Location = new System.Drawing.Point(12, 321);
            this.StdCT.Name = "StdCT";
            this.StdCT.Size = new System.Drawing.Size(202, 233);
            this.StdCT.TabIndex = 219;
            this.StdCT.Tag = "asd";
            this.StdCT.Text = "Indoor Current Transformer";
            this.StdCT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.StdCT.UseVisualStyleBackColor = false;
            this.StdCT.Click += new System.EventHandler(this.StdCT_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button6.Image = global::EMSC.Properties.Resources.Lampsx1;
            this.button6.Location = new System.Drawing.Point(474, 321);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(202, 233);
            this.button6.TabIndex = 218;
            this.button6.Tag = "ff";
            this.button6.Text = "Internal Lighting";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Image = global::EMSC.Properties.Resources.Metering_devices2;
            this.button1.Location = new System.Drawing.Point(705, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 233);
            this.button1.TabIndex = 217;
            this.button1.Tag = "ff";
            this.button1.Text = "Metering Devices";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // protection_relay
            // 
            this.protection_relay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.protection_relay.FlatAppearance.BorderSize = 0;
            this.protection_relay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.protection_relay.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.protection_relay.ForeColor = System.Drawing.Color.MidnightBlue;
            this.protection_relay.Image = global::EMSC.Properties.Resources.Protection_Relayx1;
            this.protection_relay.Location = new System.Drawing.Point(243, 68);
            this.protection_relay.Name = "protection_relay";
            this.protection_relay.Size = new System.Drawing.Size(202, 233);
            this.protection_relay.TabIndex = 214;
            this.protection_relay.Tag = "wq";
            this.protection_relay.Text = "\r\nProtection Relay";
            this.protection_relay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.protection_relay.UseVisualStyleBackColor = false;
            this.protection_relay.Click += new System.EventHandler(this.protection_relay_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button3.Image = global::EMSC.Properties.Resources.Circuit_breakers;
            this.button3.Location = new System.Drawing.Point(12, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 233);
            this.button3.TabIndex = 213;
            this.button3.Tag = "asd";
            this.button3.Text = "\r\nCircuit Breaker";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // auxulary_menu
            // 
            this.auxulary_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.auxulary_menu.FlatAppearance.BorderSize = 0;
            this.auxulary_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.auxulary_menu.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.auxulary_menu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.auxulary_menu.Image = global::EMSC.Properties.Resources.Control_Componentsx1;
            this.auxulary_menu.Location = new System.Drawing.Point(474, 68);
            this.auxulary_menu.Name = "auxulary_menu";
            this.auxulary_menu.Size = new System.Drawing.Size(202, 233);
            this.auxulary_menu.TabIndex = 212;
            this.auxulary_menu.Tag = "ff";
            this.auxulary_menu.Text = "\r\nControl Components";
            this.auxulary_menu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.auxulary_menu.UseVisualStyleBackColor = false;
            this.auxulary_menu.Click += new System.EventHandler(this.auxulary_menu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::EMSC.Properties.Resources.Picture2;
            this.pictureBox1.Location = new System.Drawing.Point(612, 625);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 204;
            this.pictureBox1.TabStop = false;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(785, 22);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(42, 13);
            this.version.TabIndex = 222;
            this.version.Text = "Version";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(205)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(920, 687);
            this.Controls.Add(this.version);
            this.Controls.Add(this.CompleteSolution);
            this.Controls.Add(this.VT);
            this.Controls.Add(this.StdCT);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.protection_relay);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.auxulary_menu);
            this.Controls.Add(this.DB_status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnversion);
            this.Controls.Add(this.DB_index);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DB_index;
        private System.Windows.Forms.Button btnversion;
        private System.Windows.Forms.Label DB_status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button auxulary_menu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button protection_relay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CompleteSolution;
        private System.Windows.Forms.Button VT;
        private System.Windows.Forms.Button StdCT;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label version;
    }
}

