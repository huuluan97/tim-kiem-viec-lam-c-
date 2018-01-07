namespace PhanMemHoTroTimKiemVietLam
{
    partial class frmTimKiemDN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiemDN));
            this.grpDanhSachDN = new System.Windows.Forms.GroupBox();
            this.dgvDN = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxQuan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxNganhNghe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnGuiYeuCau = new System.Windows.Forms.Button();
            this.btnXemTatca = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grpDanhSachDN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDanhSachDN
            // 
            this.grpDanhSachDN.Controls.Add(this.dgvDN);
            this.grpDanhSachDN.Location = new System.Drawing.Point(12, 154);
            this.grpDanhSachDN.Name = "grpDanhSachDN";
            this.grpDanhSachDN.Size = new System.Drawing.Size(997, 282);
            this.grpDanhSachDN.TabIndex = 3;
            this.grpDanhSachDN.TabStop = false;
            this.grpDanhSachDN.Text = "Danh Sách Doanh Nghiệp";
            // 
            // dgvDN
            // 
            this.dgvDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDN.Location = new System.Drawing.Point(6, 27);
            this.dgvDN.Name = "dgvDN";
            this.dgvDN.RowTemplate.Height = 24;
            this.dgvDN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDN.Size = new System.Drawing.Size(985, 249);
            this.dgvDN.TabIndex = 0;
            this.dgvDN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxQuan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxNganhNghe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 127);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm doanh nghiệp";
            // 
            // cbxQuan
            // 
            this.cbxQuan.FormattingEnabled = true;
            this.cbxQuan.Location = new System.Drawing.Point(248, 71);
            this.cbxQuan.Name = "cbxQuan";
            this.cbxQuan.Size = new System.Drawing.Size(150, 28);
            this.cbxQuan.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm theo địa điểm:";
            // 
            // cbxNganhNghe
            // 
            this.cbxNganhNghe.FormattingEnabled = true;
            this.cbxNganhNghe.Location = new System.Drawing.Point(248, 33);
            this.cbxNganhNghe.Name = "cbxNganhNghe";
            this.cbxNganhNghe.Size = new System.Drawing.Size(150, 28);
            this.cbxNganhNghe.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm theo ngành nghề:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnThoat);
            this.groupBox5.Controls.Add(this.btnGuiYeuCau);
            this.groupBox5.Controls.Add(this.btnXemTatca);
            this.groupBox5.Controls.Add(this.btnTimKiem);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(456, 13);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(547, 127);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chọn tác vụ";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(418, 39);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(121, 46);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnGuiYeuCau
            // 
            this.btnGuiYeuCau.Location = new System.Drawing.Point(277, 39);
            this.btnGuiYeuCau.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuiYeuCau.Name = "btnGuiYeuCau";
            this.btnGuiYeuCau.Size = new System.Drawing.Size(133, 46);
            this.btnGuiYeuCau.TabIndex = 1;
            this.btnGuiYeuCau.Text = "Gửi yêu cầu";
            this.btnGuiYeuCau.UseVisualStyleBackColor = true;
            this.btnGuiYeuCau.Click += new System.EventHandler(this.btnGuiYeuCau_Click);
            // 
            // btnXemTatca
            // 
            this.btnXemTatca.Location = new System.Drawing.Point(8, 39);
            this.btnXemTatca.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemTatca.Name = "btnXemTatca";
            this.btnXemTatca.Size = new System.Drawing.Size(121, 46);
            this.btnXemTatca.TabIndex = 0;
            this.btnXemTatca.Text = "Xem tất cả";
            this.btnXemTatca.UseVisualStyleBackColor = true;
            this.btnXemTatca.Click += new System.EventHandler(this.btnXemTatca_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(137, 39);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(121, 46);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmTimKiemDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 446);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpDanhSachDN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTimKiemDN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm Kiếm Doanh Nghiệp";
            this.Load += new System.EventHandler(this.frmTimKiemDN_Load);
            this.grpDanhSachDN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDanhSachDN;
        private System.Windows.Forms.DataGridView dgvDN;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxNganhNghe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxQuan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnGuiYeuCau;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXemTatca;
    }
}