namespace EMSC
{
    partial class EMSC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMSC));
            this.start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.ForestGreen;
            this.start.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.start.FlatAppearance.BorderSize = 2;
            this.start.Font = new System.Drawing.Font("Technic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.start.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.start.Location = new System.Drawing.Point(545, 77);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(191, 60);
            this.start.TabIndex = 1;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // EMSC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::EMSC.Properties.Resources.MVRef1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(924, 691);
            this.Controls.Add(this.start);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1, 1);
            this.MaximizeBox = false;
            this.Name = "EMSC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "EMSC";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button start;
    }
}