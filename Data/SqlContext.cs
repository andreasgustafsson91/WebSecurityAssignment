using Microsoft.EntityFrameworkCore;
using WebSecurityAssignment.Models;

namespace WebSecurityAssignment.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        protected SqlContext()
        {
        }

        public virtual DbSet<Comment> Comments { get; set; }
    }
}
