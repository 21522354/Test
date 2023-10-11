using entity_framework_codefirst.Model.Database.Entity;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace entity_framework_codefirst
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=TestModel")
        {
            
        }

        public DbSet<Heo> Heos { get; set; }
        public DbSet<ChuongHeo> ChuongHeos { get; set; }
        public DbSet<quidinh> quidinhs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
