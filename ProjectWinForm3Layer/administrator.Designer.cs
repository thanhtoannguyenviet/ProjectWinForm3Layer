namespace ProjectWinForm3Layer
{
    partial class administrator
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
            this.label3 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.showusername = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sslide1 = new System.Windows.Forms.Panel();
            this.sslide2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnbuylogs = new System.Windows.Forms.Button();
            this.btnEmploy = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnmsalelog = new System.Windows.Forms.Button();
            this.btnusersmana = new System.Windows.Forms.Button();
            this.btnproducts = new System.Windows.Forms.Button();
            this.btndashboard = new System.Windows.Forms.Button();
            this.myDashBoard1 = new ProjectWinForm3Layer.MyDashBoard();
            this.myUserControl1 = new ProjectWinForm3Layer.MyUserControl();
            this.myWareHouse1 = new ProjectWinForm3Layer.MyWareHouse();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(42, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Type";
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(9, 586);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(24, 28);
            this.button11.TabIndex = 10;
            this.button11.Text = "?";
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // showusername
            // 
            this.showusername.AutoSize = true;
            this.showusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showusername.ForeColor = System.Drawing.Color.White;
            this.showusername.Location = new System.Drawing.Point(42, 129);
            this.showusername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.showusername.Name = "showusername";
            this.showusername.Size = new System.Drawing.Size(105, 24);
            this.showusername.TabIndex = 5;
            this.showusername.Text = "Username";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 181);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(165, 1);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // sslide1
            // 
            this.sslide1.BackColor = System.Drawing.Color.DarkGreen;
            this.sslide1.Location = new System.Drawing.Point(0, 187);
            this.sslide1.Margin = new System.Windows.Forms.Padding(2);
            this.sslide1.Name = "sslide1";
            this.sslide1.Size = new System.Drawing.Size(8, 43);
            this.sslide1.TabIndex = 3;
            // 
            // sslide2
            // 
            this.sslide2.BackColor = System.Drawing.Color.DarkGreen;
            this.sslide2.Location = new System.Drawing.Point(190, 187);
            this.sslide2.Margin = new System.Windows.Forms.Padding(2);
            this.sslide2.Name = "sslide2";
            this.sslide2.Size = new System.Drawing.Size(8, 43);
            this.sslide2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnbuylogs);
            this.panel1.Controls.Add(this.btnEmploy);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.showusername);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.sslide2);
            this.panel1.Controls.Add(this.sslide1);
            this.panel1.Controls.Add(this.btnmsalelog);
            this.panel1.Controls.Add(this.btnusersmana);
            this.panel1.Controls.Add(this.btnproducts);
            this.panel1.Controls.Add(this.btndashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 458);
            this.panel1.TabIndex = 15;
            // 
            // btnbuylogs
            // 
            this.btnbuylogs.FlatAppearance.BorderSize = 0;
            this.btnbuylogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuylogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuylogs.ForeColor = System.Drawing.Color.White;
            this.btnbuylogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuylogs.Location = new System.Drawing.Point(12, 332);
            this.btnbuylogs.Margin = new System.Windows.Forms.Padding(2);
            this.btnbuylogs.Name = "btnbuylogs";
            this.btnbuylogs.Size = new System.Drawing.Size(174, 43);
            this.btnbuylogs.TabIndex = 19;
            this.btnbuylogs.Text = "         Thu Ngân";
            this.btnbuylogs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuylogs.UseVisualStyleBackColor = true;
            this.btnbuylogs.Click += new System.EventHandler(this.btnmcus_Click_1);
            // 
            // btnEmploy
            // 
            this.btnEmploy.FlatAppearance.BorderSize = 0;
            this.btnEmploy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmploy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmploy.ForeColor = System.Drawing.Color.White;
            this.btnEmploy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmploy.Location = new System.Drawing.Point(12, 234);
            this.btnEmploy.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmploy.Name = "btnEmploy";
            this.btnEmploy.Size = new System.Drawing.Size(174, 43);
            this.btnEmploy.TabIndex = 1;
            this.btnEmploy.Text = "           Nhân Viên";
            this.btnEmploy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmploy.UseVisualStyleBackColor = true;
            this.btnEmploy.Click += new System.EventHandler(this.btnmcus_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(46, 21);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btnmsalelog
            // 
            this.btnmsalelog.FlatAppearance.BorderSize = 0;
            this.btnmsalelog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmsalelog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmsalelog.ForeColor = System.Drawing.Color.White;
            this.btnmsalelog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmsalelog.Location = new System.Drawing.Point(12, 522);
            this.btnmsalelog.Margin = new System.Windows.Forms.Padding(2);
            this.btnmsalelog.Name = "btnmsalelog";
            this.btnmsalelog.Size = new System.Drawing.Size(174, 43);
            this.btnmsalelog.TabIndex = 3;
            this.btnmsalelog.Text = "          M-SaleLog";
            this.btnmsalelog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmsalelog.UseVisualStyleBackColor = true;
            // 
            // btnusersmana
            // 
            this.btnusersmana.FlatAppearance.BorderSize = 0;
            this.btnusersmana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnusersmana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusersmana.ForeColor = System.Drawing.Color.White;
            this.btnusersmana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnusersmana.Location = new System.Drawing.Point(12, 474);
            this.btnusersmana.Margin = new System.Windows.Forms.Padding(2);
            this.btnusersmana.Name = "btnusersmana";
            this.btnusersmana.Size = new System.Drawing.Size(174, 43);
            this.btnusersmana.TabIndex = 2;
            this.btnusersmana.Text = "           M-Users";
            this.btnusersmana.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnusersmana.UseVisualStyleBackColor = true;
            // 
            // btnproducts
            // 
            this.btnproducts.FlatAppearance.BorderSize = 0;
            this.btnproducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproducts.ForeColor = System.Drawing.Color.White;
            this.btnproducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproducts.Location = new System.Drawing.Point(12, 283);
            this.btnproducts.Margin = new System.Windows.Forms.Padding(2);
            this.btnproducts.Name = "btnproducts";
            this.btnproducts.Size = new System.Drawing.Size(174, 43);
            this.btnproducts.TabIndex = 1;
            this.btnproducts.Text = "          Kho SP";
            this.btnproducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnproducts.UseVisualStyleBackColor = true;
            this.btnproducts.Click += new System.EventHandler(this.btnmcus_Click_1);
            // 
            // btndashboard
            // 
            this.btndashboard.FlatAppearance.BorderSize = 0;
            this.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.ForeColor = System.Drawing.Color.White;
            this.btndashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashboard.Location = new System.Drawing.Point(12, 187);
            this.btndashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(174, 43);
            this.btndashboard.TabIndex = 0;
            this.btndashboard.Text = "           Trang chủ";
            this.btndashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndashboard.UseVisualStyleBackColor = true;
            this.btndashboard.Click += new System.EventHandler(this.btnmcus_Click_1);
            // 
            // myDashBoard1
            // 
            this.myDashBoard1.Location = new System.Drawing.Point(203, 3);
            this.myDashBoard1.Name = "myDashBoard1";
            this.myDashBoard1.Size = new System.Drawing.Size(825, 455);
            this.myDashBoard1.TabIndex = 17;
            // 
            // myUserControl1
            // 
            this.myUserControl1.Location = new System.Drawing.Point(203, 0);
            this.myUserControl1.Name = "myUserControl1";
            this.myUserControl1.Size = new System.Drawing.Size(825, 455);
            this.myUserControl1.TabIndex = 16;
            // 
            // myWareHouse1
            // 
            this.myWareHouse1.Location = new System.Drawing.Point(203, 2);
            this.myWareHouse1.Name = "myWareHouse1";
            this.myWareHouse1.Size = new System.Drawing.Size(825, 455);
            this.myWareHouse1.TabIndex = 15;
            // 
            // administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1019, 458);
            this.Controls.Add(this.myDashBoard1);
            this.Controls.Add(this.myUserControl1);
            this.Controls.Add(this.myWareHouse1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label showusername;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel sslide1;
        private System.Windows.Forms.Panel sslide2;
        private System.Windows.Forms.Button btnmsalelog;
        private System.Windows.Forms.Button btnusersmana;
        private System.Windows.Forms.Button btnproducts;
        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEmploy;
        private MyUserControl myUserControl1;
        private MyDashBoard myDashBoard1;
        private MyWareHouse myWareHouse1;
        private System.Windows.Forms.Button btnbuylogs;
    }
}