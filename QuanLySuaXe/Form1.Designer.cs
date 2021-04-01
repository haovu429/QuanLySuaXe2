
namespace QuanLySuaXe
{
    partial class Form1
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
        /// 

        private void InitializeComponent()
        {
            this.btExit = new System.Windows.Forms.Button();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhPho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDelete = new System.Windows.Forms.Button();
            this.bReLoad = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxMaKH = new System.Windows.Forms.ComboBox();
            this.txtMaKHlk = new System.Windows.Forms.Label();
            this.lbHang = new System.Windows.Forms.Label();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.txtHang = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.lbSoDT = new System.Windows.Forms.Label();
            this.lbTenXe = new System.Windows.Forms.Label();
            this.lbMaXe = new System.Windows.Forms.Label();
            this.txtThanhPho = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lbThanhPho = new System.Windows.Forms.Label();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.brepair = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.bInsert = new System.Windows.Forms.Button();
            this.dgvXe = new System.Windows.Forms.DataGridView();
            this.quanLySuaXeDataSet = new QuanLySuaXe.QuanLySuaXeDataSet();
            this.KhachHang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.khachHangTableAdapter = new QuanLySuaXe.QuanLySuaXeDataSetTableAdapters.KhachHangTableAdapter();
            this.btMode = new System.Windows.Forms.Button();
            this.xeTableAdapter = new QuanLySuaXe.QuanLySuaXeDataSetTableAdapters.XeTableAdapter();
            this.MaXe1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenXe1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hang1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbKhachHang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySuaXeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Lime;
            this.btExit.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.Red;
            this.btExit.Location = new System.Drawing.Point(828, 388);
            this.btExit.Margin = new System.Windows.Forms.Padding(2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(77, 37);
            this.btExit.TabIndex = 9;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.ThanhPho,
            this.DienThoai});
            this.dgvKhachHang.Location = new System.Drawing.Point(0, 150);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 62;
            this.dgvKhachHang.RowTemplate.Height = 28;
            this.dgvKhachHang.Size = new System.Drawing.Size(460, 206);
            this.dgvKhachHang.TabIndex = 10;
            this.dgvKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellContentClick);
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.Name = "MaKH";
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên KH";
            this.TenKH.Name = "TenKH";
            // 
            // ThanhPho
            // 
            this.ThanhPho.DataPropertyName = "ThanhPho";
            this.ThanhPho.HeaderText = "Thành Phố";
            this.ThanhPho.Name = "ThanhPho";
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "SoDT";
            this.DienThoai.HeaderText = "Điện thoại";
            this.DienThoai.Name = "DienThoai";
            // 
            // bDelete
            // 
            this.bDelete.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.Location = new System.Drawing.Point(292, 392);
            this.bDelete.Margin = new System.Windows.Forms.Padding(2);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(76, 37);
            this.bDelete.TabIndex = 12;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            // 
            // bReLoad
            // 
            this.bReLoad.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bReLoad.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReLoad.Location = new System.Drawing.Point(198, 392);
            this.bReLoad.Margin = new System.Windows.Forms.Padding(2);
            this.bReLoad.Name = "bReLoad";
            this.bReLoad.Size = new System.Drawing.Size(79, 37);
            this.bReLoad.TabIndex = 11;
            this.bReLoad.Text = "Reload";
            this.bReLoad.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxMaKH);
            this.panel1.Controls.Add(this.txtMaKHlk);
            this.panel1.Controls.Add(this.lbHang);
            this.panel1.Controls.Add(this.txtMaXe);
            this.panel1.Controls.Add(this.txtTenXe);
            this.panel1.Controls.Add(this.txtHang);
            this.panel1.Controls.Add(this.txtSoDT);
            this.panel1.Controls.Add(this.lbSoDT);
            this.panel1.Controls.Add(this.lbTenXe);
            this.panel1.Controls.Add(this.lbMaXe);
            this.panel1.Controls.Add(this.txtThanhPho);
            this.panel1.Controls.Add(this.txtTenKH);
            this.panel1.Controls.Add(this.lbThanhPho);
            this.panel1.Controls.Add(this.lbTenKH);
            this.panel1.Controls.Add(this.lbMaKH);
            this.panel1.Controls.Add(this.txtMaKH);
            this.panel1.Location = new System.Drawing.Point(0, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 135);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBoxMaKH
            // 
            this.comboBoxMaKH.FormattingEnabled = true;
            this.comboBoxMaKH.Location = new System.Drawing.Point(620, 89);
            this.comboBoxMaKH.Name = "comboBoxMaKH";
            this.comboBoxMaKH.Size = new System.Drawing.Size(143, 21);
            this.comboBoxMaKH.TabIndex = 18;
            // 
            // txtMaKHlk
            // 
            this.txtMaKHlk.AutoSize = true;
            this.txtMaKHlk.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKHlk.Location = new System.Drawing.Point(477, 91);
            this.txtMaKHlk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtMaKHlk.Name = "txtMaKHlk";
            this.txtMaKHlk.Size = new System.Drawing.Size(50, 16);
            this.txtMaKHlk.TabIndex = 17;
            this.txtMaKHlk.Text = "Mã KH";
            // 
            // lbHang
            // 
            this.lbHang.AutoSize = true;
            this.lbHang.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHang.Location = new System.Drawing.Point(477, 65);
            this.lbHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHang.Name = "lbHang";
            this.lbHang.Size = new System.Drawing.Size(39, 16);
            this.lbHang.TabIndex = 16;
            this.lbHang.Text = "Hãng";
            // 
            // txtMaXe
            // 
            this.txtMaXe.Location = new System.Drawing.Point(620, 10);
            this.txtMaXe.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(143, 20);
            this.txtMaXe.TabIndex = 15;
            // 
            // txtTenXe
            // 
            this.txtTenXe.Location = new System.Drawing.Point(620, 35);
            this.txtTenXe.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(143, 20);
            this.txtTenXe.TabIndex = 14;
            // 
            // txtHang
            // 
            this.txtHang.Location = new System.Drawing.Point(621, 63);
            this.txtHang.Margin = new System.Windows.Forms.Padding(2);
            this.txtHang.Name = "txtHang";
            this.txtHang.Size = new System.Drawing.Size(143, 20);
            this.txtHang.TabIndex = 13;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(171, 85);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(143, 20);
            this.txtSoDT.TabIndex = 11;
            // 
            // lbSoDT
            // 
            this.lbSoDT.AutoSize = true;
            this.lbSoDT.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoDT.Location = new System.Drawing.Point(32, 89);
            this.lbSoDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSoDT.Name = "lbSoDT";
            this.lbSoDT.Size = new System.Drawing.Size(83, 16);
            this.lbSoDT.TabIndex = 10;
            this.lbSoDT.Text = "Số điện thoại";
            // 
            // lbTenXe
            // 
            this.lbTenXe.AutoSize = true;
            this.lbTenXe.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenXe.Location = new System.Drawing.Point(477, 39);
            this.lbTenXe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenXe.Name = "lbTenXe";
            this.lbTenXe.Size = new System.Drawing.Size(45, 16);
            this.lbTenXe.TabIndex = 8;
            this.lbTenXe.Text = "Tên xe";
            // 
            // lbMaXe
            // 
            this.lbMaXe.AutoSize = true;
            this.lbMaXe.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaXe.Location = new System.Drawing.Point(477, 16);
            this.lbMaXe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaXe.Name = "lbMaXe";
            this.lbMaXe.Size = new System.Drawing.Size(43, 16);
            this.lbMaXe.TabIndex = 7;
            this.lbMaXe.Text = "Mã xe";
            // 
            // txtThanhPho
            // 
            this.txtThanhPho.Location = new System.Drawing.Point(171, 59);
            this.txtThanhPho.Margin = new System.Windows.Forms.Padding(2);
            this.txtThanhPho.Name = "txtThanhPho";
            this.txtThanhPho.Size = new System.Drawing.Size(143, 20);
            this.txtThanhPho.TabIndex = 5;
            this.txtThanhPho.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(171, 35);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(143, 20);
            this.txtTenKH.TabIndex = 4;
            // 
            // lbThanhPho
            // 
            this.lbThanhPho.AutoSize = true;
            this.lbThanhPho.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhPho.Location = new System.Drawing.Point(32, 63);
            this.lbThanhPho.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbThanhPho.Name = "lbThanhPho";
            this.lbThanhPho.Size = new System.Drawing.Size(71, 16);
            this.lbThanhPho.TabIndex = 3;
            this.lbThanhPho.Text = "Thành Phố";
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKH.Location = new System.Drawing.Point(32, 37);
            this.lbTenKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(52, 16);
            this.lbTenKH.TabIndex = 2;
            this.lbTenKH.Text = "Tên KH";
            this.lbTenKH.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKH.Location = new System.Drawing.Point(32, 10);
            this.lbMaKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(50, 16);
            this.lbMaKH.TabIndex = 1;
            this.lbMaKH.Text = "Mã KH";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(171, 10);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(106, 20);
            this.txtMaKH.TabIndex = 0;
            this.txtMaKH.TextChanged += new System.EventHandler(this.txtMaKH_TextChanged);
            // 
            // brepair
            // 
            this.brepair.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brepair.Location = new System.Drawing.Point(726, 392);
            this.brepair.Margin = new System.Windows.Forms.Padding(2);
            this.brepair.Name = "brepair";
            this.brepair.Size = new System.Drawing.Size(78, 33);
            this.brepair.TabIndex = 16;
            this.brepair.Text = "Repair";
            this.brepair.UseVisualStyleBackColor = true;
            // 
            // bSave
            // 
            this.bSave.Enabled = false;
            this.bSave.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.Location = new System.Drawing.Point(384, 392);
            this.bSave.Margin = new System.Windows.Forms.Padding(2);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(76, 37);
            this.bSave.TabIndex = 14;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bCancel
            // 
            this.bCancel.Enabled = false;
            this.bCancel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.Location = new System.Drawing.Point(480, 392);
            this.bCancel.Margin = new System.Windows.Forms.Padding(2);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(78, 37);
            this.bCancel.TabIndex = 15;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // bInsert
            // 
            this.bInsert.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInsert.Location = new System.Drawing.Point(572, 392);
            this.bInsert.Margin = new System.Windows.Forms.Padding(2);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(131, 33);
            this.bInsert.TabIndex = 17;
            this.bInsert.Text = "Insert";
            this.bInsert.UseVisualStyleBackColor = true;
            this.bInsert.Click += new System.EventHandler(this.bInsert_Click);
            // 
            // dgvXe
            // 
            this.dgvXe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaXe1,
            this.TenXe1,
            this.Hang1,
            this.cbKhachHang});
            this.dgvXe.Location = new System.Drawing.Point(441, 150);
            this.dgvXe.Margin = new System.Windows.Forms.Padding(2);
            this.dgvXe.Name = "dgvXe";
            this.dgvXe.RowHeadersWidth = 62;
            this.dgvXe.RowTemplate.Height = 28;
            this.dgvXe.Size = new System.Drawing.Size(568, 206);
            this.dgvXe.TabIndex = 18;
            this.dgvXe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // quanLySuaXeDataSet
            // 
            this.quanLySuaXeDataSet.DataSetName = "QuanLySuaXeDataSet";
            this.quanLySuaXeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KhachHang
            // 
            this.KhachHang.DataPropertyName = "MaKH";
            this.KhachHang.HeaderText = "Khách hàng";
            this.KhachHang.Name = "KhachHang";
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // btMode
            // 
            this.btMode.Location = new System.Drawing.Point(26, 392);
            this.btMode.Name = "btMode";
            this.btMode.Size = new System.Drawing.Size(89, 33);
            this.btMode.TabIndex = 19;
            this.btMode.Text = "Khách hàng";
            this.btMode.UseVisualStyleBackColor = true;
            this.btMode.Click += new System.EventHandler(this.Mode_Click);
            // 
            // xeTableAdapter
            // 
            this.xeTableAdapter.ClearBeforeFill = true;
            // 
            // MaXe1
            // 
            this.MaXe1.DataPropertyName = "MaXe";
            this.MaXe1.HeaderText = "Mã Xe";
            this.MaXe1.Name = "MaXe1";
            // 
            // TenXe1
            // 
            this.TenXe1.DataPropertyName = "TenXe";
            this.TenXe1.HeaderText = "Tên xe";
            this.TenXe1.Name = "TenXe1";
            // 
            // Hang1
            // 
            this.Hang1.DataPropertyName = "HangXe";
            this.Hang1.HeaderText = "Hãng";
            this.Hang1.Name = "Hang1";
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.DataPropertyName = "TenKH";
            this.cbKhachHang.HeaderText = "Khách Hàng";
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 450);
            this.Controls.Add(this.btMode);
            this.Controls.Add(this.bInsert);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.brepair);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bReLoad);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.dgvXe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySuaXeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bReLoad;
        private System.Windows.Forms.Label lbTenXe;
        private System.Windows.Forms.Label lbMaXe;
        private System.Windows.Forms.TextBox txtThanhPho;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lbThanhPho;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Button brepair;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bInsert;
        private System.Windows.Forms.Label txtMaKHlk;
        private System.Windows.Forms.Label lbHang;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.TextBox txtHang;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label lbSoDT;
        private System.Windows.Forms.DataGridView dgvXe;
        private System.Windows.Forms.ComboBox comboBoxMaKH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewComboBoxColumn KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhPho;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private QuanLySuaXeDataSet quanLySuaXeDataSet;
        private QuanLySuaXeDataSetTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private System.Windows.Forms.Button btMode;
        private QuanLySuaXeDataSetTableAdapters.XeTableAdapter xeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaXe1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenXe1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hang1;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbKhachHang;
    }
}

