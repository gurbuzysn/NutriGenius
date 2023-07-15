﻿namespace NutriGeniusForm
{
    partial class LoginForm
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
            label1 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnLogın = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(368, 480);
            label1.Name = "label1";
            label1.Size = new Size(340, 197);
            label1.TabIndex = 0;
            label1.Text = "\"NutriGenius, sağlıklı beslenme yolcuğunuzda günlük kalori alımlarınızı takip ederek sizin için muhteşem bir yol arkadaşı ve motivasyon kaynağı olur!\"";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserName.Location = new Point(473, 314);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(219, 29);
            txtUserName.TabIndex = 1;
            txtUserName.Text = "aveli@hotmail.com";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(473, 349);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(219, 29);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "123456aA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(377, 317);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 2;
            label2.Text = "E-Mail : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(377, 352);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 2;
            label3.Text = "Şifre : ";
            // 
            // btnLogın
            // 
            btnLogın.BackColor = SystemColors.ActiveCaption;
            btnLogın.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogın.Location = new Point(368, 398);
            btnLogın.Name = "btnLogın";
            btnLogın.Size = new Size(340, 57);
            btnLogın.TabIndex = 3;
            btnLogın.Text = "Giriş Yap";
            btnLogın.UseVisualStyleBackColor = false;
            btnLogın.Click += btnLogın_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LogınForm;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 729);
            Controls.Add(btnLogın);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "LogınForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label2;
        private Label label3;
        private Button btnLogın;
    }
}