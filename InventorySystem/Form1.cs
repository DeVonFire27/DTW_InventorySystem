using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace InventorySystem
{
    public partial class Form1 : Form
    {
        public enum FormType { NONE, AddItem, EditItem};
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.parentFrm = this;
            frm.type = (int)FormType.AddItem;
            frm.Show();
        }

        public void AddItemFunc(ProductItem newItem)
        {
            SerialList.Items.Add(newItem.itemSerial);
            Product.Items.Add(newItem.itemName);
            Quantity.Items.Add(newItem.itemQuan);
            perCase.Items.Add(newItem.perCaseQ);
        }

        public void EditItemFunc(ProductItem newItem)
        {
            if(SerialList.SelectedIndex > -1)
            {
                ProductItem temp = new ProductItem();
                temp.itemSerial = (string)SerialList.SelectedItem;
                temp.itemName = (string)Product.SelectedItem;
                temp.itemQuan = (int)Quantity.SelectedItem;
                temp.perCaseQ = (int)perCase.SelectedItem;

                int ind = SerialList.SelectedIndex;

                ind = SerialList.SelectedIndex;
                SerialList.Items[ind] = newItem.itemSerial;
                Product.Items[ind] = newItem.itemName;
                Quantity.Items[ind] = newItem.itemQuan;
                perCase.Items[ind] = newItem.perCaseQ;
            }
        }

        private void SerialList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product.SelectedIndex = SerialList.SelectedIndex;
            Quantity.SelectedIndex = SerialList.SelectedIndex;
            perCase.SelectedIndex = SerialList.SelectedIndex;
        }

        private void Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            SerialList.SelectedIndex = Product.SelectedIndex;
            Quantity.SelectedIndex = Product.SelectedIndex;
            perCase.SelectedIndex = SerialList.SelectedIndex;
        }

        private void Quantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            SerialList.SelectedIndex = Quantity.SelectedIndex;
            Product.SelectedIndex = Quantity.SelectedIndex;
            perCase.SelectedIndex = SerialList.SelectedIndex;
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            if(SerialList.SelectedIndex > -1)
            {
                int ind = SerialList.SelectedIndex;
                SerialList.Items.RemoveAt(ind);
                Product.Items.RemoveAt(ind);
                Quantity.Items.RemoveAt(ind);
                perCase.Items.RemoveAt(ind);
            }
        }

        private void EditItem_Click(object sender, EventArgs e)
        {
            if(SerialList.SelectedIndex > -1)
            {
                Form2 frm = new Form2();
                frm.parentFrm = this;
                frm.type = (int)FormType.EditItem;
                frm.SetText((string)SerialList.SelectedItem, (string)Product.SelectedItem, (int)Quantity.SelectedItem, (int)perCase.SelectedItem);
                frm.Show();
            }
        }

        private void QuantityChange_Click(object sender, EventArgs e)
        {
            if (Quantity.SelectedIndex > -1)
            {
                Quantity.SelectedItem = (int)changeValue.Value;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            save.AddExtension = true;
            save.DefaultExt = ".xml";
            if(save.ShowDialog() == DialogResult.OK)
            {
                XElement root = new XElement("Inventory_List");
                for (int x = 0; x < SerialList.Items.Count; x++)
                {
                    XElement ItemELe = new XElement("Item");
                    ItemELe.Add(new XAttribute("Serial_Number", SerialList.Items[x].ToString()));
                    ItemELe.Add(new XAttribute("Product_Name", Product.Items[x].ToString()));
                    ItemELe.Add(new XAttribute("Quantity_by_Case", Quantity.Items[x].ToString()));
                    ItemELe.Add(new XAttribute("Quantity_per_Case", perCase.Items[x].ToString()));
                    root.Add(ItemELe);
                }

                root.Save(save.FileName);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK && dlg.FileName.Contains(".xml"))
            {
                newToolStripMenuItem_Click(sender, e);
                StreamReader stream  = new StreamReader(dlg.FileName);
                XmlReader read = XmlReader.Create(stream);

                while (read.ReadToFollowing("Item"))
                {
                    string ser;
                    string prod;
                    int quan = 0;
                    int pc = 0;
                    read.MoveToFirstAttribute();
                    ser = read.Value;
                    read.MoveToNextAttribute();
                    prod = read.Value;
                    read.MoveToNextAttribute();
                    quan = int.Parse(read.Value);
                    read.MoveToNextAttribute();
                    pc = int.Parse(read.Value);

                    SerialList.Items.Add(ser);
                    Product.Items.Add(prod);
                    Quantity.Items.Add(quan);
                    perCase.Items.Add(pc);
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerialList.Items.Clear();
            Product.Items.Clear();
            Quantity.Items.Clear();
            perCase.Items.Clear();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItem_Click(sender, e);
        }

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItem_Click(sender, e);
        }

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditItem_Click(sender, e);
        }

        private void searchInventory(string item, bool bySerial)
        {
            if(bySerial && SerialList.Items.Contains(item))
            {
                SerialList.SelectedIndex = SerialList.Items.IndexOf(item);
            }
            else if(!bySerial && Product.Items.Contains(item))
            {
                Product.SelectedIndex = Product.Items.IndexOf(item);
            }
            else
            {
                MessageBox.Show("Item can not be found.", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SortInventory(bool reverse, int type)
        {
            string tempSer = "";
            string tempName = "";
            int tempQuan = 0;
            int tempC = 0;
            for(int x = 0; x < Quantity.Items.Count - 1; x++)
            {
                for(int y = x +1; y < Quantity.Items.Count; y++)
                {
                    if (reverse)
                    {
                        if ((type == 2 && (int)Quantity.Items[x] > (int)Quantity.Items[y]) ||
                        (type == 0 && String.Compare((string)SerialList.Items[x], (string)SerialList.Items[y], true) > 0) ||
                        (type == 1 && String.Compare((string)Product.Items[x], (string)Product.Items[y], true) > 0))
                        {

                            tempQuan = (int)Quantity.Items[x];
                            Quantity.Items[x] = Quantity.Items[y];
                            Quantity.Items[y] = tempQuan;

                            tempSer = (string)SerialList.Items[x];
                            SerialList.Items[x] = SerialList.Items[y];
                            SerialList.Items[y] = tempSer;

                            tempName = (string)Product.Items[x];
                            Product.Items[x] = Product.Items[y];
                            Product.Items[y] = tempName;

                            tempC = (int)perCase.Items[x];
                            perCase.Items[x] = perCase.Items[y];
                            perCase.Items[y] = tempC;
                        }
                    }
                    else if (!reverse)
                    {
                        if ((type == 2 && (int)Quantity.Items[x] < (int)Quantity.Items[y]) ||
                        (type == 0 && String.Compare((string)SerialList.Items[x], (string)SerialList.Items[y], true) < 0) ||
                        (type == 1 && String.Compare((string)Product.Items[x], (string)Product.Items[y], true) < 0))
                        {
                            tempQuan = (int)Quantity.Items[y];
                            Quantity.Items[y] = Quantity.Items[x];
                            Quantity.Items[x] = tempQuan;

                            tempSer = (string)SerialList.Items[y];
                            SerialList.Items[y] = SerialList.Items[x];
                            SerialList.Items[x] = tempSer;

                            tempName = (string)Product.Items[y];
                            Product.Items[y] = Product.Items[x];
                            Product.Items[x] = tempName;

                            tempC = (int)perCase.Items[y];
                            perCase.Items[y] = perCase.Items[x];
                            perCase.Items[x] = tempC;
                        }
                    }
                }
            }
        }
        private void lowHighToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //quantity
            SortInventory(true, 2);
        }

        private void highLowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //quantity
            SortInventory(false, 2);
        }

        private void firstLastToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //serial
            SortInventory(true, 0);
        }

        private void lastFirstToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //serial
            SortInventory(false, 0);
        }

        private void firstLastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //product
            SortInventory(true, 1);
        }

        private void lastFirstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //product
            SortInventory(false, 1);
        }

        private void BySerial_Click(object sender, EventArgs e)
        {
            searchInventory(searchBox.Text.ToLower(), true);
        }

        private void ByProduct_Click(object sender, EventArgs e)
        {
            searchInventory(searchBox.Text.ToLower(), false);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void perCase_SelectedIndexChanged(object sender, EventArgs e)
        {
            SerialList.SelectedIndex = Quantity.SelectedIndex;
            Product.SelectedIndex = Quantity.SelectedIndex;
            Quantity.SelectedIndex = Product.SelectedIndex;
        }
    }
}
