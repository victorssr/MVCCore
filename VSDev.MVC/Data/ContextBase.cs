using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VSDev.MVC.Models;

namespace VSDev.MVC.Data
{
    public class ContextBase : IdentityDbContext
    {
        public ContextBase(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Artigo> Artigos { get; set; }
    }
}
