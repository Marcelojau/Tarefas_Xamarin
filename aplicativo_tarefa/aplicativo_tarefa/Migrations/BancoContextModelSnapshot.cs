﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using aplicativo_tarefa.Banco;

namespace aplicativo_tarefa.Migrations
{
    [DbContext(typeof(BancoContext))]
    partial class BancoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("aplicativo_tarefa.Modelos.Tarefa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Data")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Finalizada")
                        .HasColumnType("INTEGER");

                    b.Property<TimeSpan>("HorarioFinal")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("HorarioInicial")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nota")
                        .HasColumnType("TEXT");

                    b.Property<string>("Prioridade")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tarefas");
                });
#pragma warning restore 612, 618
        }
    }
}
