using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyCatToc
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyCatTocDB;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDichVu();
            LoadLichHen();
        }

        private void LoadDichVu()
        {
            string query = "SELECT * FROM DichVu";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbDichVu.DataSource = dt;
                cbDichVu.DisplayMember = "TenDichVu";
                cbDichVu.ValueMember = "MaDichVu";
            }
        }

        private void LoadLichHen()
        {
            string query = "SELECT lh.MaLich, lh.TenKhachHang, lh.SoDienThoai, lh.NgayGioHen, dv.TenDichVu FROM LichHen lh JOIN DichVu dv ON lh.MaDichVu = dv.MaDichVu";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDanhSachLich.DataSource = dt;
            }
        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO LichHen (TenKhachHang, SoDienThoai, NgayGioHen, MaDichVu) VALUES (@Ten, @SDT, @Ngay, @MaDV)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ten", txtTenKhach.Text);
                cmd.Parameters.AddWithValue("@SDT", txtSoDienThoai.Text);
                cmd.Parameters.AddWithValue("@Ngay", dtpNgayHen.Value);
                cmd.Parameters.AddWithValue("@MaDV", cbDichVu.SelectedValue);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Đặt lịch thành công!");
            LoadLichHen();
        }
    }
}