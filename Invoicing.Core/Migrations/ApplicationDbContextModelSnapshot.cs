﻿// <auto-generated />
using System;
using Invoicing.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Invoicing.Core.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("Invoicing.Core.Models.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(250);

                    b.Property<string>("CompanyName")
                        .HasMaxLength(250);

                    b.Property<DateTime>("Created");

                    b.Property<string>("Email")
                        .HasMaxLength(150);

                    b.Property<DateTime>("Modified");

                    b.Property<string>("Name")
                        .HasMaxLength(250);

                    b.Property<string>("Password")
                        .HasMaxLength(250);

                    b.Property<string>("Phone")
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.ToTable("ApplicationUsers");
                });

            modelBuilder.Entity("Invoicing.Core.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ApplicationUserId");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Email")
                        .HasMaxLength(150);

                    b.Property<string>("FirstName")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .HasMaxLength(50);

                    b.Property<DateTime>("Modified");

                    b.Property<string>("Notes")
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Invoicing.Core.Models.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<int>("ClientId");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime?>("DueDate");

                    b.Property<DateTime?>("InvoiceDate");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("Status")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("Invoicing.Core.Models.Client", b =>
                {
                    b.HasOne("Invoicing.Core.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Invoicing.Core.Models.Invoice", b =>
                {
                    b.HasOne("Invoicing.Core.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
