﻿// <auto-generated />
using System;
using Horatiu_Muresan_MediiProiect.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Horatiu_Muresan_MediiProiect.Migrations
{
    [DbContext(typeof(Horatiu_Muresan_MediiProiectContext))]
    [Migration("20220216180051_InitialMigrate")]
    partial class InitialMigrate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Horatiu_Muresan_MediiProiect.Models.Automat", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("automatIdent")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("ID");

                    b.ToTable("Automat");
                });

            modelBuilder.Entity("Horatiu_Muresan_MediiProiect.Models.Locatie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("locatieDenumire")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("ID");

                    b.ToTable("Locatie");
                });

            modelBuilder.Entity("Horatiu_Muresan_MediiProiect.Models.LocAut", b =>
                {
                    b.Property<int>("LocAutID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AutomatID");

                    b.Property<int>("LocatieID");

                    b.Property<int>("ProdusID");

                    b.HasKey("LocAutID");

                    b.HasIndex("AutomatID");

                    b.HasIndex("LocatieID");

                    b.ToTable("LocAut");
                });

            modelBuilder.Entity("Horatiu_Muresan_MediiProiect.Models.Produs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AutomatID");

                    b.Property<int>("LocatieID");

                    b.Property<DateTime>("produsData");

                    b.Property<string>("produsDescriere")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<DateTime>("produsExp");

                    b.Property<string>("produsNume")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("ID");

                    b.HasIndex("AutomatID");

                    b.HasIndex("LocatieID");

                    b.ToTable("Produs");
                });

            modelBuilder.Entity("Horatiu_Muresan_MediiProiect.Models.LocAut", b =>
                {
                    b.HasOne("Horatiu_Muresan_MediiProiect.Models.Automat", "Automat")
                        .WithMany("LocAut")
                        .HasForeignKey("AutomatID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Horatiu_Muresan_MediiProiect.Models.Locatie", "Locatie")
                        .WithMany("LocAut")
                        .HasForeignKey("LocatieID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Horatiu_Muresan_MediiProiect.Models.Produs", b =>
                {
                    b.HasOne("Horatiu_Muresan_MediiProiect.Models.Automat", "Automat")
                        .WithMany()
                        .HasForeignKey("AutomatID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Horatiu_Muresan_MediiProiect.Models.Locatie", "Locatie")
                        .WithMany()
                        .HasForeignKey("LocatieID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
