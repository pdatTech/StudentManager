namespace QLSV_1
{
    partial class frmSinhVien
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
            this.txtHo1 = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTendem = new System.Windows.Forms.TextBox();
            this.txtTendem1 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtTen1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbNgaysinh = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuequan1 = new System.Windows.Forms.Label();
            this.rbtNam = new System.Windows.Forms.RadioButton();
            this.rbtNu = new System.Windows.Forms.RadioButton();
            this.txtQuequan = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtDiachi1 = new System.Windows.Forms.Label();
            this.txtEmail1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDienthoai = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHo1
            // 
            this.txtHo1.AutoSize = true;
            this.txtHo1.Location = new System.Drawing.Point(84, 27);
            this.txtHo1.Name = "txtHo1";
            this.txtHo1.Size = new System.Drawing.Size(21, 13);
            this.txtHo1.TabIndex = 0;
            this.txtHo1.Text = "Họ";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(145, 20);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(176, 20);
            this.txtHo.TabIndex = 1;
            // 
            // txtTendem
            // 
            this.txtTendem.Location = new System.Drawing.Point(145, 62);
            this.txtTendem.Name = "txtTendem";
            this.txtTendem.Size = new System.Drawing.Size(176, 20);
            this.txtTendem.TabIndex = 3;
            // 
            // txtTendem1
            // 
            this.txtTendem1.AutoSize = true;
            this.txtTendem1.Location = new System.Drawing.Point(84, 65);
            this.txtTendem1.Name = "txtTendem1";
            this.txtTendem1.Size = new System.Drawing.Size(50, 13);
            this.txtTendem1.TabIndex = 2;
            this.txtTendem1.Text = "Tên đệm";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(145, 108);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(176, 20);
            this.txtTen.TabIndex = 5;
            this.txtTen.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtTen1
            // 
            this.txtTen1.AutoSize = true;
            this.txtTen1.Location = new System.Drawing.Point(84, 108);
            this.txtTen1.Name = "txtTen1";
            this.txtTen1.Size = new System.Drawing.Size(26, 13);
            this.txtTen1.TabIndex = 4;
            this.txtTen1.Text = "Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày sinh";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // mtbNgaysinh
            // 
            this.mtbNgaysinh.Location = new System.Drawing.Point(146, 150);
            this.mtbNgaysinh.Mask = "00/00/0000";
            this.mtbNgaysinh.Name = "mtbNgaysinh";
            this.mtbNgaysinh.Size = new System.Drawing.Size(100, 20);
            this.mtbNgaysinh.TabIndex = 7;
            this.mtbNgaysinh.ValidatingType = typeof(System.DateTime);
            this.mtbNgaysinh.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giới tính";
            // 
            // txtQuequan1
            // 
            this.txtQuequan1.AutoSize = true;
            this.txtQuequan1.Location = new System.Drawing.Point(84, 224);
            this.txtQuequan1.Name = "txtQuequan1";
            this.txtQuequan1.Size = new System.Drawing.Size(54, 13);
            this.txtQuequan1.TabIndex = 9;
            this.txtQuequan1.Text = "Quê quán";
            // 
            // rbtNam
            // 
            this.rbtNam.AutoSize = true;
            this.rbtNam.Checked = true;
            this.rbtNam.Location = new System.Drawing.Point(145, 187);
            this.rbtNam.Name = "rbtNam";
            this.rbtNam.Size = new System.Drawing.Size(47, 17);
            this.rbtNam.TabIndex = 10;
            this.rbtNam.TabStop = true;
            this.rbtNam.Text = "Nam";
            this.rbtNam.UseVisualStyleBackColor = true;
            // 
            // rbtNu
            // 
            this.rbtNu.AutoSize = true;
            this.rbtNu.Location = new System.Drawing.Point(236, 187);
            this.rbtNu.Name = "rbtNu";
            this.rbtNu.Size = new System.Drawing.Size(39, 17);
            this.rbtNu.TabIndex = 11;
            this.rbtNu.Text = "Nữ";
            this.rbtNu.UseVisualStyleBackColor = true;
            // 
            // txtQuequan
            // 
            this.txtQuequan.Location = new System.Drawing.Point(145, 217);
            this.txtQuequan.Name = "txtQuequan";
            this.txtQuequan.Size = new System.Drawing.Size(176, 20);
            this.txtQuequan.TabIndex = 12;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(146, 256);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(176, 20);
            this.txtDiachi.TabIndex = 13;
            // 
            // txtDiachi1
            // 
            this.txtDiachi1.AutoSize = true;
            this.txtDiachi1.Location = new System.Drawing.Point(84, 259);
            this.txtDiachi1.Name = "txtDiachi1";
            this.txtDiachi1.Size = new System.Drawing.Size(40, 13);
            this.txtDiachi1.TabIndex = 14;
            this.txtDiachi1.Text = "Địa chỉ";
            // 
            // txtEmail1
            // 
            this.txtEmail1.AutoSize = true;
            this.txtEmail1.Location = new System.Drawing.Point(84, 297);
            this.txtEmail1.Name = "txtEmail1";
            this.txtEmail1.Size = new System.Drawing.Size(32, 13);
            this.txtEmail1.TabIndex = 16;
            this.txtEmail1.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(146, 294);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(176, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Điện thoại";
            // 
            // txtDienthoai
            // 
            this.txtDienthoai.Location = new System.Drawing.Point(146, 339);
            this.txtDienthoai.Name = "txtDienthoai";
            this.txtDienthoai.Size = new System.Drawing.Size(176, 20);
            this.txtDienthoai.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDienthoai);
            this.Controls.Add(this.txtEmail1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDiachi1);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtQuequan);
            this.Controls.Add(this.rbtNu);
            this.Controls.Add(this.rbtNam);
            this.Controls.Add(this.txtQuequan1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtbNgaysinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtTen1);
            this.Controls.Add(this.txtTendem);
            this.Controls.Add(this.txtTendem1);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.txtHo1);
            this.Name = "frmSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSinhVien";
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtHo1;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTendem;
        private System.Windows.Forms.Label txtTendem1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label txtTen1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtbNgaysinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtQuequan1;
        private System.Windows.Forms.RadioButton rbtNam;
        private System.Windows.Forms.RadioButton rbtNu;
        private System.Windows.Forms.TextBox txtQuequan;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label txtDiachi1;
        private System.Windows.Forms.Label txtEmail1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDienthoai;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}