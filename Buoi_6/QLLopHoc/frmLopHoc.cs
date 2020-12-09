using QLLopHoc.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLopHoc
{
    public partial class frmLopHoc : Form
    {
        private LopHocEntities1 database = new LopHocEntities1();
        public frmLopHoc()
        {
            InitializeComponent();
            LoadThongTinLop();
            ChangeGridViewHeaderName();
        }
        private void ChangeGridViewHeaderName()
        {
            dgvLopHoc.Columns[0].HeaderText = "Mã lớp";
            dgvLopHoc.Columns[1].HeaderText = "Tên lớp";
        }
        private void AddLopHocBinding()
        {
            //Refresh lại
            txtMaLop.DataBindings.Clear();
            txtTenLop.DataBindings.Clear();

            //Add lại bindingo
            txtMaLop.DataBindings.Add("Text", dgvLopHoc.DataSource, "MaLop");
            txtTenLop.DataBindings.Add("Text", dgvLopHoc.DataSource, "TenLop");
        }
        private void LoadThongTinLop()
        {
            var dsLopHoc = from LOPHOC in database.LOPHOCs
                           select new { MaLop = LOPHOC.MaLop, TenLop = LOPHOC.TenLop };
            dgvLopHoc.DataSource = dsLopHoc.ToList();

            //Add binding
            AddLopHocBinding();
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            string MaLop = txtMaLop.Text;
            string TenLop = txtTenLop.Text;
            //Đã xuất hiện trong CSDL
            LOPHOC lop = database.LOPHOCs.Where(l => l.MaLop == MaLop).SingleOrDefault();
            if (lop != null)
            {
                MessageBox.Show("Mã lớp học đã tồn tại");
                return;
            }
            else if (String.IsNullOrEmpty(MaLop) || String.IsNullOrEmpty(TenLop))
            {
                MessageBox.Show("Mã lớp hoặc tên lớp không được trống");
                return;
            }
            else
            {
                lop = new LOPHOC();
                lop.MaLop = MaLop;
                lop.TenLop = TenLop;
                database.LOPHOCs.Add(lop);
                database.SaveChanges();
                LoadThongTinLop();
                MessageBox.Show("Thêm lớp mới thành công");
            }
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            string MaLop = txtMaLop.Text;
            string TenLop = txtTenLop.Text;
            //Đã xuất hiện trong CSDL
            LOPHOC lop = database.LOPHOCs.Where(l => l.MaLop == MaLop).SingleOrDefault();
            if (lop == null)
            {
                MessageBox.Show("Mã lớp học đã tồn tại");
                return;
            }
            else if (String.IsNullOrEmpty(MaLop)) 
            {
                MessageBox.Show("Mã lớp cần xóa không được trống");
                return;
            }
            else
            {
                if (lop.SINHVIENs.Count > 0)
                {
                    MessageBox.Show("Hãy xóa sinh viên trong lớp trước");
                    return;
                }
                database.LOPHOCs.Remove(lop);
                database.SaveChanges();
                LoadThongTinLop();
                MessageBox.Show("Xóa lớp học thành công");
            }
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            string MaLop = txtMaLop.Text;
            string TenLop = txtTenLop.Text;
            //Đã xuất hiện trong CSDL
            LOPHOC lop = database.LOPHOCs.Where(l => l.MaLop == MaLop).SingleOrDefault();
            if (lop == null)
            {
                MessageBox.Show("Mã lớp học đã tồn tại");
                return;
            }
            else if (String.IsNullOrEmpty(MaLop))
            {
                MessageBox.Show("Mã lớp cần sửa không được trống");
                return;
            }
            else
            {
                lop.TenLop = TenLop;
                database.SaveChanges();
                LoadThongTinLop();
                MessageBox.Show("Cập nhật thông tin lớp học thành công");
            }
        }

        private void btnQLSV_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSinhVien formSV = new frmSinhVien();
            formSV.ShowDialog();
            formSV = null;
            this.Show();
        }
    }
}
