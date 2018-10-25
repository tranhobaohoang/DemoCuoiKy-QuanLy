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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
       // SqlConnection conn = new SqlConnection("Data Source=VAIO-SONY;Initial Catalog=QLKD;User ID=sa; Password=123");
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Screen_DN dn = new Screen_DN();
            dn.ShowDialog();
            /*Screen_DN screen_DN = new Screen_DN();
            screen_DN.ShowDialog();*/
        }

        private void tinTứcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
