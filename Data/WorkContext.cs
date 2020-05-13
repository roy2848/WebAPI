using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class WorkContext : DbContext
    {
        public WorkContext(DbContextOptions<WorkContext> options)
            : base(options)
        {
        }
        public DbSet<Work> Work { get; set; }
        public DbSet<File> File { get; set; }
    }
}