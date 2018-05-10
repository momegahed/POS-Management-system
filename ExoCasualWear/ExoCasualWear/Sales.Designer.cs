namespace ExoCasualWear
{
    partial class Sales
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
            this.barcodeentrytextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printbutton = new System.Windows.Forms.Button();
            this.minusbutton = new System.Windows.Forms.Button();
            this.plusbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(105, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(360, 594);
            this.dataGridView1.TabIndex = 0;
            // 
            // barcodeentrytextbox
            // 
            this.barcodeentrytextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.barcodeentrytextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.barcodeentrytextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeentrytextbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.barcodeentrytextbox.Location = new System.Drawing.Point(741, 198);
            this.barcodeentrytextbox.Name = "barcodeentrytextbox";
            this.barcodeentrytextbox.Size = new System.Drawing.Size(378, 45);
            this.barcodeentrytextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(572, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barcode:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // printbutton
            // 
            this.printbutton.BackgroundImage = global::ExoCasualWear.Properties.Resources.print;
            this.printbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.printbutton.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.printbutton.Location = new System.Drawing.Point(12, 348);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(75, 70);
            this.printbutton.TabIndex = 5;
            this.printbutton.UseVisualStyleBackColor = true;
            // 
            // minusbutton
            // 
            this.minusbutton.BackgroundImage = global::ExoCasualWear.Properties.Resources.minus;
            this.minusbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minusbutton.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.minusbutton.Location = new System.Drawing.Point(12, 262);
            this.minusbutton.Name = "minusbutton";
            this.minusbutton.Size = new System.Drawing.Size(75, 70);
            this.minusbutton.TabIndex = 4;
            this.minusbutton.UseVisualStyleBackColor = true;
            // 
            // plusbutton
            // 
            this.plusbutton.BackgroundImage = global::ExoCasualWear.Properties.Resources.plus;
            this.plusbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plusbutton.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.plusbutton.Location = new System.Drawing.Point(12, 173);
            this.plusbutton.Name = "plusbutton";
            this.plusbutton.Size = new System.Drawing.Size(75, 70);
            this.plusbutton.TabIndex = 3;
            this.plusbutton.UseVisualStyleBackColor = true;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 779);
            this.Controls.Add(this.printbutton);
            this.Controls.Add(this.minusbutton);
            this.Controls.Add(this.plusbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barcodeentrytextbox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox barcodeentrytextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button plusbutton;
        private System.Windows.Forms.Button minusbutton;
        private System.Windows.Forms.Button printbutton;
    }
}