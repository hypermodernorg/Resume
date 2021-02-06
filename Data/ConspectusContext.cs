using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Resume.Models;

namespace Resume.Data
{
    public class ConspectusContext : DbContext
    {
        public ConspectusContext (DbContextOptions<ConspectusContext> options)
            : base(options)
        {
        }

        public DbSet<Resume.Models.Conspectus> Conspectus { get; set; }
    }
}
