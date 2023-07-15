using Microsoft.EntityFrameworkCore;
using NutriGenius.Data.Context;
using NutriGenius.Data.Entities;
using NutriGenius.Data.Entities.AbstractClasses;
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
    public partial class FoodForm : Form
    {
        NutriGeniusDbContext db = new NutriGeniusDbContext();
        User user = SessionManager.CurrentUser;
        Meal meal = SessionManager.CurrentMeal;

        public FoodForm()
        {
            InitializeComponent();
            ListFoodCategories();

            lblMealName.Text = meal.MealName;
        }

        private void ListFoodCategories()
        {
            cbFoodCategories.Items.Clear();
            foreach (FoodCategory foodCategory in db.FoodCategories)
            {
                cbFoodCategories.Items.Add(foodCategory);
            }
            cbFoodCategories.SelectedIndex = 0;
        }

        private void cbFoodCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFoodCategories.SelectedIndex == -1) return;
            ListFoods();
        }

        private void ListFoods()
        {
            cbFoods.Items.Clear();
            IQueryable selectedCategoriesFoods = db.Foods.Where(f => f.FoodCategoryId == ((FoodCategory)(cbFoodCategories.SelectedItem)).Id);
            //Kategorilerde seçili olan kategoriye ait yemekleri getir
            foreach (Food food in selectedCategoriesFoods)
            {
                cbFoods.Items.Add(food);
            }
        }

        private void cbFoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListPortions();
        }

        private void ListPortions()
        {
            cbPortions.Items.Clear();

            List<Portion> portions = new List<Portion>();
            portions = db.Foods
                .Include(f => f.Portions)
                .FirstOrDefault(f => f.Id == ((Food)(cbFoods.SelectedItem)).Id)!.Portions.ToList();

            foreach (var item in portions)
            {
                cbPortions.Items.Add(item);
            }
        }





        private void btnAddFood_Click(object sender, EventArgs e)  // Yeni Yemek Ekleme Sayfası Açılacak
        {
            new UserAddFoodForm().ShowDialog();
        }

        private void btnSaveFoods_Click(object sender, EventArgs e)  // Seçtiği yemekleri veri tabanındaki kendi user ının öğünlerine ekleyecek
        {


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FoodCategory foodCategory = ((FoodCategory)(cbFoodCategories.SelectedItem));
            Food food = ((Food)(cbFoods.SelectedItem));
            Portion portion = ((Portion)(cbPortions.SelectedItem));
            int piece = (int)nudPiece.Value;




        }
    }
}
