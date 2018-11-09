namespace QUANLY
{
    partial class TTNV
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
            this.lb_manv = new System.Windows.Forms.Label();
            this.lb_tennv = new System.Windows.Forms.Label();
            this.lb_sdtnv = new System.Windows.Forms.Label();
            this.lb_emailnv = new System.Windows.Forms.Label();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.txt_sdtnv = new System.Windows.Forms.TextBox();
            this.txt_emailnv = new System.Windows.Forms.TextBox();
            this.dgv_nv = new System.Windows.Forms.DataGridView();
            this.grb_nv = new System.Windows.Forms.GroupBox();
            this.btn_xoanv = new System.Windows.Forms.Button();
            this.btn_suanv = new System.Windows.Forms.Button();
            this.btn_themnv = new System.Windows.Forms.Button();
            this.btn_timkiemnv = new System.Windows.Forms.Button();
            this.txt_timkiemnv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nv)).BeginInit();
            this.grb_nv.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_manv
            // 
            this.lb_manv.AutoSize = true;
            this.lb_manv.Location = new System.Drawing.Point(28, 28);
            this.lb_manv.Name = "lb_manv";
            this.lb_manv.Size = new System.Drawing.Size(75, 13);
            this.lb_manv.TabIndex = 0;
            this.lb_manv.Text = "Mã nhân viên:";
            // 
            // lb_tennv
            // 
            this.lb_tennv.AutoSize = true;
            this.lb_tennv.Location = new System.Drawing.Point(28, 56);
            this.lb_tennv.Name = "lb_tennv";
            this.lb_tennv.Size = new System.Drawing.Size(79, 13);
            this.lb_tennv.TabIndex = 0;
            this.lb_tennv.Text = "Tên nhân viên:";
            // 
            // lb_sdtnv
            // 
            this.lb_sdtnv.AutoSize = true;
            this.lb_sdtnv.Location = new System.Drawing.Point(28, 82);
            this.lb_sdtnv.Name = "lb_sdtnv";
            this.lb_sdtnv.Size = new System.Drawing.Size(73, 13);
            this.lb_sdtnv.TabIndex = 0;
            this.lb_sdtnv.Text = "Số điện thoại:";
            // 
            // lb_emailnv
            // 
            this.lb_emailnv.AutoSize = true;
            this.lb_emailnv.Location = new System.Drawing.Point(28, 107);
            this.lb_emailnv.Name = "lb_emailnv";
            this.lb_emailnv.Size = new System.Drawing.Size(35, 13);
            this.lb_emailnv.TabIndex = 0;
            this.lb_emailnv.Text = "Email:";
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(141, 27);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(256, 20);
            this.txt_manv.TabIndex = 1;
            // 
            // txt_tennv
            // 
            this.txt_tennv.Location = new System.Drawing.Point(141, 53);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(256, 20);
            this.txt_tennv.TabIndex = 1;
            // 
            // txt_sdtnv
            // 
            this.txt_sdtnv.Location = new System.Drawing.Point(141, 79);
            this.txt_sdtnv.Name = "txt_sdtnv";
            this.txt_sdtnv.Size = new System.Drawing.Size(256, 20);
            this.txt_sdtnv.TabIndex = 1;
            // 
            // txt_emailnv
            // 
            this.txt_emailnv.Location = new System.Drawing.Point(141, 105);
            this.txt_emailnv.Name = "txt_emailnv";
            this.txt_emailnv.Size = new System.Drawing.Size(256, 20);
            this.txt_emailnv.TabIndex = 1;
            // 
            // dgv_nv
            // 
            this.dgv_nv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nv.Location = new System.Drawing.Point(29, 151);
            this.dgv_nv.Name = "dgv_nv";
            this.dgv_nv.Size = new System.Drawing.Size(711, 202);
            this.dgv_nv.TabIndex = 2;
            // 
            // grb_nv
            // 
            this.grb_nv.Controls.Add(this.btn_xoanv);
            this.grb_nv.Controls.Add(this.btn_suanv);
            this.grb_nv.Controls.Add(this.btn_themnv);
            this.grb_nv.Location = new System.Drawing.Point(449, 30);
            this.grb_nv.Name = "grb_nv";
            this.grb_nv.Size = new System.Drawing.Size(274, 94);
            this.grb_nv.TabIndex = 3;
            this.grb_nv.TabStop = false;
            this.grb_nv.Text = "Điều khiển";
            // 
            // btn_xoanv
            // 
            this.btn_xoanv.Location = new System.Drawing.Point(37, 58);
            this.btn_xoanv.Name = "btn_xoanv";
            this.btn_xoanv.Size = new System.Drawing.Size(73, 28);
            this.btn_xoanv.TabIndex = 0;
            this.btn_xoanv.Text = "Xóa";
            this.btn_xoanv.UseVisualStyleBackColor = true;
            this.btn_xoanv.Click += new System.EventHandler(this.btn_xoanv_Click);
            // 
            // btn_suanv
            // 
            this.btn_suanv.Location = new System.Drawing.Point(157, 23);
            this.btn_suanv.Name = "btn_suanv";
            this.btn_suanv.Size = new System.Drawing.Size(73, 28);
            this.btn_suanv.TabIndex = 0;
            this.btn_suanv.Text = "Sửa";
            this.btn_suanv.UseVisualStyleBackColor = true;
            this.btn_suanv.Click += new System.EventHandler(this.btn_suanv_Click);
            // 
            // btn_themnv
            // 
            this.btn_themnv.Location = new System.Drawing.Point(37, 24);
            this.btn_themnv.Name = "btn_themnv";
            this.btn_themnv.Size = new System.Drawing.Size(73, 28);
            this.btn_themnv.TabIndex = 0;
            this.btn_themnv.Text = "Thêm";
            this.btn_themnv.UseVisualStyleBackColor = true;
            this.btn_themnv.Click += new System.EventHandler(this.btn_themnv_Click);
            // 
            // btn_timkiemnv
            // 
            this.btn_timkiemnv.Location = new System.Drawing.Point(667, 131);
            this.btn_timkiemnv.Name = "btn_timkiemnv";
            this.btn_timkiemnv.Size = new System.Drawing.Size(73, 20);
            this.btn_timkiemnv.TabIndex = 0;
            this.btn_timkiemnv.Text = "Tìm Kiếm";
            this.btn_timkiemnv.UseVisualStyleBackColor = true;
            // 
            // txt_timkiemnv
            // 
            this.txt_timkiemnv.Location = new System.Drawing.Point(389, 131);
            this.txt_timkiemnv.Name = "txt_timkiemnv";
            this.txt_timkiemnv.Size = new System.Drawing.Size(258, 20);
            this.txt_timkiemnv.TabIndex = 4;
            // 
            // TTNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_timkiemnv);
            this.Controls.Add(this.txt_timkiemnv);
            this.Controls.Add(this.grb_nv);
            this.Controls.Add(this.dgv_nv);
            this.Controls.Add(this.txt_emailnv);
            this.Controls.Add(this.txt_sdtnv);
            this.Controls.Add(this.txt_tennv);
            this.Controls.Add(this.txt_manv);
            this.Controls.Add(this.lb_emailnv);
            this.Controls.Add(this.lb_tennv);
            this.Controls.Add(this.lb_sdtnv);
            this.Controls.Add(this.lb_manv);
            this.Name = "TTNV";
            this.Text = "TTNV";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TTNV_FormClosing);
            this.Load += new System.EventHandler(this.TTNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nv)).EndInit();
            this.grb_nv.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_manv;
        private System.Windows.Forms.Label lb_tennv;
        private System.Windows.Forms.Label lb_sdtnv;
        private System.Windows.Forms.Label lb_emailnv;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.TextBox txt_sdtnv;
        private System.Windows.Forms.TextBox txt_emailnv;
        private System.Windows.Forms.DataGridView dgv_nv;
        private System.Windows.Forms.GroupBox grb_nv;
        private System.Windows.Forms.Button btn_timkiemnv;
        private System.Windows.Forms.Button btn_xoanv;
        private System.Windows.Forms.Button btn_suanv;
        private System.Windows.Forms.Button btn_themnv;
        private System.Windows.Forms.TextBox txt_timkiemnv;
    }
}