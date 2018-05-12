namespace ExoCasualWear
{
    partial class ManageUsers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userTypeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.userTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.Btn_ChangePriv = new System.Windows.Forms.Button();
            this.Btn_DeleteUser = new System.Windows.Forms.Button();
            this.Btn_AddUser = new System.Windows.Forms.Button();
            this.userTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTypeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 168);
            this.dataGridView1.TabIndex = 0;
           // this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // userTypeBindingSource2
            // 
            this.userTypeBindingSource2.DataMember = "User_Type";
            // 
            // userTypeBindingSource1
            // 
            this.userTypeBindingSource1.DataMember = "User_Type";
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 168);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(800, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // Btn_ChangePriv
            // 
            this.Btn_ChangePriv.Location = new System.Drawing.Point(528, 296);
            this.Btn_ChangePriv.Name = "Btn_ChangePriv";
            this.Btn_ChangePriv.Size = new System.Drawing.Size(191, 63);
            this.Btn_ChangePriv.TabIndex = 3;
            this.Btn_ChangePriv.Text = "Change User Type";
            this.Btn_ChangePriv.UseVisualStyleBackColor = true;
            this.Btn_ChangePriv.Click += new System.EventHandler(this.Btn_ChangePriv_Click);
            // 
            // Btn_DeleteUser
            // 
            this.Btn_DeleteUser.Location = new System.Drawing.Point(276, 296);
            this.Btn_DeleteUser.Name = "Btn_DeleteUser";
            this.Btn_DeleteUser.Size = new System.Drawing.Size(191, 63);
            this.Btn_DeleteUser.TabIndex = 4;
            this.Btn_DeleteUser.Text = "Delete User";
            this.Btn_DeleteUser.UseVisualStyleBackColor = true;
            this.Btn_DeleteUser.Click += new System.EventHandler(this.Btn_DeleteUser_Click);
            // 
            // Btn_AddUser
            // 
            this.Btn_AddUser.Location = new System.Drawing.Point(23, 296);
            this.Btn_AddUser.Name = "Btn_AddUser";
            this.Btn_AddUser.Size = new System.Drawing.Size(191, 63);
            this.Btn_AddUser.TabIndex = 5;
            this.Btn_AddUser.Text = "Add User";
            this.Btn_AddUser.UseVisualStyleBackColor = true;
            this.Btn_AddUser.Click += new System.EventHandler(this.Btn_AddUser_Click);
            // 
            // userTypeBindingSource
            // 
            this.userTypeBindingSource.DataMember = "User_Type";
      
            // 
            // storeDataSet
            // 
            // user_TypeTableAdapter
            // 
            // 
            // user_TypeTableAdapter2
            // 
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_AddUser);
            this.Controls.Add(this.Btn_DeleteUser);
            this.Controls.Add(this.Btn_ChangePriv);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManageUsers";
            this.Text = "ManageUsers";
            //this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTypeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource userTypeBindingSource;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.Button Btn_ChangePriv;
        private System.Windows.Forms.Button Btn_DeleteUser;
        private System.Windows.Forms.Button Btn_AddUser;
        private System.Windows.Forms.BindingSource userTypeBindingSource1;
        private System.Windows.Forms.BindingSource userTypeBindingSource2;
    }
}