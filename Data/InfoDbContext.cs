using System.Collections.Generic;
using BlandAI.Models;
using Microsoft.EntityFrameworkCore;

namespace BlandAI.Data
{
    public class InfoDbContext:DbContext
    {
        public InfoDbContext(DbContextOptions<InfoDbContext> options) : base(options) { }
        public DbSet<Info> Infos { get; set; }


    }
}


