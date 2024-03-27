using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD08
{
    public partial class Form1 : Form
    {
        List<LOPHOC> LOPHOCs;
        List<HOCVIEN> HOCVIENs;
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lstDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDs.SelectedIndex == -1) return;
            HOCVIEN hv = lstDs.SelectedItem as HOCVIEN;
            //gán dữ liệu
            txtMa.Text = hv.MaHV.ToString();
            txtTen.Text = hv.Ten;
            checkBox1.Checked = hv.LaSV;
            comboBox1.SelectedValue = hv.MaLH;
            label5.Text = hv.ThanhTien.ToString("#,##0đ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoDuLieu();
            KhoiTaoComBoBox();
            KhoiTaoListDs();
        }

        private void KhoiTaoListDs()
        {
            lstDs.DataSource = null;
            lstDs.DisplayMember = "Ten";
            lstDs.ValueMember = "MaHV";
            lstDs.DataSource = HOCVIENs;
        }

        private void KhoiTaoComBoBox()
        {
            
            comboBox1.DisplayMember = "TenLH";
            comboBox1.ValueMember = "MaLH";           
            comboBox1.DataSource = LOPHOCs;
        }

        private void KhoiTaoDuLieu()
        {
            LOPHOCs = new List<LOPHOC>
            {
                new LOPHOC {MaLH="A01",TenLH="Lập trình hướng đối tượng",Tien=1000000},
                new LOPHOC { MaLH = "A02", TenLH = "Lập trình Windows",Tien=2000000 },
                new LOPHOC { MaLH = "A03", TenLH = "Tiếng anh",Tien=3000000 },
                new LOPHOC {MaLH="A04",TenLH="Thiết kế và xử lí hình ảnh",Tien=4000000},
                new LOPHOC {MaLH="A05",TenLH="Tin Học",Tien=5000000}
            };
            HOCVIENs = new List<HOCVIEN>
            {
                new HOCVIEN {MaHV=01,Ten="Nguyễn Ngọc Linh",MaLH="A01",LaSV=true,ThanhTien=900000},
                new HOCVIEN {MaHV=02,Ten="Lý Mạc Sầu",MaLH="A02",LaSV=false,ThanhTien=1800000},
                new HOCVIEN {MaHV=03,Ten="Cô Cô",MaLH="A03",LaSV=true,ThanhTien=2700000},
                new HOCVIEN {MaHV=04,Ten="Dương Quái",MaLH="A04",LaSV=true,ThanhTien=3600000},
                new HOCVIEN {MaHV=05,Ten="Kim Tử Long",MaLH="A05",LaSV=false,ThanhTien=4500000},
                new HOCVIEN {MaHV=06,Ten="Quả Quả",MaLH="A01",LaSV=false,ThanhTien=900000},
                new HOCVIEN {MaHV=07,Ten="Negav",MaLH="A02",LaSV=true,ThanhTien=1800000},
            };
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) return;
            LOPHOC a = comboBox1.SelectedItem as LOPHOC;
            double t = a.Tien * (checkBox1.Checked == true ? 0.9 : 1);
            label5.Text = t.ToString("#,##0đ");

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            HOCVIEN hv;
            if (!txtMa.ReadOnly) //thêm mới
            {
                hv = new HOCVIEN();
                hv.MaHV = int.Parse(txtMa.Text);
                hv.Ten = txtTen.Text;
                hv.LaSV = checkBox1.Checked;
                hv.MaLH = comboBox1.SelectedValue.ToString();
                hv.ThanhTien = int.Parse(label5.Text.Replace(",", "").Replace("đ", ""));
                HOCVIENs.Add(hv);
                txtMa.ReadOnly = true;
                KhoiTaoListDs();
                lstDs.SelectedIndex = lstDs.Items.IndexOf(hv);                                               
            }
            else //cập nhật
            {
                hv = lstDs.SelectedItem as HOCVIEN;               
                hv.Ten = txtTen.Text;
                hv.MaLH = comboBox1.SelectedValue.ToString();
                hv.ThanhTien = int.Parse(label5.Text.Replace(",", "").Replace("đ", ""));
                lstDs.SelectedIndex = lstDs.Items.IndexOf(hv);
                KhoiTaoListDs();
            }
            //comboBox1_SelectedIndexChanged(sender, e);
            //lstDs.SelectedIndex = lstDs.Items.IndexOf(hv);
            //txtMa.ReadOnly = true;

        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtMa.ReadOnly = false;
            foreach (Control a in this.groupBox1.Controls)
                if (a is TextBox)
                    (a as TextBox).Clear();
            checkBox1.Checked = false;
            comboBox1_SelectedIndexChanged(sender, e);
            txtMa.Focus();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show($"Bạn có muốn xoá {txtTen.Text}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                HOCVIENs.Remove(lstDs.SelectedItem as HOCVIEN);
                lstDs.SelectedIndex = 0;
                KhoiTaoListDs();
            }                                  
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(sender, e);
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
