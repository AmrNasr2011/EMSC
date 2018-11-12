namespace EMSC
{
    partial class Circuit_Breaker_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Circuit_Breaker_menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sf1_sf2 = new System.Windows.Forms.Button();
            this.HVX = new System.Windows.Forms.Button();
            this.LF123 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::EMSC.Properties.Resources.Picture2;
            this.pictureBox1.Location = new System.Drawing.Point(630, 400);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 212;
            this.pictureBox1.TabStop = false;
            // 
            // sf1_sf2
            // 
            this.sf1_sf2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.sf1_sf2.FlatAppearance.BorderSize = 0;
            this.sf1_sf2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sf1_sf2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.sf1_sf2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.sf1_sf2.Image = global::EMSC.Properties.Resources.LLLLFFF;
            this.sf1_sf2.Location = new System.Drawing.Point(642, 82);
            this.sf1_sf2.Name = "sf1_sf2";
            this.sf1_sf2.Size = new System.Drawing.Size(250, 250);
            this.sf1_sf2.TabIndex = 211;
            this.sf1_sf2.Tag = "3";
            this.sf1_sf2.Text = "SF1 && SF2";
            this.sf1_sf2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sf1_sf2.UseVisualStyleBackColor = false;
            this.sf1_sf2.Click += new System.EventHandler(this.sf1_sf2_Click);
            // 
            // HVX
            // 
            this.HVX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.HVX.FlatAppearance.BorderSize = 0;
            this.HVX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HVX.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HVX.ForeColor = System.Drawing.Color.MidnightBlue;
            this.HVX.Image = global::EMSC.Properties.Resources.Picture21;
            this.HVX.Location = new System.Drawing.Point(351, 82);
            this.HVX.Name = "HVX";
            this.HVX.Size = new System.Drawing.Size(250, 250);
            this.HVX.TabIndex = 210;
            this.HVX.Tag = "2";
            this.HVX.Text = "HVx";
            this.HVX.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HVX.UseVisualStyleBackColor = false;
            this.HVX.Click += new System.EventHandler(this.HVX_Click);
            // 
            // LF123
            // 
            this.LF123.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.LF123.FlatAppearance.BorderSize = 0;
            this.LF123.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LF123.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LF123.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LF123.Image = global::EMSC.Properties.Resources.Pic1;
            this.LF123.Location = new System.Drawing.Point(60, 82);
            this.LF123.Name = "LF123";
            this.LF123.Size = new System.Drawing.Size(250, 250);
            this.LF123.TabIndex = 209;
            this.LF123.Tag = "1";
            this.LF123.Text = "LF123";
            this.LF123.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LF123.UseVisualStyleBackColor = false;
            this.LF123.Click += new System.EventHandler(this.LF123_Click);
            // 
            // Circuit_Breaker_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(205)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(924, 462);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sf1_sf2);
            this.Controls.Add(this.HVX);
            this.Controls.Add(this.LF123);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Circuit_Breaker_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Circuit_Breaker_menu";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Circuit_Breaker_menu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HVX;
        private System.Windows.Forms.Button LF123;
        private System.Windows.Forms.Button sf1_sf2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}