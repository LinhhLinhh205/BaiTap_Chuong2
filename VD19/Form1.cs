using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView.ImageList = imageList1;
            TreeNode nutgoc = new TreeNode();
            nutgoc.Text = "Danh sách Khoa";
            nutgoc.ImageIndex = 0;
            nutgoc.SelectedImageIndex = 1;
            treeView.Nodes.Add(nutgoc);

            TreeNode nutconcntt = new TreeNode("Khoa Công Nghệ Thông Tin",2,3);
            nutgoc.Nodes.Add(nutconcntt);

            TreeNode nutcondien = new TreeNode("Khoa Công Nghệ Điện",2,3);
            nutgoc.Nodes.Add(nutcondien);

            TreeNode nutconcokhi = new TreeNode("Khoa Cơ Khí",2,3);
            nutgoc.Nodes.Add(nutconcokhi);

            TreeNode nutgocphong = new TreeNode();
            nutgocphong.Text = "Danh sách Phòng";
            nutgocphong.ImageIndex = 0;
            nutgocphong.SelectedImageIndex = 1;
            treeView.Nodes.Add(nutgocphong);

            TreeNode nutcondaotao = new TreeNode("Phòng Đào Tạo", 2, 3);
            nutgocphong.Nodes.Add(nutcondaotao);

            TreeNode nutgoctaichinh = new TreeNode("Phòng Tài Chính & Kế Toán",2,3);
            nutgocphong.Nodes.Add(nutgoctaichinh);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            TreeNode xoa = treeView.SelectedNode;
            if (xoa.Level == 0)
                treeView.Nodes.Remove(xoa);
            else if (xoa.Level > 0)
            {
                TreeNode xoacha = xoa.Parent;
                xoacha.Nodes.Remove(xoa);
            }
        }

        private void btnGoc_Click(object sender, EventArgs e)
        {
            if (txtNut.Text == "") return;
            TreeNode nutthem = new TreeNode(txtNut.Text, 0, 1);
            treeView.Nodes.Add(nutthem);
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            TreeNode nutchon = treeView.SelectedNode;
            TreeNode nutthem = new TreeNode(txtNut.Text, 2, 3);
            nutchon.Nodes.Add(nutthem);
        }
    }
}
