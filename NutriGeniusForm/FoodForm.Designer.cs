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
            btnSaveFoods = new Button();
            lblMealName = new Label();
            label3 = new Label();
            btnAddFood = new Button();
            label1 = new Label();
            cbFoods = new ComboBox();
            label4 = new Label();
            cbPortions = new ComboBox();
            label5 = new Label();
            btnAdd = new Button();
            nudPiece = new NumericUpDown();
            dgvSelectedFoods = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudPiece).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSelectedFoods).BeginInit();
            SuspendLayout();
            // 
            // cbFoodCategories
            // 
            cbFoodCategories.FormattingEnabled = true;
            cbFoodCategories.Location = new Point(30, 289);
            cbFoodCategories.Name = "cbFoodCategories";
            cbFoodCategories.Size = new Size(395, 23);
            cbFoodCategories.TabIndex = 1;
            cbFoodCategories.SelectedIndexChanged += cbFoodCategories_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 265);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 0;
            label2.Text = "Kategoriler";
            // 
            // btnSaveFoods
            // 
            btnSaveFoods.BackColor = Color.Orange;
            btnSaveFoods.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveFoods.Location = new Point(582, 620);
            btnSaveFoods.Name = "btnSaveFoods";
            btnSaveFoods.Size = new Size(379, 37);
            btnSaveFoods.TabIndex = 4;
            btnSaveFoods.Text = "Kaydet";
            btnSaveFoods.UseVisualStyleBackColor = false;
            btnSaveFoods.Click += btnSaveFoods_Click;
            // 
            // lblMealName
            // 
            lblMealName.BackColor = Color.Transparent;
            lblMealName.BorderStyle = BorderStyle.FixedSingle;
            lblMealName.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblMealName.Location = new Point(717, 124);
            lblMealName.Name = "lblMealName";
            lblMealName.Size = new Size(123, 42);
            lblMealName.TabIndex = 0;
            lblMealName.Text = "label1";
            lblMealName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(727, 252);
            label3.Name = "label3";
            label3.Size = new Size(85, 21);
            label3.TabIndex = 0;
            label3.Text = "Seçilenler";
            // 
            // btnAddFood
            // 
            btnAddFood.BackColor = Color.YellowGreen;
            btnAddFood.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddFood.Location = new Point(30, 620);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(395, 37);
            btnAddFood.TabIndex = 5;
            btnAddFood.Text = "Aradığım Yemek Listede Yok";
            btnAddFood.UseVisualStyleBackColor = false;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 337);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 0;
            label1.Text = "Yemekler";
            // 
            // cbFoods
            // 
            cbFoods.FormattingEnabled = true;
            cbFoods.Location = new Point(30, 361);
            cbFoods.Name = "cbFoods";
            cbFoods.Size = new Size(395, 23);
            cbFoods.TabIndex = 1;
            cbFoods.SelectedIndexChanged += cbFoods_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(30, 411);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 0;
            label4.Text = "Porsiyon";
            // 
            // cbPortions
            // 
            cbPortions.FormattingEnabled = true;
            cbPortions.Location = new Point(30, 435);
            cbPortions.Name = "cbPortions";
            cbPortions.Size = new Size(395, 23);
            cbPortions.TabIndex = 1;
            cbPortions.SelectedIndexChanged += cbFoodCategories_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(30, 483);
            label5.Name = "label5";
            label5.Size = new Size(46, 21);
            label5.TabIndex = 0;
            label5.Text = "Adet";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Orange;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(30, 567);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(395, 35);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // nudPiece
            // 
            nudPiece.AutoSize = true;
            nudPiece.Location = new Point(30, 518);
            nudPiece.Name = "nudPiece";
            nudPiece.Size = new Size(395, 23);
            nudPiece.TabIndex = 6;
            nudPiece.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dgvSelectedFoods
            // 
            dgvSelectedFoods.AllowUserToAddRows = false;
            dgvSelectedFoods.AllowUserToDeleteRows = false;
            dgvSelectedFoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSelectedFoods.Location = new Point(582, 289);
            dgvSelectedFoods.Name = "dgvSelectedFoods";
            dgvSelectedFoods.ReadOnly = true;
            dgvSelectedFoods.RowTemplate.Height = 25;
            dgvSelectedFoods.Size = new Size(379, 325);
            dgvSelectedFoods.TabIndex = 7;
            // 
            // FoodForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 729);
            Controls.Add(dgvSelectedFoods);
            Controls.Add(nudPiece);
            Controls.Add(btnAddFood);
            Controls.Add(btnAdd);
            Controls.Add(btnSaveFoods);
            Controls.Add(label5);
            Controls.Add(cbFoods);
            Controls.Add(cbPortions);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(cbFoodCategories);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lblMealName);
            DoubleBuffered = true;
            Name = "FoodForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FoodForm";
            ((System.ComponentModel.ISupportInitialize)nudPiece).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSelectedFoods).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbFoodCategories;
        private Label label2;
        private Button btnSaveFoods;
        private Label label3;
        public Label lblMealName;
        private Button btnAddFood;
        private Label label1;
        private ComboBox cbFoods;
        private Label label4;
        private ComboBox cbPortions;
        private Label label5;
        private Button btnAdd;
        private NumericUpDown nudPiece;
        private DataGridView dgvSelectedFoods;
    }
}