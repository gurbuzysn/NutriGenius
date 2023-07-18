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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodForm));
            cbFoodCategories = new ComboBox();
            label2 = new Label();
            btnSaveFoods = new Button();
            lblMealName = new Label();
            btnAddNewFood = new Button();
            label1 = new Label();
            cbFoods = new ComboBox();
            label4 = new Label();
            cbPortions = new ComboBox();
            label5 = new Label();
            btnAdd = new Button();
            nudPiece = new NumericUpDown();
            dgvFoods = new DataGridView();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPiece).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFoods).BeginInit();
            SuspendLayout();
            // 
            // cbFoodCategories
            // 
            cbFoodCategories.DisplayMember = "CategoryName";
            cbFoodCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFoodCategories.FormattingEnabled = true;
            cbFoodCategories.Location = new Point(30, 298);
            cbFoodCategories.Margin = new Padding(4, 3, 4, 3);
            cbFoodCategories.Name = "cbFoodCategories";
            cbFoodCategories.Size = new Size(395, 23);
            cbFoodCategories.TabIndex = 1;
            cbFoodCategories.SelectedIndexChanged += cbFoodCategories_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 255);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 30);
            label2.TabIndex = 0;
            label2.Text = "Kategoriler";
            // 
            // btnSaveFoods
            // 
            btnSaveFoods.BackColor = Color.DarkOrange;
            btnSaveFoods.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveFoods.Location = new Point(582, 549);
            btnSaveFoods.Margin = new Padding(4, 3, 4, 3);
            btnSaveFoods.Name = "btnSaveFoods";
            btnSaveFoods.Size = new Size(379, 41);
            btnSaveFoods.TabIndex = 4;
            btnSaveFoods.Text = "Kaydet";
            btnSaveFoods.UseVisualStyleBackColor = false;
            btnSaveFoods.Click += btnSaveFoods_Click;
            // 
            // lblMealName
            // 
            lblMealName.BackColor = Color.DarkOrange;
            lblMealName.BorderStyle = BorderStyle.FixedSingle;
            lblMealName.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblMealName.Location = new Point(704, 215);
            lblMealName.Margin = new Padding(4, 0, 4, 0);
            lblMealName.Name = "lblMealName";
            lblMealName.Size = new Size(123, 42);
            lblMealName.TabIndex = 0;
            lblMealName.Text = "label1";
            lblMealName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAddNewFood
            // 
            btnAddNewFood.BackColor = Color.DarkSeaGreen;
            btnAddNewFood.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddNewFood.Location = new Point(30, 680);
            btnAddNewFood.Margin = new Padding(4, 3, 4, 3);
            btnAddNewFood.Name = "btnAddNewFood";
            btnAddNewFood.Size = new Size(396, 37);
            btnAddNewFood.TabIndex = 5;
            btnAddNewFood.Text = "Aradığım Yemek Listede Yok";
            btnAddNewFood.UseVisualStyleBackColor = false;
            btnAddNewFood.Click += btnAddNewFood_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 334);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 30);
            label1.TabIndex = 0;
            label1.Text = "Yemekler";
            // 
            // cbFoods
            // 
            cbFoods.DisplayMember = "FoodName";
            cbFoods.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFoods.FormattingEnabled = true;
            cbFoods.Location = new Point(30, 367);
            cbFoods.Margin = new Padding(4, 3, 4, 3);
            cbFoods.Name = "cbFoods";
            cbFoods.Size = new Size(395, 23);
            cbFoods.TabIndex = 1;
            cbFoods.SelectedIndexChanged += cbFoods_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(30, 402);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 30);
            label4.TabIndex = 0;
            label4.Text = "Porsiyon";
            // 
            // cbPortions
            // 
            cbPortions.DisplayMember = "Unit";
            cbPortions.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPortions.FormattingEnabled = true;
            cbPortions.Location = new Point(30, 435);
            cbPortions.Margin = new Padding(4, 3, 4, 3);
            cbPortions.Name = "cbPortions";
            cbPortions.Size = new Size(395, 23);
            cbPortions.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(30, 474);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(63, 30);
            label5.TabIndex = 0;
            label5.Text = "Adet";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkOrange;
            btnAdd.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(30, 549);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(396, 41);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // nudPiece
            // 
            nudPiece.AutoSize = true;
            nudPiece.Location = new Point(30, 507);
            nudPiece.Margin = new Padding(4, 3, 4, 3);
            nudPiece.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPiece.Name = "nudPiece";
            nudPiece.Size = new Size(396, 23);
            nudPiece.TabIndex = 6;
            nudPiece.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dgvFoods
            // 
            dgvFoods.AllowUserToAddRows = false;
            dgvFoods.AllowUserToDeleteRows = false;
            dgvFoods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFoods.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvFoods.BackgroundColor = Color.DarkSeaGreen;
            dgvFoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvFoods.DefaultCellStyle = dataGridViewCellStyle1;
            dgvFoods.Location = new Point(582, 298);
            dgvFoods.Margin = new Padding(4, 3, 4, 3);
            dgvFoods.MultiSelect = false;
            dgvFoods.Name = "dgvFoods";
            dgvFoods.ReadOnly = true;
            dgvFoods.RowHeadersVisible = false;
            dgvFoods.RowTemplate.Height = 25;
            dgvFoods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFoods.Size = new Size(379, 232);
            dgvFoods.TabIndex = 7;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(582, 596);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(379, 41);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Seçiliyi Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // FoodForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 729);
            Controls.Add(dgvFoods);
            Controls.Add(nudPiece);
            Controls.Add(btnAddNewFood);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnSaveFoods);
            Controls.Add(label5);
            Controls.Add(cbFoods);
            Controls.Add(cbPortions);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(cbFoodCategories);
            Controls.Add(label2);
            Controls.Add(lblMealName);
            DoubleBuffered = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FoodForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FoodForm";
            FormClosing += FoodForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)nudPiece).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFoods).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbFoodCategories;
        private Label label2;
        private Button btnSaveFoods;
        public Label lblMealName;
        private Button btnAddNewFood;
        private Label label1;
        private ComboBox cbFoods;
        private Label label4;
        private ComboBox cbPortions;
        private Label label5;
        private Button btnAdd;
        private NumericUpDown nudPiece;
        private DataGridView dgvFoods;
        private Button btnDelete;
    }
}