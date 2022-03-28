﻿using AssignmentMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AssignmentMVC.Data
{
    public class MyIdentityDbContext : DbContext
    {
        public MyIdentityDbContext() : base("AssignmentMVC")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}