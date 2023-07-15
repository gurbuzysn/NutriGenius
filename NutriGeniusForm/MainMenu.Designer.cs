namespace NutriGeniusForm
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            btnSignIn = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.RosyBrown;
            btnSignIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignIn.Location = new Point(725, 679);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(271, 38);
            btnSignIn.TabIndex = 0;
            btnSignIn.Text = "Kayıt Ol";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.RosyBrown;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(365, 319);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(257, 115);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 729);
            Controls.Add(btnLogin);
            Controls.Add(btnSignIn);
            DoubleBuffered = true;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSignIn;
        private Button btnLogin;
    }
}