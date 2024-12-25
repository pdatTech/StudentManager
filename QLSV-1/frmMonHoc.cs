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
    public partial class frmMonHoc : Form
    {
        public frmMonHoc(string mamh)
        {
            this.mamh = mamh;
            InitializeComponent();
        }

        private string mamh;
        private string nguoithuchien = "admin";
        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mamh))
            {
                this.Text = "Thêm mới môn học";
            }
            else
            {
                this.Text = "Cập nhật môn học";
                // Thêm mã để lấy thông tin môn học từ cơ sở dữ liệu và hiển thị lên form khi cập nhật
                var r = new Database().Select("selectMH '" + mamh + "'");
                txtTenMH.Text = r["tenmonhoc"].ToString();
                txtSoTC.Text = r["sotinchi"].ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // btnluu
        {
            try
            {
                var stc = int.Parse(txtSoTC.Text); // Chuyển đổi giá trị từ `txtSoTC` sang số nguyên
                if (stc <= 0) // Kiểm tra nếu số tín chỉ nhỏ hơn hoặc bằng 0
                {
                    MessageBox.Show("Số tín chỉ phải lớn hơn 0");
                    txtSoTC.Select(); // Đưa con trỏ về lại ô nhập `txtSoTC`
                    return;
                }
            }
            catch
            {
                // Nếu có lỗi khi chuyển đổi giá trị từ `txtSoTC` sang số nguyên
                MessageBox.Show("Số tín chỉ phải là kiểu số nguyên");
                txtSoTC.Select(); // Đưa con trỏ về lại ô nhập `txtSoTC`
                return;
            }
            if (string.IsNullOrEmpty(txtTenMH.Text))
            {
                MessageBox.Show("Tên môn học không được để trống");
                txtTenMH.Select(); // Đưa con trỏ về ô nhập `txtTenMH`
                return;
            }

            string sql = "";
            List<CustomParameter> lstPara = new List<CustomParameter>();

            if (string.IsNullOrEmpty(mamh))
            {
                // Nếu mamh trống, thực hiện thêm mới môn học
                sql = "insertMH";
                lstPara.Add(new CustomParameter()
                {
                    key = "@nguoitao",
                    value = nguoithuchien // Thêm người thực hiện (nguoithuchien) cho quá trình thêm mới
                });
            }
            else
            {
                lstPara.Add(new CustomParameter()
                {
                    key = "@mamonhoc",
                    value = mamh 
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@nguoicapnhat",
                    value = nguoithuchien 
                });
                sql = "updateMH";
            }
            lstPara.Add(new CustomParameter() { key = "@tenmonhoc", value = txtTenMH.Text });
            lstPara.Add(new CustomParameter() { key = "@sotinchi", value = txtSoTC.Text });
            var rs = new Database().Execute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(mamh))
                {
                    MessageBox.Show("Thêm mới môn học thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin môn học thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực hiện truy vấn thất bại");
            }

        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
