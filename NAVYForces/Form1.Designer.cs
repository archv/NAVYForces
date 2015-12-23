namespace NAVYForces
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxPassngrs = new System.Windows.Forms.ListBox();
            this.listBoxTaxi = new System.Windows.Forms.ListBox();
            this.labelPassngrs = new System.Windows.Forms.Label();
            this.labelTaxi = new System.Windows.Forms.Label();
            this.DrawMapButton = new System.Windows.Forms.Button();
            this.ShowPanelButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.listBoxPassngrs);
            this.panel1.Controls.Add(this.listBoxTaxi);
            this.panel1.Controls.Add(this.labelPassngrs);
            this.panel1.Controls.Add(this.labelTaxi);
            this.panel1.Location = new System.Drawing.Point(513, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 320);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // listBoxPassngrs
            // 
            this.listBoxPassngrs.FormattingEnabled = true;
            this.listBoxPassngrs.Location = new System.Drawing.Point(143, 43);
            this.listBoxPassngrs.Name = "listBoxPassngrs";
            this.listBoxPassngrs.Size = new System.Drawing.Size(120, 251);
            this.listBoxPassngrs.TabIndex = 3;
            // 
            // listBoxTaxi
            // 
            this.listBoxTaxi.FormattingEnabled = true;
            this.listBoxTaxi.Location = new System.Drawing.Point(7, 43);
            this.listBoxTaxi.Name = "listBoxTaxi";
            this.listBoxTaxi.Size = new System.Drawing.Size(120, 251);
            this.listBoxTaxi.TabIndex = 2;
            // 
            // labelPassngrs
            // 
            this.labelPassngrs.AutoSize = true;
            this.labelPassngrs.Location = new System.Drawing.Point(140, 27);
            this.labelPassngrs.Name = "labelPassngrs";
            this.labelPassngrs.Size = new System.Drawing.Size(62, 13);
            this.labelPassngrs.TabIndex = 1;
            this.labelPassngrs.Text = "Passengers";
            // 
            // labelTaxi
            // 
            this.labelTaxi.AutoSize = true;
            this.labelTaxi.Location = new System.Drawing.Point(4, 27);
            this.labelTaxi.Name = "labelTaxi";
            this.labelTaxi.Size = new System.Drawing.Size(27, 13);
            this.labelTaxi.TabIndex = 0;
            this.labelTaxi.Text = "Taxi";
            // 
            // DrawMapButton
            // 
            this.DrawMapButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawMapButton.Location = new System.Drawing.Point(619, 373);
            this.DrawMapButton.Name = "DrawMapButton";
            this.DrawMapButton.Size = new System.Drawing.Size(75, 23);
            this.DrawMapButton.TabIndex = 1;
            this.DrawMapButton.Text = "DrawMap";
            this.DrawMapButton.UseVisualStyleBackColor = true;
            this.DrawMapButton.Click += new System.EventHandler(this.DrawMapButton_Click);
            // 
            // ShowPanelButton
            // 
            this.ShowPanelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowPanelButton.Location = new System.Drawing.Point(708, 373);
            this.ShowPanelButton.Name = "ShowPanelButton";
            this.ShowPanelButton.Size = new System.Drawing.Size(75, 23);
            this.ShowPanelButton.TabIndex = 2;
            this.ShowPanelButton.Text = "ShowPanel";
            this.ShowPanelButton.UseVisualStyleBackColor = true;
            this.ShowPanelButton.Click += new System.EventHandler(this.ShowPanelButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(795, 408);
            this.Controls.Add(this.ShowPanelButton);
            this.Controls.Add(this.DrawMapButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxPassngrs;
        private System.Windows.Forms.ListBox listBoxTaxi;
        private System.Windows.Forms.Label labelPassngrs;
        private System.Windows.Forms.Label labelTaxi;
        private System.Windows.Forms.Button DrawMapButton;
        private System.Windows.Forms.Button ShowPanelButton;

    }
}

