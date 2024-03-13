
using System;

namespace ViDu_02
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
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.LbKetqua = new System.Windows.Forms.Label();
            this.btnHo = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTiep = new System.Windows.Forms.Button();
            this.btnHoTen = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ lót";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(74, 19);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(247, 23);
            this.txtHo.TabIndex = 1;
            this.txtHo.Text = "Nguyễn Ngọc";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(74, 48);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(146, 23);
            this.txtTen.TabIndex = 3;
            this.txtTen.Text = "Linh";
            // 
            // LbKetqua
            // 
            this.LbKetqua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LbKetqua.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbKetqua.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbKetqua.Location = new System.Drawing.Point(0, 0);
            this.LbKetqua.Name = "LbKetqua";
            this.LbKetqua.Size = new System.Drawing.Size(497, 35);
            this.LbKetqua.TabIndex = 4;
            this.LbKetqua.Text = "Nguyễn Ngọc Linh";
            this.LbKetqua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbKetqua.Click += new System.EventHandler(this.LbKetqua_Click);
            // 
            // btnHo
            // 
            this.btnHo.BackColor = System.Drawing.Color.White;
            this.btnHo.Location = new System.Drawing.Point(25, 86);
            this.btnHo.Name = "btnHo";
            this.btnHo.Size = new System.Drawing.Size(58, 30);
            this.btnHo.TabIndex = 5;
            this.btnHo.Text = "Họ";
            this.btnHo.UseVisualStyleBackColor = false;
            this.btnHo.Click += new System.EventHandler(this.btnHo_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(259, 86);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 30);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTiep
            // 
            this.btnTiep.BackColor = System.Drawing.Color.White;
            this.btnTiep.Location = new System.Drawing.Point(210, 86);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(58, 30);
            this.btnTiep.TabIndex = 7;
            this.btnTiep.Text = "Tiếp";
            this.btnTiep.UseVisualStyleBackColor = false;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // btnHoTen
            // 
            this.btnHoTen.BackColor = System.Drawing.Color.White;
            this.btnHoTen.Location = new System.Drawing.Point(123, 86);
            this.btnHoTen.Name = "btnHoTen";
            this.btnHoTen.Size = new System.Drawing.Size(96, 30);
            this.btnHoTen.TabIndex = 8;
            this.btnHoTen.Text = "Họ và tên";
            this.btnHoTen.UseVisualStyleBackColor = false;
            this.btnHoTen.Click += new System.EventHandler(this.btnHoTen_Click);
            // 
            // btnTen
            // 
            this.btnTen.BackColor = System.Drawing.Color.White;
            this.btnTen.Location = new System.Drawing.Point(74, 86);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(58, 30);
            this.btnTen.TabIndex = 9;
            this.btnTen.Text = "Tên";
            this.btnTen.UseVisualStyleBackColor = false;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btnHoTen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnTiep);
            this.groupBox1.Controls.Add(this.txtHo);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.btnHo);
            this.groupBox1.Controls.Add(this.btnTen);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 221);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin họ tên";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(497, 292);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LbKetqua);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void LbKetqua_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label LbKetqua;
        private System.Windows.Forms.Button btnHo;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Button btnHoTen;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

