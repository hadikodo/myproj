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
    public partial class Login : Form
    {
        private Register reg = new Register();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

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
            Thread thread = new Thread(() =>
            {
                Application.Run(new Register());
            });
            thread.Start();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkLogin(username_txt.Text, pass_txt.Text))
            {
                Thread thread = new Thread(() =>
                {
                    Application.Run(new MainForm());
                });
                thread.Start();
                this.Close();
            }
            else
                MessageBox.Show("Incorrect Username or Password!!");
        }

        private Boolean checkLogin(string username,string password)
        {
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                using (var data = new DataClasses1DataContext())
                {
                    var user = from d in data.users
                               where d.username == username_txt.Text
                               select d;
                    if (user.Count() == 0)
                        return false;
                    else
                    {
                        foreach (var u in user)
                        {
                            if (u.username.Equals(username) && u.password.Equals(password))
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return false;
        }
    }
}
