﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tech.WebAPI.Persistence;

namespace Tech.WebAPI.Migrations
{
    [DbContext(typeof(TechContext))]
    partial class TechContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Tech.WebAPI.Domain.Alimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("Caloria");

                    b.Property<decimal?>("Carboidrato");

                    b.Property<decimal?>("FibraAlimentar");

                    b.Property<decimal?>("GorduraSaturada");

                    b.Property<decimal?>("GorduraTotail");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal?>("Peso");

                    b.Property<decimal?>("Proteina");

                    b.Property<decimal?>("Sodio");

                    b.Property<string>("Tag")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Alimentos");
                });

            modelBuilder.Entity("Tech.WebAPI.Domain.Medida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AlimentoId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<decimal>("Peso");

                    b.HasKey("Id");

                    b.HasIndex("AlimentoId");

                    b.ToTable("Medidas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Seed Data",
                            Peso = 18.3m
                        });
                });

            modelBuilder.Entity("Tech.WebAPI.Domain.Medida", b =>
                {
                    b.HasOne("Tech.WebAPI.Domain.Alimento", "Alimento")
                        .WithMany("Medidas")
                        .HasForeignKey("AlimentoId");
                });
#pragma warning restore 612, 618
        }
    }
}
