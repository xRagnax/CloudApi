using ChiroAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChiroAPI.Data
{
    public class LeidingContext : DbContext
    {
        public LeidingContext(DbContextOptions<LeidingContext> options) : base(options)
        {

        }
        public DbSet<Leiding> Leiders { get; set; }
    }
}
