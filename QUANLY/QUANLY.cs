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
    public partial class QUANLY : Form
    {
        public QUANLY()
        {
            InitializeComponent();
        }

        private void QUANLY_Load(object sender, EventArgs e)
        {
            if (Screen_DN.LOAITK == "2")
            {
                MessageBox.Show("Xin chào Quản lý đẹp trai xinh gái:  ");
            }
        }

        private void thêmSửaXóaNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TTNV ttnv = new TTNV();
            ttnv.ShowDialog();
        }
    }
}
