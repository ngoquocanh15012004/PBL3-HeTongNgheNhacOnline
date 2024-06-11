﻿using Music_Application.BLL;
using System;
using System.Windows.Forms;

namespace Music_Application
{
    public partial class signUpForm : Form
    {
        public signUpForm()
        {
            InitializeComponent();
        }

        private void closeBt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void logInBt_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void signUpBt_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string account = accountTextBox.Text;
            string password = passwordTextBox.Text;
            string rewritePass = rewritePassTextBox.Text;
            if (name == "" || account == "" || password == "" || rewritePass == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                if (rewritePass != password)
                {
                    MessageBox.Show("Mật khẩu nhập lại không trùng khớp!");
                }
                else
                {
                    bool check = BLL_Users.Instance.checkSignUp(account);
                    if (check)
                    {
                        MessageBox.Show("Tài khoản đã tồn tại!");
                    }
                    else
                    {
                        BLL_Users.Instance.addUser(name, account, password);
                        MessageBox.Show("Tạo tài khoản thành công");
                        Close();
                    }
                }
            }
        }
    }
}
