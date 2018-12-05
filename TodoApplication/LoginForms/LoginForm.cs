using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ToDoApplicationLib;
using ToDoApplicationLib.BusinessLogic;
using ToDoApplicationLib.BusinessLogic.Impl;
using ToDoApplicationLib.EntityModel;

namespace TodoApplication.LoginForms
{
    public partial class LoginForm : Form
    {
        UserService userService;
        TaskService taskService;
        User mainUser;
        MainForm mainForm;

        public LoginForm()
        {
            InitializeComponent();
            userService = new UserService();
            taskService = new TaskService();
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //USUNAC
            //dbContext = new DbEntities();
            //statusDataSource.Text = dbContext.Database.Connection.DataSource;
            //statusServerVersion.Text = dbContext.Database.Connection.ServerVersion;
            //statusState.Text = dbContext.Database.Connection.State.ToString();

            tbPass.Text = "test";
            loginCombo.Text = "test";
        }

        private void loadLoginsToCombo()
        {
            loginCombo.Items.Clear();
            var logins = userService.getAllLogin();
            if (logins.Count > 0)
            {
                loginCombo.Items.AddRange(logins.ToArray());
            }
            else
            {
                MessageBox.Show("W bazie nie ma użytkowników. Należy utworzyć aby się zalogować", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            var newUserForm = new NewUserForm();
            newUserForm.ShowDialog();
        }

        private void btbLogin_Click(object sender, EventArgs e)
        {
            User loginUser = new User(loginCombo.Text,"", tbPass.Text);
            loginUser = userService.login(loginUser);
            if (loginUser != null && loginUser.isLogged)
            {
                //LOGOWANIE OK
                this.mainUser = loginUser;
                mainForm = new MainForm(this.mainUser, this);
                //mainForm.WindowState = FormWindowState.Maximized;
                mainForm.Show();
            }
            else
                MessageBox.Show("Nieprawidłowy login lub hasło", "Logowanie", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void loginCombo_Enter(object sender, EventArgs e)
        {
            loadLoginsToCombo();
        }
    }
}
