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
      this.btnAddUser = new System.Windows.Forms.Button();
      this.btnGetUsers = new System.Windows.Forms.Button();
      this.lstUsers = new System.Windows.Forms.ListBox();
      this.Activate = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
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
      this.lstUsers.FormattingEnabled = true;
      this.lstUsers.Location = new System.Drawing.Point(40, 112);
      this.lstUsers.Name = "lstUsers";
      this.lstUsers.Size = new System.Drawing.Size(179, 95);
      this.lstUsers.TabIndex = 2;
      // 
      // Activate
      // 
      this.Activate.Location = new System.Drawing.Point(225, 112);
      this.Activate.Name = "Activate";
      this.Activate.Size = new System.Drawing.Size(75, 23);
      this.Activate.TabIndex = 3;
      this.Activate.Text = "Activate";
      this.Activate.UseVisualStyleBackColor = true;
      this.Activate.Click += new System.EventHandler(this.Activate_Click);
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
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(465, 263);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.Activate);
      this.Controls.Add(this.lstUsers);
      this.Controls.Add(this.btnGetUsers);
      this.Controls.Add(this.btnAddUser);
      this.Name = "Form1";
      this.Text = "Form1";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnAddUser;
    private System.Windows.Forms.Button btnGetUsers;
    private System.Windows.Forms.ListBox lstUsers;
    private System.Windows.Forms.Button Activate;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
  }
}

