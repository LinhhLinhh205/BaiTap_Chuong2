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
            if (listView1.SelectedItems.Count == 0) return;
            ListViewItem l = listView1.SelectedItems[0];
            textBox1.Text = l.Text;
            textBox3.Text = l.SubItems[1].Text;
            textBox2.Text = l.SubItems[2].Text;

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
                new SINHVIEN {MaSV="A01",Ten="Nguyễn Ngọc Linh",MaLH="A01"},
                new SINHVIEN {MaSV="A02",Ten="Lý Mạc Sầu",MaLH="A02"},
                new SINHVIEN {MaSV="A03",Ten="Cô Cô",MaLH="A03"},
                new SINHVIEN {MaSV="A04",Ten="Dương Quái",MaLH="A04"},
                new SINHVIEN {MaSV="A05",Ten="Kim Tử Long",MaLH="A05"},
                new SINHVIEN {MaSV="A06",Ten="Quả Quả",MaLH="A01"},
                new SINHVIEN {MaSV="A07",Ten="Negav",MaLH="A02"}
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            foreach(Control a in this.Controls)
            {
                if (a is TextBox)
                    (a as TextBox).Clear();
            }
            textBox1.Focus();
        }

        private SINHVIEN TimSinhVien(string msv)
        {
            SINHVIEN kq = null;
            foreach (SINHVIEN sv in SINHVIENs)
                if (sv.MaSV == msv)
                    return sv;
            return kq;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.ReadOnly == false)
            {
                SINHVIEN sv = new SINHVIEN();
                sv.MaSV = textBox1.Text;
                sv.Ten = textBox3.Text;
                sv.MaLH = textBox2.Text;
                SINHVIENs.Add(sv);
                ListViewItem l = new ListViewItem(sv.MaSV);
                l.SubItems.Add(sv.Ten);
                l.SubItems.Add(sv.MaLH);
                listView1.Items.Add(l);
                l.Selected = true;
                listView1.Select();
                textBox1.ReadOnly = true;
            }
            else
            {
                SINHVIEN sv = TimSinhVien(textBox1.Text);
                sv.Ten = textBox2.Text;
                sv.MaSV = textBox1.Text;
                ListViewItem l = listView1.SelectedItems[0];
                l.SubItems[1].Text = textBox2.Text;
                l.SubItems[2].Text = textBox3.Text;
                listView1.Select();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SINHVIEN xoa = TimSinhVien(textBox1.Text);
            SINHVIENs.Remove(xoa);
            ListViewItem delete = listView1.SelectedItems[0];
            listView1.Items.Remove(delete);
            listView1.Select();
            listView1.Items[0].Selected = true;
        }
    }    
}
