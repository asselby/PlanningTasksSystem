using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entities;

namespace Model.DbConnection
{
    public class DataBaseContext : DbContext
    {
        static DataBaseContext()
        {
            Database.SetInitializer<DataBaseContext>(new MyDbInitializer());
           
            
        }
        public DataBaseContext() : base("DBConnection")
        {

        }
        public DbSet<Deal> Deals { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> People { get; set; }

    }

    public class MyDbInitializer : DropCreateDatabaseAlways<DataBaseContext>
    {
        protected override void Seed(DataBaseContext context)
        {
            User user = new User() {Id = 1, LastName = "Assel", FirstName = "Baim", Login = "Assel", Password = "123"};

            context.People.Add(user);
            context.SaveChanges();
        }
    }
}
