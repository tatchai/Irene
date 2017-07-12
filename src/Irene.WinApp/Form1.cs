using Irene.Data;
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
  public partial class Form1 : Form {

    private App app = new App();

    public Form1() {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
      var u = new User("Tester " + DateTime.Now.Millisecond);
      u.PIN = app.Users.GenerateUniquePIN();
      app.Users.Add(u); 

      app.SaveChanges();
      MessageBox.Show("OK!");
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
      ((IDisposable)app).Dispose();
    }
  }
}
