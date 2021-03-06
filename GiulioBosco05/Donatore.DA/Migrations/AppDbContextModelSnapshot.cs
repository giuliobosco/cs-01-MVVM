﻿// <auto-generated />
using System;
using Donatore.DA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Donatore.DA.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("Donatore.DA.Models.Donatore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Added");

                    b.Property<DateTime>("Deleted");

                    b.Property<string>("IPAddress");

                    b.Property<string>("Indirizzo");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("Nome");

                    b.Property<int?>("SangueId");

                    b.Property<string>("Telefono");

                    b.Property<DateTime>("UltimaDonazione");

                    b.HasKey("Id");

                    b.HasIndex("SangueId");

                    b.ToTable("Donatori");
                });

            modelBuilder.Entity("Donatore.DA.Models.Sangue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Added");

                    b.Property<DateTime>("Deleted");

                    b.Property<string>("IPAddress");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("Tipo");

                    b.Property<bool>("fattorePositivo");

                    b.HasKey("Id");

                    b.ToTable("Sangue");
                });

            modelBuilder.Entity("Donatore.DA.Models.Donatore", b =>
                {
                    b.HasOne("Donatore.DA.Models.Sangue", "Sangue")
                        .WithMany()
                        .HasForeignKey("SangueId");
                });
#pragma warning restore 612, 618
        }
    }
}
