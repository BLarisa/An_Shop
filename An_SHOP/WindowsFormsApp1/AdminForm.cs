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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        anotherShopBDEntities db = new anotherShopBDEntities();
        private void buttonExitSystem_Click(object sender, EventArgs e)
        {
            WantAutor();
        }

        private void WantAutor()
        {
            this.Hide();
            AutorizationForm autorizationForm = new AutorizationForm();
            autorizationForm.Show();
        }

        private void FillDataGridHistoryUser()
        {
            var UserHis = db.History_Users
               .Select(m => new
               {
                   Дата_входа = m.Data_Entry,
                   Дата_выхода = m.Data_Entry
               })
               .ToList();

            dataGridView1.DataSource = UserHis;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            FillDataGridHistoryUser();
        }
    }
}
