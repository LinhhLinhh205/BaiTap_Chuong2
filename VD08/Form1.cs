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
            txtMa.Text = hv.MaHV.ToString();
            txtTen.Text = hv.Ten;
            comboBox1.SelectedValue = hv.MaLH;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoDuLieu();
            KhoiTaoComBoBox();
            KhoiTaoListDs();
        }

        private void KhoiTaoListDs()
        {
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
                new LOPHOC {MaLH="A01",TenLH="Lập trình hướng đối tượng"},
                new LOPHOC { MaLH = "A02", TenLH = "Lập trình Windows" },
                new LOPHOC { MaLH = "A03", TenLH = "Tiếng anh" },
                new LOPHOC {MaLH="A04",TenLH="Thiết kế và xử lí hình ảnh"},
                new LOPHOC {MaLH="A05",TenLH="Tin Học"}
            };
            HOCVIENs = new List<HOCVIEN>
            {
                new HOCVIEN {MaHV=01,Ten="Nguyễn Ngọc Linh",MaLH="A01"},
                new HOCVIEN {MaHV=02,Ten="Lý Mạc Sầu",MaLH="A02"},
                new HOCVIEN {MaHV=03,Ten="Cô Cô",MaLH="A03"},
                new HOCVIEN {MaHV=04,Ten="Dương Quái",MaLH="A04"},
                new HOCVIEN {MaHV=05,Ten="Kim Tử Long",MaLH="A05"},
                new HOCVIEN {MaHV=06,Ten="Quả Quả",MaLH="A01"},
                new HOCVIEN {MaHV=07,Ten="Negav",MaLH="A02"},
            };
        }
    }
}
