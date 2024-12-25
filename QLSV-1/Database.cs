using QLSV_1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSV
{
    public class Database
    {
        private string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=QLSV;User ID=sa;Password=1234";
        private SqlConnection conn;
        private string sql;
        private DataTable dt;
        private SqlCommand cmd;
        public Database()
        {
            try
            {
                conn = new SqlConnection(connectionString); // Sửa lỗi ở đây
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
            }
        }

        public DataTable SelectData(string sql, List<CustomParameter> lstPara)
        {
            DataTable dataTable = new DataTable();
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure; // set command type cho cmd
                foreach (var para in lstPara) // gán các tham số cho cmd
                {
                    cmd.Parameters.AddWithValue(para.key, para.value);
                }
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataRow Select(string sql)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn); // truyền giá trị vào cmd
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load thông tin chi tiết: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public int Execute(string sql, List<CustomParameter> lstPara)
        {
            try
            {
                // Cần sửa lại hàm execute như sau
                // string sql, List<CustomParameter> lstPara là tham số truyền vào
                // CustomParameter đã được định nghĩa ở phần trước - Xem lại part 4
                conn.Open(); // mở kết nối

                cmd = new SqlCommand(sql, conn); // thực thi câu lệnh sql
                cmd.CommandType = CommandType.StoredProcedure; // chỉ định loại thủ tục
                foreach (var p in lstPara) // thêm các tham số cho cmd
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }

                var rs = cmd.ExecuteNonQuery(); // lấy kết quả thực thi truy vấn
                return (int)rs; // trả về kết quả
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi câu lệnh: " + ex.Message);
                return -100;
            }
            finally
            {
                conn.Close();
            }
        }


    }
}
