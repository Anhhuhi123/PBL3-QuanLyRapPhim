namespace GUI
{
    partial class BanVe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btTimPhim = new System.Windows.Forms.Button();
            this.btTimPhong = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.txtChonPhong = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DTSearch = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ten Phim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chon Ngay";
            // 
            // btTimPhim
            // 
            this.btTimPhim.Location = new System.Drawing.Point(237, 315);
            this.btTimPhim.Name = "btTimPhim";
            this.btTimPhim.Size = new System.Drawing.Size(260, 55);
            this.btTimPhim.TabIndex = 2;
            this.btTimPhim.Text = "Tim Phim";
            this.btTimPhim.UseVisualStyleBackColor = true;
            // 
            // btTimPhong
            // 
            this.btTimPhong.Location = new System.Drawing.Point(237, 421);
            this.btTimPhong.Name = "btTimPhong";
            this.btTimPhong.Size = new System.Drawing.Size(260, 49);
            this.btTimPhong.TabIndex = 3;
            this.btTimPhong.Text = "Tim Phong";
            this.btTimPhong.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 542);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1914, 355);
            this.dataGridView1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chon Phong";
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.Location = new System.Drawing.Point(237, 67);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(370, 31);
            this.txtTenPhim.TabIndex = 6;
            // 
            // txtChonPhong
            // 
            this.txtChonPhong.Location = new System.Drawing.Point(237, 229);
            this.txtChonPhong.Name = "txtChonPhong";
            this.txtChonPhong.Size = new System.Drawing.Size(370, 31);
            this.txtChonPhong.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(237, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(370, 31);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(671, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 544);
            this.panel1.TabIndex = 9;
            // 
            // DTSearch
            // 
            this.DTSearch.AutoSize = true;
            this.DTSearch.Location = new System.Drawing.Point(631, 148);
            this.DTSearch.Name = "DTSearch";
            this.DTSearch.Size = new System.Drawing.Size(28, 27);
            this.DTSearch.TabIndex = 10;
            this.DTSearch.UseVisualStyleBackColor = true;
            // 
            // BanVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1910, 892);
            this.Controls.Add(this.DTSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtChonPhong);
            this.Controls.Add(this.txtTenPhim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btTimPhong);
            this.Controls.Add(this.btTimPhim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BanVe";
            this.Text = "BanVe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btTimPhim;
        private System.Windows.Forms.Button btTimPhong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.TextBox txtChonPhong;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox DTSearch;
    }
}