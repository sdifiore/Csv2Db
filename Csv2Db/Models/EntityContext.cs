using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csv2Db.Models
{
    class EntityContext : DbContext
    {
        public EntityContext() : base("name=SqlServer")
        {
        }

        public DbSet<Vendedor> Vendedores { get; set; }
    }
}
