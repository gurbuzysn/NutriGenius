namespace NutriGeniusForm
{
    partial class UserAddFoodForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAddFoodForm));
            label1 = new Label();
            label2 = new Label();
            cbFoodCategories = new ComboBox();
            txtFoodName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cbPortions = new ComboBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            txtCalories = new TextBox();
            btnAddFood = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(345, 336);
            label1.Name = "label1";
            label1.Size = new Size(95, 21);
            label1.TabIndex = 0;
            label1.Text = "Yemek Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(345, 390);
            label2.Name = "label2";
            label2.Size = new Size(146, 21);
            label2.TabIndex = 0;
            label2.Text = "Yemek Kategorisi:";
            // 
            // cbFoodCategories
            // 
            cbFoodCategories.DisplayMember = "CategoryName";
            cbFoodCategories.FormattingEnabled = true;
            cbFoodCategories.Location = new Point(517, 392);
            cbFoodCategories.Name = "cbFoodCategories";
            cbFoodCategories.Size = new Size(121, 23);
            cbFoodCategories.TabIndex = 1;
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new Point(517, 336);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(121, 23);
            txtFoodName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(345, 444);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 0;
            label3.Text = "Porsiyon:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(492, 448);
            label4.Name = "label4";
            label4.Size = new Size(19, 21);
            label4.TabIndex = 0;
            label4.Text = "1";
            // 
            // cbPortions
            // 
            cbPortions.DisplayMember = "Unit";
            cbPortions.FormattingEnabled = true;
            cbPortions.Items.AddRange(new object[] { "Porsiyon", "Gram", "Adet", "Bardak", "Yemek Kaşığı" });
            cbPortions.Location = new Point(517, 448);
            cbPortions.Name = "cbPortions";
            cbPortions.Size = new Size(121, 23);
            cbPortions.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(345, 498);
            label5.Name = "label5";
            label5.Size = new Size(67, 21);
            label5.TabIndex = 0;
            label5.Text = "Kalori : ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(243, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(484, 239);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // txtCalories
            // 
            txtCalories.Location = new Point(517, 500);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(121, 23);
            txtCalories.TabIndex = 2;
            // 
            // btnAddFood
            // 
            btnAddFood.BackColor = SystemColors.ActiveCaption;
            btnAddFood.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddFood.Location = new Point(385, 542);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(229, 43);
            btnAddFood.TabIndex = 4;
            btnAddFood.Text = "Yemek Ekle";
            btnAddFood.UseVisualStyleBackColor = false;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // UserAddFoodForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1004, 725);
            Controls.Add(btnAddFood);
            Controls.Add(pictureBox1);
            Controls.Add(txtCalories);
            Controls.Add(txtFoodName);
            Controls.Add(cbPortions);
            Controls.Add(cbFoodCategories);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "UserAddFoodForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UserAddFoodForm";
            Load += UserAddFoodForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbFoodCategories;
        private TextBox txtFoodName;
        private Label label3;
        private Label label4;
        private ComboBox cbPortions;
        private Label label5;
        private PictureBox pictureBox1;
        private TextBox txtCalories;
        private Button btnAddFood;
    }
}