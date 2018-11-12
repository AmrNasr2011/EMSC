namespace EMSC
{
    partial class CTView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CTView));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Other = new System.Windows.Forms.Button();
            this.MCSET123 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Image = global::EMSC.Properties.Resources.LPCTx1;
            this.button1.Location = new System.Drawing.Point(598, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 250);
            this.button1.TabIndex = 367;
            this.button1.Text = "\r\nLPCT";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::EMSC.Properties.Resources.Picture2;
            this.pictureBox1.Location = new System.Drawing.Point(566, 297);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 366;
            this.pictureBox1.TabStop = false;
            // 
            // Other
            // 
            this.Other.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.Other.FlatAppearance.BorderSize = 0;
            this.Other.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Other.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.Other.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Other.Image = global::EMSC.Properties.Resources.CT_MCSET4;
            this.Other.Location = new System.Drawing.Point(310, 29);
            this.Other.Name = "Other";
            this.Other.Size = new System.Drawing.Size(250, 250);
            this.Other.TabIndex = 1;
            this.Other.Text = "\r\nMCSET4 && SM6";
            this.Other.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Other.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Other.UseVisualStyleBackColor = false;
            this.Other.Click += new System.EventHandler(this.Other_Click);
            // 
            // MCSET123
            // 
            this.MCSET123.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.MCSET123.FlatAppearance.BorderSize = 0;
            this.MCSET123.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MCSET123.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.MCSET123.ForeColor = System.Drawing.Color.MidnightBlue;
            this.MCSET123.Image = global::EMSC.Properties.Resources.CT_MCSET123;
            this.MCSET123.Location = new System.Drawing.Point(22, 29);
            this.MCSET123.Name = "MCSET123";
            this.MCSET123.Size = new System.Drawing.Size(250, 250);
            this.MCSET123.TabIndex = 0;
            this.MCSET123.Text = "\r\nMCEST 1,2,3 && PIX ";
            this.MCSET123.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MCSET123.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MCSET123.UseVisualStyleBackColor = false;
            this.MCSET123.Click += new System.EventHandler(this.MCSET123_Click);
            // 
            // CTView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(205)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(860, 359);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Other);
            this.Controls.Add(this.MCSET123);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CTView";
            this.Text = "Indoor MV Current Transformers ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MCSET123;
        private System.Windows.Forms.Button Other;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}