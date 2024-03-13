using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViDu03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            if(txtA.Text=="")
            {
                MessageBox.Show("Hệ số a không được phép rỗng", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtA.Focus();
                return;
            }
            if (txtB.Text == "")
            {
                MessageBox.Show("Hệ số b không được phép rỗng", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtB.Focus();
                return;
            }
            int hsA, hsB;
            string nghiem;
            if (int.TryParse(txtA.Text, out hsA) == false)
            {
                MessageBox.Show("Hệ số a rỗng","Báo lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtA.Text = "";
                txtA.Focus();
                return;
            }
            if(int.TryParse(txtB.Text,out hsB) == false)
            {
                MessageBox.Show("Hệ số b rỗng", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtB.Text = "";
                txtB.Focus();
                return;
            }
            if (hsA == 0)
                if (hsB == 0)
                    nghiem = "Phương trinh vô số nghiệm";
                else
                    nghiem = "Phương trình vô nghiệm";
            else
                nghiem="Phương trình có nghiệm X="+ -(float)hsB/hsA;
            txtKetQua.Text = nghiem;
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKetQua.Clear();
            txtA.Focus();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn muốn thoát không?", "Hỏi đáp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (a == DialogResult.Yes)
                this.Close();
        }
    }
}
