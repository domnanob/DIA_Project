using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIA_Project.Models;

namespace DIA_Project
{
    public class SQL : DbContext
    {
        public static string ConnectionString { get; set; }


        public static SQL MySql()
        {
            var options = new DbContextOptionsBuilder().UseMySql(SQL.ConnectionString,ServerVersion.AutoDetect(ConnectionString)).Options;
            return new SQL(options);
        }

        private SQL(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Users> users { get; set; }
        public DbSet<UserAnswers> userAnswers { get; set; }
        public DbSet<Tests> tests { get; set; }
        public DbSet<TaskTypes> taskTypes { get; set; }
        public DbSet<Tasks> tasks { get; set; }
        public DbSet<Roles> roles { get; set; }
        public DbSet<Classes> classes { get; set; }
        public DbSet<Answers> answers { get; set; }
        public DbSet<Teachers> teachers { get; set; }
        public DbSet<Subjects> subjects { get; set; }
        public DbSet<Positions> positions { get; set; }
        public DbSet<Purchases> purchases { get; set; }

    }
}
