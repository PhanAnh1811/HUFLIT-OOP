using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLopHoc.DAL;

namespace QLopHoc
{
    public partial class Form1 : Form
    {
        private QLLOPHOCEntities database = new QLLOPHOCEntities();
        public Form1()
        {
            InitializeComponent();
            LoadData();
            ChangeGridViewName();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLLOPHOCDataSet.lophoc' table. You can move, or remove it, as needed.
            this.lophocTableAdapter.Fill(this.qLLOPHOCDataSet.lophoc);

        }

        private void LoadData()
        {
            var result = from lophoc in database.lophocs
                         select new
                         {
                             MaLop = lophoc.malop,
                             TenLop = lophoc.tenlop
                         };
            dgvLopHoc.DataSource = result.ToList();
            AddDataBinding();
        }

        private void AddDataBinding()
        {
            txtMaLop.DataBindings.Clear();
            txtTenLop.DataBindings.Clear();

            txtMaLop.DataBindings.Add("Text", dgvLopHoc.DataSource, "MaLop");
            txtTenLop.DataBindings.Add("Text", dgvLopHoc.DataSource, "TenLop");

        }

        private void ChangeGridViewName()
        {
            dgvLopHoc.Columns[0].HeaderText = "Mã lớp";
            dgvLopHoc.Columns[1].HeaderText = "Tên lớp";

        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text;
            string tenLop = txtTenLop.Text;

            lophoc lop = database.lophocs.Where(
                z => z.malop == maLop).SingleOrDefault();
            if(lop != null)
            {
                MessageBox.Show("Duplicate ID");
                return;
            }else if (String.IsNullOrEmpty(maLop) || String.IsNullOrEmpty(tenLop))
            {
                MessageBox.Show("Mã lớp hoặc tên lớp không được trống");
                return;
            }
            else
            {
                lop = new lophoc();
                lop.malop = maLop;
                lop.tenlop = tenLop;
                database.lophocs.Add(lop);
                database.SaveChanges();
                LoadData();
                MessageBox.Show("Add successfully");

            }


        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text;
            string tenLop = txtTenLop.Text;

            lophoc lop = database.lophocs.Where(
                z => z.malop == maLop).SingleOrDefault();
            if (lop == null)
            {
                MessageBox.Show("ID is not Exsiting");
                return;
            }
            else if (String.IsNullOrEmpty(maLop) || String.IsNullOrEmpty(tenLop))
            {
                MessageBox.Show("Mã lớp not null");
                return;
            }
            else
            {
                database.lophocs.Remove(lop);
                database.SaveChanges();
                LoadData();
                MessageBox.Show("Delete successfully");

            }
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text;
            string tenLop = txtTenLop.Text;

            lophoc lop = database.lophocs.Where(
                z => z.malop == maLop).SingleOrDefault();
            if (lop == null)
            {
                MessageBox.Show("ID is not Exsiting");
                return;
            }
            else if (String.IsNullOrEmpty(maLop) || String.IsNullOrEmpty(tenLop))
            {
                MessageBox.Show("Mã lớp not null");
                return;
            }
            else
            {
                lop.tenlop = tenLop;
                database.SaveChanges();
                
                LoadData();
                MessageBox.Show("Update successfully");

            }
        }
    }
}
