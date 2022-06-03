﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Remtask.Context;

#nullable disable

namespace Remtask.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220531212742_InicalMigration")]
    partial class InicalMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Remtask.Models.Tarefa", b =>
                {
                    b.Property<int>("TarefaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TarefaId"), 1L, 1);

                    b.Property<string>("DiaTarefa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Horario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TituloTarefa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TarefaId");

                    b.ToTable("Tarefas");
                });
#pragma warning restore 612, 618
        }
    }
}