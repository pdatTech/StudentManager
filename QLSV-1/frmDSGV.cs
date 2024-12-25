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
    public partial class frmDSGV : Form
    {
        public frmDSGV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // btnTimKiem
        {
            tukhoa = txtTimKiem.Text.Trim();
            loadDSGV();
        }
        private string tukhoa = "";

        private void loadDSGV()
        {
            string sql = "selectAllGV";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvDSGV.DataSource = new Database().SelectData(sql, lstPara);
        }

        private void frmDSGV_Load(object sender, EventArgs e)
        {
            loadDSGV();
        }

        private void dgvDSGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            loadDSGV();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmGV(null).ShowDialog();
            loadDSGV();
        }

        private void dgvDSGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy mã giáo viên từ cột "magiaovien" trong hàng mà người dùng nhấp đúp
                var mgv = dgvDSGV.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();

                // Mở form frmGV và truyền mã giáo viên
                new frmGV(mgv).ShowDialog();

                // Tải lại danh sách giáo viên sau khi đóng form
                loadDSGV();
            }
        }

    }
}
