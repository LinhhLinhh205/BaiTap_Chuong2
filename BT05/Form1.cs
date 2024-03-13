using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SinhVien sv1 = new SinhVien();
            sv1.MaSV = "A1";
            sv1.HoTen = "Nguyễn Ngọc Linh";
            sv1.NgaySinh = new DateTime(2005,05,05);
            lstSV.Items.Add(sv1);
            SinhVien sv2 = new SinhVien();
            sv2.MaSV = "A2";
            sv2.HoTen = "Tiểu Tử Thối";
            sv2.NgaySinh = new DateTime(2004,11,07);
            lstSV.Items.Add(sv2);
            SinhVien sv3 = new SinhVien();
            sv3.MaSV = "A3";
            sv3.HoTen = "Lý Mạc Sầu";
            sv3.NgaySinh = new DateTime(2002,5,3);
            lstSV.Items.Add(sv3);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMa.ReadOnly == false)
            {
                SinhVien sv = new SinhVien();
                sv.MaSV = txtMa.Text;
                sv.HoTen = txtTen.Text;
                sv.NgaySinh = DateTime.Parse(txtNgaySinh.Text);
                lstSV.Items.Add(sv);
                lstSV.SelectedIndex = lstSV.Items.IndexOf(sv);
                txtMa.ReadOnly = true;
            }
            else
            {
                SinhVien sv = new SinhVien();
                sv.HoTen = txtTen.Text;
                sv.NgaySinh = DateTime.Parse(txtNgaySinh.Text);
                lstSV.Items[lstSV.SelectedIndex] = sv;
                txtMa.ReadOnly = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstSV.SelectedIndex == -1)
                return;
            DialogResult delete = MessageBox.Show("Bạn có chắc chắn xoá : " + txtTen.Text, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (delete == DialogResult.Yes)
            {
                lstSV.Items.Remove(lstSV.SelectedItem);
                lstSV.SelectedIndex = 0;
            }
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtTen.Clear();
            txtNgaySinh.Clear();
            txtMa.Focus();
        }

        private void lstSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSV.SelectedIndex == -1)
                return;
            SinhVien sv = lstSV.SelectedItem as SinhVien;
            txtMa.Text = sv.MaSV;
            txtTen.Text = sv.HoTen;
            txtNgaySinh.Text = sv.NgaySinh.ToString("dd/MM/yyyy");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstSV.DisplayMember = "HoTen";
        }
    }
}
