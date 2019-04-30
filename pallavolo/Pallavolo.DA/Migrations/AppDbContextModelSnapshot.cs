﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pallavolo.DA;

namespace Pallavolo.DA.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("Pallavolo.DA.Models.Giocatore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Added");

                    b.Property<string>("Cognome");

                    b.Property<DateTime>("Deleted");

                    b.Property<DateTime>("Modified");

                    b.Property<DateTime>("Nascita");

                    b.Property<string>("Nome");

                    b.Property<int>("numero");

                    b.HasKey("Id");

                    b.ToTable("Giocatori");
                });

            modelBuilder.Entity("Pallavolo.DA.Models.Squadra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Added");

                    b.Property<DateTime>("Deleted");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Squadre");
                });
#pragma warning restore 612, 618
        }
    }
}
