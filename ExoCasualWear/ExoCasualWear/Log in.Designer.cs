namespace ExoCasualWear
{
    partial class Login
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
            this.TxtBx_username = new System.Windows.Forms.TextBox();
            this.TextBx_pass = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Btn_pass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBx_username
            // 
            this.TxtBx_username.Location = new System.Drawing.Point(146, 126);
            this.TxtBx_username.Name = "TxtBx_username";
            this.TxtBx_username.Size = new System.Drawing.Size(195, 22);
            this.TxtBx_username.TabIndex = 6;
            this.TxtBx_username.TextChanged += new System.EventHandler(this.TxtBx_username_TextChanged);
            // 
            // TextBx_pass
            // 
            this.TextBx_pass.Cursor = System.Windows.Forms.Cursors.Default;
            this.TextBx_pass.Location = new System.Drawing.Point(146, 179);
            this.TextBx_pass.Name = "TextBx_pass";
            this.TextBx_pass.PasswordChar = '*';
            this.TextBx_pass.Size = new System.Drawing.Size(195, 22);
            this.TextBx_pass.TabIndex = 1;
            this.TextBx_pass.TextChanged += new System.EventHandler(this.TextBx_pass_TextChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(55, 131);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(71, 17);
            this.label.TabIndex = 2;
            this.label.Text = "username";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(273, 224);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(134, 60);
            this.Btn_Login.TabIndex = 4;
            this.Btn_Login.Text = "&Login";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Btn_pass
            // 
            this.Btn_pass.Location = new System.Drawing.Point(58, 224);
            this.Btn_pass.Name = "Btn_pass";
            this.Btn_pass.Size = new System.Drawing.Size(134, 60);
            this.Btn_pass.TabIndex = 5;
            this.Btn_pass.Text = "&ForgotPassword ?";
            this.Btn_pass.UseVisualStyleBackColor = true;
            this.Btn_pass.Click += new System.EventHandler(this.Btn_pass_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 338);
            this.Controls.Add(this.Btn_pass);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.TextBx_pass);
            this.Controls.Add(this.TxtBx_username);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBx_username;
        private System.Windows.Forms.TextBox TextBx_pass;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Button Btn_pass;
    }
}

