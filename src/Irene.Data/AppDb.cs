﻿using Irene.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irene.Data {
  public class AppDb : DbContext {

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder) {
      modelBuilder.Entity<User>()
        .Property(u => u.PIN)
        .HasColumnAnnotation(
          "Index",
          new IndexAnnotation(new IndexAttribute("IX_PIN") { IsUnique = true }));


      modelBuilder.Entity<User>()
        .Property(u => u.UserName)
        .HasColumnAnnotation(
          "Index",
          new IndexAnnotation(new IndexAttribute("IX_UserName") { IsUnique = true }));
    }
  }
}
