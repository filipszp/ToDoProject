using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TodoApplication.Config;
using TodoApplication.LoginForms;
using ToDoApplicationLib.BusinessLogic;
using ToDoApplicationLib.BusinessLogic.Impl;
using ToDoApplicationLib.EntityModel;
using ToDoApplicationLib.Sheduler;

namespace TodoApplication
{
    public partial class MainForm : Form
    {
        private User loggedUser;
        private LoginForm loginForm;
        private TaskService taskService;
        private UserService userService;
        private TaskCategoryService taskCategoryService;
        private Task currentTask;
        private List<Task> tasksList;
        private List<String> taskCategoryList;

        public MainForm(User _loggedUser, LoginForm _loginForm)
        {
            taskService = new TaskService();
            userService = new UserService();
            taskCategoryService = new TaskCategoryService();
            loggedUser = _loggedUser;
            loginForm = _loginForm;
            currentTask = new Task();
            tasksList = new List<Task>();
            taskCategoryList = new List<String>();
            InitializeComponent();

            NotifyTaskScheduler.RunTaskCheckerAsync().GetAwaiter().GetResult();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (loggedUser.isLogged)
            {
                toolStripStatusUserLbl.Text = "Zalogowany użytkownik: " + loggedUser.FullName + "(" + loggedUser.Login + ")";
                toolStripStatusLastLogin.Text = loggedUser.LastLoginDate.HasValue ? "        Ostatnie logowanie " + loggedUser.LastLoginDate.ToString() : String.Empty;
                loggedUser = userService.lastLoginTimeUpdate(loggedUser);
                dataGridView1.AutoGenerateColumns = false;

                loafDataGridAndTaskList(true);
                editableTaskField(false);
                loginForm.Hide();
            }
        }

        private void loafDataGridAndTaskList(bool withDefaultQuery)
        {
            if (withDefaultQuery)
            {
                tasksList = taskService.getTasksByUserId(loggedUser.Id);
                dataGridView1.DataSource = tasksList;
            }
            taskCategoryList = taskCategoryService.getAllCategoryName();
            comboTaskCategory.Items.Clear();
            comboTaskCategory.Items.AddRange(taskCategoryList.ToArray());
            lblRecordCount.Text = "Liczba zadań " + dataGridView1.RowCount;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void editableTaskField(bool editable)
        {
            txtTaskName.Enabled = txtDesc.Enabled
                = dtPickerTaskDate.Enabled
                = checkBoxCompleted.Enabled
                = btnSave.Enabled
                = btnEditTask.Enabled
                = comboTaskCategory.Enabled
                = btnCancelEdit.Enabled
                = checkBoxAlert.Enabled
                = dtPickerAlert.Enabled
                = editable;

            comboTaskCategory.SelectedItem = currentTask.TaskCategory.CategoryName;
        }


        private void checkBoxCompleted_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCompleted.Checked)
            {
                dtPickerTaskDate.Enabled = true;
            }
            else
            {
                dtPickerTaskDate.Enabled = false;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            loafDataGridAndTaskList(true);
            loadCurrentTaskToControls();
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            editableTaskField(true);
            btnEditTask.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateControls())
            {
                if (currentTask.isNew)
                {
                    loadCurrentTaskFromControls();
                    currentTask = taskService.saveNewEntity(currentTask);
                    currentTask.isNew = false;
                    btnSave.Text = "Zapisz";
                    editableTaskField(false);
                }
                else
                {
                    currentTask = taskService.updateTask(mapCurrentTaskWithControls());
                }
                loafDataGridAndTaskList(true);
                loadCurrentTaskToControls();
                //dataGridView1.CurrentCell = dataGridView1.Rows[currentTask.Id].Cells[0];
                editableTaskField(false);
            }
        }

        private bool validateControls()
        {
            if (txtTaskName.Text.Equals(String.Empty))
            {
                validatorProvider.SetError(txtTaskName, "Należy wprowadzić nazwę zadania");
                return false;
            }

            return true;
        }

        private Task mapCurrentTaskWithControls()
        {
            currentTask.Completed = (checkBoxCompleted.CheckState == CheckState.Checked ? 1 : 0);
            currentTask.TaskName = txtTaskName.Text.Trim();
            currentTask.TaskDate = dtPickerTaskDate.Value;

            var cat = taskCategoryService.getCategoryByName(comboTaskCategory.Text);
            currentTask.TaskCategory = cat;

            currentTask.Description = txtDesc.Text.Trim();
            return currentTask;
        }


