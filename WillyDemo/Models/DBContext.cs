using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using WillyDemo.Models.Mapping;

namespace WillyDemo.Models
{
    public partial class DBContext : DbContext
    {
        static DBContext()
        {
            Database.SetInitializer<DBContext>(null);
        }

        public DBContext()
            : base("Name=DBContext")
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeMap());
        }
    }
}
