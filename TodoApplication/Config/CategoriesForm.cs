using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoApplicationLib.BusinessLogic;
using ToDoApplicationLib.EntityModel;

namespace TodoApplication.Config
{
    public partial class CategoriesForm : Form
    {
        private TaskCategoryService taskCategoryService;
        private TaskCategory currentTaskCatgory;
        public CategoriesForm()
        {
            InitializeComponent();
            taskCategoryService = new TaskCategoryService();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = taskCategoryService.getAll("CategoryName", System.Data.SqlClient.SortOrder.Ascending);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          // dataGridView1.
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            btnSave.Enabled = true;
        }
    }
}
