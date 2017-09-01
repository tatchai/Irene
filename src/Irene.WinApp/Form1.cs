using Irene.Models;
using Irene.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity.Validation;

#pragma warning disable IDE1006 // Naming Styles

namespace Irene.WinApp {
  public partial class Form1 : Form {

    private App app = new App();

    public Form1() {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
      var u = new User("Tester " + DateTime.Now.Millisecond) {
        PIN = app.Users.GenerateUniquePIN()
      };
      app.Users.Add(u);

      app.SaveChanges();

      reloadData();
      MessageBox.Show("OK!");
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
      ((IDisposable)app).Dispose();
    }

    private void button2_Click(object sender, EventArgs e) {
      reloadData();
    }

    private List<User> users;

    private void reloadData() {
      users = app.Users.All().ToList();
      bindingSource1.DataSource = users;
    }

    private User SelectedUser
    {
      get
      {
        return (User)lstUsers.SelectedItem;
      }
    }
    private void Activate_Click(object sender, EventArgs e) {
      SelectedUser?.Active();
      app.SaveChanges();
      //reloadData();
    }

    private void button1_Click_1(object sender, EventArgs e) {
      SelectedUser?.Suspend();
      app.SaveChanges();
      //reloadData();
    }

    private void button2_Click_1(object sender, EventArgs e) {
      SelectedUser?.Disable();
      app.SaveChanges();
      //reloadData();
    }

    private void Form1_Load(object sender, EventArgs e) {

    }

    private void bindingSource1_CurrentChanged(object sender, EventArgs e) {
      var u = bindingSource1.Current as User;

      bindingSource2.DataSource = u.Cars;
      //dataGridView2.DataSource = bindingSource2;

      this.Text = u.UserName + " " + u.Cars.Count();
    }

    private void lstUsers_SelectedIndexChanged(object sender, EventArgs e) {

    }

    private void button3_Click(object sender, EventArgs e) {
      int n = app.SaveChanges();
      //MessageBox.Show(n.ToString());
    }

    private void bindingSource2_ListChanged(object sender, ListChangedEventArgs e) {
    }

    private void bindingSource2_CurrentItemChanged(object sender, EventArgs e) {
      try
      {
        int n = app.SaveChanges();
        //MessageBox.Show(n.ToString()); 
      }
      catch (DbEntityValidationException ex)
      {
        foreach (var x in ex.EntityValidationErrors)
        {
          
        }
      }

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

    }
  }
}

#pragma warning restore IDE1006 // Naming Styles
