using Microsoft.EntityFrameworkCore;

namespace VSDev.MVC.Data
{
    public class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions options)
            : base(options)
        {

        }
    }
}
