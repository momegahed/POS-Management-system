namespace ExoCasualWear
{
    partial class AddUser
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBx_username = new System.Windows.Forms.TextBox();
            this.TxtBx_password = new System.Windows.Forms.TextBox();
            this.TxtBx_ID = new System.Windows.Forms.TextBox();
            this.Btn_AddUser = new System.Windows.Forms.Button();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBx_Security = new System.Windows.Forms.TextBox();
            this.userTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Employee ID";
            // 
            // TxtBx_username
            // 
            this.TxtBx_username.Location = new System.Drawing.Point(331, 57);
            this.TxtBx_username.Name = "TxtBx_username";
            this.TxtBx_username.Size = new System.Drawing.Size(311, 22);
            this.TxtBx_username.TabIndex = 4;
            // 
            // TxtBx_password
            // 
            this.TxtBx_password.Location = new System.Drawing.Point(331, 168);
            this.TxtBx_password.Name = "TxtBx_password";
            this.TxtBx_password.Size = new System.Drawing.Size(311, 22);
            this.TxtBx_password.TabIndex = 5;
            // 
            // TxtBx_ID
            // 
            this.TxtBx_ID.Location = new System.Drawing.Point(331, 344);
            this.TxtBx_ID.Name = "TxtBx_ID";
            this.TxtBx_ID.Size = new System.Drawing.Size(311, 22);
            this.TxtBx_ID.TabIndex = 7;
            // 
            // Btn_AddUser
            // 
            this.Btn_AddUser.Location = new System.Drawing.Point(240, 474);
            this.Btn_AddUser.Name = "Btn_AddUser";
            this.Btn_AddUser.Size = new System.Drawing.Size(296, 40);
            this.Btn_AddUser.TabIndex = 8;
            this.Btn_AddUser.Text = "Add User";
            this.Btn_AddUser.UseVisualStyleBackColor = true;
            this.Btn_AddUser.Click += new System.EventHandler(this.Btn_AddUser_Click);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.fillByToolStrip.Size = new System.Drawing.Size(102, 25);
            this.fillByToolStrip.TabIndex = 10;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Items.AddRange(new object[] {
            "Admin",
            "Branch Manager",
            "Sales Assistant"});
            this.comboBox_Type.Location = new System.Drawing.Point(331, 243);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(305, 24);
            this.comboBox_Type.TabIndex = 9;
            this.comboBox_Type.SelectedIndexChanged += new System.EventHandler(this.comboBox_Type_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(314, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Security Question : What is your favourite food ?";
            // 
            // TxtBx_Security
            // 
            this.TxtBx_Security.Location = new System.Drawing.Point(332, 418);
            this.TxtBx_Security.Name = "TxtBx_Security";
            this.TxtBx_Security.Size = new System.Drawing.Size(311, 22);
            this.TxtBx_Security.TabIndex = 12;
            // 
            // userTypeBindingSource
            // 
            this.userTypeBindingSource.DataMember = "User_Type";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(841, 548);
            this.Controls.Add(this.TxtBx_Security);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.comboBox_Type);
            this.Controls.Add(this.Btn_AddUser);
            this.Controls.Add(this.TxtBx_ID);
            this.Controls.Add(this.TxtBx_password);
            this.Controls.Add(this.TxtBx_username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddUser";
            this.Text = "AddUser";
            ((System.ComponentModel.ISupportInitialize)(this.userTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBx_username;
        private System.Windows.Forms.TextBox TxtBx_password;
        private System.Windows.Forms.TextBox TxtBx_ID;
        private System.Windows.Forms.Button Btn_AddUser;
        private System.Windows.Forms.BindingSource userTypeBindingSource;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtBx_Security;
    }
}