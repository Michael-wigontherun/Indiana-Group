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
        public DbSet<Indiana.Models.TruckingCompanies> TruckingCompanies { get; set; }
        public DbSet<Indiana.Models.ChameleonCompanies> ChameleonCompanies { get; set; }
        public DbSet<Indiana.Models.LiquidatedCompanys> LiquidatedCompanys { get; set; }
    }
}
