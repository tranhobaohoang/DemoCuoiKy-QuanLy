namespace QUANLY
{
    partial class TTKH
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
            this.btn_ThemKH = new System.Windows.Forms.Button();
            this.btn_SuaKH = new System.Windows.Forms.Button();
            this.btn_XoaKH = new System.Windows.Forms.Button();
            this.dgv_KH = new System.Windows.Forms.DataGridView();
            this.btn_Timkiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_MaKH = new System.Windows.Forms.Label();
            this.lb_TenKH = new System.Windows.Forms.Label();
            this.lb_EmailKH = new System.Windows.Forms.Label();
            this.lb_SdtKH = new System.Windows.Forms.Label();
            this.txt_SdtKH = new System.Windows.Forms.TextBox();
            this.txt_EmailKH = new System.Windows.Forms.TextBox();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.txt_maKH = new System.Windows.Forms.TextBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ThemKH
            // 
            this.btn_ThemKH.Location = new System.Drawing.Point(40, 17);
            this.btn_ThemKH.Name = "btn_ThemKH";
            this.btn_ThemKH.Size = new System.Drawing.Size(82, 32);
            this.btn_ThemKH.TabIndex = 0;
            this.btn_ThemKH.Text = "Thêm";
            this.btn_ThemKH.UseVisualStyleBackColor = true;
            this.btn_ThemKH.Click += new System.EventHandler(this.btn_ThemKH_Click);
            // 
            // btn_SuaKH
            // 
            this.btn_SuaKH.Location = new System.Drawing.Point(40, 63);
            this.btn_SuaKH.Name = "btn_SuaKH";
            this.btn_SuaKH.Size = new System.Drawing.Size(84, 33);
            this.btn_SuaKH.TabIndex = 0;
            this.btn_SuaKH.Text = "Lưu";
            this.btn_SuaKH.UseVisualStyleBackColor = true;
            this.btn_SuaKH.Click += new System.EventHandler(this.btn_SuaKH_Click);
            // 
            // btn_XoaKH
            // 
            this.btn_XoaKH.Location = new System.Drawing.Point(157, 17);
            this.btn_XoaKH.Name = "btn_XoaKH";
            this.btn_XoaKH.Size = new System.Drawing.Size(82, 32);
            this.btn_XoaKH.TabIndex = 0;
            this.btn_XoaKH.Text = "Xóa";
            this.btn_XoaKH.UseVisualStyleBackColor = true;
            this.btn_XoaKH.Click += new System.EventHandler(this.btn_XoaKH_Click);
            // 
            // dgv_KH
            // 
            this.dgv_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KH.Location = new System.Drawing.Point(34, 149);
            this.dgv_KH.Name = "dgv_KH";
            this.dgv_KH.Size = new System.Drawing.Size(726, 213);
            this.dgv_KH.TabIndex = 2;
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.Location = new System.Drawing.Point(157, 63);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Size = new System.Drawing.Size(82, 33);
            this.btn_Timkiem.TabIndex = 0;
            this.btn_Timkiem.Text = "Tìm Kiếm";
            this.btn_Timkiem.UseVisualStyleBackColor = true;
            this.btn_Timkiem.Click += new System.EventHandler(this.btn_Timkiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Timkiem);
            this.groupBox1.Controls.Add(this.btn_XoaKH);
            this.groupBox1.Controls.Add(this.btn_SuaKH);
            this.groupBox1.Controls.Add(this.btn_ThemKH);
            this.groupBox1.Location = new System.Drawing.Point(477, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 109);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điều Khiển";
            // 
            // lb_MaKH
            // 
            this.lb_MaKH.AutoSize = true;
            this.lb_MaKH.Location = new System.Drawing.Point(31, 26);
            this.lb_MaKH.Name = "lb_MaKH";
            this.lb_MaKH.Size = new System.Drawing.Size(82, 13);
            this.lb_MaKH.TabIndex = 4;
            this.lb_MaKH.Text = "Mã khách hàng";
            // 
            // lb_TenKH
            // 
            this.lb_TenKH.AutoSize = true;
            this.lb_TenKH.Location = new System.Drawing.Point(31, 52);
            this.lb_TenKH.Name = "lb_TenKH";
            this.lb_TenKH.Size = new System.Drawing.Size(86, 13);
            this.lb_TenKH.TabIndex = 4;
            this.lb_TenKH.Text = "Tên khách hàng";
            // 
            // lb_EmailKH
            // 
            this.lb_EmailKH.AutoSize = true;
            this.lb_EmailKH.Location = new System.Drawing.Point(31, 78);
            this.lb_EmailKH.Name = "lb_EmailKH";
            this.lb_EmailKH.Size = new System.Drawing.Size(92, 13);
            this.lb_EmailKH.TabIndex = 4;
            this.lb_EmailKH.Text = "Email khách hàng";
            // 
            // lb_SdtKH
            // 
            this.lb_SdtKH.AutoSize = true;
            this.lb_SdtKH.Location = new System.Drawing.Point(31, 104);
            this.lb_SdtKH.Name = "lb_SdtKH";
            this.lb_SdtKH.Size = new System.Drawing.Size(89, 13);
            this.lb_SdtKH.TabIndex = 4;
            this.lb_SdtKH.Text = "SDT khách hàng";
            // 
            // txt_SdtKH
            // 
            this.txt_SdtKH.Location = new System.Drawing.Point(178, 101);
            this.txt_SdtKH.Name = "txt_SdtKH";
            this.txt_SdtKH.Size = new System.Drawing.Size(223, 20);
            this.txt_SdtKH.TabIndex = 5;
            // 
            // txt_EmailKH
            // 
            this.txt_EmailKH.Location = new System.Drawing.Point(178, 75);
            this.txt_EmailKH.Name = "txt_EmailKH";
            this.txt_EmailKH.Size = new System.Drawing.Size(223, 20);
            this.txt_EmailKH.TabIndex = 5;
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Location = new System.Drawing.Point(178, 49);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(223, 20);
            this.txt_TenKH.TabIndex = 5;
            // 
            // txt_maKH
            // 
            this.txt_maKH.Location = new System.Drawing.Point(178, 23);
            this.txt_maKH.Name = "txt_maKH";
            this.txt_maKH.Size = new System.Drawing.Size(223, 20);
            this.txt_maKH.TabIndex = 5;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(517, 123);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(199, 20);
            this.txt_Search.TabIndex = 5;
            // 
            // TTKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_maKH);
            this.Controls.Add(this.txt_TenKH);
            this.Controls.Add(this.txt_EmailKH);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.txt_SdtKH);
            this.Controls.Add(this.lb_SdtKH);
            this.Controls.Add(this.lb_EmailKH);
            this.Controls.Add(this.lb_TenKH);
            this.Controls.Add(this.lb_MaKH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_KH);
            this.Name = "TTKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TTKH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TTKH_FormClosing);
            this.Load += new System.EventHandler(this.TTKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ThemKH;
        private System.Windows.Forms.Button btn_SuaKH;
        private System.Windows.Forms.Button btn_XoaKH;
        private System.Windows.Forms.DataGridView dgv_KH;
        private System.Windows.Forms.Button btn_Timkiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_MaKH;
        private System.Windows.Forms.Label lb_TenKH;
        private System.Windows.Forms.Label lb_EmailKH;
        private System.Windows.Forms.Label lb_SdtKH;
        private System.Windows.Forms.TextBox txt_SdtKH;
        private System.Windows.Forms.TextBox txt_EmailKH;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.TextBox txt_maKH;
        private System.Windows.Forms.TextBox txt_Search;
    }
}