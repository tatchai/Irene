namespace Irene.WinApp {
  partial class frmUserGroups {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.panel1 = new System.Windows.Forms.Panel();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.button4 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.bsUserGroups = new System.Windows.Forms.BindingSource(this.components);
      this.button1 = new System.Windows.Forms.Button();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.btnRemoveUserFromGroup = new System.Windows.Forms.Button();
      this.btnAddUserToGroup = new System.Windows.Forms.Button();
      this.lstUsersInGroup = new System.Windows.Forms.ListBox();
      this.bsUsersInGroup = new System.Windows.Forms.BindingSource(this.components);
      this.lstAllUsers = new System.Windows.Forms.ListBox();
      this.bsUsers = new System.Windows.Forms.BindingSource(this.components);
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.rolesDataGridView = new System.Windows.Forms.DataGridView();
      this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.mapItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bsUserGroups)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bsUsersInGroup)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.rolesDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.mapItemBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.textBox3);
      this.panel1.Controls.Add(this.button4);
      this.panel1.Controls.Add(this.button3);
      this.panel1.Controls.Add(this.button2);
      this.panel1.Controls.Add(this.button1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(803, 96);
      this.panel1.TabIndex = 0;
      // 
      // textBox3
      // 
      this.textBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.textBox3.Location = new System.Drawing.Point(0, 52);
      this.textBox3.Multiline = true;
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(803, 44);
      this.textBox3.TabIndex = 4;
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(365, 8);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(104, 38);
      this.button4.TabIndex = 3;
      this.button4.Text = "&Add New";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.btnAddNew_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(255, 8);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(104, 38);
      this.button3.TabIndex = 2;
      this.button3.Text = "&Delete";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // button2
      // 
      this.button2.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bsUserGroups, "IsValid", true));
      this.button2.Location = new System.Drawing.Point(122, 8);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(104, 38);
      this.button2.TabIndex = 1;
      this.button2.Text = "&Save";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // bsUserGroups
      // 
      this.bsUserGroups.AllowNew = false;
      this.bsUserGroups.DataSource = typeof(Irene.Models.UserGroup);
      this.bsUserGroups.CurrentChanged += new System.EventHandler(this.bsUserGroups_CurrentChanged);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(12, 8);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(104, 38);
      this.button1.TabIndex = 0;
      this.button1.Text = "&Load";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.btnLoad_Click);
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 96);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.AutoScroll = true;
      this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
      this.splitContainer1.Panel2.Controls.Add(this.textBox2);
      this.splitContainer1.Panel2.Controls.Add(this.textBox1);
      this.splitContainer1.Size = new System.Drawing.Size(803, 304);
      this.splitContainer1.SplitterDistance = 278;
      this.splitContainer1.TabIndex = 1;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.bsUserGroups;
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView1.Location = new System.Drawing.Point(0, 0);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(278, 304);
      this.dataGridView1.TabIndex = 0;
      // 
      // idDataGridViewTextBoxColumn
      // 
      this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
      this.idDataGridViewTextBoxColumn.HeaderText = "Id";
      this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
      this.idDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // nameDataGridViewTextBoxColumn
      // 
      this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
      this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
      this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
      this.nameDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // commentDataGridViewTextBoxColumn
      // 
      this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
      this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
      this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
      this.commentDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // tabControl1
      // 
      this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(14, 83);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(495, 209);
      this.tabControl1.TabIndex = 2;
      // 
      // tabPage1
      // 
      this.tabPage1.AutoScroll = true;
      this.tabPage1.Controls.Add(this.btnRemoveUserFromGroup);
      this.tabPage1.Controls.Add(this.btnAddUserToGroup);
      this.tabPage1.Controls.Add(this.lstUsersInGroup);
      this.tabPage1.Controls.Add(this.lstAllUsers);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(487, 183);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Users";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // btnRemoveUserFromGroup
      // 
      this.btnRemoveUserFromGroup.Location = new System.Drawing.Point(196, 83);
      this.btnRemoveUserFromGroup.Name = "btnRemoveUserFromGroup";
      this.btnRemoveUserFromGroup.Size = new System.Drawing.Size(52, 44);
      this.btnRemoveUserFromGroup.TabIndex = 3;
      this.btnRemoveUserFromGroup.Text = "<";
      this.btnRemoveUserFromGroup.UseVisualStyleBackColor = true;
      this.btnRemoveUserFromGroup.Click += new System.EventHandler(this.btnRemoveUserFromGroup_Click);
      // 
      // btnAddUserToGroup
      // 
      this.btnAddUserToGroup.Location = new System.Drawing.Point(196, 33);
      this.btnAddUserToGroup.Name = "btnAddUserToGroup";
      this.btnAddUserToGroup.Size = new System.Drawing.Size(52, 44);
      this.btnAddUserToGroup.TabIndex = 2;
      this.btnAddUserToGroup.Text = ">";
      this.btnAddUserToGroup.UseVisualStyleBackColor = true;
      this.btnAddUserToGroup.Click += new System.EventHandler(this.btnAddUserToGroup_Click);
      // 
      // lstUsersInGroup
      // 
      this.lstUsersInGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.lstUsersInGroup.DataSource = this.bsUsersInGroup;
      this.lstUsersInGroup.DisplayMember = "UserName";
      this.lstUsersInGroup.FormattingEnabled = true;
      this.lstUsersInGroup.IntegralHeight = false;
      this.lstUsersInGroup.Location = new System.Drawing.Point(254, 6);
      this.lstUsersInGroup.Name = "lstUsersInGroup";
      this.lstUsersInGroup.Size = new System.Drawing.Size(181, 172);
      this.lstUsersInGroup.TabIndex = 1;
      // 
      // bsUsersInGroup
      // 
      this.bsUsersInGroup.DataMember = "Users";
      this.bsUsersInGroup.DataSource = this.bsUserGroups;
      // 
      // lstAllUsers
      // 
      this.lstAllUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.lstAllUsers.DataSource = this.bsUsers;
      this.lstAllUsers.DisplayMember = "UserName";
      this.lstAllUsers.FormattingEnabled = true;
      this.lstAllUsers.IntegralHeight = false;
      this.lstAllUsers.Location = new System.Drawing.Point(6, 6);
      this.lstAllUsers.Name = "lstAllUsers";
      this.lstAllUsers.Size = new System.Drawing.Size(184, 172);
      this.lstAllUsers.TabIndex = 0;
      this.lstAllUsers.ValueMember = "CanActivate";
      // 
      // bsUsers
      // 
      this.bsUsers.DataSource = typeof(Irene.Models.User);
      // 
      // tabPage2
      // 
      this.tabPage2.AutoScroll = true;
      this.tabPage2.Controls.Add(this.rolesDataGridView);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(487, 183);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Roles";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // rolesDataGridView
      // 
      this.rolesDataGridView.AutoGenerateColumns = false;
      this.rolesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.rolesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
      this.rolesDataGridView.DataSource = this.mapItemBindingSource;
      this.rolesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rolesDataGridView.Location = new System.Drawing.Point(3, 3);
      this.rolesDataGridView.Name = "rolesDataGridView";
      this.rolesDataGridView.Size = new System.Drawing.Size(481, 177);
      this.rolesDataGridView.TabIndex = 0;
      // 
      // roleBindingSource
      // 
      this.roleBindingSource.DataSource = typeof(Irene.Models.Role);
      // 
      // mapItemBindingSource
      // 
      this.mapItemBindingSource.DataSource = typeof(Irene.Models.MapItemInt);
      this.mapItemBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.mapItemBindingSource_AddingNew_1);
      // 
      // textBox2
      // 
      this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUserGroups, "Name", true));
      this.textBox2.Location = new System.Drawing.Point(93, 42);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(340, 20);
      this.textBox2.TabIndex = 1;
      // 
      // textBox1
      // 
      this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUserGroups, "Id", true));
      this.textBox1.Location = new System.Drawing.Point(93, 16);
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.Size = new System.Drawing.Size(100, 20);
      this.textBox1.TabIndex = 0;
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      this.errorProvider1.DataSource = this.bsUserGroups;
      // 
      // Column1
      // 
      this.Column1.DataPropertyName = "Id";
      this.Column1.DataSource = this.roleBindingSource;
      this.Column1.DisplayMember = "Name";
      this.Column1.HeaderText = "Name";
      this.Column1.Name = "Column1";
      this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.Column1.ValueMember = "Id";
      // 
      // frmUserGroups
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(803, 400);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.panel1);
      this.Name = "frmUserGroups";
      this.Text = "User Groups";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUserGroups_FormClosed);
      this.Load += new System.EventHandler(this.frmUserGroups_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bsUserGroups)).EndInit();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.bsUsersInGroup)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).EndInit();
      this.tabPage2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.rolesDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.mapItemBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.BindingSource bsUserGroups;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.ErrorProvider errorProvider1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.Button btnRemoveUserFromGroup;
    private System.Windows.Forms.Button btnAddUserToGroup;
    private System.Windows.Forms.ListBox lstUsersInGroup;
    private System.Windows.Forms.ListBox lstAllUsers;
    private System.Windows.Forms.TabPage tabPage2;
    //private System.Windows.Forms.DataGridView usersDataGridView;
    //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    //private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    private System.Windows.Forms.BindingSource bsUsersInGroup;
    private System.Windows.Forms.BindingSource bsUsers;
    private System.Windows.Forms.DataGridView rolesDataGridView;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.BindingSource roleBindingSource;
    private System.Windows.Forms.BindingSource mapItemBindingSource;
    //private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
  }
}