using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD07
{
    public partial class Form1 : Form
    {
        List<LOPHOC> LOPHOCs;
        List<HOCVIEN> HOCVIENs; 
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
                return;
            string m = comboBox1.SelectedValue.ToString();
            List<HOCVIEN> ds = new List<HOCVIEN>();
            foreach (HOCVIEN hv in HOCVIENs)
                if (hv.MaLH == m)
                    ds.Add(hv);
            lstDs.DisplayMember = "Ten";
            lstDs.ValueMember = "Ma";
            lstDs.DataSource = ds;
        }

        private void txtNgay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGioi_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDs.SelectedIndex == -1)
                return;
            HOCVIEN hv = lstDs.SelectedItem as HOCVIEN;
            txtMa.Text = hv.Ma.ToString();
            txtTen.Text = hv.Ten;
            txtGioi.Text = hv.Gioi == true ? "Nam" : "Nữ";
            txtNgay.Text = hv.Ngay.ToShortDateString();
            txtDiaChi.Text = hv.DiaChi;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoDuLieu();
            KhoiTaoComBoBox();          
        }
        private void KhoiTaoDuLieu()
        {
            LOPHOCs = new List<LOPHOC>
            {
                new LOPHOC {MaLH="A01",TenLH="Lập trình hướng đối tượng"},
                new LOPHOC { MaLH = "A02", TenLH = "Lập trình Windows" },
                new LOPHOC { MaLH = "A03", TenLH = "Tiếng anh" },
                new LOPHOC {MaLH="A04",TenLH="Thiết kế và xử lí hình ảnh"},
                new LOPHOC {MaLH="A05",TenLH="Tin Học"}
            };
            HOCVIENs = new List<HOCVIEN>
            {
                new HOCVIEN {Ma=01,Ten="Nguyễn Ngọc Linh",Gioi=true,Ngay=new DateTime(2005/05/20),DiaChi="Quảng Ngãi",MaLH="A01"},
                new HOCVIEN {Ma=02,Ten="Lý Mạc Sầu",Gioi=true,Ngay=new DateTime(2000/05/21),DiaChi="Quảng Trị",MaLH="A02"},
                new HOCVIEN {Ma=03,Ten="Cô Cô",Gioi=false,Ngay=new DateTime(2004/07/19),DiaChi="Quảng Bình",MaLH="A03"},
                new HOCVIEN {Ma=04,Ten="Dương Quái",Gioi=false,Ngay=new DateTime(1999/04/17),DiaChi="Hà Nội",MaLH="A04"},
                new HOCVIEN {Ma=05,Ten="Kim Tử Long",Gioi=false,Ngay=new DateTime(1998/04/04),DiaChi="Cà Mau",MaLH="A05"},
                new HOCVIEN {Ma=06,Ten="Quả Quả",Gioi=true,Ngay=new DateTime(1999/04/04),DiaChi="TP HCM",MaLH="A01"},
                new HOCVIEN {Ma=07,Ten="Negav",Gioi=true,Ngay=new DateTime(1999/09/04),DiaChi="TP HCM",MaLH="A02"},
            };
        }
        private void KhoiTaoComBoBox()
        {
            comboBox1.DisplayMember = "TenLH";
            comboBox1.ValueMember = "MaLH";
            comboBox1.DataSource = LOPHOCs;
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            foreach (Control a in this.groupBox1.Controls)
                if (a is TextBox)
                    (a as TextBox).Clear();
            txtMa.ReadOnly = false;
            txtMa.Focus();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            HOCVIEN hv;
            if (!txtMa.ReadOnly)
            {
                hv = new HOCVIEN();
                hv.Ma = int.Parse(txtMa.Text);
                hv.Ten = txtTen.Text;
                hv.Gioi = txtGioi.Text.ToUpper() == "NAM" ? true : false;
                hv.Ngay = DateTime.Parse(txtNgay.Text);
                hv.DiaChi = txtDiaChi.Text;
                hv.MaLH = comboBox1.SelectedValue.ToString();
                HOCVIENs.Add(hv);
            }
            else
            {
                hv = lstDs.SelectedItem as HOCVIEN;
                hv.Ten = txtTen.Text;
                hv.Gioi = txtGioi.Text.ToUpper()== "NAM" ? true : false;
                hv.Ngay = DateTime.Parse(txtNgay.Text);
                hv.DiaChi = txtDiaChi.Text;
            }
            comboBox1_SelectedIndexChanged(sender, e);
            lstDs.SelectedIndex = lstDs.Items.IndexOf(hv);
            txtMa.ReadOnly = true;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có chắc chắn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                HOCVIENs.Remove(lstDs.SelectedItem as HOCVIEN);
                comboBox1_SelectedIndexChanged(sender, e);
                lstDs.SelectedIndex = 0;
            }
        }
    }
}
