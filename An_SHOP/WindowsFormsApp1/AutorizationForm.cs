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
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            WantRegister();
        }

        private void WantRegister()
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Autor();
        }

        private void WantUser(int id)
        {
         

            this.Hide();
            UserForm userForm = new UserForm();
            userForm.UserID = id;
            userForm.Show();
        }
        private void WantAdmin()
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }
        anotherShopBDEntities db = new anotherShopBDEntities();

        void DataEntry(int id)
        {

            DateTime EntryDateTime = DateTime.UtcNow;
            History_Users history_Users = new History_Users
            {
                User_ID = id,
                Data_Entry = EntryDateTime,
            };
            db.History_Users.Add(history_Users);
            db.SaveChanges();
            

        }

        private void Autor()
        {
            Users result = db.Users
                .Where(c => c.Login == textBoxLogin.Text && c.Pass == textBoxPassword.Text)
                .Select(c => c)
                .FirstOrDefault();

            if(result == null)
            {
                MessageBox.Show("Логин или пароль не правильные, попробуйте еще раз!");
                return;
            }

            if(result.Role_ID == 1)
            {
                WantAdmin();
            }   
            else if(result.Role_ID == 2)
            {
                WantUser(result.ID);
                DataEntry(result.ID);
            }
            else
            {
                MessageBox.Show("В разработке...");
            }
        }
    }
}
