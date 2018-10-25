namespace QUANLY
{
    partial class NHANVIEN
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
            this.lb_Phienlamviec = new System.Windows.Forms.Label();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.menu_nhanvien = new System.Windows.Forms.MenuStrip();
            this.thôngTinKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dịchVụKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_nhanvien.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Phienlamviec
            // 
            this.lb_Phienlamviec.AutoSize = true;
            this.lb_Phienlamviec.Location = new System.Drawing.Point(12, 363);
            this.lb_Phienlamviec.Name = "lb_Phienlamviec";
            this.lb_Phienlamviec.Size = new System.Drawing.Size(79, 13);
            this.lb_Phienlamviec.TabIndex = 0;
            this.lb_Phienlamviec.Text = "Phiên làm việc:";
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.Location = new System.Drawing.Point(114, 360);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(236, 20);
            this.txt_TenNV.TabIndex = 1;
            // 
            // menu_nhanvien
            // 
            this.menu_nhanvien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinKháchHàngToolStripMenuItem,
            this.dịchVụKháchHàngToolStripMenuItem});
            this.menu_nhanvien.Location = new System.Drawing.Point(0, 0);
            this.menu_nhanvien.Name = "menu_nhanvien";
            this.menu_nhanvien.Size = new System.Drawing.Size(800, 24);
            this.menu_nhanvien.TabIndex = 2;
            this.menu_nhanvien.Text = "menu_nhanvien";
            // 
            // thôngTinKháchHàngToolStripMenuItem
            // 
            this.thôngTinKháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem});
            this.thôngTinKháchHàngToolStripMenuItem.Name = "thôngTinKháchHàngToolStripMenuItem";
            this.thôngTinKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.thôngTinKháchHàngToolStripMenuItem.Text = "Thông tin khách hàng";
            this.thôngTinKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.thôngTinKháchHàngToolStripMenuItem_Click);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.thêmToolStripMenuItem.Text = "Thêm - sửa - xóa TTKH";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // dịchVụKháchHàngToolStripMenuItem
            // 
            this.dịchVụKháchHàngToolStripMenuItem.Name = "dịchVụKháchHàngToolStripMenuItem";
            this.dịchVụKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.dịchVụKháchHàngToolStripMenuItem.Text = "Dịch vụ khách hàng";
            this.dịchVụKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.dịchVụKháchHàngToolStripMenuItem_Click);
            // 
            // NHANVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_TenNV);
            this.Controls.Add(this.lb_Phienlamviec);
            this.Controls.Add(this.menu_nhanvien);
            this.MainMenuStrip = this.menu_nhanvien;
            this.Name = "NHANVIEN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHANVIEN";
            this.Load += new System.EventHandler(this.NHANVIEN_Load);
            this.menu_nhanvien.ResumeLayout(false);
            this.menu_nhanvien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Phienlamviec;
        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.MenuStrip menu_nhanvien;
        private System.Windows.Forms.ToolStripMenuItem thôngTinKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dịchVụKháchHàngToolStripMenuItem;
    }
}