using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddSupplierForm : Form
    {
        public AddSupplierForm()
        {
            InitializeComponent();
        }

        anotherShopBDEntities db = new anotherShopBDEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            AddSupplier();
        }

        private void WantAddItem()
        {
            this.Hide();
            AddItem addItem = new AddItem();
            addItem.Show();
        }

        private void AddSupplier()
        {
            if (textBoxAdress.Text != "" && textBoxPhone.Text != "" && textBoxSupplierName.Text != "")
            {
                Suppliers suppliers = new Suppliers
                {
                    Suplier_Name = textBoxSupplierName.Text,
                    Adress = textBoxAdress.Text,
                    Phone = textBoxPhone.Text,
                };

                db.Suppliers.Add(suppliers);
                db.SaveChanges();
                MessageBox.Show("Успешное добавление поставщика");
                WantAddItem();
            }

            else
            {
                MessageBox.Show("Вы заполнили не все поля!");
            }
        }
    }
}
