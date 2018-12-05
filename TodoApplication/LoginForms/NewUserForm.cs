using System;
using System.Linq;
using System.Windows.Forms;
using ToDoApplicationLib.BusinessLogic;
using ToDoApplicationLib.EntityModel;

namespace TodoApplication.LoginForms
{
    public partial class NewUserForm : Form
    {
        private UserService userService;
        public NewUserForm()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (validateControls(lblValidate))
            {
                addNewUser();
            }
        }

        private void addNewUser()
        {
            User createdUser = new User(tbLogin.Text, tbName.Text, PasswordCrypto.Encrypt(tbPass.Text));
            createdUser = userService.createUser(createdUser);
            if (createdUser!=null && createdUser.Id > 0)
            {
                MessageBox.Show("Utworzono użytkownika " + tbLogin.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else { Application.Exit(); }
        }

        private bool validateControls(Label label)
        {
            label.Text = "";
            if (tbLogin.Text.Any(Char.IsWhiteSpace))
            {
                label.Text = "Login nie może zawierać spacji";
                tbLogin.Focus();
                tbLogin.SelectAll();
                return false;
            }
            if (tbLogin.Text.Length > 20)
            {
                label.Text = "Login nie może mieć więcej niż 20 znaków";
                tbLogin.Focus();
                tbLogin.SelectAll();
                return false;
            }
            if (tbPass.Text.Any(Char.IsWhiteSpace))
            {
                label.Text = "Hasło nie może zawierać spacji";
                tbPass.Focus();
                tbPass.SelectAll();
                return false;
            }
            if (tbPass.Text.Length < 4)
            {
                label.Text = "Hasło musi mieć minimum 4 znaki";
                tbPass.Focus();
                tbPass.SelectAll();
                return false;
            }
            return true;
        }

        private void NewUserForm_Load(object sender, EventArgs e)
        {
            tbLogin.Focus();
        }
    }
}
