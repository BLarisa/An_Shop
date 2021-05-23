using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Objects;

namespace WindowsFormsApp1
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.FormClosing += RegisterForm_FormClosing;
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        anotherShopBDEntities db = new anotherShopBDEntities();
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Register();
        }

        private void WantAutor()
        {
            this.Hide();
            AutorizationForm autorizationForm = new AutorizationForm();
            autorizationForm.Show();
        }

        private void Register()
        {
            if(textBoxFIO.Text == "" && textBoxLOGIN.Text == "" && textBoxPASS.Text == "" && comboBox1.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Вы не заполнили все необходимые поля!");
                return;
            }

            var SelectRole = db.Roles
                .Where(c => c.Role_Name == comboBox1.SelectedItem.ToString())
                .Select(c => c.ID)
                .FirstOrDefault();

            Users users = new Users
            {
                FIO = textBoxFIO.Text,
                Login = textBoxLOGIN.Text,
                Pass = textBoxPASS.Text,
                Role_ID = SelectRole
            };

            db.Users.Add(users);
            db.SaveChanges();

            MessageBox.Show("Успешная регистрация!");
            WantAutor();
        }

        private void FillListBoxRole()
        {
            var Roles = db.Roles
                .Select(c => c.Role_Name)
                .ToArray();

            comboBox1.Items.AddRange(Roles);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WantAutor();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            FillListBoxRole();
        }
    }
}
