using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myproj
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void username_txt_Click(object sender, EventArgs e)
        {
            username_txt.Text = "";
            username_txt.ForeColor = Color.Black;
        }

        private void pass_txt_Click(object sender, EventArgs e)
        {
            pass_txt.Text = "";
            pass_txt.ForeColor = Color.Black;
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(username_txt.Text))
            {
                if (checkusername(username_txt.Text))
                {
                    if (checkPass(pass_txt.Text))
                    {
                        if (conf_txt.Text.Equals(pass_txt.Text))
                        {
                            using (var data = new DataClasses1DataContext())
                            {
                                var us = new user();
                                us.username = username_txt.Text;
                                us.password = pass_txt.Text;
                                data.users.InsertOnSubmit(us);
                                data.SubmitChanges();
                            }
                            MessageBox.Show("User Inserted.");
                            Thread thread = new Thread(() =>
                            {
                                Application.Run(new Login());
                            });
                            thread.Start();
                            this.Close();
                        }
                        else
                            MessageBox.Show("Please Confirm Your Password Correctly!!");
                    }
                    else
                        label2.Show();
                }
                else
                    MessageBox.Show("This Username is Already Exist!!");
            }
            else
                MessageBox.Show("Username Can't be Empty!!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Hide();
        }

        private Boolean checkPass(string str)
        {
            if(str.Length > 8 && str.Length < 16 && (str.Contains('@') || str.Contains('#') || str.Contains('*')))
            {
                return true;
            }
            return false;
        }
        private Boolean checkusername(string str)
        {
            using(var data = new DataClasses1DataContext())
            {
                var username = from user in data.users
                               where user.username == str
                               select user;
                return username.Count() == 0;
            }
        }

        private void conf_txt_Click(object sender, EventArgs e)
        {
            conf_txt.Text = "";
            conf_txt.ForeColor = Color.Black;
            conf_txt.UseSystemPasswordChar = true;
        }

       
    }
}
