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

    private void frmRoles_Load(object sender, EventArgs e) {
      //
    }

    private void btnLoad_Click(object sender, EventArgs e) {
      _list = _app.Roles.GetDisconnectedList(x => true); // x.Name.StartsWith("R"));
      bs1.DataSource = _list.List;
    }

    private void btnSave_Click(object sender, EventArgs e) {
      _app.Roles.MergeWithDisconnectedList(_list);
      int n = _app.SaveChanges();

      bs1.ResetBindings(false);
      Text = n.ToString();
    }

    private void frmRoles_FormClosed(object sender, FormClosedEventArgs e) {
      ((IDisposable)_app).Dispose();
    }

  }
}
