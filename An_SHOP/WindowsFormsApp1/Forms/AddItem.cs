using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Objects;

namespace WindowsFormsApp1
{
    public partial class AddItem : Form
    {
        private anotherShopBDEntities db = new anotherShopBDEntities();

        public AddItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddItems();
        }

        private void AddItems()
        {
            if(textBoxAmountItem.Text != "" &&
                textBoxItemPrice.Text != "" &&
                textBoxNameItems.Text != "" &&
                comboBoxSupplier.SelectedItem.ToString() != "")
            {
                var SelectedSupplier = db.Suppliers
              .Where(c => c.Suplier_Name == comboBoxSupplier.SelectedItem.ToString())
              .Select(c => c.ID)
              .FirstOrDefault();

                int itemPrice, amount;
                if(Int32.TryParse(textBoxItemPrice.Text, out itemPrice) || Int32.TryParse(textBoxAmountItem.Text, out amount))
                {
                    MessageBox.Show("Проверьте правильность введённых данных", "Ошибка добавления предмета", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Items items = new Items
                {
                    Item_Name = textBoxNameItems.Text,
                    Item_Price = itemPrice,
                    Item_Amount = amount,
                    Item_Supplier_ID = SelectedSupplier,
                };
                db.Items.Add(items);
                db.SaveChanges();

                MessageBox.Show("Предмет успешно добавлен!");
                WantUser();
            }
            else
            {
                MessageBox.Show("Вы заполнили не все поля!");
            }
        }

        private void WantUser()
        {
            this.Hide();
            UserForm userForm = new UserForm();
            userForm.Show();
        }

        private void FillComboBoxSupplier()
        {
            var Supplier = db.Suppliers
                .Select(c => c.Suplier_Name)
                .ToArray();

            if(Supplier != null)
            {
                comboBoxSupplier.Items.AddRange(Supplier);
                comboBoxSupplier.Items.Add("Добавить поставщика...");
            }
        }
        
        private void WantAddSupplier()
        {
            this.Hide();
            AddSupplierForm addSupplierForm = new AddSupplierForm();
            addSupplierForm.Show();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSupplier.Text == "Добавить поставщика...")
            {
                WantAddSupplier();
            }
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            FillComboBoxSupplier();
        }
    }
}
