using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adatbázisok
{
    class Connection : DbContext
    {
        public Connection() :
            base(new SQLiteConnection()
            {
                ConnectionString = new SQLiteConnectionStringBuilder() { DataSource = "Tanulok.db", ForeignKeys = true }.ConnectionString
            }, true)
        { }

        public DbSet<Tanulo> Tanulok { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
