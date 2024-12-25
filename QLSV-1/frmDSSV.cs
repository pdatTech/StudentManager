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
    public partial class frmDSSV : Form
    {
        public frmDSSV()
        {
            InitializeComponent();
        }

        private void frmDSSV_Load(object sender, EventArgs e)
        {
            LoadDSSV();

        }

        private void LoadDSSV()
        {

            // load toàn bộ danh sách sinh viên khi form được load

            // Khai báo list customparameter -> xem part 3 để hiểu rõ hơn
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = txtTukhoa.Text
            });
            dgvSinhVien.DataSource = new Database().SelectData("SelectAllSinhVien", lstPara);


            // Đặt tên cột
            dgvSinhVien.Columns["masinhvien"].HeaderText = "Mã SV";
            dgvSinhVien.Columns["hoten"].HeaderText = "Họ tên";
            dgvSinhVien.Columns["nsinh"].HeaderText = "Ngày sinh";
            dgvSinhVien.Columns["gt"].HeaderText = "Giới tính";
            dgvSinhVien.Columns["quequan"].HeaderText = "Quê quán";
            dgvSinhVien.Columns["diachi"].HeaderText = "Địa chỉ";
            dgvSinhVien.Columns["email"].HeaderText = "Email";
            dgvSinhVien.Columns["dienthoai"].HeaderText = "Điện thoại";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thêm mã xử lý sự kiện tại đây
        }
        private void label1_Click(object sender, EventArgs e)
        {
            // Thêm mã xử lý sự kiện cho label1 tại đây (nếu cần)
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Thêm mã xử lý sự kiện cho txtTukhoa khi nội dung thay đổi (nếu cần)
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSinhVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ý tưởng: khi double click vào sinh viên trên datagridview
            // sẽ hiện ra form cập nhật thông tin sinh viên
            // để cập nhật được sinh viên
            // ta cần lấy được mã sinh viên
            if (e.RowIndex >= 0)
            {
                var msv = dgvSinhVien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
                // Cần truyền mã sinh viên này vào form sinh viên
                new frmSinhVien(msv).ShowDialog();

                // sau khi form frmSinhVien được đóng lại
                // cần load lại danh sách sinh viên
                LoadDSSV();
            }
        }
        private void txtTukhoa_TextChanged(object sender, EventArgs e)
        {
            LoadDSSV();
        }

        private void button2_Click(object sender, EventArgs e) // btnThemmoi
        {
            new frmSinhVien(null).ShowDialog();
            LoadDSSV(); //load lại ds sv khi thêm thành công  
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            LoadDSSV();
        }
    }
}
