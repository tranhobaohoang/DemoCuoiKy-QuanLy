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
    public partial class TTKH : Form
    {
        public TTKH()
        {
            InitializeComponent();
        }
        SqlConnection con;

        private void TTKH_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QLKD"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            Hienthi();
        }

        private void TTKH_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
        public void Hienthi()
        {
            string sqlSELECT = "SELECT * FROM KHACHHANG";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv_KH.DataSource = dt; 
        }

        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO KHACHHANG VALUES(@MaKH,@TenKH,@EmailKH,@SdtKH)";
            SqlCommand cmd = new SqlCommand(sqlINSERT,con);
            cmd.Parameters.AddWithValue("MaKH",txt_maKH.Text);
            cmd.Parameters.AddWithValue("TenKH", txt_TenKH.Text);
            cmd.Parameters.AddWithValue("EmailKH", txt_EmailKH.Text);
            cmd.Parameters.AddWithValue("SdtKH", txt_SdtKH.Text);
            txt_maKH.Text = "";
            txt_SdtKH.Text = "";
            txt_EmailKH.Text = "";
            txt_TenKH.Text = "";
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btn_SuaKH_Click(object sender, EventArgs e)
        {
            string sqlEdit = "UPDATE KHACHHANG SET TenKH=@TenKH,EmailKH=@EmailKH,SdtKH=@SdtKH WHERE MaKH=@MaKH";
            SqlCommand cmd = new SqlCommand(sqlEdit, con);
            cmd.Parameters.AddWithValue("MaKH", txt_maKH.Text);
            cmd.Parameters.AddWithValue("TenKH", txt_TenKH.Text);
            cmd.Parameters.AddWithValue("EmailKH", txt_EmailKH.Text);
            cmd.Parameters.AddWithValue("SdtKH", txt_SdtKH.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btn_XoaKH_Click(object sender, EventArgs e)
        {
            string sqlDelete = "DELETE FROM KHACHHANG WHERE MaKH=@MaKH";
            SqlCommand cmd = new SqlCommand(sqlDelete, con);
            cmd.Parameters.AddWithValue("MaKH", dgv_KH.CurrentRow.Cells[0].Value);
            /*cmd.Parameters.AddWithValue("MaKH", txt_maKH.Text);
            cmd.Parameters.AddWithValue("TenKH", txt_TenKH.Text);
            cmd.Parameters.AddWithValue("EmailKH", txt_EmailKH.Text);
            cmd.Parameters.AddWithValue("SdtKH", txt_SdtKH.Text);*/
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            string sqlSearch = "SELECT *FROM KHACHHANG WHERE SdtKH=@SdtKH OR MaKH=@MaKH";
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            cmd.Parameters.AddWithValue("SdtKH", txt_Search.Text);
            cmd.Parameters.AddWithValue("MaKH", txt_Search.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv_KH.DataSource = dt;
        }
    }
}
