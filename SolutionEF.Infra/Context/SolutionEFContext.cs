using SolutionEF.Core.Models;
using SolutionEF.Infra.Mapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionEF.Infra.Context
{
    public class SolutionEFContext : DbContext
    {
        public SolutionEFContext() : base(@"Data Source=(LocalDB)\Library;Initial Catalog=Library;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False" /*o "airlines"*/)
        {
        }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BookMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
