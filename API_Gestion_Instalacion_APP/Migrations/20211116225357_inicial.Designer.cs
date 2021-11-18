﻿// <auto-generated />
using System;
using API_Gestion_Instalacion_APP;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API_Gestion_Instalacion_APP.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20211116225357_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("API_Gestion_Instalacion_APP.Modelos.Apps", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Apps");
                });

            modelBuilder.Entity("API_Gestion_Instalacion_APP.Modelos.Instalaciones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Exitosa")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("Instalaciones");
                });

            modelBuilder.Entity("API_Gestion_Instalacion_APP.Modelos.Operarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Operarios");
                });

            modelBuilder.Entity("API_Gestion_Instalacion_APP.Modelos.Sensores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Sensores");
                });

            modelBuilder.Entity("API_Gestion_Instalacion_APP.Modelos.Telefonos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .HasColumnType("text");

                    b.Property<string>("Modelo")
                        .HasColumnType("text");

                    b.Property<float>("precio")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Telefonos");
                });
#pragma warning restore 612, 618
        }
    }
}
