using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ToDoApplicationLib.BusinessLogic;
using ToDoApplicationLib.EntityModel;

namespace TodoApplication.Config
{
    public partial class CategoriesForm : Form
    {
        private TaskCategoryService taskCategoryService;
        private TaskCategory currentTaskCategory;
        private List<TaskCategory> taskCategories;
        public CategoriesForm()
        {
            InitializeComponent();
            taskCategoryService = new TaskCategoryService();
            taskCategories = new List<TaskCategory>();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            taskCategories = (List<TaskCategory>)taskCategoryService.getAll("CategoryName", System.Data.SqlClient.SortOrder.Ascending);
            dataGridView1.DataSource = taskCategories;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            taskCategoryService.createTaskCategory(mapCurrentTaskCategoryWithControls());

            if (validateControls())
            {
                if (currentTaskCategory.isNew)
                {
                    loadCurrentTaskCategoryFromControls();
                    currentTaskCategory = taskCategoryService.saveNewEntity(currentTaskCategory);
                    currentTaskCategory.isNew = false;
                    txtDesc.Enabled = txtName.Enabled = false;
                }
                else
                {
                    currentTaskCategory = taskCategoryService.updateTaskCategory(mapCurrentTaskCategoryWithControls());
                }
                taskCategories = (List<TaskCategory>)taskCategoryService.getAll("CategoryName", System.Data.SqlClient.SortOrder.Ascending);
                dataGridView1.DataSource = taskCategories;
                loadCurrentTaskCategoryToControls();
                //dataGridView1.CurrentCell = dataGridView1.Rows[currentTask.Id].Cells[0];
                txtDesc.Enabled = txtName.Enabled = false;
            }

            btnSave.Enabled = false;
            btnEAdd.Enabled = btnEdit.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            currentTaskCategory.isNew = true;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            txtName.Enabled = txtDesc.Enabled = true;
            txtName.Text = txtDesc.Text = "";
            txtName.Focus();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index != -1)
            {
                int categoryTaskId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                currentTaskCategory = taskCategories.Find(t => t.Id == categoryTaskId);
                loadCurrentTaskCategoryToControls();
            }
        }

        private void loadCurrentTaskCategoryToControls()
        {
            if (currentTaskCategory.Id > 0)
            {
                txtDesc.Text = currentTaskCategory.Description;
                txtName.Text = currentTaskCategory.CategoryName;
            }
        }
        private void loadCurrentTaskCategoryFromControls()
        {
            currentTaskCategory.Description = txtDesc.Text;
            currentTaskCategory.CategoryName = txtName.Text;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            currentTaskCategory.isNew = false;
            btnEdit.Enabled = btnEAdd.Enabled = false;
            btnSave.Enabled = true;
            txtName.Enabled = txtDesc.Enabled = true;
            txtName.Focus();
        }

        private TaskCategory mapCurrentTaskCategoryWithControls()
        {
            currentTaskCategory.CategoryName = txtName.Text;
            currentTaskCategory.Description = txtDesc.Text;
            return currentTaskCategory;
        }

        private bool validateControls()
        {
            if (txtName.Text.Equals(String.Empty))
            {
                errorProvider1.SetError(txtName, "Należy wprowadzić nazwę grupy zadań");
                return false;
            }

            return true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            taskCategoryService.deleteTaskCategory(currentTaskCategory);
        }
    }
}
