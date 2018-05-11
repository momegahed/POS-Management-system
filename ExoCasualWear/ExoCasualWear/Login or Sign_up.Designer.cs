namespace ExoCasualWear
{
    partial class Login_or_Sign_up
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
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_signup = new System.Windows.Forms.Button();
            this.Btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome !";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btn_signup
            // 
            this.Btn_signup.Location = new System.Drawing.Point(82, 280);
            this.Btn_signup.Name = "Btn_signup";
            this.Btn_signup.Size = new System.Drawing.Size(197, 49);
            this.Btn_signup.TabIndex = 1;
            this.Btn_signup.Text = "Sign up";
            this.Btn_signup.UseVisualStyleBackColor = true;
            this.Btn_signup.Click += new System.EventHandler(this.Btn_signup_Click);
            // 
            // Btn_login
            // 
            this.Btn_login.Location = new System.Drawing.Point(460, 280);
            this.Btn_login.Name = "Btn_login";
            this.Btn_login.Size = new System.Drawing.Size(197, 49);
            this.Btn_login.TabIndex = 2;
            this.Btn_login.Text = "Login";
            this.Btn_login.UseVisualStyleBackColor = true;
            this.Btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // Login_or_Sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_login);
            this.Controls.Add(this.Btn_signup);
            this.Controls.Add(this.label1);
            this.Name = "Login_or_Sign_up";
            this.Text = "Login_or_Sign_up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_signup;
        private System.Windows.Forms.Button Btn_login;
    }
}