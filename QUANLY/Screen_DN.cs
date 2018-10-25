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
using System.Configuration;

namespace QUANLY
{
    public partial class Screen_DN : Form
    {
        public Screen_DN()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Screen_DN_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QLKD"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
        }
        private string getID(string username, string pass)
        {
            string id = "";
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM TENDN_MK WHERE TENDN ='" + username + "' and MK='" + pass + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["LoaiTK"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            return id;
        }
        public static string LOAITK = "";

        private void btb_Dangnhap_Click(object sender, EventArgs e)
        {
                LOAITK = getID(txt_Tendangnhap.Text, txt_Matkhau.Text);
                if (LOAITK != "" && LOAITK == "1")
                {
                    NHANVIEN nv = new NHANVIEN();
                    nv.Show();
                }
                else if (LOAITK != "" && LOAITK == "2")
                {
                    QUANLY ql = new QUANLY();
                    ql.Show();
                }         
                else
                {
                    MessageBox.Show("Tài khoản và mật khẩu không đúng !");
                }
        }
               
        private void Screen_DN_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
    }
}
