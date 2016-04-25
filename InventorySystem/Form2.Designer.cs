namespace InventorySystem
{
    partial class Form2
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
            this.Serial = new System.Windows.Forms.TextBox();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.Product = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.perCaseUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perCaseUD)).BeginInit();
            this.SuspendLayout();
            // 
            // Serial
            // 
            this.Serial.Location = new System.Drawing.Point(12, 44);
            this.Serial.Name = "Serial";
            this.Serial.Size = new System.Drawing.Size(149, 20);
            this.Serial.TabIndex = 0;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(175, 85);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(100, 25);
            this.AcceptButton.TabIndex = 3;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // Product
            // 
            this.Product.Location = new System.Drawing.Point(167, 44);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(129, 20);
            this.Product.TabIndex = 1;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(302, 44);
            this.quantity.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(120, 20);
            this.quantity.TabIndex = 2;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(302, 85);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 25);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Serial Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity by Case";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantity per Case";
            // 
            // perCaseUD
            // 
            this.perCaseUD.Location = new System.Drawing.Point(428, 45);
            this.perCaseUD.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.perCaseUD.Name = "perCaseUD";
            this.perCaseUD.Size = new System.Drawing.Size(120, 20);
            this.perCaseUD.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 122);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.perCaseUD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.Serial);
            this.Name = "Form2";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perCaseUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Serial;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.TextBox Product;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown perCaseUD;
    }
}