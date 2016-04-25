namespace InventorySystem
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bySerialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byQuantityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Product = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SerialList = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.QuantityChange = new System.Windows.Forms.Button();
            this.changeValue = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DeleteItem = new System.Windows.Forms.Button();
            this.EditItem = new System.Windows.Forms.Button();
            this.AddItem = new System.Windows.Forms.Button();
            this.lowHighToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highLowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstLastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastFirstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstLastToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lastFirstToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.BySerial = new System.Windows.Forms.Button();
            this.ByProduct = new System.Windows.Forms.Button();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.perCase = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeValue)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sortToolStripMenuItem,
            this.inventoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(842, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Sa&ve";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "&Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bySerialToolStripMenuItem,
            this.byNameToolStripMenuItem,
            this.byQuantityToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.sortToolStripMenuItem.Text = "S&ort";
            // 
            // bySerialToolStripMenuItem
            // 
            this.bySerialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstLastToolStripMenuItem1,
            this.lastFirstToolStripMenuItem1});
            this.bySerialToolStripMenuItem.Name = "bySerialToolStripMenuItem";
            this.bySerialToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bySerialToolStripMenuItem.Text = "By Se&rial";
            // 
            // byNameToolStripMenuItem
            // 
            this.byNameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstLastToolStripMenuItem,
            this.lastFirstToolStripMenuItem});
            this.byNameToolStripMenuItem.Name = "byNameToolStripMenuItem";
            this.byNameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.byNameToolStripMenuItem.Text = "By Na&me";
            // 
            // byQuantityToolStripMenuItem
            // 
            this.byQuantityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lowHighToolStripMenuItem,
            this.highLowToolStripMenuItem});
            this.byQuantityToolStripMenuItem.Name = "byQuantityToolStripMenuItem";
            this.byQuantityToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.byQuantityToolStripMenuItem.Text = "By &Quantity";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToolStripMenuItem,
            this.deleteItemToolStripMenuItem,
            this.editItemToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "&Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addItemToolStripMenuItem.Text = "&Add Item";
            this.addItemToolStripMenuItem.Click += new System.EventHandler(this.addItemToolStripMenuItem_Click);
            // 
            // deleteItemToolStripMenuItem
            // 
            this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteItemToolStripMenuItem.Text = "&Delete Item";
            this.deleteItemToolStripMenuItem.Click += new System.EventHandler(this.deleteItemToolStripMenuItem_Click);
            // 
            // editItemToolStripMenuItem
            // 
            this.editItemToolStripMenuItem.Name = "editItemToolStripMenuItem";
            this.editItemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editItemToolStripMenuItem.Text = "&Edit Item";
            this.editItemToolStripMenuItem.Click += new System.EventHandler(this.editItemToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.perCase);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Quantity);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Product);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SerialList);
            this.panel1.Location = new System.Drawing.Point(155, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 536);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantity (by Cases)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Quantity
            // 
            this.Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.FormattingEnabled = true;
            this.Quantity.ItemHeight = 16;
            this.Quantity.Location = new System.Drawing.Point(368, 54);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(130, 468);
            this.Quantity.TabIndex = 4;
            this.Quantity.SelectedIndexChanged += new System.EventHandler(this.Quantity_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Name";
            // 
            // Product
            // 
            this.Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product.FormattingEnabled = true;
            this.Product.ItemHeight = 16;
            this.Product.Location = new System.Drawing.Point(189, 54);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(161, 468);
            this.Product.TabIndex = 2;
            this.Product.SelectedIndexChanged += new System.EventHandler(this.Product_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serial Number";
            // 
            // SerialList
            // 
            this.SerialList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialList.FormattingEnabled = true;
            this.SerialList.ItemHeight = 16;
            this.SerialList.Location = new System.Drawing.Point(13, 54);
            this.SerialList.Name = "SerialList";
            this.SerialList.Size = new System.Drawing.Size(161, 468);
            this.SerialList.TabIndex = 0;
            this.SerialList.SelectedIndexChanged += new System.EventHandler(this.SerialList_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 533);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.QuantityChange);
            this.groupBox1.Controls.Add(this.changeValue);
            this.groupBox1.Location = new System.Drawing.Point(15, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 103);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quantity";
            // 
            // QuantityChange
            // 
            this.QuantityChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityChange.Location = new System.Drawing.Point(14, 45);
            this.QuantityChange.Name = "QuantityChange";
            this.QuantityChange.Size = new System.Drawing.Size(86, 40);
            this.QuantityChange.TabIndex = 1;
            this.QuantityChange.Text = "Change Quantity";
            this.QuantityChange.UseVisualStyleBackColor = true;
            this.QuantityChange.Click += new System.EventHandler(this.QuantityChange_Click);
            // 
            // changeValue
            // 
            this.changeValue.Location = new System.Drawing.Point(14, 19);
            this.changeValue.Name = "changeValue";
            this.changeValue.Size = new System.Drawing.Size(86, 20);
            this.changeValue.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DeleteItem);
            this.panel3.Controls.Add(this.EditItem);
            this.panel3.Controls.Add(this.AddItem);
            this.panel3.Location = new System.Drawing.Point(15, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(116, 140);
            this.panel3.TabIndex = 3;
            // 
            // DeleteItem
            // 
            this.DeleteItem.Location = new System.Drawing.Point(14, 57);
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.Size = new System.Drawing.Size(86, 29);
            this.DeleteItem.TabIndex = 1;
            this.DeleteItem.Text = "Delete Item";
            this.DeleteItem.UseVisualStyleBackColor = true;
            this.DeleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // EditItem
            // 
            this.EditItem.Location = new System.Drawing.Point(14, 102);
            this.EditItem.Name = "EditItem";
            this.EditItem.Size = new System.Drawing.Size(86, 29);
            this.EditItem.TabIndex = 2;
            this.EditItem.Text = "Edit Item";
            this.EditItem.UseVisualStyleBackColor = true;
            this.EditItem.Click += new System.EventHandler(this.EditItem_Click);
            // 
            // AddItem
            // 
            this.AddItem.Location = new System.Drawing.Point(14, 12);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(86, 29);
            this.AddItem.TabIndex = 0;
            this.AddItem.Text = "Add Item";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // lowHighToolStripMenuItem
            // 
            this.lowHighToolStripMenuItem.Name = "lowHighToolStripMenuItem";
            this.lowHighToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lowHighToolStripMenuItem.Text = "Low->High";
            this.lowHighToolStripMenuItem.Click += new System.EventHandler(this.lowHighToolStripMenuItem_Click);
            // 
            // highLowToolStripMenuItem
            // 
            this.highLowToolStripMenuItem.Name = "highLowToolStripMenuItem";
            this.highLowToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.highLowToolStripMenuItem.Text = "High->Low";
            this.highLowToolStripMenuItem.Click += new System.EventHandler(this.highLowToolStripMenuItem_Click);
            // 
            // firstLastToolStripMenuItem
            // 
            this.firstLastToolStripMenuItem.Name = "firstLastToolStripMenuItem";
            this.firstLastToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.firstLastToolStripMenuItem.Text = "First->Last";
            this.firstLastToolStripMenuItem.Click += new System.EventHandler(this.firstLastToolStripMenuItem_Click);
            // 
            // lastFirstToolStripMenuItem
            // 
            this.lastFirstToolStripMenuItem.Name = "lastFirstToolStripMenuItem";
            this.lastFirstToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lastFirstToolStripMenuItem.Text = "Last->First";
            this.lastFirstToolStripMenuItem.Click += new System.EventHandler(this.lastFirstToolStripMenuItem_Click);
            // 
            // firstLastToolStripMenuItem1
            // 
            this.firstLastToolStripMenuItem1.Name = "firstLastToolStripMenuItem1";
            this.firstLastToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.firstLastToolStripMenuItem1.Text = "First->Last";
            this.firstLastToolStripMenuItem1.Click += new System.EventHandler(this.firstLastToolStripMenuItem1_Click);
            // 
            // lastFirstToolStripMenuItem1
            // 
            this.lastFirstToolStripMenuItem1.Name = "lastFirstToolStripMenuItem1";
            this.lastFirstToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.lastFirstToolStripMenuItem1.Text = "Last->First";
            this.lastFirstToolStripMenuItem1.Click += new System.EventHandler(this.lastFirstToolStripMenuItem1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ByProduct);
            this.groupBox2.Controls.Add(this.BySerial);
            this.groupBox2.Controls.Add(this.searchBox);
            this.groupBox2.Location = new System.Drawing.Point(15, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 120);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(14, 29);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(86, 20);
            this.searchBox.TabIndex = 0;
            // 
            // BySerial
            // 
            this.BySerial.Location = new System.Drawing.Point(14, 55);
            this.BySerial.Name = "BySerial";
            this.BySerial.Size = new System.Drawing.Size(86, 23);
            this.BySerial.TabIndex = 1;
            this.BySerial.Text = "By Serial";
            this.BySerial.UseVisualStyleBackColor = true;
            this.BySerial.Click += new System.EventHandler(this.BySerial_Click);
            // 
            // ByProduct
            // 
            this.ByProduct.Location = new System.Drawing.Point(14, 85);
            this.ByProduct.Name = "ByProduct";
            this.ByProduct.Size = new System.Drawing.Size(86, 23);
            this.ByProduct.TabIndex = 2;
            this.ByProduct.Text = "By Name";
            this.ByProduct.UseVisualStyleBackColor = true;
            this.ByProduct.Click += new System.EventHandler(this.ByProduct_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(517, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity (per Cases)";
            // 
            // perCase
            // 
            this.perCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perCase.FormattingEnabled = true;
            this.perCase.ItemHeight = 16;
            this.perCase.Location = new System.Drawing.Point(526, 54);
            this.perCase.Name = "perCase";
            this.perCase.Size = new System.Drawing.Size(130, 468);
            this.perCase.TabIndex = 7;
            this.perCase.SelectedIndexChanged += new System.EventHandler(this.perCase_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 568);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Inventory";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.changeValue)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Quantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Product;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox SerialList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button QuantityChange;
        private System.Windows.Forms.NumericUpDown changeValue;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button DeleteItem;
        private System.Windows.Forms.Button EditItem;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bySerialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byQuantityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowHighToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highLowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstLastToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lastFirstToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem firstLastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastFirstToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button BySerial;
        private System.Windows.Forms.Button ByProduct;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox perCase;
        private System.Windows.Forms.Label label4;
    }
}

