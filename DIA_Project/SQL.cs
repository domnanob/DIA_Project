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
        public DbSet<User> users { get; set; }
        public DbSet<UserAnswer> userAnswers { get; set; }
        public DbSet<Test> tests { get; set; }
        public DbSet<TaskType> taskTypes { get; set; }
        public DbSet<Models.Tasks> tasks { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<Classes> classes { get; set; }
        public DbSet<Answers> answers { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Subject> subjects { get; set; }
        public DbSet<Position> positions { get; set; }
        public DbSet<Purchase> purchases { get; set; }
        public DbSet<UserTest> userTests { get; set; }
        public DbSet<RegistrationToken> registrationTokens { get; set; }

    }
}
