using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Bạn cần nhập để thêm vào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            lstThucDon.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            lstThucDon.Items.Clear();
            lstThucDon.Items.Add("Thịt kho hột vịt");
            lstThucDon.Items.Add("Cơm gà xối mỡ");
            lstThucDon.Items.Add("Thịt heo quay");
            lstThucDon.Items.Add("Gà rán");
            lstThucDon.Items.Add("Bánh tráng trộn");
            lstThucDon.Items.Add("Hột vịt lộn");
            lstThucDon.Items.Add("Bánh bao chiên");
            lstThucDon.Items.Add("Bánh tráng kẹp");
            lstThucDon.Items.Add("Mỳ xào");
            lstThucDon.Items.Add("Bắp xào");
            lstThucDon.Items.Add("Bò hít");
        }

        private void btnPhai_Click(object sender, EventArgs e)
        {
            if (lstThucDon.SelectedIndex == -1)
                return;
            for(int i=0;i< lstThucDon.SelectedItems.Count; i++)
            {
                lstMonAn.Items.Add(lstThucDon.SelectedItems[i]);
            }
            while (lstThucDon.SelectedItems.Count > 0)
            {
                lstThucDon.Items.Remove(lstThucDon.SelectedItems[0]);
            }           
        }
        private void btnAllPhai_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstThucDon.Items.Count; i++)
                lstMonAn.Items.Add(lstThucDon.Items[i]);
            lstThucDon.Items.Clear();
        }

        private void btnTrai_Click(object sender, EventArgs e)
        {
            if (lstMonAn.SelectedIndex == -1)
                return;
            for (int i = 0; i < lstMonAn.SelectedItems.Count; i++)
            {
                lstThucDon.Items.Add(lstMonAn.SelectedItems[i]);
            }
            while (lstMonAn.SelectedItems.Count > 0)
            {
                lstMonAn.Items.Remove(lstMonAn.SelectedItems[0]);
            }
        }

        private void btnAllTrai_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lstMonAn.Items.Count; i++)
            
                lstThucDon.Items.Add(lstMonAn.Items[i]);
             lstMonAn.Items.Clear();
            
        }
    }
}
