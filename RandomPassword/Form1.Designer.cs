namespace RandomPassword
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkUppercase = new System.Windows.Forms.CheckBox();
            this.chkNumbers = new System.Windows.Forms.CheckBox();
            this.chkSpecial = new System.Windows.Forms.CheckBox();
            this.chk_lowercase = new System.Windows.Forms.CheckBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txtlength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_password_2 = new System.Windows.Forms.TextBox();
            this.txt_password_3 = new System.Windows.Forms.TextBox();
            this.txt_password_4 = new System.Windows.Forms.TextBox();
            this.txt_password_6 = new System.Windows.Forms.TextBox();
            this.txt_password_7 = new System.Windows.Forms.TextBox();
            this.txt_password_8 = new System.Windows.Forms.TextBox();
            this.txt_password_9 = new System.Windows.Forms.TextBox();
            this.txt_password_10 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_password_5 = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(207, 269);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(95, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Tạo Mật Khẩu";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkUppercase);
            this.groupBox1.Controls.Add(this.chkNumbers);
            this.groupBox1.Controls.Add(this.chkSpecial);
            this.groupBox1.Controls.Add(this.chk_lowercase);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
            // 
            // chkUppercase
            // 
            this.chkUppercase.AutoSize = true;
            this.chkUppercase.Checked = true;
            this.chkUppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUppercase.Location = new System.Drawing.Point(18, 42);
            this.chkUppercase.Name = "chkUppercase";
            this.chkUppercase.Size = new System.Drawing.Size(75, 17);
            this.chkUppercase.TabIndex = 5;
            this.chkUppercase.Text = "CHỮ HOA";
            this.chkUppercase.UseVisualStyleBackColor = true;
            // 
            // chkNumbers
            // 
            this.chkNumbers.AutoSize = true;
            this.chkNumbers.Checked = true;
            this.chkNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNumbers.Location = new System.Drawing.Point(18, 69);
            this.chkNumbers.Name = "chkNumbers";
            this.chkNumbers.Size = new System.Drawing.Size(41, 17);
            this.chkNumbers.TabIndex = 4;
            this.chkNumbers.Text = "SỐ";
            this.chkNumbers.UseVisualStyleBackColor = true;
            // 
            // chkSpecial
            // 
            this.chkSpecial.AutoSize = true;
            this.chkSpecial.Checked = true;
            this.chkSpecial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSpecial.Location = new System.Drawing.Point(18, 94);
            this.chkSpecial.Name = "chkSpecial";
            this.chkSpecial.Size = new System.Drawing.Size(110, 17);
            this.chkSpecial.TabIndex = 3;
            this.chkSpecial.Text = "KÝ TỰ ĐẶC BIỆT";
            this.chkSpecial.UseVisualStyleBackColor = true;
            // 
            // chk_lowercase
            // 
            this.chk_lowercase.AutoSize = true;
            this.chk_lowercase.Checked = true;
            this.chk_lowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_lowercase.Location = new System.Drawing.Point(18, 19);
            this.chk_lowercase.Name = "chk_lowercase";
            this.chk_lowercase.Size = new System.Drawing.Size(99, 17);
            this.chk_lowercase.TabIndex = 2;
            this.chk_lowercase.Text = "CHỮ THƯỜNG";
            this.chk_lowercase.UseVisualStyleBackColor = true;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.Red;
            this.txt_password.Location = new System.Drawing.Point(87, 55);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(215, 20);
            this.txt_password.TabIndex = 3;
            // 
            // txtlength
            // 
            this.txtlength.Location = new System.Drawing.Point(99, 153);
            this.txtlength.Name = "txtlength";
            this.txtlength.Size = new System.Drawing.Size(408, 20);
            this.txtlength.TabIndex = 5;
            this.txtlength.Text = "12";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Độ dài ký tự:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RandomPassword.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(549, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txt_password_2
            // 
            this.txt_password_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password_2.ForeColor = System.Drawing.Color.Red;
            this.txt_password_2.Location = new System.Drawing.Point(87, 93);
            this.txt_password_2.Name = "txt_password_2";
            this.txt_password_2.Size = new System.Drawing.Size(215, 20);
            this.txt_password_2.TabIndex = 7;
            // 
            // txt_password_3
            // 
            this.txt_password_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password_3.ForeColor = System.Drawing.Color.Red;
            this.txt_password_3.Location = new System.Drawing.Point(87, 138);
            this.txt_password_3.Name = "txt_password_3";
            this.txt_password_3.Size = new System.Drawing.Size(215, 20);
            this.txt_password_3.TabIndex = 8;
            // 
            // txt_password_4
            // 
            this.txt_password_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password_4.ForeColor = System.Drawing.Color.Red;
            this.txt_password_4.Location = new System.Drawing.Point(87, 179);
            this.txt_password_4.Name = "txt_password_4";
            this.txt_password_4.Size = new System.Drawing.Size(215, 20);
            this.txt_password_4.TabIndex = 9;
            // 
            // txt_password_6
            // 
            this.txt_password_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password_6.ForeColor = System.Drawing.Color.Red;
            this.txt_password_6.Location = new System.Drawing.Point(322, 55);
            this.txt_password_6.Name = "txt_password_6";
            this.txt_password_6.Size = new System.Drawing.Size(215, 20);
            this.txt_password_6.TabIndex = 11;
            // 
            // txt_password_7
            // 
            this.txt_password_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password_7.ForeColor = System.Drawing.Color.Red;
            this.txt_password_7.Location = new System.Drawing.Point(322, 93);
            this.txt_password_7.Name = "txt_password_7";
            this.txt_password_7.Size = new System.Drawing.Size(215, 20);
            this.txt_password_7.TabIndex = 12;
            // 
            // txt_password_8
            // 
            this.txt_password_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password_8.ForeColor = System.Drawing.Color.Red;
            this.txt_password_8.Location = new System.Drawing.Point(322, 138);
            this.txt_password_8.Name = "txt_password_8";
            this.txt_password_8.Size = new System.Drawing.Size(215, 20);
            this.txt_password_8.TabIndex = 13;
            // 
            // txt_password_9
            // 
            this.txt_password_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password_9.ForeColor = System.Drawing.Color.Red;
            this.txt_password_9.Location = new System.Drawing.Point(322, 179);
            this.txt_password_9.Name = "txt_password_9";
            this.txt_password_9.Size = new System.Drawing.Size(215, 20);
            this.txt_password_9.TabIndex = 14;
            // 
            // txt_password_10
            // 
            this.txt_password_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password_10.ForeColor = System.Drawing.Color.Red;
            this.txt_password_10.Location = new System.Drawing.Point(322, 220);
            this.txt_password_10.Name = "txt_password_10";
            this.txt_password_10.Size = new System.Drawing.Size(215, 20);
            this.txt_password_10.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.txt_password_5);
            this.groupBox2.Controls.Add(this.txt_password_10);
            this.groupBox2.Controls.Add(this.txt_password);
            this.groupBox2.Controls.Add(this.txt_password_9);
            this.groupBox2.Controls.Add(this.txt_password_2);
            this.groupBox2.Controls.Add(this.txt_password_8);
            this.groupBox2.Controls.Add(this.btnGenerate);
            this.groupBox2.Controls.Add(this.txt_password_7);
            this.groupBox2.Controls.Add(this.txt_password_3);
            this.groupBox2.Controls.Add(this.txt_password_6);
            this.groupBox2.Controls.Add(this.txt_password_4);
            this.groupBox2.Location = new System.Drawing.Point(12, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(632, 316);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mật khẩu Random";
            // 
            // txt_password_5
            // 
            this.txt_password_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password_5.ForeColor = System.Drawing.Color.Red;
            this.txt_password_5.Location = new System.Drawing.Point(87, 220);
            this.txt_password_5.Name = "txt_password_5";
            this.txt_password_5.Size = new System.Drawing.Size(215, 20);
            this.txt_password_5.TabIndex = 16;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(322, 269);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 23);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Làm Mới";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 532);
            this.Controls.Add(this.txtlength);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "[C#] Random Password - hai.nh";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkUppercase;
        private System.Windows.Forms.CheckBox chkNumbers;
        private System.Windows.Forms.CheckBox chkSpecial;
        private System.Windows.Forms.CheckBox chk_lowercase;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txtlength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_password_2;
        private System.Windows.Forms.TextBox txt_password_3;
        private System.Windows.Forms.TextBox txt_password_4;
        private System.Windows.Forms.TextBox txt_password_6;
        private System.Windows.Forms.TextBox txt_password_7;
        private System.Windows.Forms.TextBox txt_password_8;
        private System.Windows.Forms.TextBox txt_password_9;
        private System.Windows.Forms.TextBox txt_password_10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_password_5;
        private System.Windows.Forms.Button btnReset;
    }
}

