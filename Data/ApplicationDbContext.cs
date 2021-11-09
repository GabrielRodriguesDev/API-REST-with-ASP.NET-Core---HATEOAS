using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API_REST_with_ASP.NET_Core_HATEOAS.Models;

namespace API_REST_with_ASP.NET_Core_HATEOAS.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base (options)
        {
        }

        public DbSet<Produto> Produtos {get;set;}
    }
}