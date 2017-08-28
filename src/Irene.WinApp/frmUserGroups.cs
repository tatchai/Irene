using Irene.Models;
using Irene.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Irene.WinApp {
  public partial class frmUserGroups : Form {

    private App _app = new App();
    private DisconnectedList<UserGroup> _list;


    public frmUserGroups() {
      InitializeComponent();
    }

    private void frmUserGroups_Load(object sender, EventArgs e) {

    }

    private void button1_Click(object sender, EventArgs e) {
      _list = _app.UserGroups.GetDisconnectedList(x => true); // x.Name.StartsWith("R"));
      bsUserGroups.DataSource = _list.List;

    }

    private void frmUserGroups_FormClosed(object sender, FormClosedEventArgs e) {
      ((IDisposable)_app).Dispose();
    }

    private void button2_Click(object sender, EventArgs e) {
      _app.UserGroups.MergeWithDisconnectedList(_list);
      int n = _app.SaveChanges();

      bsUserGroups.ResetBindings(false);
      Text = n.ToString();
    }


    private void btnDelete_Click(object sender, EventArgs e) {
      if (CurrentUserGroup == null) return;

      _list.List.Remove(CurrentUserGroup);
      bsUserGroups.ResetBindings(false);
    }

    private void btnAddNew_Click(object sender, EventArgs e) {
      var item = new UserGroup();
      item.Name = $"Group {DateTime.Now.Millisecond}";
      _list.List.Add(item);

      bsUserGroups.Position = _list.List.Count() - 1;
      bsUserGroups.ResetBindings(false);
    }

    private UserGroup CurrentUserGroup => bsUserGroups.Current as UserGroup;

    private User CurrentUserFromAllUsers => bsUsers.Current as User;
    private User CurrentUserFromUsersInGroup => bsUsersInGroup.Current as User;
    private DisconnectedList<User> AllRemainingUsersInGroup;

    private void bsUserGroups_CurrentChanged(object sender, EventArgs e) {
      AllRemainingUsersInGroup = _app.Users.GetDisconnectedList(u => true);
      AllRemainingUsersInGroup.List = AllRemainingUsersInGroup.List.Except(CurrentUserGroup?.Users).ToList();
      bsUsers.DataSource = AllRemainingUsersInGroup.List;
    }

    private void btnAddUserToGroup_Click(object sender, EventArgs e) {
      if (CurrentUserFromAllUsers == null) return;

      CurrentUserGroup.Users.Add(CurrentUserFromAllUsers);
      AllRemainingUsersInGroup.List.Remove(CurrentUserFromAllUsers);
      bsUsers.ResetBindings(false);
    }

    private void btnRemoveUserFromGroup_Click(object sender, EventArgs e) {
      if (CurrentUserFromUsersInGroup == null) return;

      CurrentUserGroup.Users.Remove(CurrentUserFromUsersInGroup);
      AllRemainingUsersInGroup.List.Add(CurrentUserFromUsersInGroup);
      bsUsers.ResetBindings(false);
    }
  }
}
