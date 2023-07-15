
using NutriGenius.Data.Context;
using NutriGenius.Data.Entities;
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
        NutriGeniusDbContext db = new NutriGeniusDbContext();

        public LoginForm()
        {
            InitializeComponent();
        }

        User? logInUser;

        private void btnLogın_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş olamaz!+");
                return;
            }

            logInUser = new User();

            if (logInUser.LogIn(db, txtUserName.Text, txtPassword.Text))
            {
                logInUser = db.Users.FirstOrDefault(u => u.UserName == txtUserName.Text);
                SessionManager.CurrentUser = logInUser!;
                new UserMainForm().ShowDialog();

            }
            else
                MessageBox.Show("Şifre veya kullanıcı hatalıdır!");
        }


    }
}
