namespace QUANLY
{
    partial class Screen_DN
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
            this.txt_Matkhau = new System.Windows.Forms.TextBox();
            this.txt_Tendangnhap = new System.Windows.Forms.TextBox();
            this.lb_Tendangnhap = new System.Windows.Forms.Label();
            this.lb_Matkhau = new System.Windows.Forms.Label();
            this.lb_Dangnhap = new System.Windows.Forms.Label();
            this.btb_Dangnhap = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Matkhau
            // 
            this.txt_Matkhau.Location = new System.Drawing.Point(158, 80);
            this.txt_Matkhau.Name = "txt_Matkhau";
            this.txt_Matkhau.Size = new System.Drawing.Size(271, 20);
            this.txt_Matkhau.TabIndex = 0;
            this.txt_Matkhau.UseSystemPasswordChar = true;
            // 
            // txt_Tendangnhap
            // 
            this.txt_Tendangnhap.Location = new System.Drawing.Point(158, 50);
            this.txt_Tendangnhap.Name = "txt_Tendangnhap";
            this.txt_Tendangnhap.Size = new System.Drawing.Size(271, 20);
            this.txt_Tendangnhap.TabIndex = 0;
            // 
            // lb_Tendangnhap
            // 
            this.lb_Tendangnhap.AutoSize = true;
            this.lb_Tendangnhap.Location = new System.Drawing.Point(35, 57);
            this.lb_Tendangnhap.Name = "lb_Tendangnhap";
            this.lb_Tendangnhap.Size = new System.Drawing.Size(84, 13);
            this.lb_Tendangnhap.TabIndex = 1;
            this.lb_Tendangnhap.Text = "Tên Đăng Nhập";
            // 
            // lb_Matkhau
            // 
            this.lb_Matkhau.AutoSize = true;
            this.lb_Matkhau.Location = new System.Drawing.Point(35, 83);
            this.lb_Matkhau.Name = "lb_Matkhau";
            this.lb_Matkhau.Size = new System.Drawing.Size(53, 13);
            this.lb_Matkhau.TabIndex = 1;
            this.lb_Matkhau.Text = "Mật Khẩu";
            // 
            // lb_Dangnhap
            // 
            this.lb_Dangnhap.AutoSize = true;
            this.lb_Dangnhap.Location = new System.Drawing.Point(207, 9);
            this.lb_Dangnhap.Name = "lb_Dangnhap";
            this.lb_Dangnhap.Size = new System.Drawing.Size(62, 13);
            this.lb_Dangnhap.TabIndex = 1;
            this.lb_Dangnhap.Text = "Đăng Nhập";
            // 
            // btb_Dangnhap
            // 
            this.btb_Dangnhap.Location = new System.Drawing.Point(123, 132);
            this.btb_Dangnhap.Name = "btb_Dangnhap";
            this.btb_Dangnhap.Size = new System.Drawing.Size(118, 43);
            this.btb_Dangnhap.TabIndex = 2;
            this.btb_Dangnhap.Text = "Đăng Nhập";
            this.btb_Dangnhap.UseVisualStyleBackColor = true;
            this.btb_Dangnhap.Click += new System.EventHandler(this.btb_Dangnhap_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(247, 132);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(118, 43);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // Screen_DN
            // 
            this.AcceptButton = this.btb_Dangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 210);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btb_Dangnhap);
            this.Controls.Add(this.lb_Dangnhap);
            this.Controls.Add(this.lb_Matkhau);
            this.Controls.Add(this.lb_Tendangnhap);
            this.Controls.Add(this.txt_Tendangnhap);
            this.Controls.Add(this.txt_Matkhau);
            this.Name = "Screen_DN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screen_DN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Screen_DN_FormClosing);
            this.Load += new System.EventHandler(this.Screen_DN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Matkhau;
        private System.Windows.Forms.TextBox txt_Tendangnhap;
        private System.Windows.Forms.Label lb_Tendangnhap;
        private System.Windows.Forms.Label lb_Matkhau;
        private System.Windows.Forms.Label lb_Dangnhap;
        private System.Windows.Forms.Button btb_Dangnhap;
        private System.Windows.Forms.Button btn_Thoat;
    }
}