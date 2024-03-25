
namespace VD12
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
            this.txtTen = new System.Windows.Forms.TextBox();
            this.picMo = new System.Windows.Forms.PictureBox();
            this.picTat = new System.Windows.Forms.PictureBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(65, 11);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(227, 27);
            this.txtTen.TabIndex = 1;
            this.txtTen.Text = "Linh";
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // picMo
            // 
            this.picMo.Image = global::VD12.Properties.Resources.LightOFF;
            this.picMo.Location = new System.Drawing.Point(27, 44);
            this.picMo.Name = "picMo";
            this.picMo.Size = new System.Drawing.Size(265, 190);
            this.picMo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMo.TabIndex = 3;
            this.picMo.TabStop = false;
            this.picMo.Visible = false;
            // 
            // picTat
            // 
            this.picTat.Image = global::VD12.Properties.Resources.LightON;
            this.picTat.Location = new System.Drawing.Point(27, 44);
            this.picTat.Name = "picTat";
            this.picTat.Size = new System.Drawing.Size(265, 190);
            this.picTat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTat.TabIndex = 2;
            this.picTat.TabStop = false;
            // 
            // btnChon
            // 
            this.btnChon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Location = new System.Drawing.Point(27, 245);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(264, 32);
            this.btnChon.TabIndex = 4;
            this.btnChon.Text = ".Tắt đèn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Maroon;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(221, 288);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(69, 29);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(320, 326);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.picMo);
            this.Controls.Add(this.picTat);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Bật tắt bóng đèn";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.PictureBox picTat;
        private System.Windows.Forms.PictureBox picMo;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnThoat;
    }
}

