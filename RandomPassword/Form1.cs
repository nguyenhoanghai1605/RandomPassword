using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomPassword
{
    public partial class Form1 : Form
    {
        private List<TextBox> passwordTextBoxes = new List<TextBox>();
        public Form1()
        {
            InitializeComponent();
            InitializePasswordTextBoxes();

            // Thêm sự kiện Click cho nút "Làm mới"
            btnReset.Click += btnReset_Click;
        }

        //private void btnGenerate_Click(object sender, EventArgs e)
        //{
        //    List<string> generatedPasswords = new List<string>();

        //    foreach (TextBox textBox in passwordTextBoxes)
        //    {
        //        string newPassword;
        //        do
        //        {
        //            newPassword = GeneratePassword(chk_lowercase.Checked, chkUppercase.Checked, chkNumbers.Checked, chkSpecial.Checked, int.Parse(txtlength.Text));
        //        } while (generatedPasswords.Contains(newPassword));

        //        generatedPasswords.Add(newPassword);
        //        textBox.Text = newPassword;
        //    }
        //}

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            List<string> generatedPasswords = new List<string>();

            // Kiểm tra xem ít nhất một checkbox đã được chọn
            if (!chk_lowercase.Checked && !chkUppercase.Checked && !chkNumbers.Checked && !chkSpecial.Checked)
            {
                MessageBox.Show("Chưa chọn định dạng!");
                return;
            }

            foreach (TextBox textBox in passwordTextBoxes)
            {
                string newPassword;
                do
                {
                    newPassword = GeneratePassword(chk_lowercase.Checked, chkUppercase.Checked, chkNumbers.Checked, chkSpecial.Checked, int.Parse(txtlength.Text));
                } while (generatedPasswords.Contains(newPassword));

                generatedPasswords.Add(newPassword);
                textBox.Text = newPassword;
            }
        }


        private void InitializePasswordTextBoxes()
        {
            // Thêm các TextBox vào danh sách
            passwordTextBoxes.Add(txt_password);
            passwordTextBoxes.Add(txt_password_2);
            passwordTextBoxes.Add(txt_password_3);
            passwordTextBoxes.Add(txt_password_4);
            passwordTextBoxes.Add(txt_password_5);
            passwordTextBoxes.Add(txt_password_6);
            passwordTextBoxes.Add(txt_password_7);
            passwordTextBoxes.Add(txt_password_8);
            passwordTextBoxes.Add(txt_password_9);
            passwordTextBoxes.Add(txt_password_10);
        }

        const string LOWER_CASE = "abcdefghijklmnopqursuvwxyz";
        const string UPPER_CASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string NUMBERS = "0123456789";
        const string SPECIALS = @"!@£$%^&*()#€";

        public string GeneratePassword(bool useLowercase, bool useUppercase, bool useNumbers, bool useSpecial, int passwordSize)
        {
            try
            {
                char[] _password = new char[passwordSize];
                string charSet = "";
                System.Random _random = new Random();
                int counter;


                if (useLowercase) charSet += LOWER_CASE;

                if (useUppercase) charSet += UPPER_CASE;

                if (useNumbers) charSet += NUMBERS;

                if (useSpecial) charSet += SPECIALS;

                for (counter = 0; counter < passwordSize; counter++)
                {
                    _password[counter] = charSet[_random.Next(charSet.Length - 1)];
                }

                return string.Join(null, _password);
                //return new string(_password);
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa chọn định dạng!");
                return string.Empty;
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (TextBox textBox in passwordTextBoxes)
            {
                textBox.Text = string.Empty;
            }
        }
    }
}

