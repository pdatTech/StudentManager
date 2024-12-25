using QLSV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_1
{
    public partial class frmLopHoc : Form
    {
        public frmLopHoc(string malophoc)
        {
            this.malophoc = malophoc;
            InitializeComponent();
        }
        private string malophoc;
        private Database db;
        private string nguoithuchien = "admin";
        private void button2_Click(object sender, EventArgs e) // btnHuy
        {
            this.Dispose();
        }

        private void frmLopHoc_Load(object sender, EventArgs e)
        {
            db = new Database();
            List<CustomParameter> lst = new List<CustomParameter>
            {
                new CustomParameter
                {
                    key = "@tukhoa",
                    value = "" // gán giá trị từ biến `tukhoa` hoặc có thể là một chuỗi cụ thể
                }
            };

            // Load dữ liệu cho ComboBox môn học
            cbbMonhoc.DataSource = db.SelectData("selectAllMonHoc", lst);
            cbbMonhoc.DisplayMember = "tenmonhoc"; // Thuộc tính hiển thị của ComboBox (tên môn học)
            cbbMonhoc.ValueMember = "mamonhoc";    // Giá trị (key) của ComboBox (mã môn học)
            cbbMonhoc.SelectedIndex = -1;

            cbbGiaoVien.DataSource = db.SelectData("selectAllGV", lst);
            cbbGiaoVien.DisplayMember = "hoten";      // Cột hiển thị trong ComboBox (tên giáo viên)
            cbbGiaoVien.ValueMember = "magiaovien";   // Giá trị (key) của ComboBox (mã giáo viên)
            cbbGiaoVien.SelectedIndex = -1;
            if (string.IsNullOrEmpty(malophoc))
            {
                this.Text = "Thêm mới lớp học";
            }
            else
            {
                this.Text = "Cập nhật lớp học";
                var r = db.Select("exec selectLopHoc '" + malophoc + "'");
                cbbGiaoVien.SelectedValue = r["magiaovien"].ToString();
                cbbMonhoc.SelectedValue = r["mamonhoc"].ToString();
            }
        }

        private void cbbMH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            // Ràng buộc điều kiện
            // Phải chọn môn học và giáo viên giảng dạy mới tiếp tục thực hiện các câu lệnh phía dưới
            if (cbbMonhoc.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn môn học");
                return;
            }

            if (cbbGiaoVien.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn giáo viên");
                return;
            }
           
            List<CustomParameter> lst = new List<CustomParameter>();

            if (string.IsNullOrEmpty(malophoc))
            {
                sql = "insertLopHoc";
                lst.Add(new CustomParameter()
                {
                    key = "@nguoitao",
                    value = nguoithuchien
                });
            }
            else
            {
                sql = "updateLopHoc";
                lst.Add(new CustomParameter()
                {
                    key = "@nguoicapnhat",
                    value = nguoithuchien
                });
                lst.Add(new CustomParameter()
                {
                    key = "@malophoc",
                    value = malophoc
                });
            }
            lst.Add(new CustomParameter() { key = "@mamonhoc", value = cbbMonhoc.SelectedValue.ToString() }); // lấy giá trị dc chọn của combobox môn học
            lst.Add(new CustomParameter() { key = "@magiaovien", value = cbbGiaoVien.SelectedValue.ToString() }); // lấy giá trị dc chọn của combobox giáo viên

            var kq = db.Execute(sql, lst);
            if (kq == 1)
            {
                if (string.IsNullOrEmpty(malophoc))
                {
                    MessageBox.Show("Thêm mới lớp học thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật lớp học thành công");
                }
            }
            else
            {
                MessageBox.Show("Lưu dữ liệu thất bại");
            }

        }

    }
}
