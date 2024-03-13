
namespace VD04
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.btnSo = new System.Windows.Forms.Button();
            this.lstSo = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnXoadaucuoi = new System.Windows.Forms.Button();
            this.btnBinhPhuong = new System.Windows.Forms.Button();
            this.btnXoaPTchon = new System.Windows.Forms.Button();
            this.btnTongsochan = new System.Windows.Forms.Button();
            this.btnTangPT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số ";
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(101, 14);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(155, 23);
            this.txtSo.TabIndex = 1;
            // 
            // btnSo
            // 
            this.btnSo.BackColor = System.Drawing.Color.White;
            this.btnSo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSo.Location = new System.Drawing.Point(283, 10);
            this.btnSo.Name = "btnSo";
            this.btnSo.Size = new System.Drawing.Size(75, 30);
            this.btnSo.TabIndex = 2;
            this.btnSo.Text = "Nhập số";
            this.btnSo.UseVisualStyleBackColor = false;
            this.btnSo.Click += new System.EventHandler(this.btnSo_Click);
            // 
            // lstSo
            // 
            this.lstSo.FormattingEnabled = true;
            this.lstSo.ItemHeight = 16;
            this.lstSo.Location = new System.Drawing.Point(26, 62);
            this.lstSo.Name = "lstSo";
            this.lstSo.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstSo.Size = new System.Drawing.Size(230, 228);
            this.lstSo.TabIndex = 3;
            this.lstSo.SelectedIndexChanged += new System.EventHandler(this.lstSo_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTongsochan);
            this.groupBox1.Controls.Add(this.btnTangPT);
            this.groupBox1.Controls.Add(this.btnBinhPhuong);
            this.groupBox1.Controls.Add(this.btnXoaPTchon);
            this.groupBox1.Controls.Add(this.btnXoadaucuoi);
            this.groupBox1.Controls.Add(this.btnTong);
            this.groupBox1.Location = new System.Drawing.Point(285, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 240);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn các chức năng";
            // 
            // btnTong
            // 
            this.btnTong.BackColor = System.Drawing.Color.White;
            this.btnTong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTong.Location = new System.Drawing.Point(6, 22);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(184, 30);
            this.btnTong.TabIndex = 5;
            this.btnTong.Text = "Tổng các số";
            this.btnTong.UseVisualStyleBackColor = false;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnXoadaucuoi
            // 
            this.btnXoadaucuoi.BackColor = System.Drawing.Color.White;
            this.btnXoadaucuoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnXoadaucuoi.Location = new System.Drawing.Point(6, 58);
            this.btnXoadaucuoi.Name = "btnXoadaucuoi";
            this.btnXoadaucuoi.Size = new System.Drawing.Size(184, 30);
            this.btnXoadaucuoi.TabIndex = 6;
            this.btnXoadaucuoi.Text = "Xoá PT đầu và cuối";
            this.btnXoadaucuoi.UseVisualStyleBackColor = false;
            this.btnXoadaucuoi.Click += new System.EventHandler(this.btnXoadaucuoi_Click);
            // 
            // btnBinhPhuong
            // 
            this.btnBinhPhuong.BackColor = System.Drawing.Color.White;
            this.btnBinhPhuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBinhPhuong.Location = new System.Drawing.Point(6, 130);
            this.btnBinhPhuong.Name = "btnBinhPhuong";
            this.btnBinhPhuong.Size = new System.Drawing.Size(184, 30);
            this.btnBinhPhuong.TabIndex = 8;
            this.btnBinhPhuong.Text = "Thay bằng bình phương";
            this.btnBinhPhuong.UseVisualStyleBackColor = false;
            this.btnBinhPhuong.Click += new System.EventHandler(this.btnBinhPhuong_Click);
            // 
            // btnXoaPTchon
            // 
            this.btnXoaPTchon.BackColor = System.Drawing.Color.White;
            this.btnXoaPTchon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnXoaPTchon.Location = new System.Drawing.Point(6, 94);
            this.btnXoaPTchon.Name = "btnXoaPTchon";
            this.btnXoaPTchon.Size = new System.Drawing.Size(184, 30);
            this.btnXoaPTchon.TabIndex = 7;
            this.btnXoaPTchon.Text = "Xoá PT chọn";
            this.btnXoaPTchon.UseVisualStyleBackColor = false;
            this.btnXoaPTchon.Click += new System.EventHandler(this.btnXoaPTchon_Click);
            // 
            // btnTongsochan
            // 
            this.btnTongsochan.BackColor = System.Drawing.Color.White;
            this.btnTongsochan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTongsochan.Location = new System.Drawing.Point(6, 202);
            this.btnTongsochan.Name = "btnTongsochan";
            this.btnTongsochan.Size = new System.Drawing.Size(184, 30);
            this.btnTongsochan.TabIndex = 10;
            this.btnTongsochan.Text = "Chọn số chẵn";
            this.btnTongsochan.UseVisualStyleBackColor = false;
            this.btnTongsochan.Click += new System.EventHandler(this.btnTongsochan_Click);
            // 
            // btnTangPT
            // 
            this.btnTangPT.BackColor = System.Drawing.Color.White;
            this.btnTangPT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTangPT.Location = new System.Drawing.Point(6, 166);
            this.btnTangPT.Name = "btnTangPT";
            this.btnTangPT.Size = new System.Drawing.Size(184, 30);
            this.btnTangPT.TabIndex = 9;
            this.btnTangPT.Text = "Tăng phần tử lên 2";
            this.btnTangPT.UseVisualStyleBackColor = false;
            this.btnTangPT.Click += new System.EventHandler(this.btnTangPT_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Nhập số";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(509, 313);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstSo);
            this.Controls.Add(this.btnSo);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xử lý danh sách";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Button btnSo;
        private System.Windows.Forms.ListBox lstSo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTongsochan;
        private System.Windows.Forms.Button btnTangPT;
        private System.Windows.Forms.Button btnBinhPhuong;
        private System.Windows.Forms.Button btnXoaPTchon;
        private System.Windows.Forms.Button btnXoadaucuoi;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button button1;
    }
}

