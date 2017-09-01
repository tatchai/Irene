namespace Irene.WinApp {
  partial class Form1 {
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
      this.btnAddUser = new System.Windows.Forms.Button();
      this.btnGetUsers = new System.Windows.Forms.Button();
      this.lstUsers = new System.Windows.Forms.ListBox();
      this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.btnActivate = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.passwordHashDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.statusTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.createdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.createdByUserNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lastVisibleDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.carsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.canActivateDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.canSuspendDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.canDisableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.friendlyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.commentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridView2 = new System.Windows.Forms.DataGridView();
      this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
      this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.button3 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // btnAddUser
      // 
      this.btnAddUser.Location = new System.Drawing.Point(40, 27);
      this.btnAddUser.Name = "btnAddUser";
      this.btnAddUser.Size = new System.Drawing.Size(75, 23);
      this.btnAddUser.TabIndex = 0;
      this.btnAddUser.Text = "Add User ";
      this.btnAddUser.UseVisualStyleBackColor = true;
      this.btnAddUser.Click += new System.EventHandler(this.button1_Click);
      // 
      // btnGetUsers
      // 
      this.btnGetUsers.Location = new System.Drawing.Point(40, 83);
      this.btnGetUsers.Name = "btnGetUsers";
      this.btnGetUsers.Size = new System.Drawing.Size(75, 23);
      this.btnGetUsers.TabIndex = 1;
      this.btnGetUsers.Text = "Get all users";
      this.btnGetUsers.UseVisualStyleBackColor = true;
      this.btnGetUsers.Click += new System.EventHandler(this.button2_Click);
      // 
      // lstUsers
      // 
      this.lstUsers.DataSource = this.bindingSource1;
      this.lstUsers.DisplayMember = "FriendlyName";
      this.lstUsers.FormattingEnabled = true;
      this.lstUsers.Location = new System.Drawing.Point(40, 112);
      this.lstUsers.Name = "lstUsers";
      this.lstUsers.Size = new System.Drawing.Size(179, 95);
      this.lstUsers.TabIndex = 2;
      this.lstUsers.ValueMember = "Id";
      this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
      // 
      // bindingSource1
      // 
      this.bindingSource1.DataSource = typeof(Irene.Models.User);
      this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
      // 
      // btnActivate
      // 
      this.btnActivate.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bindingSource1, "CanActivate", true));
      this.btnActivate.Location = new System.Drawing.Point(225, 112);
      this.btnActivate.Name = "btnActivate";
      this.btnActivate.Size = new System.Drawing.Size(75, 23);
      this.btnActivate.TabIndex = 3;
      this.btnActivate.Text = "Activate";
      this.btnActivate.UseVisualStyleBackColor = true;
      this.btnActivate.Click += new System.EventHandler(this.Activate_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(225, 141);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 4;
      this.button1.Text = "Suspend";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click_1);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(225, 170);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 5;
      this.button2.Text = "Disable";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click_1);
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.passwordHashDataGridViewTextBoxColumn,
            this.pINDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.statusTextDataGridViewTextBoxColumn,
            this.createdDateDataGridViewTextBoxColumn,
            this.createdByUserNameDataGridViewTextBoxColumn,
            this.lastVisibleDateDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.carsDataGridViewTextBoxColumn,
            this.canActivateDataGridViewCheckBoxColumn,
            this.canSuspendDataGridViewCheckBoxColumn,
            this.canDisableDataGridViewCheckBoxColumn,
            this.friendlyNameDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn1});
      this.dataGridView1.DataSource = this.bindingSource1;
      this.dataGridView1.Location = new System.Drawing.Point(335, 27);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(309, 180);
      this.dataGridView1.TabIndex = 6;
      this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      // 
      // userNameDataGridViewTextBoxColumn
      // 
      this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
      this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
      this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
      // 
      // passwordHashDataGridViewTextBoxColumn
      // 
      this.passwordHashDataGridViewTextBoxColumn.DataPropertyName = "PasswordHash";
      this.passwordHashDataGridViewTextBoxColumn.HeaderText = "PasswordHash";
      this.passwordHashDataGridViewTextBoxColumn.Name = "passwordHashDataGridViewTextBoxColumn";
      // 
      // pINDataGridViewTextBoxColumn
      // 
      this.pINDataGridViewTextBoxColumn.DataPropertyName = "PIN";
      this.pINDataGridViewTextBoxColumn.HeaderText = "PIN";
      this.pINDataGridViewTextBoxColumn.Name = "pINDataGridViewTextBoxColumn";
      // 
      // statusDataGridViewTextBoxColumn
      // 
      this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
      this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
      this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
      this.statusDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // statusTextDataGridViewTextBoxColumn
      // 
      this.statusTextDataGridViewTextBoxColumn.DataPropertyName = "StatusText";
      this.statusTextDataGridViewTextBoxColumn.HeaderText = "StatusText";
      this.statusTextDataGridViewTextBoxColumn.Name = "statusTextDataGridViewTextBoxColumn";
      // 
      // createdDateDataGridViewTextBoxColumn
      // 
      this.createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
      this.createdDateDataGridViewTextBoxColumn.HeaderText = "CreatedDate";
      this.createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
      // 
      // createdByUserNameDataGridViewTextBoxColumn
      // 
      this.createdByUserNameDataGridViewTextBoxColumn.DataPropertyName = "CreatedByUserName";
      this.createdByUserNameDataGridViewTextBoxColumn.HeaderText = "CreatedByUserName";
      this.createdByUserNameDataGridViewTextBoxColumn.Name = "createdByUserNameDataGridViewTextBoxColumn";
      // 
      // lastVisibleDateDataGridViewTextBoxColumn
      // 
      this.lastVisibleDateDataGridViewTextBoxColumn.DataPropertyName = "LastVisibleDate";
      this.lastVisibleDateDataGridViewTextBoxColumn.HeaderText = "LastVisibleDate";
      this.lastVisibleDateDataGridViewTextBoxColumn.Name = "lastVisibleDateDataGridViewTextBoxColumn";
      // 
      // emailDataGridViewTextBoxColumn
      // 
      this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
      this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
      this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
      // 
      // mobileDataGridViewTextBoxColumn
      // 
      this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
      this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
      this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
      // 
      // noteDataGridViewTextBoxColumn
      // 
      this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
      this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
      this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
      // 
      // carsDataGridViewTextBoxColumn
      // 
      this.carsDataGridViewTextBoxColumn.DataPropertyName = "Cars";
      this.carsDataGridViewTextBoxColumn.HeaderText = "Cars";
      this.carsDataGridViewTextBoxColumn.Name = "carsDataGridViewTextBoxColumn";
      // 
      // canActivateDataGridViewCheckBoxColumn
      // 
      this.canActivateDataGridViewCheckBoxColumn.DataPropertyName = "CanActivate";
      this.canActivateDataGridViewCheckBoxColumn.HeaderText = "CanActivate";
      this.canActivateDataGridViewCheckBoxColumn.Name = "canActivateDataGridViewCheckBoxColumn";
      this.canActivateDataGridViewCheckBoxColumn.ReadOnly = true;
      // 
      // canSuspendDataGridViewCheckBoxColumn
      // 
      this.canSuspendDataGridViewCheckBoxColumn.DataPropertyName = "CanSuspend";
      this.canSuspendDataGridViewCheckBoxColumn.HeaderText = "CanSuspend";
      this.canSuspendDataGridViewCheckBoxColumn.Name = "canSuspendDataGridViewCheckBoxColumn";
      this.canSuspendDataGridViewCheckBoxColumn.ReadOnly = true;
      // 
      // canDisableDataGridViewCheckBoxColumn
      // 
      this.canDisableDataGridViewCheckBoxColumn.DataPropertyName = "CanDisable";
      this.canDisableDataGridViewCheckBoxColumn.HeaderText = "CanDisable";
      this.canDisableDataGridViewCheckBoxColumn.Name = "canDisableDataGridViewCheckBoxColumn";
      this.canDisableDataGridViewCheckBoxColumn.ReadOnly = true;
      // 
      // friendlyNameDataGridViewTextBoxColumn
      // 
      this.friendlyNameDataGridViewTextBoxColumn.DataPropertyName = "FriendlyName";
      this.friendlyNameDataGridViewTextBoxColumn.HeaderText = "FriendlyName";
      this.friendlyNameDataGridViewTextBoxColumn.Name = "friendlyNameDataGridViewTextBoxColumn";
      this.friendlyNameDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // idDataGridViewTextBoxColumn
      // 
      this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
      this.idDataGridViewTextBoxColumn.HeaderText = "Id";
      this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
      // 
      // commentDataGridViewTextBoxColumn1
      // 
      this.commentDataGridViewTextBoxColumn1.DataPropertyName = "Comment";
      this.commentDataGridViewTextBoxColumn1.HeaderText = "Comment";
      this.commentDataGridViewTextBoxColumn1.Name = "commentDataGridViewTextBoxColumn1";
      // 
      // dataGridView2
      // 
      this.dataGridView2.AutoGenerateColumns = false;
      this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colorDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn1,
            this.commentDataGridViewTextBoxColumn});
      this.dataGridView2.DataSource = this.bindingSource2;
      this.dataGridView2.Location = new System.Drawing.Point(128, 232);
      this.dataGridView2.Name = "dataGridView2";
      this.dataGridView2.Size = new System.Drawing.Size(615, 174);
      this.dataGridView2.TabIndex = 7;
      // 
      // colorDataGridViewTextBoxColumn
      // 
      this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
      this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
      this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
      // 
      // idDataGridViewTextBoxColumn1
      // 
      this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
      this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
      this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
      // 
      // commentDataGridViewTextBoxColumn
      // 
      this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
      this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
      this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
      // 
      // bindingSource2
      // 
      this.bindingSource2.DataSource = typeof(Irene.Models.Car);
      this.bindingSource2.CurrentItemChanged += new System.EventHandler(this.bindingSource2_CurrentItemChanged);
      this.bindingSource2.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bindingSource2_ListChanged);
      // 
      // carBindingSource
      // 
      this.carBindingSource.DataSource = typeof(Irene.Models.Car);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(40, 307);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(75, 23);
      this.button3.TabIndex = 8;
      this.button3.Text = "button3";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(778, 418);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.dataGridView2);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.btnActivate);
      this.Controls.Add(this.lstUsers);
      this.Controls.Add(this.btnGetUsers);
      this.Controls.Add(this.btnAddUser);
      this.Name = "Form1";
      this.Text = "Form1";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnAddUser;
    private System.Windows.Forms.Button btnGetUsers;
    private System.Windows.Forms.ListBox lstUsers;
    private System.Windows.Forms.Button btnActivate;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource bindingSource1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridView dataGridView2;
    private System.Windows.Forms.BindingSource bindingSource2;
    private System.Windows.Forms.BindingSource carBindingSource;
    private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn passwordHashDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn pINDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn statusTextDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn createdByUserNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn lastVisibleDateDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn carsDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn canActivateDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn canSuspendDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn canDisableDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn friendlyNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn1;
    private System.Windows.Forms.Button button3;
  }
}