        private void loadCurrentTaskToControls()
        {
            if (currentTask.Id > 0)
            {
                txtDesc.Text = currentTask.Description;
                txtTaskName.Text = currentTask.TaskName;
                dtPickerTaskDate.Value = currentTask.TaskDate;
                if (currentTask.Completed == 1) { checkBoxCompleted.CheckState = CheckState.Checked; }
                else { checkBoxCompleted.CheckState = CheckState.Unchecked; }
                txtUserName.Text = currentTask.User.FullName;
                comboTaskCategory.Items.Clear();
                comboTaskCategory.Items.Add(currentTask.TaskCategory.CategoryName);
                comboTaskCategory.Text = currentTask.TaskCategory.CategoryName;
                btnEditTask.Enabled = true;
            }
        }

        private void comboTaskCategory_MouseEnter(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(comboTaskCategory.Text))
                toolTipCategory.SetToolTip(comboTaskCategory, taskCategoryService.getCategoryByName(comboTaskCategory.Text).Description);
        }

        private void noweZadanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControls();
            btnEditTask.Enabled = false;
            btnSave.Text = "Dodaj zadanie";
            currentTask.isNew = true;

        }

        private void loadCurrentTaskFromControls()
        {
            currentTask.Description = txtDesc.Text;
            currentTask.TaskName = txtTaskName.Text;
            currentTask.CreateDate = dtPickerTaskDate.Value;
            currentTask.TaskDate = dtPickerTaskDate.Value;
            if (currentTask.Completed == 1) { checkBoxCompleted.CheckState = CheckState.Checked; }
            else { checkBoxCompleted.CheckState = CheckState.Unchecked; }

            var cat = taskCategoryService.getCategoryByName(comboTaskCategory.Text);
            currentTask.TaskCategory = cat;
            //comboTaskCategory.Items.Clear();
            //comboTaskCategory.Items.Add(currentTask.TaskCategory.CategoryName);
            //comboTaskCategory.Text = currentTask.TaskCategory.CategoryName;
            btnEditTask.Enabled = false;
        }

        private void clearControls()
        {
            editableTaskField(true);

            txtTaskName.Text = "";
            txtDesc.Text = "";
            dtPickerTaskDate.Value = DateTime.Now;
        }

        private void przeglądajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var categoriesForm = new CategoriesForm())
            {
                categoriesForm.ShowDialog();
            }
        }

        private void dataGridView1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index != -1)
            {
                int taskId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                currentTask = tasksList.Find(t => t.Id == taskId);
                loadCurrentTaskToControls();
            }
        }

        private void checkBoxCompletedFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCompletedFilter.CheckState == CheckState.Checked && checkBoxNotCompleted.CheckState == CheckState.Unchecked)
                dataGridView1.DataSource = taskService.findByNameField("Completed", currentTask.User.Id, "", 1);

            if (checkBoxCompletedFilter.CheckState == CheckState.Checked && checkBoxNotCompleted.CheckState == CheckState.Checked)
                dataGridView1.DataSource = taskService.getTasksByUserId(currentTask.User.Id);

            if (checkBoxCompletedFilter.CheckState == CheckState.Unchecked && checkBoxNotCompleted.CheckState == CheckState.Checked)
                dataGridView1.DataSource = taskService.findByNameField("Completed", currentTask.User.Id, "", 0);

            if (checkBoxCompletedFilter.CheckState == CheckState.Unchecked && checkBoxNotCompleted.CheckState == CheckState.Unchecked)
                dataGridView1.DataSource = new List<Task>();

            loafDataGridAndTaskList(false);
        }


        private void checkBoxNotCompleted_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCompletedFilter.CheckState == CheckState.Checked && checkBoxNotCompleted.CheckState == CheckState.Unchecked)
                dataGridView1.DataSource = taskService.findByNameField("Completed", currentTask.User.Id, "", 1);

            if (checkBoxCompletedFilter.CheckState == CheckState.Checked && checkBoxNotCompleted.CheckState == CheckState.Checked)
                dataGridView1.DataSource = taskService.getTasksByUserId(currentTask.User.Id);

            if (checkBoxCompletedFilter.CheckState == CheckState.Unchecked && checkBoxNotCompleted.CheckState == CheckState.Checked)
                dataGridView1.DataSource = taskService.findByNameField("Completed", currentTask.User.Id, "", 0);

            if (checkBoxCompletedFilter.CheckState == CheckState.Unchecked && checkBoxNotCompleted.CheckState == CheckState.Unchecked)
                dataGridView1.DataSource = new List<Task>();

            loafDataGridAndTaskList(false);
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            editableTaskField(false);
            loadCurrentTaskToControls();
        }
    }
}
