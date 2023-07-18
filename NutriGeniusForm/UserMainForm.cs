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
        Meal? currentMeal;
        User? dbUser;

        List<UserMealFoodPortion>? userMeals;

        public UserMainForm()
        {
            InitializeComponent();
            ShowUserName();
            LoadData();
            GetUserMeal();
            ListMeal();
        }

        private void ListMeal()
        {
            lstBreakfast.DataSource = null;
            lstBreakfast.DataSource = db.Foods.Where(x => x.Id == 1).ToList();

            
        }

        private void GetUserMeal()  // Mevcut Kullanıcının dtpDate de seçili olan tarihte yediği yemekler 
        {
            userMeals = dbUser?.UserMealFoodPortions.Where(x => x.Meal.MealDate == dtpDate.Value.Date).ToList();
        }

        private void LoadData()
        {
            dbUser = db.Users.Include(x => x.UserMealFoodPortions).ThenInclude(x => x.Meal).FirstOrDefault(x => x.UserName == currentUser.UserName);
        }

        private void ShowUserName()
        {
            lblName.Text = "Merhaba " + currentUser.FirstName;
            lblProfileName.Text = currentUser.FirstName;
        }

        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            currentMeal = userMeals?.FirstOrDefault(x => x.Meal.MealName == "Kahvaltı")?.Meal;

            if (currentMeal == null)
            {
                currentMeal = new Breakfast() { MealDate = dtpDate.Value.Date };
            }

            CheckMeal(currentMeal);
        }



        private void btn_Lunch_Click(object sender, EventArgs e)
        {
            currentMeal = userMeals?.FirstOrDefault(x => x.Meal.MealName == "Öğle Yemeği")?.Meal;

            if (currentMeal == null)
            {
                currentMeal = new Lunch() { MealDate = dtpDate.Value.Date };
            }

            CheckMeal(currentMeal);
        }

        private void btn_Dinner_Click(object sender, EventArgs e)
        {
            currentMeal = userMeals?.FirstOrDefault(x => x.Meal.MealName == "Akşam Yemeği")?.Meal;

            if (currentMeal == null)
            {
                currentMeal = new Dinner() { MealDate = dtpDate.Value.Date };
            }

            CheckMeal(currentMeal);
        }

        private void btn_Snack_Click(object sender, EventArgs e)
        {
            currentMeal = userMeals?.FirstOrDefault(x => x.Meal.MealName == "Ara Öğün")?.Meal;

            if (currentMeal == null)
            {
                currentMeal = new Snack() { MealDate = dtpDate.Value.Date };
            }

            CheckMeal(currentMeal);
        }

        private void CheckMeal(Meal meal)
        {
            SessionManager.CurrentMeal = meal;
            db.Entry(meal).State = EntityState.Detached;
            db.SaveChanges();
            Close();
            new FoodForm().ShowDialog();
        }
    }
}
