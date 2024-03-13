using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSo_Click(object sender, EventArgs e)
        {
            if (txtSo.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSo.Focus();
                return;
            }
            if(int.TryParse(txtSo.Text,out int result) == false)
            {
                MessageBox.Show("Bạn cần nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Khoi_Tao();               
                return;
            }
            lstSo.Items.Add(txtSo.Text);
            Khoi_Tao();         
        }

        private void Khoi_Tao()
        {
            txtSo.Clear();
            txtSo.Focus();
            
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong=0;
            for(int i = 0; i < lstSo.Items.Count; i++)
            {
                int x = Convert.ToInt32(lstSo.Items[i]);
                tong += x;
            }
            MessageBox.Show($"Tổng các số bằng: {tong}");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSo.Clear();
            lstSo.Items.Add(4);
            lstSo.Items.Add(6);
            lstSo.Items.Add(7);
            lstSo.Items.Add(2);
        }

        private void btnXoadaucuoi_Click(object sender, EventArgs e)
        {
            lstSo.Items.RemoveAt(0);
            lstSo.Items.RemoveAt(lstSo.Items.Count - 1);
        }

        private void btnXoaPTchon_Click(object sender, EventArgs e)
        {
            if (lstSo.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn dòng cần xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lstSo.Items.Remove(lstSo.SelectedItem);
        }

        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            if (lstSo.Items.Count ==0)
            {
                MessageBox.Show("ListBox rỗng. Vui lòng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for(int i = 0; i < lstSo.Items.Count; i++)
            {
                int x = Convert.ToInt32(lstSo.Items[i]);
                lstSo.Items[i] = x * x;
            }
        }

        private void btnTangPT_Click(object sender, EventArgs e)
        {
            if (lstSo.Items.Count == 0)
            {
                MessageBox.Show("ListBox rỗng. Vui lòng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int x = Convert.ToInt32(lstSo.Items[i]);
                lstSo.Items[i] = x + 2;
            }

        }
        private void btnTongsochan_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int x = Convert.ToInt32(lstSo.Items[i]);
                if (x % 2 == 0)
                    lstSo.SelectedIndex = i;
            }
        }
    }
}
