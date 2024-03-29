using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lvl3Week3Day2_BlogBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace Lvl3Week3Day2_BlogBackend.Services.Context
{
                            // inheriting attributes and methods from another class = DbContext
    public class DataContext : DbContext
    {
        public DbSet<UserModel> UserInfo { get; set; }
        public DbSet<BlogItemModel> BlogInfo { get; set; }

        public DataContext(DbContextOptions options): base(options){}

        //this function will build out our table in the database
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}