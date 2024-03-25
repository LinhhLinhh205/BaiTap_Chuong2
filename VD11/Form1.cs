using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD11
{
    public partial class Form1 : Form
    {
        int stt = 0;
        string a = @"..\..\..\DanhSachHinh\";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stt = 1;
            pictureBox1.Image = Image.FromFile(a + stt + ".jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label3.Text = stt.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (stt == 5)
                stt = 1;
            
            else 
                stt++;
            pictureBox1.Image = Image.FromFile(a + stt + ".jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label3.Text = stt.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (stt == 1)
                stt = 5;
            else
                stt--;               
            pictureBox1.Image = Image.FromFile(a + stt + ".jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label3.Text = stt.ToString();
        }
    }
}
