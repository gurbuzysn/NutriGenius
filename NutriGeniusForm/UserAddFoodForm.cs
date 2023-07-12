using NutriGenius.Data.Context;
using NutriGenius.Data.Entities.Classes;
using NutriGenius.Data.Entities.Enums;
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
    public partial class UserAddFoodForm : Form
    {
        NutriGeniusDbContext db = new NutriGeniusDbContext();
        public UserAddFoodForm()
        {
            InitializeComponent();
            ListFoodCategories();
        }

        private void ListFoodCategories()
        {
            cbFoodCategories.DataSource = null;
            cbFoodCategories.DataSource = db.FoodCategories.ToList();
            cbFoodCategories.DisplayMember = "CategoryName";
        }

        private void UserAddFoodForm_Load(object sender, EventArgs e)
        {

        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {


            try
            {
                string foodName = txtFoodName.Text;
                string calorie = txtCalories.Text;
                int categoryId = ((FoodCategory)cbFoodCategories.SelectedItem).Id;

                if (string.IsNullOrEmpty(foodName) || string.IsNullOrEmpty(calorie) || cbFoodCategories.SelectedIndex == -1 || cbPortions.SelectedIndex == -1)
                {
                    MessageBox.Show("Tüm alanlar doldurulmalıdır.");
                }

                if (db.Foods.Any(x => x.FoodName.Equals(foodName)))  // Aynı isimde yemek varsa Çık!
                {
                    MessageBox.Show("Bu yemek zaten mevcut!");
                    return;
                }


                db.Foods.Add(new Food()
                {
                    FoodName = foodName,
                    FoodCategoryId = categoryId,
                    Portions = new List<Portion>()
                {
                            new Portion() { Amount = 1, Unit = (Unit)cbPortions.SelectedIndex, Calorie = Convert.ToDouble(calorie) }
                }
                }
                );

                MessageBox.Show("Yemek başarıyla eklenmiştir.");
                db.SaveChanges();
                Close();

            }
            catch (FormatException)
            {
                MessageBox.Show("Kalori sayısal bir değer olmak zorundadır.");
            }

        }
    }
}
