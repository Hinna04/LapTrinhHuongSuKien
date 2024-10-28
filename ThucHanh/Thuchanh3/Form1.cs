using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanh3
{
    public partial class Form1 : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();
        //private string[] items = { "Lăn kim", "Triệt lông", "Nâng mũi", "Cắt môi trái tim", "Cắt mi mắt", "Xăm lông mày", "Xăm môi" };
        //private string selectedItem;
        //SqlConnection conn = new SqlConnection();

        string connectionString = ConfigurationManager
                                      .ConnectionStrings["ThamMyVien"]
                                      .ConnectionString;
        SqlConnection KetNoi;
        SqlCommand ThucHien;
        SqlDataReader DocDuLieu;
        string Lenh;
        int i;

        public Form1()
        {
            InitializeComponent();
            KetNoi = new SqlConnection(connectionString);
            Lenh = @"select MaBN from tblBenhNhan";
            KetNoi.Open();
            ThucHien = new SqlCommand(Lenh, KetNoi);
            DocDuLieu = ThucHien.ExecuteReader();
            i = 0;
            while (DocDuLieu.Read())
            {
                cb_mabn.Items.Add((i + 1).ToString());
                //cb_mabn.Items[i].SubItems.Add(DocDuLieu[0].ToString());
                i++;
            }
            KetNoi.Close();
            /*// Tạo kết nối
            SqlConnection conn = new SqlConnection(connectionString);

            // Tạo SqlCommand
            SqlCommand command = new SqlCommand("select * from tblBenhNhan", conn);

            // Mở kết nối
            conn.Open();

            // Đọc dữ liệu
            SqlDataReader reader = command.ExecuteReader();

            // Gán dữ liệu vào combobox
            while (reader.Read())
            {
                cb_mabn.Items.Add(reader["MaBN"]);
                cb_dichvu.Items.Add(reader["TenBN"]);
            }

            // Đóng kết nối
            conn.Close();

            // Tạo DataContext
            DataContext db = new DataContext(connectionString);

            // Truy vấn dữ liệu
            var bn = from c in db.
                     select c.MaBN;

            // Gán dữ liệu vào combobox
            cb_mabn.DataSource = bn;
            cb_mabn.DisplayMember = "MaBN";
            */
        }
        /*
        void LoadComboBox()
        {
            var cmd = new SqlCommand("select MaBN from tblBenhNhan", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cb_mabn.DataSource = dt;
            cb_dichvu.DataSource = dt;
        }*/

        
        /*
        public static bool UpdateBenhNhan(string connectionStrings, string mabn, string tenbn)
        {
            string Update_proc = "Update_BenhNhan";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = Update_proc;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@mabn", SqlDbType.Int).Value = mabn;
                    cmd.Parameters.AddWithValue("@tenbn", tenbn);
                    conn.Open();

                    conn.Close();
                }
            }
        }
        */


        private void cb_dichvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = cb_dichvu.Text;
            //selectedItem = cb_dichvu.SelectedItem.ToString();
            rtb_dsdv.AppendText($"{text}\n"); 
            rtb_nhan.AppendText($"{text}. ");
            //rtb_dsdv.Text = selectedItem;
            if (this.cb_dichvu.Text.Length > 0)
            {
                btn_chon.Enabled = true;
            }
            else
            {
                btn_chon.Enabled = false;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_ten_TextChanged(object sender, EventArgs e)
        {
            if (this.tb_ten.Text.Length > 0)
            {
                btn_chon.Enabled = true;
            }
            else
            {
                btn_chon.Enabled = false;
            }
            UpdateButtonStatus();
        }
        private void tb_ten_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_ten.Text))
            {
                //e.Cancel = true;
                errorProvider.SetError(tb_ten, "Họ tên bệnh nhân không được để trống!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider.SetError(tb_ten, null);
            }
        }

        private void tb_ngay_TextChanged(object sender, EventArgs e)
        {
            TextBox tb_n = (TextBox)sender;
            string text = tb_n.Text;

            // Lặp qua từng ký tự trong văn bản và chỉ giữ lại ký tự số
            string numericText = "";
            foreach (char c in text)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    numericText += c;
                }
            }

            // Đặt lại văn bản của TextBox thành chỉ chứa ký tự số
            tb_n.Text = numericText;

            // Di chuyển con trỏ đến cuối TextBox để người dùng có thể tiếp tục nhập
            tb_n.SelectionStart = tb_n.Text.Length;

            TextBox textBox = (TextBox)sender;
            if (!string.IsNullOrWhiteSpace(tb_thang.Text) && !string.IsNullOrWhiteSpace(tb_nam.Text))
            {
                if (int.TryParse(textBox.Text, out int enteredNumber) && enteredNumber > 0)
                {
                    if (enteredNumber > 28)
                    {
                        if (int.TryParse(tb_nam.Text, out int enteredNumber1) && enteredNumber1 % 4 == 0)
                        {
                            if (int.TryParse(tb_thang.Text, out int enteredNumber2) && enteredNumber2 == 2)
                            {
                                textBox.Text = "29";
                            }
                            else if (enteredNumber2 % 2 == 0 && enteredNumber2 != 2)
                            {
                                textBox.Text = "30";
                            }
                            else if (enteredNumber2 % 2 != 0 && enteredNumber2 != 2)
                            {
                                textBox.Text = "31";
                            }
                        }
                        else
                        {
                            if (enteredNumber1 % 4 != 0)
                            {
                                if (int.TryParse(tb_thang.Text, out int enteredNumber2) && enteredNumber2 == 2)
                                {
                                    textBox.Text = "28";
                                }
                                else if (enteredNumber2 % 2 == 0 && enteredNumber2 != 2)
                                {
                                    textBox.Text = "30";
                                }
                                else
                                {
                                    textBox.Text = "31";
                                }
                            }
                        }
                    }
                }
                else if (!string.IsNullOrWhiteSpace(tb_n.Text))
                {
                    MessageBox.Show("Ngày không được bằng 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập tháng năm, không thể xác định ngày!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            UpdateButtonStatus();
            if (this.tb_ngay.Text.Length > 0)
            {
                btn_chon.Enabled = true;
            }
            else
            {
                btn_chon.Enabled = false;
            }  
        }

        private void tb_ngay_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_ngay.Text))
            {
                //e.Cancel = true;
                errorProvider.SetError(tb_ngay, "Ngày không được để trống!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider.SetError(tb_ngay, null);
            }
        }

        private void tb_thang_TextChanged(object sender, EventArgs e)
        {
            TextBox tb_n = (TextBox)sender;
            string text = tb_n.Text;

            // Lặp qua từng ký tự trong văn bản và chỉ giữ lại ký tự số
            string numericText = "";
            foreach (char c in text)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    numericText += c;
                }
            }

            // Đặt lại văn bản của TextBox thành chỉ chứa ký tự số
            tb_n.Text = numericText;

            // Di chuyển con trỏ đến cuối TextBox để người dùng có thể tiếp tục nhập
            tb_n.SelectionStart = tb_n.Text.Length;

            TextBox textBox = (TextBox)sender;
            // Kiểm tra nếu giá trị là số và lớn hơn 10
            if (int.TryParse(textBox.Text, out int enteredNumber) && enteredNumber > 12)
            {
                if (enteredNumber > 0)
                {
                    // Nếu lớn hơn 10, đặt giá trị của textbox thành 10
                    textBox.Text = "12";
                }
                else if (!string.IsNullOrWhiteSpace(tb_thang.Text))
                {
                    MessageBox.Show("Tháng không được bằng 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            UpdateButtonStatus();
            if (this.tb_thang.Text.Length > 0)
            {
                btn_chon.Enabled = true;
            }
            else
            {
                btn_chon.Enabled = false;
            }         
        }

        private void tb_thang_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_thang.Text))
            {
                //e.Cancel = true;
                errorProvider.SetError(tb_thang, "Tháng không được để trống!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider.SetError(tb_thang, null);
            }
        }

        private void tb_nam_TextChanged(object sender, EventArgs e)
        {
            TextBox tb_ngay = (TextBox)sender;
            string text = tb_ngay.Text;

            // Lặp qua từng ký tự trong văn bản và chỉ giữ lại ký tự số
            string numericText = "";
            foreach (char c in text)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    numericText += c;
                }
            }

            // Đặt lại văn bản của TextBox thành chỉ chứa ký tự số
            tb_ngay.Text = numericText;

            // Di chuyển con trỏ đến cuối TextBox để người dùng có thể tiếp tục nhập
            tb_ngay.SelectionStart = tb_ngay.Text.Length;

            TextBox textBox = (TextBox)sender;
            // Kiểm tra nếu giá trị là số và lớn hơn 10
            if (int.TryParse(textBox.Text, out int enteredNumber) && enteredNumber > 2024)
            {
                if (enteredNumber > 0)
                {
                    // Nếu lớn hơn 10, đặt giá trị của textbox thành 10
                    textBox.Text = "2024";
                }
                else if (!string.IsNullOrWhiteSpace(tb_nam.Text))
                {
                    MessageBox.Show("Năm không được bằng 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            UpdateButtonStatus();
            if (this.tb_nam.Text.Length > 0)
            {
                btn_chon.Enabled = true;
            }
            else
            {
                btn_chon.Enabled = false;
            }       
        }

        private void tb_nam_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_nam.Text))
            {
                //e.Cancel = true;
                errorProvider.SetError(tb_nam, "Năm không được để trống!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider.SetError(tb_nam, null);
            }
        }

       /* private void cb_dichvu_Click(object sender, EventArgs e)
        {
            cb_dichvu.Items.AddRange(items);
            cb_dichvu.SelectedIndex = 0;
        }

        private void rtb_dsdv_TextChanged(object sender, EventArgs e)
        {
            cb_dichvu.Items.Clear();
            foreach(string item in items)
            {
                if(item.ToLower().Contains(rtb_dsdv.Text.ToLower()))
                {
                    cb_dichvu.Items.Add(item);
                }    
            }    
        }*/

        private void btn_chon_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tất cả các ô nhập liệu đã nhập hay chưa
            if (!string.IsNullOrWhiteSpace(tb_ten.Text) &&
                !string.IsNullOrWhiteSpace(cb_dichvu.Text) &&
                !string.IsNullOrWhiteSpace(rtb_dsdv.Text) &&
                double.TryParse(tb_ngay.Text, out _) &&
                double.TryParse(tb_thang.Text, out _) &&
                double.TryParse(tb_nam.Text, out _))
            {
                string text1 = tb_ten.Text;
                string text2 = tb_ngay.Text;
                string text3 = tb_thang.Text;
                string text4 = tb_nam.Text;
                string text5 = rtb_nhan.Text;
                rtb_ketqua.Clear();
                rtb_ketqua.AppendText($"Tên bệnh nhân: {text1}\n");
                rtb_ketqua.AppendText($"Ngày khám: {text2}/{text3}/{text4}\n");
                rtb_ketqua.AppendText($"Dịch vụ khám: {text5}\n");
            }
            else
            {
                // Hiển thị thông báo nếu còn ô nhập liệu chưa được nhập
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi Chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            List<string> maBNList = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open(); // Mở kết nối
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT MaBN FROM tblBenhNhan";
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Lấy dữ liệu từ cột MaBN và thêm vào List
                            maBNList.Add(reader["MaBN"].ToString());
                        }
                    }
                }
            }
            if (maBNList.Contains(cb_mabn.Text))
            {
                string insert_proc = "Insert_HopDong";
                int day, month, year;

                // Chuyển đổi dữ liệu từ các TextBox thành số nguyên
                int.TryParse(tb_ngay.Text, out day);
                int.TryParse(tb_thang.Text, out month);
                int.TryParse(tb_nam.Text, out year);

                // Tạo một đối tượng DateTime từ các giá trị day, month, year
                DateTime dateValue = new DateTime(year, month, day);

                // Chuyển đổi đối tượng DateTime thành chuỗi định dạng yyyy-MM-dd
                string formattedDate = dateValue.ToString("yyyy-MM-dd");
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        //cmd.Connection = conn;
                        cmd.CommandText = insert_proc;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ngay", formattedDate);
                        cmd.Parameters.AddWithValue("@maBN", cb_mabn.Text);
                        cmd.Parameters.AddWithValue("@dichVu", rtb_nhan.Text);

                        conn.Open();
                        int i = cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                rtb_ketqua.AppendText($"\n\n Cảm ơn bạn đã tiếp tục sử dụng dịch vụ \n\n");
            }
            else
            {
                string insert_proc = "Insert_HopDong";
                int day, month, year;

                // Chuyển đổi dữ liệu từ các TextBox thành số nguyên
                int.TryParse(tb_ngay.Text, out day);
                int.TryParse(tb_thang.Text, out month);
                int.TryParse(tb_nam.Text, out year);

                // Tạo một đối tượng DateTime từ các giá trị day, month, year
                DateTime dateValue = new DateTime(year, month, day);

                // Chuyển đổi đối tượng DateTime thành chuỗi định dạng yyyy-MM-dd
                string formattedDate = dateValue.ToString("yyyy-MM-dd");
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        //cmd.Connection = conn;
                        cmd.CommandText = insert_proc;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ngay", formattedDate);
                        cmd.Parameters.AddWithValue("@maBN", cb_mabn.Text);
                        cmd.Parameters.AddWithValue("@dichVu", rtb_nhan.Text);

                        
                    }
                }
                string insert_proc1 = "Insert_BenhNhan";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        //cmd.Connection = conn;
                        cmd.CommandText = insert_proc1;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@maBN", cb_mabn.Text);
                        cmd.Parameters.AddWithValue("@TenBN", tb_ten.Text);

                        conn.Open();
                        int i = cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                rtb_ketqua.AppendText($"\n\n Bệnh nhân không có mã này trong danh sách đã thực hiện thêm \n\n");
            }
        }

        private bool atLeastOneFieldFilled = false;

        private void UpdateButtonStatus()
        {
            // Kiểm tra và cập nhật trạng thái biến flag
            atLeastOneFieldFilled = !string.IsNullOrWhiteSpace(tb_ten.Text) ||
                                    !string.IsNullOrWhiteSpace(cb_dichvu.Text) ||
                                    !string.IsNullOrWhiteSpace(rtb_dsdv.Text) ||
                                    double.TryParse(tb_ngay.Text, out _) ||
                                    double.TryParse(tb_thang.Text, out _) ||
                                    double.TryParse(tb_nam.Text, out _);

            // Kích hoạt hoặc vô hiệu hóa nút 
            btn_tieptuc.Enabled = atLeastOneFieldFilled;
        }

        private void btn_tieptuc_Click(object sender, EventArgs e)
        {
            if (atLeastOneFieldFilled)
            {
                // Xóa dữ liệu trong TextBox
                tb_ten.Clear();
                tb_ngay.Clear();
                tb_thang.Clear();
                tb_nam.Clear();

                // Xóa dữ liệu trong ComboBox
                cb_dichvu.SelectedIndex = -1;

                // Xóa nội dung trong RichTextBox
                rtb_dsdv.Clear();
                rtb_nhan.Clear();
                rtb_ketqua.Clear();
            }
            else
            {
                // Hiển thị thông báo nếu không có ô nhập liệu nào có dữ liệu
                MessageBox.Show("Vui lòng nhập ít nhất một thông tin trước khi tiếp tục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rtb_dsdv_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonStatus();
        }

        private void rtb_ketqua_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonStatus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //LoadComboBox();
            /*cb_mabn.Items.Clear();
                string insert_proc = "Insert_BenhNhan";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        //cmd.Connection = conn;
                        cmd.CommandText = insert_proc;
                        cmd.CommandType = CommandType.StoredProcedure;
                        //khoi tao va truyen tham so cho proc
                        cmd.Parameters.Add("@mabn", SqlDbType.Int).Value = mabn;
                        cmd.Parameters.AddWithValue("@tenbn", tenbn);

                        conn.Open();
                        int i = cmd.ExecuteNonQuery();
                        conn.Close();
                        return (i > 0);
                    }
                }*/
            cb_mabn.Items.Clear();
            List< string > maBNList = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open(); // Mở kết nối
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT MaBN FROM tblBenhNhan";
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Lấy dữ liệu từ cột MaBN và thêm vào List
                            maBNList.Add(reader["MaBN"].ToString());
                        }
                    }
                }
            }
            cb_mabn.Items.AddRange(maBNList.ToArray());

            cb_dichvu.Items.Clear();
            List<string> tenDVList = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open(); // Mở kết nối
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT TenDV FROM tblDichVu";
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Lấy dữ liệu từ cột MaBN và thêm vào List
                            tenDVList.Add(reader["TenDV"].ToString());
                        }
                    }
                }
            }
            cb_dichvu.Items.AddRange(tenDVList.ToArray());
        }

        private void cb_mabn_SelectedIndexChanged(object sender, EventArgs e)
        {

if (cb_mabn.SelectedItem != null)
            {
                string maBN = cb_mabn.SelectedItem.ToString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT TenBN FROM tblBenhNhan WHERE MaBN = @MaBN", conn);
                    cmd.Parameters.AddWithValue("@MaBN", maBN);
                    string tenBN = cmd.ExecuteScalar()?.ToString();

                    if (tenBN != null)
                    {
                        tb_ten.Text = tenBN;
                    }
                    else
                    {
                        tb_ten.Text = "Không tìm thấy thông tin.";
                    }
                }
            }
        }
    }
    
}
