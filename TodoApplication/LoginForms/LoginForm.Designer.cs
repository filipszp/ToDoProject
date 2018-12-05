namespace TodoApplication.LoginForms
{
    partial class LoginForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusDataSource = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusServerVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusState = new System.Windows.Forms.ToolStripStatusLabel();
            this.loginCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btbLogin = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusDataSource,
            this.statusServerVersion,
            this.statusState});
            this.statusStrip1.Location = new System.Drawing.Point(0, 157);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(447, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip";
            // 
            // statusDataSource
            // 
            this.statusDataSource.Name = "statusDataSource";
            this.statusDataSource.Size = new System.Drawing.Size(0, 17);
            // 
            // statusServerVersion
            // 
            this.statusServerVersion.Name = "statusServerVersion";
            this.statusServerVersion.Size = new System.Drawing.Size(0, 17);
            // 
            // statusState
            // 
            this.statusState.Name = "statusState";
            this.statusState.Size = new System.Drawing.Size(0, 17);
            // 
            // loginCombo
            // 
            this.loginCombo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginCombo.FormattingEnabled = true;
            this.loginCombo.Location = new System.Drawing.Point(37, 33);
            this.loginCombo.MaxLength = 20;
            this.loginCombo.Name = "loginCombo";
            this.loginCombo.Size = new System.Drawing.Size(161, 29);
            this.loginCombo.TabIndex = 1;
            this.loginCombo.Enter += new System.EventHandler(this.loginCombo_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(244, 15);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(43, 16);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Hasło";
            // 
            // tbPass
            // 
            this.tbPass.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPass.Location = new System.Drawing.Point(241, 33);
            this.tbPass.MaxLength = 20;
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(161, 28);
            this.tbPass.TabIndex = 2;
            this.tbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btbLogin
            // 
            this.btbLogin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btbLogin.Location = new System.Drawing.Point(142, 77);
            this.btbLogin.Name = "btbLogin";
            this.btbLogin.Size = new System.Drawing.Size(161, 31);
            this.btbLogin.TabIndex = 3;
            this.btbLogin.Text = "Zaloguj";
            this.btbLogin.UseVisualStyleBackColor = true;
            this.btbLogin.Click += new System.EventHandler(this.btbLogin_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNewUser.Location = new System.Drawing.Point(142, 114);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(161, 31);
            this.btnNewUser.TabIndex = 4;
            this.btnNewUser.Text = "Nowy użytkownik";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(447, 179);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.btbLogin);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginCombo);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie ToDo";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ComboBox loginCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btbLogin;
        private System.Windows.Forms.ToolStripStatusLabel statusDataSource;
        private System.Windows.Forms.ToolStripStatusLabel statusServerVersion;
        private System.Windows.Forms.ToolStripStatusLabel statusState;
        private System.Windows.Forms.Button btnNewUser;
    }
}