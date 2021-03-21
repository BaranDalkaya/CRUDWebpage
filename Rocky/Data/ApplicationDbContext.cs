using Microsoft.EntityFrameworkCore;
using Rocky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Rocky.Data
{
    // To use DB context, we derive from that class.
    public class ApplicationDbContext : DbContext
    {
        // To pass configuration info to the DbContext, use DbContextOptions instance
        // and pass into the DBContext ctor derived with : base()
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
        }

        // Create a DbSet<TEntity> prop for each entity in the model.
        // We use this DbSet prop of each Model to query and save instances of the Model class. 
        // The LINQ queries against the DbSet<TEntity> will be translated into queires against the underlying database
        public DbSet<Category> Category { get; set; }
        public DbSet<ApplicationType> ApplicationType { get; set; }

    }
}
