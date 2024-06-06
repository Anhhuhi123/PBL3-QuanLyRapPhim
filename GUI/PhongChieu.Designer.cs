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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhongChieu));
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            this.dataGridView1.Location = new System.Drawing.Point(425, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1016, 729);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.DarkRed;
            this.btThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btThem.BackgroundImage")));
            this.btThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btThem.Location = new System.Drawing.Point(52, 351);
            this.btThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(143, 57);
            this.btThem.TabIndex = 1;
            this.btThem.Text = "Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.Button_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.DarkRed;
            this.btSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSua.BackgroundImage")));
            this.btSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSua.Location = new System.Drawing.Point(242, 351);
            this.btSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(143, 57);
            this.btSua.TabIndex = 2;
            this.btSua.Text = "Sửa";
            this.btSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.Button_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.DarkRed;
            this.btXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btXoa.BackgroundImage")));
            this.btXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btXoa.Location = new System.Drawing.Point(52, 437);
            this.btXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(143, 57);
            this.btXoa.TabIndex = 3;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.Button_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.DarkRed;
            this.btThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btThoat.BackgroundImage")));
            this.btThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btThoat.Location = new System.Drawing.Point(242, 437);
            this.btThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(143, 57);
            this.btThoat.TabIndex = 4;
            this.btThoat.Text = "Thoát";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 36);
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
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(246, 22);
            this.txtid.TabIndex = 7;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(139, 127);
            this.txtname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(246, 22);
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
            this.txtsize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsize.Name = "txtsize";
            this.txtsize.Size = new System.Drawing.Size(246, 22);
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
            this.txtmota.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmota.Multiline = true;
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(246, 77);
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(52, 316);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(213, 20);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Thay đổi phòng chứa lịch chiếu";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // PhongChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1441, 729);
            this.Controls.Add(this.checkBox1);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PhongChieu";
            this.RightToLeftLayout = true;
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
        private System.Windows.Forms.CheckBox checkBox1;
    }
}