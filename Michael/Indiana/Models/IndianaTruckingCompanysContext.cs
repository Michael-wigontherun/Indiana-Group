using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Indiana.Models
{
    public partial class IndianaTruckingCompanysContext : DbContext
    {
        public IndianaTruckingCompanysContext()
        {
        }

        public IndianaTruckingCompanysContext(DbContextOptions<IndianaTruckingCompanysContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<ChameleonCompanies> ChameleonCompanies { get; set; }
        public virtual DbSet<LiquidatedCompanys> LiquidatedCompanys { get; set; }
        public virtual DbSet<TruckingCompanies> TruckingCompanies { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<ChameleonCompanies>(entity =>
            {
                entity.HasKey(e => e.Usdot)
                    .HasName("PK__Chameleo__0CFF89A8727181C2");

                entity.Property(e => e.Usdot)
                    .HasColumnName("USDOT")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddminId)
                    .IsRequired()
                    .HasColumnName("addminID")
                    .HasMaxLength(450);

                entity.Property(e => e.PercentOcham)
                    .IsRequired()
                    .HasColumnName("percentOCham")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LiquidatedCompanys>(entity =>
            {
                entity.HasKey(e => e.Usdot)
                    .HasName("PK__Liquidat__0CFF89A8F2ACAC58");

                entity.Property(e => e.Usdot)
                    .HasColumnName("USDOT")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddminId)
                    .IsRequired()
                    .HasColumnName("addminID")
                    .HasMaxLength(450);

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Dbaname)
                    .IsRequired()
                    .HasColumnName("DBAName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GeoLocation)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LegalName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Oosdate)
                    .IsRequired()
                    .HasColumnName("OOSDate")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Oosreason)
                    .IsRequired()
                    .HasColumnName("OOSReason")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(19)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TruckingCompanies>(entity =>
            {
                entity.HasKey(e => e.Usdot)
                    .HasName("PK__Trucking__0CFF89A8987ADD1A");

                entity.Property(e => e.Usdot)
                    .HasColumnName("USDOT")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ADD_DATE_)
                    .HasColumnName("ADD_DATE_")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.addminID)
                    .IsRequired()
                    .HasColumnName("addminID")
                    .HasMaxLength(450);

                entity.Property(e => e.CARRIER_OPERATION_)
                    .HasColumnName("CARRIER_OPERATION_")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Dbaname)
                    .HasColumnName("DBAName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DRIVER_TOTAL_).HasColumnName("DRIVER_TOTAL_");

                entity.Property(e => e.EMAIL_ADDRESS_)
                    .HasColumnName("EMAIL_ADDRESS_")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FAX_)
                    .HasColumnName("FAX_")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.GeoLocation)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.HM_FLAG_)
                    .HasColumnName("HM_FLAG_")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LegalName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MAILING_CITY_)
                    .IsRequired()
                    .HasColumnName("MAILING_CITY_")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MAILING_COUNTRY_)
                    .IsRequired()
                    .HasColumnName("MAILING_COUNTRY_")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MAILING_STATE_)
                    .IsRequired()
                    .HasColumnName("MAILING_STATE_")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MAILING_STREET_)
                    .IsRequired()
                    .HasColumnName("MAILING_STREET_")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MAILING_ZIP_)
                    .IsRequired()
                    .HasColumnName("MAILING_ZIP_")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MCS150_DATE_)
                    .HasColumnName("MCS150_DATE_")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MCS150_MILEAGE_).HasColumnName("MCS150_MILEAGE_");

                entity.Property(e => e.MCS150_MILEAGE_YEAR_)
                    .HasColumnName("MCS150_MILEAGE_YEAR_")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NBR_POWER_UNIT_).HasColumnName("NBR_POWER_UNIT_");

                entity.Property(e => e.OIC_STATE_)
                    .IsRequired()
                    .HasColumnName("OIC_STATE_")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PC_FLAG_)
                    .HasColumnName("PC_FLAG_")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PHY_CITY_)
                    .IsRequired()
                    .HasColumnName("PHY_CITY_")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PHY_COUNTRY_)
                    .IsRequired()
                    .HasColumnName("PHY_COUNTRY_")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PHY_STATE_)
                    .IsRequired()
                    .HasColumnName("PHY_STATE_")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PHY_STREET_)
                    .IsRequired()
                    .HasColumnName("PHY_STREET_")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PHY_ZIP_)
                    .IsRequired()
                    .HasColumnName("PHY_ZIP_")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TELEPHONE_)
                    .HasColumnName("TELEPHONE_")
                    .HasMaxLength(14)
                    .IsUnicode(false);
            });
        }
    }
}
