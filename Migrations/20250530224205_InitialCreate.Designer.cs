﻿// <auto-generated />
using ColdConnectApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace ColdConnectApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250530224205_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ColdConnectApp.Models.Abrigo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("Abrigos");
                });

            modelBuilder.Entity("ColdConnectApp.Models.Doacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AbrigoId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.HasIndex("AbrigoId");

                    b.ToTable("Doacoes");
                });

            modelBuilder.Entity("ColdConnectApp.Models.Doacao", b =>
                {
                    b.HasOne("ColdConnectApp.Models.Abrigo", "Abrigo")
                        .WithMany("Doacoes")
                        .HasForeignKey("AbrigoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Abrigo");
                });

            modelBuilder.Entity("ColdConnectApp.Models.Abrigo", b =>
                {
                    b.Navigation("Doacoes");
                });
#pragma warning restore 612, 618
        }
    }
}
