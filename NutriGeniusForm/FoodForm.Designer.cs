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
            label1 = new Label();
            cbFoodCategories = new ComboBox();
            label2 = new Label();
            clbFoods = new CheckedListBox();
            lstFoods = new ListBox();
            btnKaydet = new Button();
            lblMealName = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(111, 49);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 0;
            label1.Text = "Yemek Ekle";
            // 
            // cbFoodCategories
            // 
            cbFoodCategories.FormattingEnabled = true;
            cbFoodCategories.Location = new Point(81, 151);
            cbFoodCategories.Name = "cbFoodCategories";
            cbFoodCategories.Size = new Size(395, 23);
            cbFoodCategories.TabIndex = 1;
            cbFoodCategories.SelectedIndexChanged += cbFoodCategories_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(81, 127);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 0;
            label2.Text = "Kategoriler";
            // 
            // clbFoods
            // 
            clbFoods.FormattingEnabled = true;
            clbFoods.Location = new Point(81, 214);
            clbFoods.Name = "clbFoods";
            clbFoods.Size = new Size(395, 490);
            clbFoods.TabIndex = 2;
            clbFoods.ItemCheck += clbFoods_ItemCheck;
            // 
            // lstFoods
            // 
            lstFoods.FormattingEnabled = true;
            lstFoods.ItemHeight = 15;
            lstFoods.Location = new Point(602, 214);
            lstFoods.Name = "lstFoods";
            lstFoods.Size = new Size(379, 439);
            lstFoods.TabIndex = 3;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Orange;
            btnKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.Location = new Point(602, 665);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(379, 39);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lblMealName
            // 
            lblMealName.AutoSize = true;
            lblMealName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMealName.Location = new Point(917, 105);
            lblMealName.Name = "lblMealName";
            lblMealName.Size = new Size(52, 21);
            lblMealName.TabIndex = 0;
            lblMealName.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(602, 190);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 0;
            label3.Text = "Seçilenler";
            // 
            // FoodForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1008, 729);
            Controls.Add(pictureBox1);
            Controls.Add(btnKaydet);
            Controls.Add(lstFoods);
            Controls.Add(clbFoods);
            Controls.Add(cbFoodCategories);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lblMealName);
            Controls.Add(label1);
            Name = "FoodForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FoodForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbFoodCategories;
        private Label label2;
        private CheckedListBox clbFoods;
        private ListBox lstFoods;
        private Button btnKaydet;
        private Label lblMealName;
        private PictureBox pictureBox1;
        private Label label3;
    }
}