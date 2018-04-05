using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entities;

namespace Model.DbConnection
{
    public class DataBaseContext: DbContext
    {
        public DbSet<Deal> Deals { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> People { get; set; }
    }
}
