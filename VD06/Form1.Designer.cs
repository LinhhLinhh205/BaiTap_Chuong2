
namespace VD06
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstThucDon = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstMonAn = new System.Windows.Forms.ListBox();
            this.btnPhai = new System.Windows.Forms.Button();
            this.btnAllPhai = new System.Windows.Forms.Button();
            this.btnAllTrai = new System.Windows.Forms.Button();
            this.btnTrai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập món ăn";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 23);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(304, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhap.ForeColor = System.Drawing.Color.Red;
            this.btnNhap.Location = new System.Drawing.Point(385, 19);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 3;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstThucDon);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(17, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 241);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thực đơn";
            // 
            // lstThucDon
            // 
            this.lstThucDon.FormattingEnabled = true;
            this.lstThucDon.ItemHeight = 16;
            this.lstThucDon.Location = new System.Drawing.Point(6, 22);
            this.lstThucDon.Name = "lstThucDon";
            this.lstThucDon.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstThucDon.Size = new System.Drawing.Size(233, 212);
            this.lstThucDon.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstMonAn);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(329, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 241);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin món ăn";
            // 
            // lstMonAn
            // 
            this.lstMonAn.FormattingEnabled = true;
            this.lstMonAn.ItemHeight = 16;
            this.lstMonAn.Location = new System.Drawing.Point(6, 22);
            this.lstMonAn.Name = "lstMonAn";
            this.lstMonAn.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstMonAn.Size = new System.Drawing.Size(233, 212);
            this.lstMonAn.TabIndex = 5;
            // 
            // btnPhai
            // 
            this.btnPhai.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhai.ForeColor = System.Drawing.Color.Red;
            this.btnPhai.Location = new System.Drawing.Point(268, 126);
            this.btnPhai.Name = "btnPhai";
            this.btnPhai.Size = new System.Drawing.Size(55, 34);
            this.btnPhai.TabIndex = 7;
            this.btnPhai.Text = ">";
            this.btnPhai.UseVisualStyleBackColor = true;
            this.btnPhai.Click += new System.EventHandler(this.btnPhai_Click);
            // 
            // btnAllPhai
            // 
            this.btnAllPhai.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllPhai.ForeColor = System.Drawing.Color.Red;
            this.btnAllPhai.Location = new System.Drawing.Point(268, 160);
            this.btnAllPhai.Name = "btnAllPhai";
            this.btnAllPhai.Size = new System.Drawing.Size(55, 34);
            this.btnAllPhai.TabIndex = 8;
            this.btnAllPhai.Text = ">>";
            this.btnAllPhai.UseVisualStyleBackColor = true;
            this.btnAllPhai.Click += new System.EventHandler(this.btnAllPhai_Click);
            // 
            // btnAllTrai
            // 
            this.btnAllTrai.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllTrai.ForeColor = System.Drawing.Color.Red;
            this.btnAllTrai.Location = new System.Drawing.Point(268, 228);
            this.btnAllTrai.Name = "btnAllTrai";
            this.btnAllTrai.Size = new System.Drawing.Size(55, 34);
            this.btnAllTrai.TabIndex = 10;
            this.btnAllTrai.Text = "<<";
            this.btnAllTrai.UseVisualStyleBackColor = true;
            this.btnAllTrai.Click += new System.EventHandler(this.btnAllTrai_Click);
            // 
            // btnTrai
            // 
            this.btnTrai.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrai.ForeColor = System.Drawing.Color.Red;
            this.btnTrai.Location = new System.Drawing.Point(268, 194);
            this.btnTrai.Name = "btnTrai";
            this.btnTrai.Size = new System.Drawing.Size(55, 34);
            this.btnTrai.TabIndex = 9;
            this.btnTrai.Text = "<";
            this.btnTrai.UseVisualStyleBackColor = true;
            this.btnTrai.Click += new System.EventHandler(this.btnTrai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(592, 356);
            this.Controls.Add(this.btnAllTrai);
            this.Controls.Add(this.btnTrai);
            this.Controls.Add(this.btnAllPhai);
            this.Controls.Add(this.btnPhai);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstThucDon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstMonAn;
        private System.Windows.Forms.Button btnPhai;
        private System.Windows.Forms.Button btnAllPhai;
        private System.Windows.Forms.Button btnAllTrai;
        private System.Windows.Forms.Button btnTrai;
    }
}

