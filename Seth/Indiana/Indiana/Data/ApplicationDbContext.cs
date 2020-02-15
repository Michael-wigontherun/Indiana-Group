using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Indiana.Models;

namespace Indiana.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ChameleonCompanies> ChameleonCompanies { get; set; }
        public DbSet<TruckingCompanies> TruckingCompanies { get; set; }
        public DbSet<LiquidatedCompanys> LiquidatedCompanys { get; set; }
    }
}
