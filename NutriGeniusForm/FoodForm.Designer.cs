namespace NutriGeniusForm
{
    partial class FoodForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodForm));
            cbFoodCategories = new ComboBox();
            label2 = new Label();
            clbFoods = new CheckedListBox();
            lstFoods = new ListBox();
            btnSaveFoods = new Button();
            lblMealName = new Label();
            label3 = new Label();
            btnAddFood = new Button();
            SuspendLayout();
            // 
            // cbFoodCategories
            // 
            cbFoodCategories.FormattingEnabled = true;
            cbFoodCategories.Location = new Point(12, 40);
            cbFoodCategories.Name = "cbFoodCategories";
            cbFoodCategories.Size = new Size(395, 23);
            cbFoodCategories.TabIndex = 1;
            cbFoodCategories.SelectedIndexChanged += cbFoodCategories_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 16);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 0;
            label2.Text = "Kategoriler";
            // 
            // clbFoods
            // 
            clbFoods.FormattingEnabled = true;
            clbFoods.Location = new Point(12, 103);
            clbFoods.Name = "clbFoods";
            clbFoods.Size = new Size(395, 490);
            clbFoods.TabIndex = 2;
            clbFoods.ItemCheck += clbFoods_ItemCheck;
            // 
            // lstFoods
            // 
            lstFoods.FormattingEnabled = true;
            lstFoods.ItemHeight = 15;
            lstFoods.Location = new Point(605, 94);
            lstFoods.Name = "lstFoods";
            lstFoods.Size = new Size(379, 499);
            lstFoods.TabIndex = 3;
            // 
            // btnSaveFoods
            // 
            btnSaveFoods.BackColor = Color.Orange;
            btnSaveFoods.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveFoods.Location = new Point(662, 609);
            btnSaveFoods.Name = "btnSaveFoods";
            btnSaveFoods.Size = new Size(275, 51);
            btnSaveFoods.TabIndex = 4;
            btnSaveFoods.Text = "Kaydet";
            btnSaveFoods.UseVisualStyleBackColor = false;
            btnSaveFoods.Click += btnSaveFoods_Click;
            // 
            // lblMealName
            // 
            lblMealName.AutoSize = true;
            lblMealName.BackColor = Color.Transparent;
            lblMealName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMealName.Location = new Point(753, 38);
            lblMealName.Name = "lblMealName";
            lblMealName.Size = new Size(52, 21);
            lblMealName.TabIndex = 0;
            lblMealName.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(605, 70);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 0;
            label3.Text = "Seçilenler";
            // 
            // btnAddFood
            // 
            btnAddFood.BackColor = Color.YellowGreen;
            btnAddFood.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddFood.Location = new Point(62, 609);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(268, 51);
            btnAddFood.TabIndex = 5;
            btnAddFood.Text = "Aradığım Yemek Listede Yok";
            btnAddFood.UseVisualStyleBackColor = false;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // FoodForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1008, 729);
            Controls.Add(btnAddFood);
            Controls.Add(btnSaveFoods);
            Controls.Add(lstFoods);
            Controls.Add(clbFoods);
            Controls.Add(cbFoodCategories);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lblMealName);
            Name = "FoodForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FoodForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbFoodCategories;
        private Label label2;
        private CheckedListBox clbFoods;
        private ListBox lstFoods;
        private Button btnSaveFoods;
        private Label label3;
        public Label lblMealName;
        private Button btnAddFood;
    }
}