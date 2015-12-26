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
            this.Descr1 = new System.Windows.Forms.Label();
            this.Descr2 = new System.Windows.Forms.Label();
            this.Descr3 = new System.Windows.Forms.Label();
            this.Descr5 = new System.Windows.Forms.Label();
            this.Descr7 = new System.Windows.Forms.Label();
            this.Descr6 = new System.Windows.Forms.Label();
            this.Descr9 = new System.Windows.Forms.Label();
            this.Descr8 = new System.Windows.Forms.Label();
            this.Descr10 = new System.Windows.Forms.Label();
            this.Descr4 = new System.Windows.Forms.Label();
            this.Descr11 = new System.Windows.Forms.Label();
            this.TopLabel = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelS = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.labelW = new System.Windows.Forms.Label();
            this.botLabel1 = new System.Windows.Forms.Label();
            this.botLabel2 = new System.Windows.Forms.Label();
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
            this.panel1.Location = new System.Drawing.Point(568, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 302);
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
            this.labelPassngrs.Size = new System.Drawing.Size(112, 13);
            this.labelPassngrs.TabIndex = 1;
            this.labelPassngrs.Text = "Список пассажиров:";
            // 
            // labelTaxi
            // 
            this.labelTaxi.AutoSize = true;
            this.labelTaxi.Location = new System.Drawing.Point(4, 27);
            this.labelTaxi.Name = "labelTaxi";
            this.labelTaxi.Size = new System.Drawing.Size(79, 13);
            this.labelTaxi.TabIndex = 0;
            this.labelTaxi.Text = "Список такси:";
            // 
            // DrawMapButton
            // 
            this.DrawMapButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawMapButton.Location = new System.Drawing.Point(764, 414);
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
            this.pictureBox1.Location = new System.Drawing.Point(13, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(549, 523);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // Nexybutt
            // 
            this.Nexybutt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Nexybutt.Location = new System.Drawing.Point(764, 385);
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
            this.AddPassBtn.Location = new System.Drawing.Point(744, 486);
            this.AddPassBtn.Name = "AddPassBtn";
            this.AddPassBtn.Size = new System.Drawing.Size(95, 37);
            this.AddPassBtn.TabIndex = 5;
            this.AddPassBtn.Text = "Добавить пассажира";
            this.AddPassBtn.UseVisualStyleBackColor = true;
            this.AddPassBtn.Click += new System.EventHandler(this.AddPassBtn_Click);
            // 
            // AddTaxiBtn
            // 
            this.AddTaxiBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTaxiBtn.Location = new System.Drawing.Point(744, 443);
            this.AddTaxiBtn.Name = "AddTaxiBtn";
            this.AddTaxiBtn.Size = new System.Drawing.Size(95, 37);
            this.AddTaxiBtn.TabIndex = 6;
            this.AddTaxiBtn.Text = "Добавить такси";
            this.AddTaxiBtn.UseVisualStyleBackColor = true;
            this.AddTaxiBtn.Click += new System.EventHandler(this.AddTaxiBtn_Click);
            // 
            // AddConnBtn
            // 
            this.AddConnBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddConnBtn.Location = new System.Drawing.Point(744, 529);
            this.AddConnBtn.Name = "AddConnBtn";
            this.AddConnBtn.Size = new System.Drawing.Size(95, 37);
            this.AddConnBtn.TabIndex = 7;
            this.AddConnBtn.Text = "Добавить связь";
            this.AddConnBtn.UseVisualStyleBackColor = true;
            this.AddConnBtn.Click += new System.EventHandler(this.AddConnBtn_Click);
            // 
            // Descr1
            // 
            this.Descr1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Descr1.AutoSize = true;
            this.Descr1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Descr1.Location = new System.Drawing.Point(648, 366);
            this.Descr1.Name = "Descr1";
            this.Descr1.Size = new System.Drawing.Size(110, 13);
            this.Descr1.TabIndex = 8;
            this.Descr1.Text = "Назначения кнопок:";
            // 
            // Descr2
            // 
            this.Descr2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Descr2.AutoSize = true;
            this.Descr2.Location = new System.Drawing.Point(592, 389);
            this.Descr2.Name = "Descr2";
            this.Descr2.Size = new System.Drawing.Size(166, 13);
            this.Descr2.TabIndex = 9;
            this.Descr2.Text = "Переход к следующему шагу ->";
            // 
            // Descr3
            // 
            this.Descr3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Descr3.AutoSize = true;
            this.Descr3.Location = new System.Drawing.Point(637, 418);
            this.Descr3.Name = "Descr3";
            this.Descr3.Size = new System.Drawing.Size(121, 13);
            this.Descr3.TabIndex = 10;
            this.Descr3.Text = "Перерисовка карты ->";
            // 
            // Descr5
            // 
            this.Descr5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Descr5.AutoSize = true;
            this.Descr5.Location = new System.Drawing.Point(587, 493);
            this.Descr5.Name = "Descr5";
            this.Descr5.Size = new System.Drawing.Size(138, 13);
            this.Descr5.TabIndex = 11;
            this.Descr5.Text = "Добавление пассажира и";
            // 
            // Descr7
            // 
            this.Descr7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Descr7.AutoSize = true;
            this.Descr7.BackColor = System.Drawing.Color.Transparent;
            this.Descr7.Location = new System.Drawing.Point(605, 506);
            this.Descr7.Name = "Descr7";
            this.Descr7.Size = new System.Drawing.Size(120, 13);
            this.Descr7.TabIndex = 12;
            this.Descr7.Text = "места его назначения";
            // 
            // Descr6
            // 
            this.Descr6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Descr6.AutoSize = true;
            this.Descr6.Location = new System.Drawing.Point(726, 498);
            this.Descr6.Name = "Descr6";
            this.Descr6.Size = new System.Drawing.Size(16, 13);
            this.Descr6.TabIndex = 13;
            this.Descr6.Text = "->";
            // 
            // Descr9
            // 
            this.Descr9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Descr9.AutoSize = true;
            this.Descr9.Location = new System.Drawing.Point(724, 541);
            this.Descr9.Name = "Descr9";
            this.Descr9.Size = new System.Drawing.Size(16, 13);
            this.Descr9.TabIndex = 16;
            this.Descr9.Text = "->";
            // 
            // Descr8
            // 
            this.Descr8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Descr8.AutoSize = true;
            this.Descr8.Location = new System.Drawing.Point(613, 535);
            this.Descr8.Name = "Descr8";
            this.Descr8.Size = new System.Drawing.Size(112, 13);
            this.Descr8.TabIndex = 14;
            this.Descr8.Text = "Добавление связи и";
            // 
            // Descr10
            // 
            this.Descr10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Descr10.AutoSize = true;
            this.Descr10.BackColor = System.Drawing.Color.Transparent;
            this.Descr10.Location = new System.Drawing.Point(605, 548);
            this.Descr10.Name = "Descr10";
            this.Descr10.Size = new System.Drawing.Size(120, 13);
            this.Descr10.TabIndex = 15;
            this.Descr10.Text = "места его назначения";
            // 
            // Descr4
            // 
            this.Descr4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Descr4.AutoSize = true;
            this.Descr4.Location = new System.Drawing.Point(628, 455);
            this.Descr4.Name = "Descr4";
            this.Descr4.Size = new System.Drawing.Size(114, 13);
            this.Descr4.TabIndex = 17;
            this.Descr4.Text = "Добавление такси ->";
            // 
            // Descr11
            // 
            this.Descr11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Descr11.AutoSize = true;
            this.Descr11.Location = new System.Drawing.Point(568, 522);
            this.Descr11.Name = "Descr11";
            this.Descr11.Size = new System.Drawing.Size(52, 13);
            this.Descr11.TabIndex = 18;
            this.Descr11.Text = "(2 клика)";
            // 
            // TopLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.Location = new System.Drawing.Point(12, 9);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(805, 13);
            this.TopLabel.TabIndex = 5;
            this.TopLabel.Text = "Для начала работы воспользуйтесь кнопками внизу окна или нажмите на любую точку н" +
    "а карте для получения информации о находящихся в ней объектах.";
            // 
            // labelA
            // 
            this.labelA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(835, 455);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(20, 13);
            this.labelA.TabIndex = 19;
            this.labelA.Text = "(A)";
            // 
            // labelS
            // 
            this.labelS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelS.AutoSize = true;
            this.labelS.Location = new System.Drawing.Point(835, 498);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(20, 13);
            this.labelS.TabIndex = 20;
            this.labelS.Text = "(S)";
            // 
            // labelD
            // 
            this.labelD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(835, 541);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(21, 13);
            this.labelD.TabIndex = 21;
            this.labelD.Text = "(D)";
            // 
            // labelW
            // 
            this.labelW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelW.AutoSize = true;
            this.labelW.Location = new System.Drawing.Point(835, 390);
            this.labelW.Name = "labelW";
            this.labelW.Size = new System.Drawing.Size(24, 13);
            this.labelW.TabIndex = 22;
            this.labelW.Text = "(W)";
            // 
            // botLabel1
            // 
            this.botLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botLabel1.AutoSize = true;
            this.botLabel1.Location = new System.Drawing.Point(12, 557);
            this.botLabel1.Name = "botLabel1";
            this.botLabel1.Size = new System.Drawing.Size(386, 13);
            this.botLabel1.TabIndex = 23;
            this.botLabel1.Text = "Легенда: черные круги и соединяющие их линии - пункты карты и дороги. ";
            // 
            // botLabel2
            // 
            this.botLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botLabel2.AutoSize = true;
            this.botLabel2.Location = new System.Drawing.Point(12, 570);
            this.botLabel2.Name = "botLabel2";
            this.botLabel2.Size = new System.Drawing.Size(675, 13);
            this.botLabel2.TabIndex = 24;
            this.botLabel2.Text = "Красные квадраты - такси. Зеленые и оранжевые квадраты - пассажиры, ожидающие так" +
    "си, и закончившие путь соответственно.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(856, 588);
            this.Controls.Add(this.botLabel2);
            this.Controls.Add(this.botLabel1);
            this.Controls.Add(this.TopLabel);
            this.Controls.Add(this.Descr4);
            this.Controls.Add(this.Descr9);
            this.Controls.Add(this.Descr8);
            this.Controls.Add(this.Descr10);
            this.Controls.Add(this.Descr6);
            this.Controls.Add(this.Descr5);
            this.Controls.Add(this.Descr2);
            this.Controls.Add(this.Descr1);
            this.Controls.Add(this.AddConnBtn);
            this.Controls.Add(this.AddTaxiBtn);
            this.Controls.Add(this.AddPassBtn);
            this.Controls.Add(this.Nexybutt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DrawMapButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Descr7);
            this.Controls.Add(this.Descr3);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelS);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelW);
            this.Controls.Add(this.Descr11);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(872, 608);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система обеспечения такси";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label Descr1;
        private System.Windows.Forms.Label Descr2;
        private System.Windows.Forms.Label Descr3;
        private System.Windows.Forms.Label Descr5;
        private System.Windows.Forms.Label Descr7;
        private System.Windows.Forms.Label Descr6;
        private System.Windows.Forms.Label Descr9;
        private System.Windows.Forms.Label Descr8;
        private System.Windows.Forms.Label Descr10;
        private System.Windows.Forms.Label Descr4;
        private System.Windows.Forms.Label Descr11;
        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelW;
        private System.Windows.Forms.Label botLabel1;
        private System.Windows.Forms.Label botLabel2;
    }
}

