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
    public partial class frmDSMH : Form
    {
        public frmDSMH()
        {
            InitializeComponent();
        }
        private string tukhoa = "";
        private void frmDSMH_Load(object sender, EventArgs e)
        {
            LoadDSMH();
            dgvDSMH.Columns["mamonhoc"].HeaderText = "Mã MH";
            dgvDSMH.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvDSMH.Columns["sotinchi"].HeaderText = "Số TC";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDSMH_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }
        
        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new frmMonHoc(null).ShowDialog();
            LoadDSMH();
        }

        private void LoadDSMH()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });

            dgvDSMH.DataSource = new Database().SelectData("selectAllMonHoc", lstPara);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            LoadDSMH();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDSMH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy mã môn học từ cột "mamonhoc" của hàng được click
                var mamh = dgvDSMH.Rows[e.RowIndex].Cells["mamonhoc"].Value?.ToString();

                // Kiểm tra nếu mã môn học không null hoặc rỗng
                if (!string.IsNullOrEmpty(mamh))
                {
                    // Hiển thị form frmMonHoc và truyền mã môn học vào
                    new frmMonHoc(mamh).ShowDialog();

                    // Sau khi form frmMonHoc đóng lại, tải lại danh sách môn học
                    LoadDSMH();
                }
                
            }
        }

    }
}
