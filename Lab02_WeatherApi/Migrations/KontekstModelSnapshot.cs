﻿// <auto-generated />
using Lab02_WeatherApi;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lab02_WeatherApi.Migrations
{
    [DbContext(typeof(Kontekst))]
    partial class KontekstModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("Lab02_WeatherApi.Struktura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("feels_like")
                        .HasColumnType("REAL");

                    b.Property<int>("humidity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("pressure")
                        .HasColumnType("INTEGER");

                    b.Property<double>("speed")
                        .HasColumnType("REAL");

                    b.Property<double>("temp")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Tabela", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}