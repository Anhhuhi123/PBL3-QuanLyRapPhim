namespace GUI
{
    partial class PhongChieu
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
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblten = new System.Windows.Forms.Label();
            this.txtsize = new System.Windows.Forms.TextBox();
            this.lblsize = new System.Windows.Forms.Label();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.lbldes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(407, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(853, 636);
            this.dataGridView1.TabIndex = 0;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(52, 319);
            this.btThem.Margin = new System.Windows.Forms.Padding(2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(124, 44);
            this.btThem.TabIndex = 1;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.Button_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(52, 382);
            this.btSua.Margin = new System.Windows.Forms.Padding(2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(124, 44);
            this.btSua.TabIndex = 2;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.Button_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(52, 449);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(124, 44);
            this.btXoa.TabIndex = 3;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.Button_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(52, 518);
            this.btThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(124, 44);
            this.btThoat.TabIndex = 4;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Phòng Chiếu";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(49, 85);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(70, 16);
            this.lblid.TabIndex = 6;
            this.lblid.Text = "Mã phòng:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(139, 85);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(182, 22);
            this.txtid.TabIndex = 7;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(139, 127);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(182, 22);
            this.txtname.TabIndex = 9;
            // 
            // lblten
            // 
            this.lblten.AutoSize = true;
            this.lblten.Location = new System.Drawing.Point(49, 127);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(75, 16);
            this.lblten.TabIndex = 8;
            this.lblten.Text = "Tên phòng:";
            // 
            // txtsize
            // 
            this.txtsize.Location = new System.Drawing.Point(139, 170);
            this.txtsize.Name = "txtsize";
            this.txtsize.Size = new System.Drawing.Size(182, 22);
            this.txtsize.TabIndex = 11;
            // 
            // lblsize
            // 
            this.lblsize.AutoSize = true;
            this.lblsize.Location = new System.Drawing.Point(49, 170);
            this.lblsize.Name = "lblsize";
            this.lblsize.Size = new System.Drawing.Size(65, 16);
            this.lblsize.TabIndex = 10;
            this.lblsize.Text = "Sức chứa:";
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(139, 218);
            this.txtmota.Multiline = true;
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(182, 77);
            this.txtmota.TabIndex = 13;
            // 
            // lbldes
            // 
            this.lbldes.AutoSize = true;
            this.lbldes.Location = new System.Drawing.Point(49, 218);
            this.lbldes.Name = "lbldes";
            this.lbldes.Size = new System.Drawing.Size(43, 16);
            this.lbldes.TabIndex = 12;
            this.lbldes.Text = "Mô tả:";
            // 
            // PhongChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1260, 636);
            this.Controls.Add(this.txtmota);
            this.Controls.Add(this.lbldes);
            this.Controls.Add(this.txtsize);
            this.Controls.Add(this.lblsize);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblten);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PhongChieu";
            this.Text = "PhongChieu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblten;
        private System.Windows.Forms.TextBox txtsize;
        private System.Windows.Forms.Label lblsize;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.Label lbldes;
    }
}