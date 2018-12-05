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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusUserLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLastLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxAlert = new System.Windows.Forms.CheckBox();
            this.dtPickerAlert = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboTaskCategory = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.dtPickerTaskDate = new System.Windows.Forms.DateTimePicker();
            this.checkBoxCompleted = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zadaniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noweZadanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przeglądajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipCategory = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBoxCompletedFilter = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxNotCompleted = new System.Windows.Forms.CheckBox();
            this.validatorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Completed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validatorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusUserLbl,
            this.toolStripStatusLastLogin});
            this.statusStrip1.Location = new System.Drawing.Point(0, 673);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1218, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "bottomStatus";
            // 
            // toolStripStatusUserLbl
            // 
            this.toolStripStatusUserLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripStatusUserLbl.ForeColor = System.Drawing.Color.Green;
            this.toolStripStatusUserLbl.Name = "toolStripStatusUserLbl";
            this.toolStripStatusUserLbl.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLastLogin
            // 
            this.toolStripStatusLastLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripStatusLastLogin.ForeColor = System.Drawing.Color.Green;
            this.toolStripStatusLastLogin.Name = "toolStripStatusLastLogin";
            this.toolStripStatusLastLogin.Size = new System.Drawing.Size(0, 17);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Completed,
            this.TaskName,
            this.TaskCategory,
            this.TaskDate,
            this.CreateDate});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(12, 301);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1195, 280);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkBoxAlert);
            this.groupBox1.Controls.Add(this.dtPickerAlert);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboTaskCategory);
            this.groupBox1.Controls.Add(this.btnEditTask);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.dtPickerTaskDate);
            this.groupBox1.Controls.Add(this.checkBoxCompleted);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTaskName);
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1218, 222);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybrane zadanie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(790, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Opis zadania";
            // 
            // checkBoxAlert
            // 
            this.checkBoxAlert.AutoSize = true;
            this.checkBoxAlert.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAlert.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxAlert.Location = new System.Drawing.Point(322, 112);
            this.checkBoxAlert.Name = "checkBoxAlert";
            this.checkBoxAlert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxAlert.Size = new System.Drawing.Size(141, 20);
            this.checkBoxAlert.TabIndex = 12;
            this.checkBoxAlert.Text = "Przypomnienie od";
            this.checkBoxAlert.UseVisualStyleBackColor = true;
            // 
            // dtPickerAlert
            // 
            this.dtPickerAlert.CustomFormat = "MMMMdd, yyyy  |  hh:mm";
            this.dtPickerAlert.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtPickerAlert.Location = new System.Drawing.Point(322, 132);
            this.dtPickerAlert.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtPickerAlert.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtPickerAlert.Name = "dtPickerAlert";
            this.dtPickerAlert.Size = new System.Drawing.Size(307, 23);
            this.dtPickerAlert.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(5, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data realizacji zadania";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(574, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Zadanie użytkownika";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(319, 52);
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
            this.comboTaskCategory.Location = new System.Drawing.Point(320, 68);
            this.comboTaskCategory.Name = "comboTaskCategory";
            this.comboTaskCategory.Size = new System.Drawing.Size(220, 24);
            this.comboTaskCategory.TabIndex = 1;
            this.comboTaskCategory.MouseEnter += new System.EventHandler(this.comboTaskCategory_MouseEnter);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.ForeColor = System.Drawing.Color.Red;
            this.btnSave.Location = new System.Drawing.Point(12, 627);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEditTask
            // 
            this.btnEditTask.Enabled = false;
            this.btnEditTask.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditTask.Location = new System.Drawing.Point(5, 183);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(135, 30);
            this.btnEditTask.TabIndex = 6;
            this.btnEditTask.Text = "Edytuj zadanie";
            this.btnEditTask.UseVisualStyleBackColor = true;
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.ForeColor = System.Drawing.Color.Yellow;
            this.txtDesc.Location = new System.Drawing.Point(793, 47);
            this.txtDesc.MaxLength = 2000;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(413, 166);
            this.txtDesc.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUserName.Location = new System.Drawing.Point(575, 68);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(187, 23);
            this.txtUserName.TabIndex = 9;
            // 
            // dtPickerTaskDate
            // 
            this.dtPickerTaskDate.CustomFormat = "MMMMdd, yyyy  |  hh:mm";
            this.dtPickerTaskDate.Enabled = false;
            this.dtPickerTaskDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtPickerTaskDate.Location = new System.Drawing.Point(6, 132);
            this.dtPickerTaskDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtPickerTaskDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtPickerTaskDate.Name = "dtPickerTaskDate";
            this.dtPickerTaskDate.Size = new System.Drawing.Size(285, 23);
            this.dtPickerTaskDate.TabIndex = 2;
            // 
            // checkBoxCompleted
            // 
            this.checkBoxCompleted.AutoSize = true;
            this.checkBoxCompleted.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCompleted.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxCompleted.Location = new System.Drawing.Point(8, 29);
            this.checkBoxCompleted.Name = "checkBoxCompleted";
            this.checkBoxCompleted.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxCompleted.Size = new System.Drawing.Size(113, 20);
            this.checkBoxCompleted.TabIndex = 6;
            this.checkBoxCompleted.Text = "Zrealizowane";
            this.checkBoxCompleted.UseVisualStyleBackColor = true;
            this.checkBoxCompleted.CheckedChanged += new System.EventHandler(this.checkBoxCompleted_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa zadania";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTaskName.Location = new System.Drawing.Point(6, 68);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(291, 26);
            this.txtTaskName.TabIndex = 0;
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReload.Location = new System.Drawing.Point(986, 266);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(135, 30);
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "Odśwież dane";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zadaniaToolStripMenuItem,
            this.kategorieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1218, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zadaniaToolStripMenuItem
            // 
            this.zadaniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noweZadanieToolStripMenuItem});
            this.zadaniaToolStripMenuItem.Name = "zadaniaToolStripMenuItem";
            this.zadaniaToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.zadaniaToolStripMenuItem.Text = "Zadania";
            // 
            // noweZadanieToolStripMenuItem
            // 
            this.noweZadanieToolStripMenuItem.Name = "noweZadanieToolStripMenuItem";
            this.noweZadanieToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.noweZadanieToolStripMenuItem.Text = "Nowe zadanie";
            this.noweZadanieToolStripMenuItem.Click += new System.EventHandler(this.noweZadanieToolStripMenuItem_Click);
            // 
            // kategorieToolStripMenuItem
            // 
            this.kategorieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.przeglądajToolStripMenuItem});
            this.kategorieToolStripMenuItem.Name = "kategorieToolStripMenuItem";
            this.kategorieToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.kategorieToolStripMenuItem.Text = "Kategorie";
            // 
            // przeglądajToolStripMenuItem
            // 
            this.przeglądajToolStripMenuItem.Name = "przeglądajToolStripMenuItem";
            this.przeglądajToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.przeglądajToolStripMenuItem.Text = "Przeglądaj";
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
            this.label5.Location = new System.Drawing.Point(393, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Filtr nazwa zadania";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(386, 267);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 26);
            this.textBox1.TabIndex = 9;
            // 
            // checkBoxCompletedFilter
            // 
            this.checkBoxCompletedFilter.AutoSize = true;
            this.checkBoxCompletedFilter.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCompletedFilter.Checked = true;
            this.checkBoxCompletedFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCompletedFilter.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxCompletedFilter.Location = new System.Drawing.Point(15, 267);
            this.checkBoxCompletedFilter.Name = "checkBoxCompletedFilter";
            this.checkBoxCompletedFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxCompletedFilter.Size = new System.Drawing.Size(113, 20);
            this.checkBoxCompletedFilter.TabIndex = 11;
            this.checkBoxCompletedFilter.Text = "Zrealizowane";
            this.checkBoxCompletedFilter.UseVisualStyleBackColor = true;
            this.checkBoxCompletedFilter.CheckedChanged += new System.EventHandler(this.checkBoxCompletedFilter_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(793, 268);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 27);
            this.comboBox1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(798, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Filtr grupa zadań";
            // 
            // checkBoxNotCompleted
            // 
            this.checkBoxNotCompleted.AutoSize = true;
            this.checkBoxNotCompleted.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxNotCompleted.Checked = true;
            this.checkBoxNotCompleted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNotCompleted.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxNotCompleted.Location = new System.Drawing.Point(156, 268);
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
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 85;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 85;
            // 
            // Completed
            // 
            this.Completed.DataPropertyName = "Completed";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = false;
            this.Completed.DefaultCellStyle = dataGridViewCellStyle2;
            this.Completed.FalseValue = "0";
            this.Completed.HeaderText = "Realizacja";
            this.Completed.MinimumWidth = 85;
            this.Completed.Name = "Completed";
            this.Completed.ReadOnly = true;
            this.Completed.TrueValue = "1";
            this.Completed.Width = 85;
            // 
            // TaskName
            // 
            this.TaskName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TaskName.DataPropertyName = "TaskName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.TaskName.DefaultCellStyle = dataGridViewCellStyle3;
            this.TaskName.HeaderText = "Nazwa zadania";
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            // 
            // TaskCategory
            // 
            this.TaskCategory.HeaderText = "Grupa zadań";
            this.TaskCategory.MinimumWidth = 150;
            this.TaskCategory.Name = "TaskCategory";
            this.TaskCategory.ReadOnly = true;
            this.TaskCategory.Width = 150;
            // 
            // TaskDate
            // 
            this.TaskDate.DataPropertyName = "TaskDate";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TaskDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.TaskDate.HeaderText = "Data realizacji zadania";
            this.TaskDate.MinimumWidth = 200;
            this.TaskDate.Name = "TaskDate";
            this.TaskDate.ReadOnly = true;
            this.TaskDate.Width = 200;
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CreateDate";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CreateDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.CreateDate.HeaderText = "Data utworzenia";
            this.CreateDate.MinimumWidth = 200;
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            this.CreateDate.Width = 200;
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Enabled = false;
            this.btnCancelEdit.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancelEdit.Location = new System.Drawing.Point(153, 627);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(135, 30);
            this.btnCancelEdit.TabIndex = 14;
            this.btnCancelEdit.Text = "Anuluj edycję";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRecordCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblRecordCount.Location = new System.Drawing.Point(11, 584);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(0, 16);
            this.lblRecordCount.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 695);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.checkBoxNotCompleted);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBoxCompletedFilter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusUserLbl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLastLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.CheckBox checkBoxCompleted;
        private System.Windows.Forms.DateTimePicker dtPickerTaskDate;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxCompletedFilter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtPickerAlert;
        private System.Windows.Forms.CheckBox checkBoxAlert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxNotCompleted;
        private System.Windows.Forms.ErrorProvider validatorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Completed;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Label lblRecordCount;
    }
}

