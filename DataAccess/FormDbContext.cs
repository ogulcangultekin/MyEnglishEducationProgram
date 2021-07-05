using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class FormDbContext:DbContext
    {
        public FormDbContext() : base("ConnectionString")
        {

        }
        public DbSet<English> englishes{ get; set; }
    }
}
