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
  public partial class frmRoles : Form {

    private App _app = new App();
    private DisconnectedList<Role> _list;

    public frmRoles() {
      InitializeComponent();
    }
     
#pragma warning disable IDE1006 // Naming Styles
    private void frmRoles_FormClosed(object sender, FormClosedEventArgs e) => ((IDisposable)_app).Dispose();
    private void btnLoad_Click(object sender, EventArgs e) => DoLoadData();
    private void btnSave_Click(object sender, EventArgs e) => DoSave();
#pragma warning restore IDE1006 // Naming Styles

    private void DoLoadData() {
      _list = _app.Roles.GetDisconnectedList(x => true); // x.Groups.Any(g => g.Id == 2)); // true); // x.Name.StartsWith("R"));
      bs1.DataSource = _list.List;
    }
    
    private void DoSave() {
      _app.Roles.MergeWithDisconnectedList(_list);
      int n = _app.SaveChanges();

      bs1.ResetBindings(false);
      Text = n.ToString();
    }


  }
}
