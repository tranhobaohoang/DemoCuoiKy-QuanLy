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
    public partial class TTNV : Form
    {
        public TTNV()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void TTNV_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QLKD"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            Hienthi();
        }

        public void Hienthi()
        {
            string sqlSELECT = "SELECT MaNV,TenNV,EmailNV,SdtNV FROM NHANVIEN";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv_nv.DataSource = dt;
        }

        private void TTNV_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void btn_themnv_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO NHANVIEN VALUES(@MaNV,@TenNV,@EmailNV,@SdtNV,@LoaiTK)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, con);
            cmd.Parameters.AddWithValue("MaNV", txt_manv.Text);
            cmd.Parameters.AddWithValue("TenNV", txt_tennv.Text);
            cmd.Parameters.AddWithValue("EmailNV", txt_emailnv.Text);
            cmd.Parameters.AddWithValue("SdtNV", txt_sdtnv.Text);
            cmd.Parameters.AddWithValue("LoaiTK", 1);
            txt_manv.Text = ""; txt_tennv.Text = "";
            txt_emailnv.Text = ""; txt_sdtnv.Text = "";
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btn_xoanv_Click(object sender, EventArgs e)
        {
            string sqlDelete = "DELETE FROM NHANVIEN WHERE MaNV=@MaNV";
            SqlCommand cmd = new SqlCommand(sqlDelete, con);
            cmd.Parameters.AddWithValue("MaNV", dgv_nv.CurrentRow.Cells[0].Value);
            //cmd.Parameters.AddWithValue("MaNV", txt_manv);
            /*cmd.Parameters.AddWithValue("TenKH", txt_TenKH.Text);
            cmd.Parameters.AddWithValue("EmailKH", txt_EmailKH.Text);
            cmd.Parameters.AddWithValue("SdtKH", txt_SdtKH.Text);*/
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btn_suanv_Click(object sender, EventArgs e)
        {
            string sqlEdit = "UPDATE NHANVIEN SET TenNV=@TenNV,EmailNV=@EmailNV,SdtNV=@SdtNV WHERE MaNV=@MaNV";
            SqlCommand cmd = new SqlCommand(sqlEdit, con);
            cmd.Parameters.AddWithValue("MaNV", txt_manv.Text);
            cmd.Parameters.AddWithValue("TenNV", txt_tennv.Text);
            cmd.Parameters.AddWithValue("EmailNV", txt_emailnv.Text);
            cmd.Parameters.AddWithValue("SdtNV", txt_sdtnv.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }
    }
}
