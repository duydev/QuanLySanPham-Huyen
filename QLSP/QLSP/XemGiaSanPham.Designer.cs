namespace QLSP
{
    partial class XemGiaSanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XemGiaSanPham));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbxThuongHieu = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbxDanhMuc = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnXoaKetQua = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenThuongHieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSi10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSi20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhậpXuấtDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpXuấtDữLiệuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saoLưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phụcHồiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinPhầnMềmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vềTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnTim = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 422);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbxThuongHieu);
            this.groupBox2.Location = new System.Drawing.Point(11, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 189);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thương Hiệu";
            // 
            // lbxThuongHieu
            // 
            this.lbxThuongHieu.FormattingEnabled = true;
            this.lbxThuongHieu.ItemHeight = 22;
            this.lbxThuongHieu.Location = new System.Drawing.Point(6, 27);
            this.lbxThuongHieu.Name = "lbxThuongHieu";
            this.lbxThuongHieu.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxThuongHieu.Size = new System.Drawing.Size(241, 158);
            this.lbxThuongHieu.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxDanhMuc);
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Mục";
            // 
            // lbxDanhMuc
            // 
            this.lbxDanhMuc.FormattingEnabled = true;
            this.lbxDanhMuc.ItemHeight = 22;
            this.lbxDanhMuc.Location = new System.Drawing.Point(6, 27);
            this.lbxDanhMuc.Name = "lbxDanhMuc";
            this.lbxDanhMuc.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxDanhMuc.Size = new System.Drawing.Size(241, 158);
            this.lbxDanhMuc.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTim);
            this.panel2.Controls.Add(this.txtTenSanPham);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(268, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(849, 61);
            this.panel2.TabIndex = 1;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(143, 11);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(487, 30);
            this.txtTenSanPham.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sản Phẩm:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnXoaKetQua);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(268, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(849, 33);
            this.panel3.TabIndex = 2;
            // 
            // btnXoaKetQua
            // 
            this.btnXoaKetQua.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnXoaKetQua.Location = new System.Drawing.Point(0, 0);
            this.btnXoaKetQua.Name = "btnXoaKetQua";
            this.btnXoaKetQua.Size = new System.Drawing.Size(126, 33);
            this.btnXoaKetQua.TabIndex = 2;
            this.btnXoaKetQua.Text = "Xóa Kết Quả";
            this.btnXoaKetQua.UseVisualStyleBackColor = true;
            this.btnXoaKetQua.Click += new System.EventHandler(this.btnXoaKetQua_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(268, 122);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(849, 328);
            this.panel4.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenSP,
            this.colTenDanhMuc,
            this.colTenThuongHieu,
            this.colSi10,
            this.colSi20,
            this.colLe});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(849, 328);
            this.dataGridView1.TabIndex = 0;
            // 
            // colTenSP
            // 
            this.colTenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenSP.DataPropertyName = "TenSanPham";
            this.colTenSP.HeaderText = "Tên Sản Phẩm";
            this.colTenSP.Name = "colTenSP";
            // 
            // colTenDanhMuc
            // 
            this.colTenDanhMuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenDanhMuc.DataPropertyName = "TenDanhMuc";
            this.colTenDanhMuc.HeaderText = "Tên Danh Mục";
            this.colTenDanhMuc.Name = "colTenDanhMuc";
            // 
            // colTenThuongHieu
            // 
            this.colTenThuongHieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenThuongHieu.DataPropertyName = "TenThuongHieu";
            this.colTenThuongHieu.HeaderText = "Tên Thương Hiệu";
            this.colTenThuongHieu.Name = "colTenThuongHieu";
            // 
            // colSi10
            // 
            this.colSi10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSi10.DataPropertyName = "Si10";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C0";
            dataGridViewCellStyle1.NullValue = "0";
            this.colSi10.DefaultCellStyle = dataGridViewCellStyle1;
            this.colSi10.HeaderText = "Giá Sỉ 10";
            this.colSi10.Name = "colSi10";
            // 
            // colSi20
            // 
            this.colSi20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSi20.DataPropertyName = "Si20";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C0";
            dataGridViewCellStyle2.NullValue = "0";
            this.colSi20.DefaultCellStyle = dataGridViewCellStyle2;
            this.colSi20.HeaderText = "Giá Sỉ 20";
            this.colSi20.Name = "colSi20";
            // 
            // colLe
            // 
            this.colLe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLe.DataPropertyName = "Le";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C0";
            dataGridViewCellStyle3.NullValue = "0";
            this.colLe.DefaultCellStyle = dataGridViewCellStyle3;
            this.colLe.HeaderText = "Giá Lẻ";
            this.colLe.Name = "colLe";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpXuấtDữLiệuToolStripMenuItem,
            this.nhậpXuấtDữLiệuToolStripMenuItem1,
            this.thôngTinPhầnMềmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1117, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhậpXuấtDữLiệuToolStripMenuItem
            // 
            this.nhậpXuấtDữLiệuToolStripMenuItem.Name = "nhậpXuấtDữLiệuToolStripMenuItem";
            this.nhậpXuấtDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.nhậpXuấtDữLiệuToolStripMenuItem.Text = "Quản Lý Sản Phẩm";
            this.nhậpXuấtDữLiệuToolStripMenuItem.Click += new System.EventHandler(this.nhậpXuấtDữLiệuToolStripMenuItem_Click);
            // 
            // nhậpXuấtDữLiệuToolStripMenuItem1
            // 
            this.nhậpXuấtDữLiệuToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saoLưuToolStripMenuItem,
            this.phụcHồiToolStripMenuItem});
            this.nhậpXuấtDữLiệuToolStripMenuItem1.Name = "nhậpXuấtDữLiệuToolStripMenuItem1";
            this.nhậpXuấtDữLiệuToolStripMenuItem1.Size = new System.Drawing.Size(156, 24);
            this.nhậpXuấtDữLiệuToolStripMenuItem1.Text = "Nhập / Xuất Dữ Liệu";
            // 
            // saoLưuToolStripMenuItem
            // 
            this.saoLưuToolStripMenuItem.Name = "saoLưuToolStripMenuItem";
            this.saoLưuToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.saoLưuToolStripMenuItem.Text = "Sao lưu";
            this.saoLưuToolStripMenuItem.Click += new System.EventHandler(this.saoLưuToolStripMenuItem_Click);
            // 
            // phụcHồiToolStripMenuItem
            // 
            this.phụcHồiToolStripMenuItem.Name = "phụcHồiToolStripMenuItem";
            this.phụcHồiToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.phụcHồiToolStripMenuItem.Text = "Phục hồi";
            this.phụcHồiToolStripMenuItem.Click += new System.EventHandler(this.phụcHồiToolStripMenuItem_Click);
            // 
            // thôngTinPhầnMềmToolStripMenuItem
            // 
            this.thôngTinPhầnMềmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vềTácGiảToolStripMenuItem});
            this.thôngTinPhầnMềmToolStripMenuItem.Name = "thôngTinPhầnMềmToolStripMenuItem";
            this.thôngTinPhầnMềmToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.thôngTinPhầnMềmToolStripMenuItem.Text = "Thông Tin Phần Mềm";
            // 
            // vềTácGiảToolStripMenuItem
            // 
            this.vềTácGiảToolStripMenuItem.Name = "vềTácGiảToolStripMenuItem";
            this.vềTácGiảToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.vềTácGiảToolStripMenuItem.Text = "Về tác giả";
            this.vềTácGiảToolStripMenuItem.Click += new System.EventHandler(this.vềTácGiảToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(268, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(849, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnTim
            // 
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(638, 11);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(102, 30);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // XemGiaSanPham
            // 
            this.AcceptButton = this.btnTim;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "XemGiaSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem Giá Sản Phẩm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.XemGiaSanPham_FormClosed);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbxThuongHieu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxDanhMuc;
        private System.Windows.Forms.Button btnXoaKetQua;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhậpXuấtDữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpXuấtDữLiệuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinPhầnMềmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vềTácGiảToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem saoLưuToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem phụcHồiToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenThuongHieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSi10;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSi20;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLe;
    }
}