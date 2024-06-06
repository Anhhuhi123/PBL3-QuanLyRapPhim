using System.Windows.Forms;

namespace GUI
{
    partial class ThongTinNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinNhanVien));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Idlbl = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rolecbb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.Activerdb = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.txtKPI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(384, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1057, 729);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Idlbl
            // 
            this.Idlbl.AutoSize = true;
            this.Idlbl.Location = new System.Drawing.Point(83, 89);
            this.Idlbl.Name = "Idlbl";
            this.Idlbl.Size = new System.Drawing.Size(29, 16);
            this.Idlbl.TabIndex = 2;
            this.Idlbl.Text = "Mã:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(175, 84);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(177, 22);
            this.txtId.TabIndex = 3;
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(173, 124);
            this.txtFullname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(179, 22);
            this.txtFullname.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vai trò:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rolecbb
            // 
            this.rolecbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rolecbb.FormattingEnabled = true;
            this.rolecbb.Location = new System.Drawing.Point(173, 166);
            this.rolecbb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rolecbb.Name = "rolecbb";
            this.rolecbb.Size = new System.Drawing.Size(180, 24);
            this.rolecbb.TabIndex = 7;
            this.rolecbb.SelectedIndexChanged += new System.EventHandler(this.rolecbb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số điện thoại:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(173, 210);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(179, 22);
            this.txtNumber.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(173, 255);
            this.txtemail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(179, 22);
            this.txtemail.TabIndex = 11;
            // 
            // Activerdb
            // 
            this.Activerdb.AutoSize = true;
            this.Activerdb.Location = new System.Drawing.Point(176, 337);
            this.Activerdb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Activerdb.Name = "Activerdb";
            this.Activerdb.Size = new System.Drawing.Size(88, 20);
            this.Activerdb.TabIndex = 14;
            this.Activerdb.TabStop = true;
            this.Activerdb.Text = "Trạng thái";
            this.Activerdb.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(290, 36);
            this.label6.TabIndex = 15;
            this.label6.Text = "Thông tin nhân viên";
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.DarkRed;
            this.Addbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Addbtn.BackgroundImage")));
            this.Addbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Addbtn.Location = new System.Drawing.Point(35, 400);
            this.Addbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(145, 54);
            this.Addbtn.TabIndex = 16;
            this.Addbtn.Text = "Thêm";
            this.Addbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Button_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.Color.DarkRed;
            this.Updatebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Updatebtn.BackgroundImage")));
            this.Updatebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Updatebtn.Location = new System.Drawing.Point(208, 400);
            this.Updatebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(145, 54);
            this.Updatebtn.TabIndex = 17;
            this.Updatebtn.Text = "Sửa";
            this.Updatebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Button_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackColor = System.Drawing.Color.DarkRed;
            this.Exitbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exitbtn.BackgroundImage")));
            this.Exitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exitbtn.Location = new System.Drawing.Point(208, 460);
            this.Exitbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(145, 54);
            this.Exitbtn.TabIndex = 19;
            this.Exitbtn.Text = "Thoát";
            this.Exitbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exitbtn.UseVisualStyleBackColor = false;
            this.Exitbtn.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.DarkRed;
            this.Deletebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Deletebtn.BackgroundImage")));
            this.Deletebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Deletebtn.Location = new System.Drawing.Point(35, 460);
            this.Deletebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(145, 54);
            this.Deletebtn.TabIndex = 18;
            this.Deletebtn.Text = "Xóa";
            this.Deletebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // txtKPI
            // 
            this.txtKPI.Location = new System.Drawing.Point(175, 295);
            this.txtKPI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKPI.Name = "txtKPI";
            this.txtKPI.Size = new System.Drawing.Size(177, 22);
            this.txtKPI.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "KPI";
            // 
            // ThongTinNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1441, 729);
            this.Controls.Add(this.txtKPI);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Activerdb);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rolecbb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.Idlbl);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThongTinNhanVien";
            this.Text = "ThongTinNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Idlbl;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox rolecbb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.RadioButton Activerdb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.TextBox txtKPI;
        private System.Windows.Forms.Label label7;
    }
}