namespace SummativeUnit1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.capriLabel = new System.Windows.Forms.Label();
            this.date1Label = new System.Windows.Forms.Label();
            this.date2Label = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // capriLabel
            // 
            this.capriLabel.AutoSize = true;
            this.capriLabel.BackColor = System.Drawing.Color.Transparent;
            this.capriLabel.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capriLabel.ForeColor = System.Drawing.Color.White;
            this.capriLabel.Location = new System.Drawing.Point(197, 367);
            this.capriLabel.Name = "capriLabel";
            this.capriLabel.Size = new System.Drawing.Size(256, 50);
            this.capriLabel.TabIndex = 0;
            this.capriLabel.Text = "CAPRICORN";
            this.capriLabel.Click += new System.EventHandler(this.titlelable_Click);
            // 
            // date1Label
            // 
            this.date1Label.AutoSize = true;
            this.date1Label.BackColor = System.Drawing.Color.Transparent;
            this.date1Label.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1Label.ForeColor = System.Drawing.Color.White;
            this.date1Label.Location = new System.Drawing.Point(12, 204);
            this.date1Label.Name = "date1Label";
            this.date1Label.Size = new System.Drawing.Size(134, 26);
            this.date1Label.TabIndex = 1;
            this.date1Label.Text = "December 22 ";
            // 
            // date2Label
            // 
            this.date2Label.AutoSize = true;
            this.date2Label.BackColor = System.Drawing.Color.Transparent;
            this.date2Label.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2Label.ForeColor = System.Drawing.Color.White;
            this.date2Label.Location = new System.Drawing.Point(515, 204);
            this.date2Label.Name = "date2Label";
            this.date2Label.Size = new System.Drawing.Size(107, 26);
            this.date2Label.TabIndex = 2;
            this.date2Label.Text = "January 19";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(12, 33);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(155, 26);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "By Lauren Steel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 426);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.date2Label);
            this.Controls.Add(this.date1Label);
            this.Controls.Add(this.capriLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Capricorn Card";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Click1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label capriLabel;
        private System.Windows.Forms.Label date1Label;
        private System.Windows.Forms.Label date2Label;
        private System.Windows.Forms.Label nameLabel;
    }
}

