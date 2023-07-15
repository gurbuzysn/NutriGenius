using Microsoft.EntityFrameworkCore;
using NutriGenius.Data.Context;
using NutriGenius.Data.Entities;
using NutriGenius.Data.Entities.AbstractClasses;
using NutriGenius.Data.Entities.Classes;
using NutriGenius.Data.Entities.SubClasses_Meal;
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
    public partial class UserMainForm : Form
    {
        NutriGeniusDbContext db = new NutriGeniusDbContext();
        User currentUser = SessionManager.CurrentUser;
        Meal currentMeal;

        User dbUser;

        public UserMainForm()
        {

            InitializeComponent();
            ShowUserName();
        }

        private void ShowUserName()
        {
            lblName.Text = lblProfileName.Text = currentUser.FirstName;
        }

        private void btnBreakfast_Click(object sender, EventArgs e)
        {

            if (currentMeal == null)
            {
                currentMeal = new Breakfast() { MealDate = DateTime.Now.Date };
            }



            SessionManager.CurrentMeal = currentMeal;                           // Bu formdaki meal bilgilerini SessionManager Meal a gönderdik. Bir sonraki forma geçince bunu rahatça kullanabileceğiz
            new FoodForm().ShowDialog();

        }

        private void btn_Lunch_Click(object sender, EventArgs e)
        {
            currentMeal = new Lunch() { MealDate = DateTime.Now.Date };
            SessionManager.CurrentMeal = currentMeal;
            new FoodForm().ShowDialog();
        }

        private void btn_Dinner_Click(object sender, EventArgs e)
        {
            currentMeal = new Dinner() { MealDate = DateTime.Now.Date };
            SessionManager.CurrentMeal = currentMeal;
            new FoodForm().ShowDialog();
        }

        private void btn_Snack_Click(object sender, EventArgs e)
        {
            currentMeal = new Snack() { MealDate = DateTime.Now.Date };
            SessionManager.CurrentMeal = currentMeal;
            new FoodForm().ShowDialog();
        }








        private void pbProfile_Click(object sender, EventArgs e)  // ProfileForm Opened
        {
            new ProfileForm().ShowDialog();
        }
    }
}
