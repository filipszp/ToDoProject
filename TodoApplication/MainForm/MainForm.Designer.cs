using System.Windows.Forms;

namespace TodoApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusUserLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLastLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboTaskCategory = new System.Windows.Forms.ComboBox();
            this.btnNewTask = new System.Windows.Forms.Button();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.dtPickerTaskDateTime = new System.Windows.Forms.DateTimePicker();
            this.checkBoxCompleted = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zadaniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noweZadanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przeglądajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipCategory = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.filtrName = new System.Windows.Forms.TextBox();
            this.checkBoxCompletedFilter = new System.Windows.Forms.CheckBox();
            this.filtrCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxNotCompleted = new System.Windows.Forms.CheckBox();
            this.validatorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.filterDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.filterDateTo = new System.Windows.Forms.DateTimePicker();
            this.btnClearFiltr = new System.Windows.Forms.Button();
            this.dtPickerTaskDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Completed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wyjścieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validatorProvider)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusUserLbl,
            this.toolStripStatusLastLogin});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1218, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "bottomStatus";
            // 
            // toolStripStatusUserLbl
            // 
            this.toolStripStatusUserLbl.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripStatusUserLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.toolStripStatusUserLbl.Name = "toolStripStatusUserLbl";
            this.toolStripStatusUserLbl.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLastLogin
            // 
            this.toolStripStatusLastLogin.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripStatusLastLogin.ForeColor = System.Drawing.Color.DarkRed;
            this.toolStripStatusLastLogin.Name = "toolStripStatusLastLogin";
            this.toolStripStatusLastLogin.Size = new System.Drawing.Size(0, 17);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Completed,
            this.TaskName,
            this.TaskDate,
            this.CreateDate});
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(11, 329);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(743, 284);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btnDeleteTask);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dtPickerTaskDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnCancelEdit);
            this.groupBox1.Controls.Add(this.comboTaskCategory);
            this.groupBox1.Controls.Add(this.btnNewTask);
            this.groupBox1.Controls.Add(this.btnEditTask);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.dtPickerTaskDateTime);
            this.groupBox1.Controls.Add(this.checkBoxCompleted);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTaskName);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1218, 278);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybrane zadanie";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(766, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Opis zadania";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(26, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data realizacji zadania";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(26, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Zadanie użytkownika";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(339, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Grupa zadań";
            // 
            // comboTaskCategory
            // 
            this.comboTaskCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTaskCategory.Enabled = false;
            this.comboTaskCategory.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboTaskCategory.FormattingEnabled = true;
            this.comboTaskCategory.Location = new System.Drawing.Point(340, 59);
            this.comboTaskCategory.Name = "comboTaskCategory";
            this.comboTaskCategory.Size = new System.Drawing.Size(220, 24);
            this.comboTaskCategory.TabIndex = 1;
            this.comboTaskCategory.MouseEnter += new System.EventHandler(this.comboTaskCategory_MouseEnter);
            // 
            // btnNewTask
            // 
            this.btnNewTask.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNewTask.Location = new System.Drawing.Point(8, 229);
            this.btnNewTask.Name = "btnNewTask";
            this.btnNewTask.Size = new System.Drawing.Size(140, 35);
            this.btnNewTask.TabIndex = 6;
            this.btnNewTask.Text = "Nowe zadanie";
            this.btnNewTask.UseVisualStyleBackColor = true;
            this.btnNewTask.Click += new System.EventHandler(this.btnNewTask_Click);
            // 
            // btnEditTask
            // 
            this.btnEditTask.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditTask.Location = new System.Drawing.Point(150, 229);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(140, 35);
            this.btnEditTask.TabIndex = 6;
            this.btnEditTask.Text = "Edytuj zadanie";
            this.btnEditTask.UseVisualStyleBackColor = true;
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.LightBlue;
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDesc.ForeColor = System.Drawing.Color.Maroon;
            this.txtDesc.Location = new System.Drawing.Point(769, 329);
            this.txtDesc.MaxLength = 2000;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(437, 284);
            this.txtDesc.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUserName.Location = new System.Drawing.Point(27, 177);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(291, 23);
            this.txtUserName.TabIndex = 9;
            // 
            // dtPickerTaskDateTime
            // 
            this.dtPickerTaskDateTime.CustomFormat = "MMMMdd, yyyy  |  hh:mm";
            this.dtPickerTaskDateTime.Enabled = false;
            this.dtPickerTaskDateTime.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtPickerTaskDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtPickerTaskDateTime.Location = new System.Drawing.Point(324, 121);
            this.dtPickerTaskDateTime.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtPickerTaskDateTime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtPickerTaskDateTime.Name = "dtPickerTaskDateTime";
            this.dtPickerTaskDateTime.ShowUpDown = true;
            this.dtPickerTaskDateTime.Size = new System.Drawing.Size(92, 23);
            this.dtPickerTaskDateTime.TabIndex = 2;
            // 
            // checkBoxCompleted
            // 
            this.checkBoxCompleted.AutoSize = true;
            this.checkBoxCompleted.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCompleted.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxCompleted.Location = new System.Drawing.Point(588, 61);
            this.checkBoxCompleted.Name = "checkBoxCompleted";
            this.checkBoxCompleted.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxCompleted.Size = new System.Drawing.Size(113, 20);
            this.checkBoxCompleted.TabIndex = 6;
            this.checkBoxCompleted.Text = "Zrealizowane";
            this.checkBoxCompleted.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa zadania";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTaskName.Location = new System.Drawing.Point(27, 57);
            this.txtTaskName.MaxLength = 100;
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(291, 26);
            this.txtTaskName.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(442, 229);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 35);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReload.Location = new System.Drawing.Point(327, 178);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(135, 30);
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "Wyszukaj";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zadaniaToolStripMenuItem,
            this.kategorieToolStripMenuItem,
            this.wyjścieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1218, 26);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zadaniaToolStripMenuItem
            // 
            this.zadaniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noweZadanieToolStripMenuItem});
            this.zadaniaToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zadaniaToolStripMenuItem.Name = "zadaniaToolStripMenuItem";
            this.zadaniaToolStripMenuItem.Size = new System.Drawing.Size(72, 22);
            this.zadaniaToolStripMenuItem.Text = "&Zadania";
            // 
            // noweZadanieToolStripMenuItem
            // 
            this.noweZadanieToolStripMenuItem.Name = "noweZadanieToolStripMenuItem";
            this.noweZadanieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noweZadanieToolStripMenuItem.Text = "&Dodaj";
            this.noweZadanieToolStripMenuItem.Click += new System.EventHandler(this.noweZadanieToolStripMenuItem_Click);
            // 
            // kategorieToolStripMenuItem
            // 
            this.kategorieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.przeglądajToolStripMenuItem});
            this.kategorieToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kategorieToolStripMenuItem.Name = "kategorieToolStripMenuItem";
            this.kategorieToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.kategorieToolStripMenuItem.Text = "&Słowniki";
            // 
            // przeglądajToolStripMenuItem
            // 
            this.przeglądajToolStripMenuItem.Name = "przeglądajToolStripMenuItem";
            this.przeglądajToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.przeglądajToolStripMenuItem.Text = "Przeglądaj\\Edytuj";
            this.przeglądajToolStripMenuItem.Click += new System.EventHandler(this.przeglądajToolStripMenuItem_Click);
            // 
            // toolTipCategory
            // 
            this.toolTipCategory.AutomaticDelay = 100;
            this.toolTipCategory.AutoPopDelay = 5000;
            this.toolTipCategory.BackColor = System.Drawing.Color.Black;
            this.toolTipCategory.ForeColor = System.Drawing.Color.Lime;
            this.toolTipCategory.InitialDelay = 100;
            this.toolTipCategory.ReshowDelay = 20;
            this.toolTipCategory.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(18, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nazwa zadania (LIKE z %)";
            // 
            // filtrName
            // 
            this.filtrName.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filtrName.Location = new System.Drawing.Point(21, 71);
            this.filtrName.Name = "filtrName";
            this.filtrName.Size = new System.Drawing.Size(272, 26);
            this.filtrName.TabIndex = 9;
            this.filtrName.TextChanged += new System.EventHandler(this.filtrName_TextChanged);
            // 
            // checkBoxCompletedFilter
            // 
            this.checkBoxCompletedFilter.AutoSize = true;
            this.checkBoxCompletedFilter.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCompletedFilter.Checked = true;
            this.checkBoxCompletedFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCompletedFilter.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxCompletedFilter.Location = new System.Drawing.Point(11, 27);
            this.checkBoxCompletedFilter.Name = "checkBoxCompletedFilter";
            this.checkBoxCompletedFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxCompletedFilter.Size = new System.Drawing.Size(113, 20);
            this.checkBoxCompletedFilter.TabIndex = 11;
            this.checkBoxCompletedFilter.Text = "Zrealizowane";
            this.checkBoxCompletedFilter.UseVisualStyleBackColor = true;
            this.checkBoxCompletedFilter.CheckedChanged += new System.EventHandler(this.checkBoxCompletedFilter_CheckedChanged);
            // 
            // filtrCategory
            // 
            this.filtrCategory.FormattingEnabled = true;
            this.filtrCategory.Location = new System.Drawing.Point(21, 122);
            this.filtrCategory.Name = "filtrCategory";
            this.filtrCategory.Size = new System.Drawing.Size(272, 27);
            this.filtrCategory.TabIndex = 13;
            this.filtrCategory.SelectedIndexChanged += new System.EventHandler(this.filtrCategory_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(18, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Grupa zadań (=)";
            // 
            // checkBoxNotCompleted
            // 
            this.checkBoxNotCompleted.AutoSize = true;
            this.checkBoxNotCompleted.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxNotCompleted.Checked = true;
            this.checkBoxNotCompleted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNotCompleted.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxNotCompleted.Location = new System.Drawing.Point(140, 27);
            this.checkBoxNotCompleted.Name = "checkBoxNotCompleted";
            this.checkBoxNotCompleted.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxNotCompleted.Size = new System.Drawing.Size(106, 20);
            this.checkBoxNotCompleted.TabIndex = 16;
            this.checkBoxNotCompleted.Text = "Do realizacji";
            this.checkBoxNotCompleted.UseVisualStyleBackColor = true;
            this.checkBoxNotCompleted.CheckedChanged += new System.EventHandler(this.checkBoxNotCompleted_CheckedChanged);
            // 
            // validatorProvider
            // 
            this.validatorProvider.ContainerControl = this;
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Enabled = false;
            this.btnCancelEdit.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancelEdit.Location = new System.Drawing.Point(296, 229);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(140, 35);
            this.btnCancelEdit.TabIndex = 14;
            this.btnCancelEdit.Text = "Anuluj edycję";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRecordCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblRecordCount.Location = new System.Drawing.Point(18, 617);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(0, 19);
            this.lblRecordCount.TabIndex = 17;
            // 
            // filterDateFrom
            // 
            this.filterDateFrom.CustomFormat = "MMMMdd, yyyy  |  hh:mm";
            this.filterDateFrom.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filterDateFrom.Location = new System.Drawing.Point(21, 176);
            this.filterDateFrom.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.filterDateFrom.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.filterDateFrom.Name = "filterDateFrom";
            this.filterDateFrom.Size = new System.Drawing.Size(272, 23);
            this.filterDateFrom.TabIndex = 19;
            this.filterDateFrom.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.filterDateFrom.ValueChanged += new System.EventHandler(this.filterDateFrom_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(18, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Data realizacji od";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(18, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Data realizacji do";
            // 
            // filterDateTo
            // 
            this.filterDateTo.CustomFormat = "MMMMdd, yyyy  |  hh:mm";
            this.filterDateTo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filterDateTo.Location = new System.Drawing.Point(21, 221);
            this.filterDateTo.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.filterDateTo.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.filterDateTo.Name = "filterDateTo";
            this.filterDateTo.Size = new System.Drawing.Size(272, 23);
            this.filterDateTo.TabIndex = 21;
            this.filterDateTo.Value = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.filterDateTo.ValueChanged += new System.EventHandler(this.filterDateTo_ValueChanged);
            // 
            // btnClearFiltr
            // 
            this.btnClearFiltr.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClearFiltr.Location = new System.Drawing.Point(327, 214);
            this.btnClearFiltr.Name = "btnClearFiltr";
            this.btnClearFiltr.Size = new System.Drawing.Size(135, 30);
            this.btnClearFiltr.TabIndex = 5;
            this.btnClearFiltr.Text = "Wyczyść filtry";
            this.btnClearFiltr.UseVisualStyleBackColor = true;
            this.btnClearFiltr.Click += new System.EventHandler(this.btnClearFiltr_Click);
            // 
            // dtPickerTaskDate
            // 
            this.dtPickerTaskDate.CustomFormat = "dd-MM-yyyy";
            this.dtPickerTaskDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtPickerTaskDate.Location = new System.Drawing.Point(27, 121);
            this.dtPickerTaskDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtPickerTaskDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtPickerTaskDate.Name = "dtPickerTaskDate";
            this.dtPickerTaskDate.ShowUpDown = true;
            this.dtPickerTaskDate.Size = new System.Drawing.Size(291, 23);
            this.dtPickerTaskDate.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.checkBoxCompletedFilter);
            this.groupBox2.Controls.Add(this.checkBoxNotCompleted);
            this.groupBox2.Controls.Add(this.btnReload);
            this.groupBox2.Controls.Add(this.btnClearFiltr);
            this.groupBox2.Controls.Add(this.filterDateTo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.filterDateFrom);
            this.groupBox2.Controls.Add(this.filtrName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.filtrCategory);
            this.groupBox2.Location = new System.Drawing.Point(725, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 259);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtry";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 10;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 10;
            // 
            // Completed
            // 
            this.Completed.DataPropertyName = "Completed";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle20.NullValue = false;
            this.Completed.DefaultCellStyle = dataGridViewCellStyle20;
            this.Completed.FalseValue = "0";
            this.Completed.HeaderText = "Status";
            this.Completed.MinimumWidth = 60;
            this.Completed.Name = "Completed";
            this.Completed.ReadOnly = true;
            this.Completed.TrueValue = "1";
            this.Completed.Width = 60;
            // 
            // TaskName
            // 
            this.TaskName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TaskName.DataPropertyName = "TaskName";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.DarkMagenta;
            this.TaskName.DefaultCellStyle = dataGridViewCellStyle21;
            this.TaskName.HeaderText = "Nazwa zadania";
            this.TaskName.MinimumWidth = 210;
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            this.TaskName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // TaskDate
            // 
            this.TaskDate.DataPropertyName = "TaskDate";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TaskDate.DefaultCellStyle = dataGridViewCellStyle22;
            this.TaskDate.HeaderText = "Data realizacji zadania";
            this.TaskDate.MinimumWidth = 190;
            this.TaskDate.Name = "TaskDate";
            this.TaskDate.ReadOnly = true;
            this.TaskDate.Width = 190;
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CreateDate";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CreateDate.DefaultCellStyle = dataGridViewCellStyle23;
            this.CreateDate.HeaderText = "Data utworzenia";
            this.CreateDate.MinimumWidth = 190;
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            this.CreateDate.Width = 190;
            // 
            // wyjścieToolStripMenuItem
            // 
            this.wyjścieToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wyjścieToolStripMenuItem.Name = "wyjścieToolStripMenuItem";
            this.wyjścieToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.wyjścieToolStripMenuItem.Text = "&Wyjście z aplikacji";
            this.wyjścieToolStripMenuItem.Click += new System.EventHandler(this.wyjścieToolStripMenuItem_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteTask.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteTask.Location = new System.Drawing.Point(588, 229);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(131, 35);
            this.btnDeleteTask.TabIndex = 16;
            this.btnDeleteTask.Text = "Usuń zadanie";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 661);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDo Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validatorProvider)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusUserLbl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLastLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.CheckBox checkBoxCompleted;
        private System.Windows.Forms.DateTimePicker dtPickerTaskDateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zadaniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noweZadanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przeglądajToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ComboBox comboTaskCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTipCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox filtrName;
        private System.Windows.Forms.CheckBox checkBoxCompletedFilter;
        private System.Windows.Forms.ComboBox filtrCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxNotCompleted;
        private System.Windows.Forms.ErrorProvider validatorProvider;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker filterDateTo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker filterDateFrom;
        private System.Windows.Forms.Button btnNewTask;
        private System.Windows.Forms.Button btnClearFiltr;
        private DateTimePicker dtPickerTaskDate;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewCheckBoxColumn Completed;
        private DataGridViewTextBoxColumn TaskName;
        private DataGridViewTextBoxColumn TaskDate;
        private DataGridViewTextBoxColumn CreateDate;
        private ToolStripMenuItem wyjścieToolStripMenuItem;
        private Button btnDeleteTask;
    }
}

