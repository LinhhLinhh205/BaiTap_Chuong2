using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViDu_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnHo_Click(object sender, EventArgs e)
        {
            LbKetqua.Text = txtHo.Text;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            LbKetqua.Text = txtTen.Text;
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtHo.Text = "";
            txtTen.Clear();
            LbKetqua.Text = "";
            txtHo.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn muốn thoát không", "Hỏi đáp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (a == DialogResult.Yes)
                this.Close();
        }

        
        private void btnHoTen_Click(object sender, EventArgs e)
        {
            LbKetqua.Text = txtHo.Text + " " + txtTen.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
