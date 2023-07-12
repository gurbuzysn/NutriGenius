﻿using NutriGenius.Data.Context;
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
        public FoodForm()
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
        private void cbFoodCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFoodCategories.SelectedIndex == -1) return;

            int foodCategoryId = ((FoodCategory)(cbFoodCategories.SelectedItem)).Id;

            clbFoods.Items.Clear();

            foreach (var food in db.Foods.Where(x => x.FoodCategoryId == foodCategoryId))
            {
                clbFoods.Items.Add(food);
            }

            CheckControl();
        }

        private void CheckControl()
        {
            clbFoods.ItemCheck -= clbFoods_ItemCheck;

            foreach (Food item in lstFoods.Items)
            {
                if (clbFoods.Items.Contains(item))
                {
                    int index = clbFoods.Items.IndexOf(item);
                    clbFoods.SetItemCheckState(index, CheckState.Checked);
                }
            }

            clbFoods.ItemCheck += clbFoods_ItemCheck;
        }

        private void clbFoods_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Food food = (Food)clbFoods.SelectedItem;

            if (e.NewValue == CheckState.Checked)
            {
                lstFoods.Items.Add(food);
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                lstFoods.Items.Remove(food);
            }






            //lstFoods.Items.Clear();
            //foreach (var item in clbFoods.CheckedItems)
            //{
            //    lstFoods.Items.Add(item);
            //}
        }




        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }
    }
}