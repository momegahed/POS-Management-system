namespace ExoCasualWear
{
    partial class Offer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_AddOffer = new System.Windows.Forms.Button();
            this.Btn_ChangeOffer = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1111, 388);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Btn_AddOffer
            // 
            this.Btn_AddOffer.Location = new System.Drawing.Point(45, 468);
            this.Btn_AddOffer.Name = "Btn_AddOffer";
            this.Btn_AddOffer.Size = new System.Drawing.Size(265, 77);
            this.Btn_AddOffer.TabIndex = 1;
            this.Btn_AddOffer.Text = "Add Offer";
            this.Btn_AddOffer.UseVisualStyleBackColor = true;
            this.Btn_AddOffer.Click += new System.EventHandler(this.Btn_AddOffer_Click);
            // 
            // Btn_ChangeOffer
            // 
            this.Btn_ChangeOffer.Location = new System.Drawing.Point(431, 468);
            this.Btn_ChangeOffer.Name = "Btn_ChangeOffer";
            this.Btn_ChangeOffer.Size = new System.Drawing.Size(258, 77);
            this.Btn_ChangeOffer.TabIndex = 2;
            this.Btn_ChangeOffer.Text = "Change Offer";
            this.Btn_ChangeOffer.UseVisualStyleBackColor = true;
            this.Btn_ChangeOffer.Click += new System.EventHandler(this.Btn_ChangeOffer_Click);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Location = new System.Drawing.Point(789, 468);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(258, 77);
            this.Btn_Refresh.TabIndex = 3;
            this.Btn_Refresh.Text = "Refresh";
            this.Btn_Refresh.UseVisualStyleBackColor = true;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // Offer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 618);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.Btn_ChangeOffer);
            this.Controls.Add(this.Btn_AddOffer);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Offer";
            this.Text = "Offer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_AddOffer;
        private System.Windows.Forms.Button Btn_ChangeOffer;
        private System.Windows.Forms.Button Btn_Refresh;
    }
}