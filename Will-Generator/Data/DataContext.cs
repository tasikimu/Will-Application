using Microsoft.EntityFrameworkCore;
using Will_Generator.Models;

namespace Will_Generator.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<PersonalDetail> PersonalDetails { get; set; }
        public DbSet<EstateExecutor> EstateExecutors { get; set; }
    }
}
