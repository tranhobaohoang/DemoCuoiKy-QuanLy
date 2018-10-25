using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QUANLY
{
    public partial class NHANVIEN : Form
    {
        public NHANVIEN()
        {
            InitializeComponent();
        }
        
        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TTKH ttkh = new TTKH();
            ttkh.ShowDialog();
        }

        private void dịchVụKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DICHVU_KH dv = new DICHVU_KH();
            dv.ShowDialog();
        }

        private void NHANVIEN_Load(object sender, EventArgs e)
        {
            if(Screen_DN.LOAITK=="1")
            {
                MessageBox.Show("Xin chào nhân viên: " );
            }
            if(Screen_DN.LOAITK == "2")
            {
                MessageBox.Show("Xin chào Quản lý đẹp trai xinh gái: mời xem lại code---SAI FORM NHANVIEN ");
                //this.Close();

            }
            // thêm tên nhân viên và quản lý vào ở trên
        }
    }
}
