using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using TodoApplication.Config;
using TodoApplication.LoginForms;
using ToDoApplicationLib.BusinessLogic;
using ToDoApplicationLib.BusinessLogic.Impl;
using ToDoApplicationLib.EntityModel;

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
        private List<String> taskCategoryNamesList;
        private DateTime taskDateTime = new DateTime();

        public MainForm(User _loggedUser, LoginForm _loginForm)
        {
            taskService = new TaskService();
            userService = new UserService();
            taskCategoryService = new TaskCategoryService();
            loggedUser = _loggedUser;
            loginForm = _loginForm;
            currentTask = new Task();
            currentTask.TaskCategory = new TaskCategory();
            currentTask.User = loggedUser;
            tasksList = new List<Task>();
            taskCategoryNamesList = new List<String>();
            InitializeComponent();

            //NotifyTaskScheduler.RunTaskCheckerAsync().GetAwaiter().GetResult();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (loggedUser.isLogged)
            {
                toolStripStatusUserLbl.Text = "Zalogowany użytkownik: " + loggedUser.FullName + "(" + loggedUser.Login + ")";
                toolStripStatusLastLogin.Text = loggedUser.LastLoginDate.HasValue ? "        Ostatnie logowanie " + loggedUser.LastLoginDate.ToString() : String.Empty;
                loggedUser = userService.lastLoginTimeUpdate(loggedUser);
                dataGridView1.AutoGenerateColumns = false;

                loadDataGridAndCombos(true, true);
                editableTaskField(false);
                btnEditTask.Enabled = true;
                loginForm.Hide();
            }
        }

        private void loadDataGridAndCombos(bool withDefaultQuery, bool reloadCombos)
        {
            if (withDefaultQuery)
            {
                tasksList = taskService.GetTasksByUserId(loggedUser.Id);
                dataGridView1.DataSource = tasksList;
            }
            lblRecordCount.Text = "Liczba zadań " + dataGridView1.RowCount;

            if (reloadCombos)
                reloadCategoryCombo();
        }

        private void reloadCategoryCombo()
        {
            taskCategoryNamesList = taskCategoryService.getAllCategoryName();
            comboTaskCategory.Items.Clear();
            comboTaskCategory.Items.AddRange(taskCategoryNamesList.ToArray());
            if (currentTask != null && currentTask.TaskCategory != null)
            {
                comboTaskCategory.SelectedItem = currentTask.TaskCategory.CategoryName;
            }

            filtrCategory.Items.Clear();
            filtrCategory.Items.Add(String.Empty);
            filtrCategory.Items.AddRange(taskCategoryNamesList.ToArray());

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void editableTaskField(bool editable)
        {

            dtPickerTaskDateTime.Enabled = dtPickerTaskDate.Enabled
            = checkBoxCompleted.Enabled
            = btnSave.Enabled
            = btnEditTask.Enabled
            = btnNewTask.Enabled
            = comboTaskCategory.Enabled
            = btnCancelEdit.Enabled
            = editable;

            txtTaskName.ReadOnly = txtDesc.ReadOnly = !editable;

            comboTaskCategory.SelectedItem = currentTask.TaskCategory.CategoryName;
        }


        private void checkBoxCompleted_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            TaskSearchCriteria criteria = new TaskSearchCriteria();
            if (!String.IsNullOrEmpty(filtrName.Text))
                criteria.TaskName = filtrName.Text;
            if (!String.IsNullOrEmpty(filtrCategory.Text))
                criteria.TaskCategory = filtrCategory.Text;

            criteria.TaskDateFrom = filterDateFrom.Value;
            criteria.TaskDateTo = filterDateTo.Value;

            tasksList = taskService.SearchTasks(criteria, loggedUser.Id);
            dataGridView1.DataSource = tasksList;
            loadDataGridAndCombos(false, false);
            loadCurrentTaskToControls();
        }



        private void btnEditTask_Click(object sender, EventArgs e)
        {
            editableTaskField(true);
            btnEditTask.Enabled = false;
            reloadCategoryCombo();
            txtDesc.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateControls())
            {
                if (currentTask.isNew)
                {
                    loadCurrentTaskFromControls();
                    currentTask = taskService.saveNewEntity(currentTask);
                    MessageBox.Show("Zadanie " + currentTask.TaskName + " zostało dodane!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    currentTask.isNew = false;
                    editableTaskField(false);
                }
                else
                {
                    currentTask = taskService.UpdateTask(mapCurrentTaskWithControls());
                    MessageBox.Show("Zadanie " + currentTask.TaskName + " zostało zaktualizowane!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                loadDataGridAndCombos(true, true);
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

            taskDateTime = dtPickerTaskDate.Value.Date +
                    dtPickerTaskDateTime.Value.TimeOfDay;

            currentTask.TaskDate = taskDateTime;

            var cat = taskCategoryService.getCategoryByName(comboTaskCategory.Text);
            currentTask.TaskCategory = cat;

            currentTask.Description = txtDesc.Text.Trim();
            return currentTask;
        }


        private void loadCurrentTaskToControls()
        {
            if (currentTask != null && currentTask.Id > 0)
            {
                txtDesc.Text = currentTask.Description;
                txtTaskName.Text = currentTask.TaskName;

                dtPickerTaskDateTime.Text = currentTask.TaskDate.TimeOfDay.ToString();
                dtPickerTaskDate.Text = currentTask.TaskDate.Date.ToString();

                if (currentTask.Completed == 1) { checkBoxCompleted.CheckState = CheckState.Checked; }
                else { checkBoxCompleted.CheckState = CheckState.Unchecked; }
                txtUserName.Text = currentTask.User.FullName;
                comboTaskCategory.Items.Clear();
                comboTaskCategory.Items.Add(currentTask.TaskCategory.CategoryName);
                comboTaskCategory.Text = currentTask.TaskCategory.CategoryName;
                btnEditTask.Enabled = true;
                btnNewTask.Enabled = true;
            }
        }

        private void comboTaskCategory_MouseEnter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(comboTaskCategory.Text))
                toolTipCategory.SetToolTip(comboTaskCategory, taskCategoryService.getCategoryByName(comboTaskCategory.Text).Description);
        }

        private void noweZadanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControls();
            btnEditTask.Enabled = btnNewTask.Enabled = false;
            currentTask.isNew = true;
            reloadCategoryCombo();
            txtTaskName.Focus();

        }

        private void loadCurrentTaskFromControls()
        {
            currentTask.Description = txtDesc.Text;
            currentTask.TaskName = txtTaskName.Text;
            currentTask.CreateDate = DateTime.Now;
            currentTask.TaskDate = dtPickerTaskDate.Value.Date + dtPickerTaskDateTime.Value.TimeOfDay;
            if (currentTask.Completed == 1) { checkBoxCompleted.CheckState = CheckState.Checked; }
            else { checkBoxCompleted.CheckState = CheckState.Unchecked; }

            var cat = taskCategoryService.getCategoryByName(comboTaskCategory.Text);
            currentTask.TaskCategory = cat;
            btnEditTask.Enabled = false;
        }

        private void clearControls()
        {
            editableTaskField(true);

            txtTaskName.Text = "";
            txtDesc.Text = "";
            dtPickerTaskDate.Value = DateTime.Now;
            dtPickerTaskDateTime.Value = DateTime.Now;
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
            if (currentTask != null && currentTask.User != null)
            {
                if (checkBoxCompletedFilter.CheckState == CheckState.Checked && checkBoxNotCompleted.CheckState == CheckState.Unchecked)
                    dataGridView1.DataSource = taskService.findByNameField("Completed", currentTask.User.Id, "", 1);

                if (checkBoxCompletedFilter.CheckState == CheckState.Checked && checkBoxNotCompleted.CheckState == CheckState.Checked)
                    dataGridView1.DataSource = taskService.GetTasksByUserId(currentTask.User.Id);

                if (checkBoxCompletedFilter.CheckState == CheckState.Unchecked && checkBoxNotCompleted.CheckState == CheckState.Checked)
                    dataGridView1.DataSource = taskService.findByNameField("Completed", currentTask.User.Id, "", 0);

                if (checkBoxCompletedFilter.CheckState == CheckState.Unchecked && checkBoxNotCompleted.CheckState == CheckState.Unchecked)
                    dataGridView1.DataSource = new List<Task>();

                loadDataGridAndCombos(false, true);
            }
        }


        private void checkBoxNotCompleted_CheckedChanged(object sender, EventArgs e)
        {
            if (currentTask != null && currentTask.User != null)
            {
                if (checkBoxCompletedFilter.CheckState == CheckState.Checked && checkBoxNotCompleted.CheckState == CheckState.Unchecked)
                    dataGridView1.DataSource = taskService.findByNameField("Completed", currentTask.User.Id, "", 1);

                if (checkBoxCompletedFilter.CheckState == CheckState.Checked && checkBoxNotCompleted.CheckState == CheckState.Checked)
                    dataGridView1.DataSource = taskService.GetTasksByUserId(currentTask.User.Id);

                if (checkBoxCompletedFilter.CheckState == CheckState.Unchecked && checkBoxNotCompleted.CheckState == CheckState.Checked)
                    dataGridView1.DataSource = taskService.findByNameField("Completed", currentTask.User.Id, "", 0);

                if (checkBoxCompletedFilter.CheckState == CheckState.Unchecked && checkBoxNotCompleted.CheckState == CheckState.Unchecked)
                    dataGridView1.DataSource = new List<Task>();

                loadDataGridAndCombos(false, true);
            }
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            editableTaskField(false);
            loadCurrentTaskToControls();
        }

        private void filtrCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnReload_Click(sender, e);
        }

        private void btnNewTask_Click(object sender, EventArgs e)
        {
            noweZadanieToolStripMenuItem_Click(sender, e);
        }

        private void btnClearFiltr_Click(object sender, EventArgs e)
        {

            filtrName.Text = String.Empty;
            filtrCategory.SelectedItem = String.Empty;
            filterDateFrom.ResetText();
            filterDateTo.ResetText();

            btnReload_Click(sender, e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
