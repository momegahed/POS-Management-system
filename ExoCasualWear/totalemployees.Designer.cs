namespace ExoCasualWear
{
    partial class totalemployees
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
            this.totals = new System.Windows.Forms.Label();
            this.updatebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total employees";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // totals
            // 
            this.totals.AutoSize = true;
            this.totals.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totals.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totals.Location = new System.Drawing.Point(289, 190);
            this.totals.MinimumSize = new System.Drawing.Size(200, 0);
            this.totals.Name = "totals";
            this.totals.Size = new System.Drawing.Size(200, 38);
            this.totals.TabIndex = 1;
            this.totals.Click += new System.EventHandler(this.totals_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(190, 283);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(206, 96);
            this.updatebutton.TabIndex = 2;
            this.updatebutton.Text = "update";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // totalemployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 469);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.totals);
            this.Controls.Add(this.label1);
            this.Name = "totalemployees";
            this.Tag = " ";
            this.Text = "totalemployees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totals;
        private System.Windows.Forms.Button updatebutton;
    }
}