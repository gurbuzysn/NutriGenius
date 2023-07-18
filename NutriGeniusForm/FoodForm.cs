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
        User currentUser = SessionManager.CurrentUser;
        Meal currentMeal = SessionManager.CurrentMeal;
        List<UserMealFoodPortion> selectedUfs = new List<UserMealFoodPortion>();

        Food? food;
        Portion? portion;
        double piece;

        public FoodForm()
        {
            LoadData();
            InitializeComponent();
            WriteMealName();
            ListFoodCategories();
            UpdateFoods();
        }

        private void LoadData()
        {

            if (db.Entry(currentMeal).State == EntityState.Detached)
            {
                db.Attach(currentMeal);
            }

            selectedUfs.AddRange(db.UserMealFoodPortions.Include(uf => uf.User).Include(uf => uf.Meal).Include(uf => uf.Food).Include(uf => uf.Portion)
                .Where(uf => uf.UserId == currentUser.Id && uf.MealId == currentMeal.Id && uf.Meal!.MealDate == currentMeal.MealDate));
        }
        private void WriteMealName()
        {
            lblMealName.Text = currentMeal.MealName;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void ListFoodCategories()   // Yemek Kategorilerini Listele
        {
            cbFoodCategories.Items.Clear();
            foreach (FoodCategory foodCategory in db.FoodCategories)
            {
                cbFoodCategories.Items.Add(foodCategory);
            }
        }

        private void cbFoodCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFoodCategories.SelectedIndex == -1) return;


            ListFoods();
        }

        private void ListFoods()
        {
            cbFoods.DataSource = null;
            cbFoods.DataSource = db.Foods
                .Where(f => f.FoodCategoryId == ((FoodCategory)(cbFoodCategories.SelectedItem)).Id).ToList();
        }

        private void cbFoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFoods.SelectedIndex == -1) return;

            ListPortions();
        }

        private void ListPortions()
        {
            cbPortions.DataSource = null;

            cbPortions.DataSource = db.Foods.Include(x => x.Portions).First(p => p.Id == ((Food)cbFoods.SelectedItem).Id).Portions.ToList();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnSaveFoods_Click(object sender, EventArgs e)  // Seçtiği yemekleri veri tabanındaki kendi user ının öğünlerine ekleyecek
        {
            if (selectedUfs.Count == 0)
            {
                MessageBox.Show("Öğüne eklenecek ürün bulunmamaktadır.");
            }


            DialogResult dialogResult = MessageBox.Show($"Seçili yemekleri {currentMeal.MealName} öğününüze eklemek istediğinize emin misiniz?", "Ekleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (dialogResult == DialogResult.No) return;



            currentMeal.UserMealFoodPortions.RemoveAll(x => x.UserId == currentUser.Id);
            currentMeal.UserMealFoodPortions.AddRange(selectedUfs);
            currentMeal.Calorie = 0;
            currentMeal.Calorie += currentMeal.UserMealFoodPortions.Sum(uf => uf.Portion!.Calorie * uf.Portion.Amount);

            db.SaveChanges();
            MessageBox.Show($"Yemekler {currentMeal.MealName} öğününüze başarıyla eklenmiştir");
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFoods.SelectedRows.Count < 0) return;


            string deletedFood = dgvFoods.SelectedRows[0].Cells[0].Value.ToString();
            UserMealFoodPortion deletedUmfp = selectedUfs.FirstOrDefault(x => x.Food.FoodName == deletedFood);

            DialogResult dr = MessageBox.Show("Seçili ürünü silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (dr == DialogResult.Yes)
            {
                selectedUfs.Remove(deletedUmfp);
                UpdateFoods();
                MessageBox.Show("Ürün başarıyla silindi");
            }

        }

        private void UpdateFoods()
        {
            if (selectedUfs.Count == 0) return;

            dgvFoods.DataSource = null;
            dgvFoods.DataSource = selectedUfs.Select(x => new
            {
                UrunIsmi = x.Food.FoodName,
                Kalori = x.Portion!.Calorie * x.Portion.Amount
            }).ToList();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            FoodCategory foodCategory = ((FoodCategory)(cbFoodCategories.SelectedItem));
            food = ((Food)(cbFoods.SelectedItem));
            portion = ((Portion)(cbPortions.SelectedItem));
            piece = (double)nudPiece.Value;
            portion.Amount = piece;

            if (selectedUfs.Any(x => x.FoodId == food.Id))
            {
                MessageBox.Show("Eklemek istediğiniz ürün listede mevcuttur.");
                return;
            }

            selectedUfs.Add(new UserMealFoodPortion()
            {
                UserId = db.Users.FirstOrDefault(u => u.Id == currentUser.Id)!.Id,
                MealId = currentMeal.Id,
                FoodId = food.Id,
                PortionId = portion.Id,

                User = db.Users.FirstOrDefault(u => u.Id == currentUser.Id),
                Meal = currentMeal,
                Food = food,
                Portion = portion
            });

            UpdateFoods();
        }

        private void btnAddNewFood_Click(object sender, EventArgs e)  // Yeni Yemek Ekleme Sayfası Açılacak
        {
            new UserAddFoodForm().ShowDialog();
        }

        private void FoodForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            new UserMainForm().ShowDialog();
        }

       
    }
}
