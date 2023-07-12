
using NutriGenius.Data.Context;
using NutriGenius.Data.Entities.Classes;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriGeniusForm
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        User? logInUser;

        private void btnLogın_Click(object sender, EventArgs e)
        {
            using (var db = new NutriGeniusDbContext())
            {
                logInUser = new User();


                if (logInUser.LogIn(db, txtUserName.Text, txtPassword.Text))
                {
                    logInUser = db.Users.FirstOrDefault(u => u.UserName == txtUserName.Text);
                        new UserMainForm(logInUser).ShowDialog();

                }
                else
                    MessageBox.Show("Şifre veya kullanıcı hatalıdır!");
            }
        }


    }
}
