using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class Form2 : Form
    {
        public Form parentFrm;
        public int type;
        public Form2()
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            ProductItem newItem = new ProductItem();
            newItem.itemSerial = Serial.Text;
            newItem.itemName = Product.Text.ToLower();
            newItem.itemQuan = (int)quantity.Value;
            newItem.perCaseQ = (int)perCaseUD.Value;
            Form1 temp = (Form1)parentFrm;

            switch(type)
            {
                case 0:
                    break;
                case 1:
                    temp.AddItemFunc(newItem);
                    break;
                case 2:
                    temp.EditItemFunc(newItem);
                    break;
            }

            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetText(string ser, string item, int quan, int pc)
        {
            Serial.Text = ser;
            Product.Text = item;
            quantity.Value = quan;
            perCaseUD.Value = pc;
        }
    }
}
