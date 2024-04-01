using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD12_DatVeXemPhim
{
    public partial class Form1 : Form
    {
        public const int DonGia = 10000;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpNgayDat.Format = DateTimePickerFormat.Custom;
            dtpNgayDat.CustomFormat = "dd/MM/yyyy";
            dtpNgayDat.MaxDate = new DateTime(DateTime.Today.Year, 12, 31);
            dtpNgayDat.Value = DateTime.Today;
            chkLaSV.Checked = true;
            nudSoLuong.Maximum = 10;
            nudSoLuong.Minimum = 1;
            nudSoLuong.Increment = 1;
            dupLoaiVe.Items.Add("ABC");
            dupLoaiVe.Items.Add("DEF");
            dupLoaiVe.Items.Add("GIJ");
            dupLoaiVe.SelectedIndex = 0;
            txtThanhTien.Enabled = false;
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            foreach(Control a in groupBox1.Controls)
            {
                if (a is TextBox)
                    (a as TextBox).Clear();
                else if (a is DateTimePicker)
                    (a as DateTimePicker).Value = DateTime.Today;
                else if (a is CheckBox)
                    (a as CheckBox).Checked = true;
                else if (a is NumericUpDown)
                    (a as NumericUpDown).Value = 1;
                else if (a is DomainUpDown)
                    (a as DomainUpDown).SelectedIndex = 0;       
            }
            txtTen.Focus();
        }

        private void btnDat_Click(object sender, EventArgs e)
        {
            double ThanhTien;
            ThanhTien = (double)nudSoLuong.Value * DonGia * (dupLoaiVe.Text == "ABC" ? 1.5 : (dupLoaiVe.Text == "DEF" ? 1.2 : 1));
            ThanhTien = ThanhTien * (chkLaSV.Checked == true ? 0.9 : 1);
            txtThanhTien.Text = ThanhTien.ToString("#,##0đ");

        }

        private void dupLoaiVe_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
