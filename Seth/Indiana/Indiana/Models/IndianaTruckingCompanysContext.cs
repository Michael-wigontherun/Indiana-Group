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

        public virtual DbSet<ChameleonCompanies> ChameleonCompanies { get; set; }
        public virtual DbSet<LiquidatedCompanys> LiquidatedCompanys { get; set; }
        public virtual DbSet<TruckingCompanies> TruckingCompanies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<ChameleonCompanies>(entity =>
            {
                entity.HasKey(e => e.Usdot)
                    .HasName("PK__Chameleo__0CFF89A8CE43CA87");

                entity.Property(e => e.Usdot)
                    .HasColumnName("USDOT")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.addminID)
                    .IsRequired()
                    .HasColumnName("addminID")
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<LiquidatedCompanys>(entity =>
            {
                entity.HasKey(e => e.Usdot)
                    .HasName("PK__Liquidat__0CFF89A83877F4AA");

                entity.Property(e => e.Usdot)
                    .HasColumnName("USDOT")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.addminID)
                    .IsRequired()
                    .HasColumnName("addminID")
                    .HasMaxLength(450);

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Dbaname)
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
                    .HasMaxLength(41)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(7)
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
                    .IsRequired()
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
                    .HasColumnName("FAX__")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.GeoLocation)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.HM_FLAG_)
                    .IsRequired()
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
                    .HasColumnName("MCS150_MILEAGE_YEAR__")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NBR_POWER_UNIT_).HasColumnName("NBR_POWER_UNIT_");

                entity.Property(e => e.OIC_STATE_)
                    .IsRequired()
                    .HasColumnName("OIC_STATE_")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PC_FLAG_)
                    .IsRequired()
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
                    .HasColumnName("TELEPHONE__")
                    .HasMaxLength(14)
                    .IsUnicode(false);
            });
        }
    }
}
