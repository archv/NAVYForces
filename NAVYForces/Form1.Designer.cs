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
            this.SelectedPtLabel = new System.Windows.Forms.Label();
            this.listBoxPassngrs = new System.Windows.Forms.ListBox();
            this.listBoxTaxi = new System.Windows.Forms.ListBox();
            this.labelPassngrs = new System.Windows.Forms.Label();
            this.labelTaxi = new System.Windows.Forms.Label();
            this.DrawMapButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Nexybutt = new System.Windows.Forms.Button();
            this.AddPassBtn = new System.Windows.Forms.Button();
            this.AddTaxiBtn = new System.Windows.Forms.Button();
            this.AddConnBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.SelectedPtLabel);
            this.panel1.Controls.Add(this.listBoxPassngrs);
            this.panel1.Controls.Add(this.listBoxTaxi);
            this.panel1.Controls.Add(this.labelPassngrs);
            this.panel1.Controls.Add(this.labelTaxi);
            this.panel1.Location = new System.Drawing.Point(562, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 320);
            this.panel1.TabIndex = 0;
            // 
            // SelectedPtLabel
            // 
            this.SelectedPtLabel.AutoSize = true;
            this.SelectedPtLabel.Location = new System.Drawing.Point(9, 8);
            this.SelectedPtLabel.Name = "SelectedPtLabel";
            this.SelectedPtLabel.Size = new System.Drawing.Size(99, 13);
            this.SelectedPtLabel.TabIndex = 4;
            this.SelectedPtLabel.Text = "Точка не выбрана";
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
            this.DrawMapButton.Location = new System.Drawing.Point(757, 399);
            this.DrawMapButton.Name = "DrawMapButton";
            this.DrawMapButton.Size = new System.Drawing.Size(75, 23);
            this.DrawMapButton.TabIndex = 1;
            this.DrawMapButton.Text = "RedrawMap";
            this.DrawMapButton.UseVisualStyleBackColor = true;
            this.DrawMapButton.Click += new System.EventHandler(this.DrawMapButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 496);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // Nexybutt
            // 
            this.Nexybutt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Nexybutt.Location = new System.Drawing.Point(757, 370);
            this.Nexybutt.Name = "Nexybutt";
            this.Nexybutt.Size = new System.Drawing.Size(75, 23);
            this.Nexybutt.TabIndex = 4;
            this.Nexybutt.Text = "Next";
            this.Nexybutt.UseVisualStyleBackColor = true;
            this.Nexybutt.Click += new System.EventHandler(this.Nexybutt_Click);
            // 
            // AddPassBtn
            // 
            this.AddPassBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPassBtn.Location = new System.Drawing.Point(737, 428);
            this.AddPassBtn.Name = "AddPassBtn";
            this.AddPassBtn.Size = new System.Drawing.Size(95, 23);
            this.AddPassBtn.TabIndex = 5;
            this.AddPassBtn.Text = "Add passenger";
            this.AddPassBtn.UseVisualStyleBackColor = true;
            this.AddPassBtn.Click += new System.EventHandler(this.AddPassBtn_Click);
            // 
            // AddTaxiBtn
            // 
            this.AddTaxiBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTaxiBtn.Location = new System.Drawing.Point(737, 457);
            this.AddTaxiBtn.Name = "AddTaxiBtn";
            this.AddTaxiBtn.Size = new System.Drawing.Size(95, 23);
            this.AddTaxiBtn.TabIndex = 6;
            this.AddTaxiBtn.Text = "Add taxi";
            this.AddTaxiBtn.UseVisualStyleBackColor = true;
            this.AddTaxiBtn.Click += new System.EventHandler(this.AddTaxiBtn_Click);
            // 
            // AddConnBtn
            // 
            this.AddConnBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddConnBtn.Location = new System.Drawing.Point(737, 486);
            this.AddConnBtn.Name = "AddConnBtn";
            this.AddConnBtn.Size = new System.Drawing.Size(95, 23);
            this.AddConnBtn.TabIndex = 7;
            this.AddConnBtn.Text = "Add connection";
            this.AddConnBtn.UseVisualStyleBackColor = true;
            this.AddConnBtn.Click += new System.EventHandler(this.AddConnBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(844, 521);
            this.Controls.Add(this.AddConnBtn);
            this.Controls.Add(this.AddTaxiBtn);
            this.Controls.Add(this.AddPassBtn);
            this.Controls.Add(this.Nexybutt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DrawMapButton);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система обеспечения такси";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ClientSizeChanged += new System.EventHandler(this.Form1_ClientSizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxPassngrs;
        private System.Windows.Forms.ListBox listBoxTaxi;
        private System.Windows.Forms.Label labelPassngrs;
        private System.Windows.Forms.Label labelTaxi;
        private System.Windows.Forms.Button DrawMapButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Nexybutt;
        private System.Windows.Forms.Button AddPassBtn;
        private System.Windows.Forms.Label SelectedPtLabel;
        private System.Windows.Forms.Button AddTaxiBtn;
        private System.Windows.Forms.Button AddConnBtn;
    }
}

