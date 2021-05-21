using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Objects;

namespace WindowsFormsApp1
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        public string SelectedNameGrid;
        anotherShopBDEntities db = new anotherShopBDEntities();

        public int UserID
        {
            get { return id; }
            set { id = value; }
        }

        int id;

        private void FillInfAboutUser()
        {
            var NameUser = db.Users
                .Where(c => c.ID == id)
                .Select(c => c.FIO)
                .FirstOrDefault();

            labelUser.Text = "На данный момент пользователь в онлайне: " + NameUser;
        }
        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            WantAddItem();
        }

        private void FillDataGrid()
        {
            var Items = db.Items
                .Select(m => new
                {
                    Наименование = m.Item_Name,
                    Цена = m.Item_Price,
                    Количество = m.Item_Amount,
                    Поставщик = m.Suppliers.Suplier_Name,
                })
                .ToList();

            if (Items != null)
            {
                dataGridViewItems.DataSource = Items;
            }
        }

        private void WantAddItem()
        {
            this.Hide();
            AddItem addItem = new AddItem();
            addItem.Show();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            FillInfAboutUser();
            FillDataGrid();
        }

        private void WantAutor()
        {
            this.Hide();
            AutorizationForm autorizationForm = new AutorizationForm();
            autorizationForm.Show();
        }

        private void buttonExitSystem_Click(object sender, EventArgs e)
        {
            WantAutor();
        }

        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

        private void DeleteItem()
        {
            if (dataGridViewItems.SelectedCells.Count > 0)
            {
                var SearchItem = db.Items
                    .Where(c => c.Item_Name == SelectedNameGrid)
                    .FirstOrDefault();

                if(MessageBox.Show("Вы уверены, что хотите удалить предмет, название товара:\"" + SelectedNameGrid + "\"?", "Удаление предмета", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Items.Remove(SearchItem);
                    db.SaveChanges();

                    dataGridViewItems.Rows.Clear();
                    var Items = db.Items
                    .Select(m => new
                    {
                        Наименование = m.Item_Name,
                        Цена = m.Item_Price,
                        Количество = m.Item_Amount,
                        Поставщик = m.Suppliers.Suplier_Name,
                    })
                    .ToList();

                    if (Items != null)
                    {
                        dataGridViewItems.DataSource = Items;
                    }
                }
               
            }
        }

        private void selItemDataGrid()
        {
            if (dataGridViewItems.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewItems.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewItems.Rows[selectedrowindex];
                string a = Convert.ToString(selectedRow.Cells["Наименование"].Value);
                SelectedNameGrid = a;
            }
        }

        private void dataGridViewItems_SelectionChanged(object sender, EventArgs e)
        {
            selItemDataGrid();
        }

        private void currencyBtn_Click(object sender, EventArgs e)
        {
            CurrencyForm cf = new CurrencyForm();
            cf.ShowDialog();
        }
    }
}
