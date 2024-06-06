namespace GUI
{
    partial class QuanLyPhim
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyPhim));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtMaPhim = new System.Windows.Forms.TextBox();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.txtThoiLuong = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.ccbTheLoai = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Filterbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(442, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(999, 729);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Phim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Phim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thời Lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thể loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mô tả";
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.DarkRed;
            this.btThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btThem.BackgroundImage")));
            this.btThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btThem.Location = new System.Drawing.Point(36, 444);
            this.btThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(143, 57);
            this.btThem.TabIndex = 6;
            this.btThem.Text = "Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.button_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.DarkRed;
            this.btSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSua.BackgroundImage")));
            this.btSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSua.Location = new System.Drawing.Point(239, 444);
            this.btSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(143, 57);
            this.btSua.TabIndex = 7;
            this.btSua.Text = "Sửa";
            this.btSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.button_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.DarkRed;
            this.btXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btXoa.BackgroundImage")));
            this.btXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btXoa.Location = new System.Drawing.Point(36, 529);
            this.btXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(143, 57);
            this.btXoa.TabIndex = 8;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkRed;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(239, 529);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 57);
            this.button4.TabIndex = 9;
            this.button4.Text = "Thoát";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Exit_Click);
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.Location = new System.Drawing.Point(123, 114);
            this.txtMaPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.Size = new System.Drawing.Size(193, 22);
            this.txtMaPhim.TabIndex = 11;
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.Location = new System.Drawing.Point(123, 165);
            this.txtTenPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(193, 22);
            this.txtTenPhim.TabIndex = 12;
            // 
            // txtThoiLuong
            // 
            this.txtThoiLuong.Location = new System.Drawing.Point(123, 265);
            this.txtThoiLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThoiLuong.Name = "txtThoiLuong";
            this.txtThoiLuong.Size = new System.Drawing.Size(76, 22);
            this.txtThoiLuong.TabIndex = 13;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(123, 314);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(263, 109);
            this.txtMoTa.TabIndex = 14;
            // 
            // ccbTheLoai
            // 
            this.ccbTheLoai.FormattingEnabled = true;
            this.ccbTheLoai.Location = new System.Drawing.Point(123, 222);
            this.ccbTheLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ccbTheLoai.Name = "ccbTheLoai";
            this.ccbTheLoai.Size = new System.Drawing.Size(193, 24);
            this.ccbTheLoai.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Phút";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 36);
            this.label7.TabIndex = 17;
            this.label7.Text = "Quản Lý Phim";
            // 
            // Filterbtn
            // 
            this.Filterbtn.Location = new System.Drawing.Point(323, 222);
            this.Filterbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Filterbtn.Name = "Filterbtn";
            this.Filterbtn.Size = new System.Drawing.Size(75, 23);
            this.Filterbtn.TabIndex = 18;
            this.Filterbtn.Text = "Lọc";
            this.Filterbtn.UseVisualStyleBackColor = true;
            this.Filterbtn.Click += new System.EventHandler(this.button_Click);
            // 
            // QuanLyPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1441, 729);
            this.Controls.Add(this.Filterbtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ccbTheLoai);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtThoiLuong);
            this.Controls.Add(this.txtTenPhim);
            this.Controls.Add(this.txtMaPhim);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLyPhim";
            this.Text = "QuanLyPhim";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtMaPhim;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.TextBox txtThoiLuong;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.ComboBox ccbTheLoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Filterbtn;
    }
}