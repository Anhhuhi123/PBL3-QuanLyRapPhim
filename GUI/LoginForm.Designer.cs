namespace GUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Dang_Nhap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btOut = new System.Windows.Forms.Button();
            this.DNhap = new System.Windows.Forms.TextBox();
            this.MKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Dang_Nhap
            // 
            this.Dang_Nhap.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Dang_Nhap.ForeColor = System.Drawing.Color.Black;
            this.Dang_Nhap.Location = new System.Drawing.Point(259, 243);
            this.Dang_Nhap.Margin = new System.Windows.Forms.Padding(2);
            this.Dang_Nhap.Name = "Dang_Nhap";
            this.Dang_Nhap.Size = new System.Drawing.Size(159, 38);
            this.Dang_Nhap.TabIndex = 4;
            this.Dang_Nhap.Text = "Login";
            this.Dang_Nhap.UseVisualStyleBackColor = false;
            this.Dang_Nhap.Click += new System.EventHandler(this.Dang_Nhap_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(193, 133);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(69, 41);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(193, 185);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(69, 41);
            this.panel2.TabIndex = 6;
            // 
            // btOut
            // 
            this.btOut.BackColor = System.Drawing.Color.Brown;
            this.btOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btOut.BackgroundImage")));
            this.btOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btOut.ForeColor = System.Drawing.Color.IndianRed;
            this.btOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btOut.Location = new System.Drawing.Point(615, 8);
            this.btOut.Margin = new System.Windows.Forms.Padding(2);
            this.btOut.Name = "btOut";
            this.btOut.Size = new System.Drawing.Size(55, 44);
            this.btOut.TabIndex = 7;
            this.btOut.UseVisualStyleBackColor = false;
            this.btOut.Click += new System.EventHandler(this.btOut_Click);
            // 
            // DNhap
            // 
            this.DNhap.BackColor = System.Drawing.SystemColors.HighlightText;
            this.DNhap.Location = new System.Drawing.Point(285, 145);
            this.DNhap.Margin = new System.Windows.Forms.Padding(2);
            this.DNhap.Name = "DNhap";
            this.DNhap.Size = new System.Drawing.Size(162, 22);
            this.DNhap.TabIndex = 8;
            this.DNhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DNhap_KeyDown);
            this.DNhap.MouseEnter += new System.EventHandler(this.DNhap_Enter);
            this.DNhap.MouseLeave += new System.EventHandler(this.DNhap_Leave);
            // 
            // MKhau
            // 
            this.MKhau.BackColor = System.Drawing.SystemColors.Menu;
            this.MKhau.Location = new System.Drawing.Point(285, 196);
            this.MKhau.Margin = new System.Windows.Forms.Padding(2);
            this.MKhau.Name = "MKhau";
            this.MKhau.PasswordChar = '*';
            this.MKhau.Size = new System.Drawing.Size(162, 22);
            this.MKhau.TabIndex = 9;
            this.MKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Mkhau_KeyDown);
            this.MKhau.MouseEnter += new System.EventHandler(this.MKhau_Enter);
            this.MKhau.MouseLeave += new System.EventHandler(this.MKhau_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(170, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "He Thong Quan Ly Ban Ve";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(683, 440);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MKhau);
            this.Controls.Add(this.DNhap);
            this.Controls.Add(this.btOut);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dang_Nhap);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Dang_Nhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btOut;
        private System.Windows.Forms.TextBox DNhap;
        private System.Windows.Forms.TextBox MKhau;
        private System.Windows.Forms.Label label1;
    }
}