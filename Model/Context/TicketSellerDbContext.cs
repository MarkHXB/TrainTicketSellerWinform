using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TicketSeller.Model;

namespace TicketSeller.Model.Context
{
    public partial class TicketSellerDbContext : DbContext
    {
        public TicketSellerDbContext()
        {
        }

        public TicketSellerDbContext(DbContextOptions<TicketSellerDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Discount> Discounts { get; set; } = null!;
        public virtual DbSet<Distance> Distances { get; set; } = null!;
        public virtual DbSet<Finance> Finances { get; set; } = null!;
        public virtual DbSet<Ticket> Tickets { get; set; } = null!;
        public virtual DbSet<Worker> Workers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\bakon\\TicketSeller\\TicketSellerDB.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.Identifier).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.DiscountId)
                    .HasConstraintName("FK_Customer_Discount_Id");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.TicketId)
                    .HasConstraintName("FK_Customer_Ticket_Id");
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.ToTable("Discount");

                entity.Property(e => e.ExpirationDate).HasColumnType("date");

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.Discounts)
                    .HasForeignKey(d => d.TicketId)
                    .HasConstraintName("FK_Discount_Ticket_Id");
            });

            modelBuilder.Entity<Distance>(entity =>
            {
                entity.ToTable("Distance");

                entity.Property(e => e.Distance1).HasColumnName("Distance");

                entity.HasOne(d => d.Destination)
                    .WithMany(p => p.DistanceDestinations)
                    .HasForeignKey(d => d.DestinationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Distance_Destination_City_id");

                entity.HasOne(d => d.FromCity)
                    .WithMany(p => p.DistanceFromCities)
                    .HasForeignKey(d => d.FromCityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Distance_From_City_Id");
            });

            modelBuilder.Entity<Finance>(entity =>
            {
                entity.ToTable("Finance");

                entity.Property(e => e.DateTime).HasColumnType("date");

                entity.Property(e => e.PayWithCreditCard)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Finances)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Finance_Customer_Id");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.Finances)
                    .HasForeignKey(d => d.TicketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Finance_Ticket_Id");

                entity.HasOne(d => d.Worker)
                    .WithMany(p => p.Finances)
                    .HasForeignKey(d => d.WorkerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Finance_Worker_Id");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.ToTable("Ticket");

                entity.Property(e => e.IsTicket)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.ToTable("Worker");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Workers)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Worker_City_Id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
