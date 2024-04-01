
namespace VD19
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNut = new System.Windows.Forms.TextBox();
            this.btnGoc = new System.Windows.Forms.Button();
            this.btnCon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(30, 29);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(270, 191);
            this.treeView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nút";
            // 
            // txtNut
            // 
            this.txtNut.AcceptsReturn = true;
            this.txtNut.Location = new System.Drawing.Point(67, 250);
            this.txtNut.Name = "txtNut";
            this.txtNut.Size = new System.Drawing.Size(233, 20);
            this.txtNut.TabIndex = 2;
            // 
            // btnGoc
            // 
            this.btnGoc.Location = new System.Drawing.Point(30, 282);
            this.btnGoc.Name = "btnGoc";
            this.btnGoc.Size = new System.Drawing.Size(64, 23);
            this.btnGoc.TabIndex = 3;
            this.btnGoc.Text = "Thêm gốc";
            this.btnGoc.UseVisualStyleBackColor = true;
            this.btnGoc.Click += new System.EventHandler(this.btnGoc_Click);
            // 
            // btnCon
            // 
            this.btnCon.Location = new System.Drawing.Point(100, 282);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(64, 23);
            this.btnCon.TabIndex = 4;
            this.btnCon.Text = "Thêm con";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(170, 282);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(64, 23);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xoá nút";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(236, 282);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(64, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Normal_folder.png");
            this.imageList1.Images.SetKeyName(1, "open-file-folder.png");
            this.imageList1.Images.SetKeyName(2, "972105c5a775f38cf33d3924aea053f1.jpg");
            this.imageList1.Images.SetKeyName(3, "login.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 317);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.btnGoc);
            this.Controls.Add(this.txtNut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView);
            this.Name = "Form1";
            this.Text = "Thiết kế TreeView";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNut;
        private System.Windows.Forms.Button btnGoc;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ImageList imageList1;
    }
}

