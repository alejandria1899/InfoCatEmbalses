﻿// <auto-generated />
using System;
using InfoCatEmbalses.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InfoCatEmbalses.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240703165853_Embalses")]
    partial class Embalses
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InfoCatEmbalses.Embalses.Embalse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Dia")
                        .HasColumnType("datetime2")
                        .HasAnnotation("Relational:JsonPropertyName", "dia");

                    b.Property<string>("Estacio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "estaci");

                    b.Property<string>("NivellAbsolut")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "nivell_absolut");

                    b.Property<string>("PercentatgeVolumEmbassat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "percentatge_volum_embassat");

                    b.Property<string>("VolumEmbassat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "volum_embassat");

                    b.HasKey("Id");

                    b.ToTable("Embalses");
                });
#pragma warning restore 612, 618
        }
    }
}
