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

namespace QuanLySuaXe
{
    public partial class Form1 : Form
    {
        string strConnectString = @"Data Source=DESKTOP-DLOT65Q\SQLEXPRESS;Initial Catalog=QuanLySuaXe;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter daXe = null;
        SqlDataAdapter daKhachhang = null;
        DataTable dtXe = null;
        DataTable dtKhachHang = null;
        bool Them;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLySuaXeDataSet.Xe' table. You can move, or remove it, as needed.
            this.xeTableAdapter.Fill(this.quanLySuaXeDataSet.Xe);
            // TODO: This line of code loads data into the 'quanLySuaXeDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.quanLySuaXeDataSet.KhachHang);
            // TODO: This line of code loads data into the 'quanLySuaXeDataSet.KhachHang' table. You can move, or remove it, as needed.
            //this.khachHangTableAdapter.Fill(this.quanLySuaXeDataSet.KhachHang);
            // TODO: This line of code loads data into the 'quanLySuaXeDataSet1.KhachHang' table. You can move, or remove it, as needed.
            //this.khachHangTableAdapter1.Fill(this.quanLySuaXeDataSet.KhachHang);
            // TODO: This line of code loads data into the 'quanLySuaXeDataSet1.Xe' table. You can move, or remove it, as needed.


            try
            {
                conn = new SqlConnection(strConnectString);

                daXe = new SqlDataAdapter("Select * From Xe", conn);
                dtXe = new DataTable();
                dtXe.Clear();
                daXe.Fill(dtXe);
                dgvXe.DataSource = dtXe;


                daKhachhang = new SqlDataAdapter("Select * From KhachHang", conn);
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();
                daKhachhang.Fill(dtKhachHang);
                dgvKhachHang.DataSource = dtKhachHang;

                // Đưa dữ liệu lên ComboBox
                this.cbKhachHang.DataSource = dtKhachHang;
                this.cbKhachHang.DisplayMember = "TenKH";
                this.cbKhachHang.ValueMember = "MaKH";

                
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Xe và KhachHang .Lỗi rồi!!!");
            }
        }
        private void Form1_Closing(object sender, EventArgs e)
        {
            dtKhachHang.Dispose();
            dtKhachHang = null;
            dtXe.Dispose();
            dtXe = null;
            conn.Close();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult TraLoi;
            TraLoi = MessageBox.Show("Chắc không?", " Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (TraLoi == DialogResult.OK) Application.Exit();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                int r = dgvKhachHang.CurrentCell.RowIndex;
                string strMKH = dgvKhachHang.Rows[r].Cells[0].Value.ToString();
                cmd.CommandText = String.Concat("Delete From KhachHang where MaKH='" + strMKH + "'");
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                //LoadData();
                MessageBox.Show("Xoa Thanh Cong");
            }
            catch (SqlException)
            {
                MessageBox.Show("Khong The xoa, Da Bi Loi");
            }
            conn.Close();
        }
        private void bInsertKH_Click(object sender, EventArgs e)
        {
            Them = true;
            this.txtMaKH.ResetText();
            this.txtTenKH.ResetText();
            this.txtThanhPho.ResetText();
            this.txtSoDT.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.bSave.Enabled = true;
            this.bCancel.Enabled = true;
            this.bDelete.Enabled = true;
            this.panel1.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.bInsert.Enabled = false;
            this.brepair.Enabled = false;
            this.bDelete.Enabled = false;
            this.btExit.Enabled = false;
            // Đưa dữ liệu lên ComboBox
            this.cbKhachHang.DataSource = dtKhachHang;
            this.cbKhachHang.DisplayMember = "TenKH";
            this.cbKhachHang.ValueMember = "MaKH";
            // Đưa con trỏ đến TextField txtMaKH
            this.txtMaKH.Focus();
        }
        private void bInsertXE_Click(object sender, EventArgs e)
        {
            Them = true;
            this.txtMaXe.ResetText();
            this.txtTenXe.ResetText();
            this.txtHang.ResetText();
            this.comboBoxMaKH.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.bSave.Enabled = true;
            this.bCancel.Enabled = true;
            this.bDelete.Enabled = true;
            this.panel1.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.bInsert.Enabled = false;
            this.brepair.Enabled = false;
            this.bDelete.Enabled = false;
            this.btExit.Enabled = false;
            // Đưa dữ liệu lên ComboBox
            this.cbKhachHang.DataSource = dtKhachHang;
            this.cbKhachHang.DisplayMember = "TenKH";
            this.cbKhachHang.ValueMember = "MaKH";
            // Đưa con trỏ đến TextField txtMaKH
            this.txtMaKH.Focus();
        }
        private void bSaveKH_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            if (Them)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = String.Concat("INSERT Into KhachHang Values(" + "'" + this.txtMaKH.Text.ToString() + "'," +
                        "'" + this.txtTenKH.Text.ToString() + "'," +
                        "'" + this.txtThanhPho.Text.ToString() + "'," +
                        //"'" + this.txtSoDT.SelectedValue.ToString() + "'," +
                        "'" + this.txtSoDT.Text.ToString() + "')");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    LoadDataXE();
                    MessageBox.Show("Successfully ");

                }
                catch (SqlException)
                {
                    MessageBox.Show("Dont Save, Please try again");
                }
            }

            if (!Them)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    int r = dgvKhachHang.CurrentCell.RowIndex;
                    string strMaKH = dgvKhachHang.Rows[r].Cells[0].Value.ToString();
                    cmd.CommandText = String.Concat("Update KhachHang Set TenKH='" + this.txtTenKH.Text.ToString() + "',"
                        + "ThanhPho='" + this.txtThanhPho.Text.ToString() + "',"
                      //  + "ThanhPho='" + this.T.SelectedValue.ToString() + "',"
                        + "SoDT='" + this.txtSoDT.Text.ToString() + "'"
                        + "Where MaKH='" + strMaKH + "'");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    LoadDataKH();
                    MessageBox.Show("Successfully");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Fail , Please try again");
                }
            }
            conn.Close();
        }
        private void bSaveXE_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            if (Them)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = String.Concat("INSERT Into Xe Values(" + "'" + this.txtMaXe.Text.ToString() + "'," +
                        "'" + this.txtTenXe.Text.ToString() + "'," +
                        "'" + this.txtHang.Text.ToString() + "'," +
                        //"'" + this.txtSoDT.SelectedValue.ToString() + "'," +
                        "'" + this.txtSoDT.Text.ToString() + "')");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    LoadDataXE();
                    MessageBox.Show("Successfully ");

                }
                catch (SqlException)
                {
                    MessageBox.Show("Dont Save, Please try again");
                }
            }

            if (!Them)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    int r = dgvXe.CurrentCell.RowIndex;
                    string strMaXe = dgvXe.Rows[r].Cells[0].Value.ToString();
                    cmd.CommandText = String.Concat("Update Xe Set TenXe='" + this.txtTenXe.Text.ToString() + "',"
                        + "HangXe='" + this.txtHang.Text.ToString() + "',"
                        + "KhachHang='" + this.comboBoxMaKH.SelectedValue.ToString() + "',"
                        + "Where MaKH='" + strMaXe + "'");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    LoadDataKH();
                    MessageBox.Show("Successfully");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Fail , Please try again");
                }
            }
            conn.Close();
        }
        public void LoadDataKH()
        {
            conn = new SqlConnection(strConnectString);
            

            daKhachhang = new SqlDataAdapter("Select * From KhachHang", conn);
            dtKhachHang = new DataTable();
            dtKhachHang.Clear();
            daKhachhang.Fill(dtKhachHang);
            dgvKhachHang.DataSource = dtKhachHang;
            this.bSave.Enabled = false;
            this.bCancel.Enabled = false;
            this.panel1.Enabled = false;
            this.bDelete.Enabled = true;
            this.bReLoad.Enabled = true;
            this.brepair.Enabled = true;
            this.bInsert.Enabled = true;
            this.btExit.Enabled = true;
            this.txtThanhPho.ResetText();
            this.txtSoDT.ResetText();
            this.txtMaKH.ResetText();
            this.txtTenKH.ResetText();
        }
        public void LoadDataXE()
        {
            conn = new SqlConnection(strConnectString);
           

            daXe = new SqlDataAdapter("Select * From KHACHHANG", conn);
            dtXe = new DataTable();
            dtXe.Clear();
            daXe.Fill(dtXe);
            dgvXe.DataSource = dtXe;
            this.bSave.Enabled = false;
            this.bCancel.Enabled = false;
            this.panel1.Enabled = false;
            this.bDelete.Enabled = true;
            this.bReLoad.Enabled = true;
            this.brepair.Enabled = true;
            this.bInsert.Enabled = true;
            this.btExit.Enabled = true;
            this.txtThanhPho.ResetText();
            this.txtSoDT.ResetText();
            this.txtMaKH.ResetText();
            this.txtTenKH.ResetText();
        }
        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void khachHangBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Mode_Click(object sender, EventArgs e)
        {
            btMode.Text = ((btMode.Text == "Khách hàng") ? ("Xe") : ("Khách hàng"));
           
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            if(btMode.Text =="Khách hàng")
            {
                bInsertKH_Click(sender,e);
            }
            else
            {
                bInsertXE_Click(sender, e);
            }
        }
        private void bSave_Click(object sender, EventArgs e)
        {
            if (btMode.Text == "Khách hàng")
            {
                bSaveKH_Click(sender, e);
            }
            else
            {
                bSaveXE_Click(sender, e);
            }
        }
    }
}
