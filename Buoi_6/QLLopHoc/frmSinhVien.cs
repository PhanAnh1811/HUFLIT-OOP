using QLLopHoc.DAL;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLopHoc
{
    public partial class frmSinhVien : Form
    {
        private LopHocEntities1 database = new LopHocEntities1();
        public frmSinhVien()
        {
            InitializeComponent();
           
            LoadThongTinSinhVien();
            ChangeGridViewHeaderName();


        }

        private void ChangeGridViewHeaderName()
        {
            dgvSinhVien.Columns[0].HeaderText = "Mã SV";
            dgvSinhVien.Columns[1].HeaderText = "Tên SV";
            dgvSinhVien.Columns[2].HeaderText = "Địa chỉ";
            dgvSinhVien.Columns[3].HeaderText = "Tuổi";
            dgvSinhVien.Columns[4].HeaderText = "Tên lớp";
        }
        private void AddSinhVienBinding()
        {
          

            //Refresh lại
            txtMaSV.DataBindings.Clear();
            txtTenSV.DataBindings.Clear();
            txtTuoi.DataBindings.Clear();
            txtDiaChiSV.DataBindings.Clear();

            //Add lại binding
            txtMaSV.DataBindings.Add("Text", dgvSinhVien.DataSource, "MaSV");
            txtTenSV.DataBindings.Add("Text", dgvSinhVien.DataSource, "TenSV");
            txtTuoi.DataBindings.Add("Text", dgvSinhVien.DataSource, "Tuoi");
            txtDiaChiSV.DataBindings.Add("Text", dgvSinhVien.DataSource, "DiaChi");
        }
        private void LoadThongTinSinhVien()
        {

            var dsLopHoc = from sv in database.SINHVIENs
                           select new
                           {
                               MaSV = sv.MaSV,
                               TenSV = sv.TenSV,
                               DiaChi = sv.DiaChi,
                               Tuoi = sv.Tuoi,
                               TenLop = sv.LOPHOC.TenLop
                           };
            dgvSinhVien.DataSource = dsLopHoc.ToList();
            BindDataTo_ComboBoxProductCategory();
            AddSinhVienBinding();
        }

        private void BindDataTo_ComboBoxProductCategory()
        {
            var y = database.LOPHOCs.Select(C => C.TenLop);
            cmbLopHoc.DataSource = y.ToList();
        }

        private string MapClassNameToId(string className)
        {       
            var r = database.LOPHOCs.Where(c => c.TenLop == className)
                .Select(c => c.MaLop)
                .FirstOrDefault();
            return r;
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            string MaSV = txtMaSV.Text;
            string TenSV = txtTenSV.Text;
            string TuoiSV = txtTuoi.Text;
            string DiaChi = txtDiaChiSV.Text;

            //Đã xuất hiện trong CSDL
            SINHVIEN sv = database.SINHVIENs.Where(s => s.MaSV ==
              MaSV).SingleOrDefault();
            if (sv != null)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại");
                return;
            }
            else if (String.IsNullOrEmpty(MaSV) || String.IsNullOrEmpty(TenSV))
            {
                MessageBox.Show("Mã sinh viên hoặc tên sinh viên không được để trống");
                return;
            }
            else
            {
                string lop = cmbLopHoc.SelectedValue.ToString();
                SINHVIEN sinhvien = new SINHVIEN();
                sinhvien.MaSV = MaSV;
                sinhvien.TenSV = TenSV;
                sinhvien.DiaChi = DiaChi;
                sinhvien.Tuoi = Convert.ToInt32(TuoiSV);
                sinhvien.MaLop = MapClassNameToId(lop);
                database.SINHVIENs.Add(sinhvien);
                database.SaveChanges();
                LoadThongTinSinhVien();
                MessageBox.Show("Thêm mới sinh viên thành công");
            }

        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            string MaSV = txtMaSV.Text;
            //Da xuat hien trong CSDL
            SINHVIEN sv = database.SINHVIENs.Where(s => s.MaSV ==
           MaSV).SingleOrDefault();
            if (sv == null)
            {
                MessageBox.Show("Mã sinh viên không tồn tại");
                return;
            }
            else if (String.IsNullOrEmpty(MaSV))
            {
                MessageBox.Show("Mã sinh viên cần xóa không được để trống");
                return;
            }
            else
            {
                database.SINHVIENs.Remove(sv);
                database.SaveChanges();
                LoadThongTinSinhVien();
                MessageBox.Show("Xóa sinh viên thành công");
            }
        }

        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            string MaSV = txtMaSV.Text;
            string TenSV = txtTenSV.Text;
            string TuoiSV = txtTuoi.Text;
            string DiaChi = txtDiaChiSV.Text;

            SINHVIEN sinhvien = database.SINHVIENs.Where(s => s.MaSV ==
              MaSV).SingleOrDefault();
            if (sinhvien == null)
            {
                MessageBox.Show("Mã sinh viên không tồn tại");
                return;
            }
            else if (String.IsNullOrEmpty(MaSV))
            {
                MessageBox.Show("Mã lớp cần sửa không được để trống");
                return;
            }
            else
            {
             
                /***/
                string lop = cmbLopHoc.SelectedValue.ToString();
                
                sinhvien.MaSV = MaSV;
                sinhvien.TenSV = TenSV;
                sinhvien.DiaChi = DiaChi;
                sinhvien.Tuoi = Convert.ToInt32(TuoiSV);
                sinhvien.MaLop = MapClassNameToId(lop);
                database.SaveChanges();
                LoadThongTinSinhVien();
                MessageBox.Show("Sửa  sinh viên thành công");
            }
        }

        private void FindStudent()
        {

            string student = txtSearch.Text;
            var res = from p in database.SINHVIENs                                         
                      where p.TenSV.Contains(student)
                      select new
                      {
                          MaSV = p.MaSV,
                          TenSV = p.TenSV,
                          DiaChi = p.DiaChi,
                          Tuoi = p.Tuoi,
                          TenLop = p.LOPHOC.TenLop
                      };

            dgvSinhVien.DataSource = res.ToList();
            MessageBox.Show("Tìm thấy " + res.Count().ToString() + " kết quả!");

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FindStudent();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadThongTinSinhVien();
        }
    }
}
