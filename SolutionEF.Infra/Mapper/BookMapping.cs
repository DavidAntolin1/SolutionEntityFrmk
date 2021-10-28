using SolutionEF.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionEF.Infra.Mapper
{
    public class BookMapping : EntityTypeConfiguration<Book>
    {
        public BookMapping()
        {
            HasKey(i => i.Id);
            ToTable("Books");
        }
    }
}
