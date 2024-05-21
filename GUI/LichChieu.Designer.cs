﻿namespace GUI
{
    partial class LichChieu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.txtIDLichChieu = new System.Windows.Forms.TextBox();
            this.ccbTenPhim = new System.Windows.Forms.ComboBox();
            this.txtGioChieu = new System.Windows.Forms.TextBox();
            this.dateTimeLichChieu = new System.Windows.Forms.DateTimePicker();
            this.rdoThayDoiLichChieuTrongPhong = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(304, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(633, 582);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ten Phim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngay Chieu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 237);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gio Chieu";
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(35, 313);
            this.btThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(107, 46);
            this.btThem.TabIndex = 6;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.Button_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(180, 313);
            this.btSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(107, 46);
            this.btSua.TabIndex = 7;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.Button_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(35, 395);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(107, 46);
            this.btXoa.TabIndex = 8;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.Button_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(180, 395);
            this.btThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(107, 46);
            this.btThoat.TabIndex = 9;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // txtIDLichChieu
            // 
            this.txtIDLichChieu.Location = new System.Drawing.Point(101, 99);
            this.txtIDLichChieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIDLichChieu.Name = "txtIDLichChieu";
            this.txtIDLichChieu.Size = new System.Drawing.Size(186, 20);
            this.txtIDLichChieu.TabIndex = 10;
            // 
            // ccbTenPhim
            // 
            this.ccbTenPhim.FormattingEnabled = true;
            this.ccbTenPhim.Location = new System.Drawing.Point(101, 141);
            this.ccbTenPhim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ccbTenPhim.Name = "ccbTenPhim";
            this.ccbTenPhim.Size = new System.Drawing.Size(186, 21);
            this.ccbTenPhim.TabIndex = 11;
            this.ccbTenPhim.SelectedIndexChanged += new System.EventHandler(this.ccbTenPhim_SelectedIndexChanged_1);
            // 
            // txtGioChieu
            // 
            this.txtGioChieu.Location = new System.Drawing.Point(101, 234);
            this.txtGioChieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGioChieu.Name = "txtGioChieu";
            this.txtGioChieu.Size = new System.Drawing.Size(186, 20);
            this.txtGioChieu.TabIndex = 12;
            // 
            // dateTimeLichChieu
            // 
            this.dateTimeLichChieu.Location = new System.Drawing.Point(101, 188);
            this.dateTimeLichChieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimeLichChieu.Name = "dateTimeLichChieu";
            this.dateTimeLichChieu.Size = new System.Drawing.Size(186, 20);
            this.dateTimeLichChieu.TabIndex = 15;
            // 
            // rdoThayDoiLichChieuTrongPhong
            // 
            this.rdoThayDoiLichChieuTrongPhong.AutoSize = true;
            this.rdoThayDoiLichChieuTrongPhong.Location = new System.Drawing.Point(35, 273);
            this.rdoThayDoiLichChieuTrongPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoThayDoiLichChieuTrongPhong.Name = "rdoThayDoiLichChieuTrongPhong";
            this.rdoThayDoiLichChieuTrongPhong.Size = new System.Drawing.Size(175, 17);
            this.rdoThayDoiLichChieuTrongPhong.TabIndex = 16;
            this.rdoThayDoiLichChieuTrongPhong.TabStop = true;
            this.rdoThayDoiLichChieuTrongPhong.Text = "Thay đổi lịch chiếu trong phòng";
            this.rdoThayDoiLichChieuTrongPhong.UseVisualStyleBackColor = true;
            this.rdoThayDoiLichChieuTrongPhong.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Quan Ly Lich Chieu";
            // 
            // LichChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(937, 582);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdoThayDoiLichChieuTrongPhong);
            this.Controls.Add(this.dateTimeLichChieu);
            this.Controls.Add(this.txtGioChieu);
            this.Controls.Add(this.ccbTenPhim);
            this.Controls.Add(this.txtIDLichChieu);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LichChieu";
            this.Text = "LichChieu";
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
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.TextBox txtIDLichChieu;
        private System.Windows.Forms.ComboBox ccbTenPhim;
        private System.Windows.Forms.TextBox txtGioChieu;
        private System.Windows.Forms.DateTimePicker dateTimeLichChieu;
        private System.Windows.Forms.RadioButton rdoThayDoiLichChieuTrongPhong;
        private System.Windows.Forms.Label label5;
    }
}