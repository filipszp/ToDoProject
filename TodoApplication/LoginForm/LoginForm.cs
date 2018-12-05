using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ToDoApplicationLib;
using ToDoApplicationLib.EntityModel;

namespace TodoApplication.Login
{
    public partial class LoginForm : Form
    {
        private DbContext dbContext;

        public LoginForm()
        {
            InitializeComponent();
            dbContext = new DbContext();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            UserService service = new UserService(dbContext);
            var logins = service.getAllLogin();
            if (logins != null)
            {
                var slogins = new List<String>();
                logins.ForEach(x => slogins.Add(x.Login));
                comboBox1.Items.AddRange(slogins.ToArray());
            }

            statusDataSource.Text = dbContext.Database.Connection.DataSource;
            statusServerVersion.Text = dbContext.Database.Connection.ServerVersion;
            statusState.Text = dbContext.Database.Connection.State.ToString();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
