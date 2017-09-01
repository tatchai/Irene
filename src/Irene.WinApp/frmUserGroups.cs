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

    private UserGroup PreviousItem { get; set; }
    private int? PreviousItemPosition = null;
    private UserGroup CurrentItem => bsUserGroups.Current as UserGroup;

    // tab Roles
    private List<Role> _roles;
    private List<MapItemInt> _mapItems; 

    // tab Users
    private User CurrentUserFromAllUsers => bsUsers.Current as User;
    private User CurrentUserFromUsersInGroup => bsUsersInGroup.Current as User;
    private List<User> availableUsersToAddToGroup = new List<User>();


    public frmUserGroups() {
      InitializeComponent();
    }

    private void frmUserGroups_Load(object sender, EventArgs e) {
      roleBindingSource.DataSource = _app.Roles.All().ToList(); // .tolist(); //.GetDisconnectedList(i => true).List;
      PreviousItem = null;
    }

    private void frmUserGroups_FormClosed(object sender, FormClosedEventArgs e) {
      ((IDisposable)_app).Dispose();
    }

    //

#pragma warning disable IDE1006 // Naming Styles
    private void btnLoad_Click(object sender, EventArgs e) => DoLoadData();
    private void btnSave_Click(object sender, EventArgs e) => DoSave();
    private void btnDelete_Click(object sender, EventArgs e) => DoDelete();
    private void btnAddNew_Click(object sender, EventArgs e) => DoAddNew();
    private void bsUserGroups_CurrentChanged(object sender, EventArgs e) => MoveCurrentItem();
    private void btnAddUserToGroup_Click(object sender, EventArgs e) => AddUserToGroup();
    private void btnRemoveUserFromGroup_Click(object sender, EventArgs e) => RemoveUserFromGroup();
#pragma warning restore IDE1006 // Naming Styles


    private void DoLoadData() {
      _list = _app.UserGroups.GetDisconnectedList(x => true); // x.Name.StartsWith("R"));
      bsUserGroups.DataSource = _list.List;
    }

    private void DoSave() { 
      SyncUserGroupRoles();

      _app.UserGroups.MergeWithDisconnectedList(_list);
      int n = _app.SaveChanges();

      bsUserGroups.ResetBindings(false);
      Text = n.ToString();
    } 

    private void DoDelete() {
      if (CurrentItem == null) return;

      _list.List.Remove(CurrentItem);
      bsUserGroups.ResetBindings(false);
    } 

    private void DoAddNew() {
      var item = new UserGroup {
        Name = $"Group {DateTime.Now.Millisecond}"
      };
      _list.List.Add(item);

      bsUserGroups.Position = _list.List.Count() - 1;
      bsUserGroups.ResetBindings(false);
    }

    //
    private void MoveCurrentItem() {
      textBox3.Text = $"Move from {PreviousItem?.Name} to {CurrentItem?.Name}\r\n" + textBox3.Text;

      SyncUserGroupRoles();
      //if (PreviousUserGroup != null && PreviousUserGroup != CurrentUserGroup && (PreviousUserGroup?.IsDirty ?? false)) {
      //  switch (MessageBox.Show($"{PreviousUserGroup?.Name} has changed! save?", "", MessageBoxButtons.YesNoCancel)) {
      //    case DialogResult.Yes:
      //      DoSave();
      //      PreviousUserGroup.ClearDirty();
      //      break;
      //    case DialogResult.No: /* reload this object or context here */ break;
      //    case DialogResult.Cancel:
      //      if (PreviousUserGroupPosition.HasValue)
      //        bsUserGroups.Position = PreviousUserGroupPosition.Value;
      //      break;
      //  }
      //}

      CurrentItem.ClearDirty();
      availableUsersToAddToGroup = _app.UserGroups.AvailableUsersToAddToGroup(CurrentItem).ToList(); //  AllRemainingUsersInGroup.List.Except(CurrentUserGroup?.Users).ToList();
      bsUsers.DataSource = availableUsersToAddToGroup;

      PreviousItem = CurrentItem;
      PreviousItemPosition = bsUserGroups.Position;
    }

    private void SyncUserGroupRoles() {
      if (PreviousItem != null) { 
        _app.Roles.Sync(_roles, _mapItems);  
        _roles.ApplyTo(PreviousItem.Roles);
      }

      _roles = CurrentItem.Roles.ToList();
      _mapItems = CurrentItem.Roles.Select(r => new MapItemInt {
        Id = r.Id,
        Name = r.Name
      }).ToList();

      mapItemBindingSource.DataSource = _mapItems;
      mapItemBindingSource.ResetBindings(false);
    }

    // tab Users
    private void AddUserToGroup() {
      if (CurrentUserFromAllUsers == null) {
        return;
      }

      CurrentItem.AddUser(CurrentUserFromAllUsers);
      availableUsersToAddToGroup.Remove(CurrentUserFromAllUsers);
      bsUsers.ResetBindings(false);
    }


    private void RemoveUserFromGroup() {
      if (CurrentUserFromUsersInGroup == null) {
        return;
      }

      CurrentItem.RemoveUser(CurrentUserFromUsersInGroup.Id);
      availableUsersToAddToGroup.Add(CurrentUserFromUsersInGroup);
      bsUsers.ResetBindings(false);
    }

    private void mapItemBindingSource_AddingNew_1(object sender, AddingNewEventArgs e) {
      e.NewObject = new MapItemInt() {
        Id = 10
      };
    }
  }
}
