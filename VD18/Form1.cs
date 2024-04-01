using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD18
{
    public partial class Form1 : Form
    {
        List<KHOA> KHOAs;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoDuLieu();
            KhoiTaoComBoBox();
        }

        private void KhoiTaoComBoBox()
        {
            comboBox1.DisplayMember="TenKH";
            comboBox1.ValueMember = "MaKH";
            comboBox1.DataSource = KHOAs;
        }

        private void KhoiTaoDuLieu()
        {
            KHOAs = new List<KHOA>
            {
                new KHOA
                {
                    MaKH="TH",TenKH="Công Nghệ Thông Tin",SINHVIENs=new List<SINHVIEN>
                    {
                        new SINHVIEN {MaSV="A01",Ten="Nguyễn Ngọc Linh",MaLH="A01"},
                        new SINHVIEN {MaSV="A02",Ten="Lý Mạc Sầu",MaLH="A02"},
                    },
                },
                new KHOA
                {
                    MaKH="CK",TenKH="Cơ Khí",SINHVIENs=new List<SINHVIEN>
                    {
                        new SINHVIEN {MaSV="A03",Ten="Cô Cô",MaLH="A03"},
                        new SINHVIEN {MaSV="A04",Ten="Dương Quái",MaLH="A04"},
                    },                    
                },
                new KHOA
                {
                    MaKH="TDH",TenKH="Tự Động Hoá",SINHVIENs=new List<SINHVIEN>
                    {
                        new SINHVIEN {MaSV="A06",Ten="Quả Quả",MaLH="A01"},
                        new SINHVIEN {MaSV="A07",Ten="Negav",MaLH="A02"},
                    },
                },
            };
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
                return;
            KHOA kh = comboBox1.SelectedItem as KHOA;
            NapDuLieu(kh);
            if (listView1.Items.Count == 0)
                return;
            listView1.Select();
            listView1.Items[0].Selected = true;
        }

        private void NapDuLieu(KHOA kh)
        {
            listView1.Items.Clear();
            foreach(SINHVIEN sv in kh.SINHVIENs)
            {
                ListViewItem a = new ListViewItem(sv.MaSV);
                a.SubItems.Add(sv.Ten);
                a.SubItems.Add(sv.MaLH);
                listView1.Items.Add(a);
            }
        }
    }
}
