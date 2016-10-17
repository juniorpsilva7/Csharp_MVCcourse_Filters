using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Filtros.Models
{
    public class K19Context : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
    }
}