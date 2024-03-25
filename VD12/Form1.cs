using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (picMo.Visible)
            {
                picMo.Visible = false;
                picTat.Visible = true;
                btnChon.Text = btnChon.Text.Replace("Tắt", "Bật");
            }
            else
            {
                picMo.Visible = true;
                picTat.Visible = false;
                btnChon.Text = btnChon.Text.Replace("Bật", "Tắt");
            }    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnChon.Text = txtTen.Text + "." + (picMo.Visible == true ? "Tắt" : "Bật") + " đèn";
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            btnChon.Text = txtTen.Text + "." + (picMo.Visible == true ? "Tắt" : "Bật") + " đèn";

        }
    }
}
