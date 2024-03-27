using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD17
{
    public partial class Form1 : Form
    {
        List<SINHVIEN> SINHVIENs;
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoSinhVien();
            KhoiTaoListView();
        }

        private void KhoiTaoListView()
        {
            foreach(SINHVIEN sv in SINHVIENs)
            {
                ListViewItem l = new ListViewItem();
                l.Text = sv.MaSV.ToString();
                l.SubItems.Add(sv.Ten);
                l.SubItems.Add(sv.MaLH);
                listView1.Items.Add(l);
            }
        }

        private void KhoiTaoSinhVien()
        {
            SINHVIENs = new List<SINHVIEN>
            {
                new SINHVIEN {MaSV=01,Ten="Nguyễn Ngọc Linh",MaLH="A01"},
                new SINHVIEN {MaSV=02,Ten="Lý Mạc Sầu",MaLH="A02"},
                new SINHVIEN {MaSV=03,Ten="Cô Cô",MaLH="A03"},
                new SINHVIEN {MaSV=04,Ten="Dương Quái",MaLH="A04"},
                new SINHVIEN {MaSV=05,Ten="Kim Tử Long",MaLH="A05"},
                new SINHVIEN {MaSV=06,Ten="Quả Quả",MaLH="A01"},
                new SINHVIEN {MaSV=07,Ten="Negav",MaLH="A02"}
            };
        }
    }
}
