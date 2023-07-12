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
        public UserMainForm()
        {
            InitializeComponent();
        }



        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            new FoodForm().ShowDialog();
            lblMealName
        }

        private void btn_Lunch_Click(object sender, EventArgs e)
        {
            new FoodForm().ShowDialog();
        }

        private void btn_Dinner_Click(object sender, EventArgs e)
        {
            new FoodForm().ShowDialog();
        }

        private void btn_Snack_Click(object sender, EventArgs e)
        {
            new FoodForm().ShowDialog();
        }
    }
}
