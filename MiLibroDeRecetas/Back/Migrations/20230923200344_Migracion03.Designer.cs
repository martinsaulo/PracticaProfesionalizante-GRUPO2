﻿// <auto-generated />
using System;
using Back;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Back.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230923200344_Migracion03")]
    partial class Migracion03
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Back.Etiqueta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RecetaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RecetaId");

                    b.ToTable("Etiquetas");
                });

            modelBuilder.Entity("Back.Ingrediente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Calorias")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RecetaId")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RecetaId");

                    b.ToTable("Ingredientes");
                });

            modelBuilder.Entity("Back.IngredienteReceta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("Ingrediente_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Ingrediente_Id");

                    b.ToTable("IngredientesReceta");
                });

            modelBuilder.Entity("Back.Paso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Descripcion")
                        .HasColumnType("int");

                    b.Property<int?>("RecetaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RecetaId");

                    b.ToTable("Pasos");
                });

            modelBuilder.Entity("Back.Receta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Calorias")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha_Creacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Fecha_Modificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Recetas");
                });

            modelBuilder.Entity("Back.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Contrasenia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Back.Etiqueta", b =>
                {
                    b.HasOne("Back.Receta", null)
                        .WithMany("Etiquetas")
                        .HasForeignKey("RecetaId");
                });

            modelBuilder.Entity("Back.Ingrediente", b =>
                {
                    b.HasOne("Back.Receta", null)
                        .WithMany("Ingredientes")
                        .HasForeignKey("RecetaId");
                });

            modelBuilder.Entity("Back.IngredienteReceta", b =>
                {
                    b.HasOne("Back.Ingrediente", "Ingrediente_")
                        .WithMany()
                        .HasForeignKey("Ingrediente_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingrediente_");
                });

            modelBuilder.Entity("Back.Paso", b =>
                {
                    b.HasOne("Back.Receta", null)
                        .WithMany("Pasos")
                        .HasForeignKey("RecetaId");
                });

            modelBuilder.Entity("Back.Receta", b =>
                {
                    b.HasOne("Back.Usuario", null)
                        .WithMany("Recetas")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("Back.Receta", b =>
                {
                    b.Navigation("Etiquetas");

                    b.Navigation("Ingredientes");

                    b.Navigation("Pasos");
                });

            modelBuilder.Entity("Back.Usuario", b =>
                {
                    b.Navigation("Recetas");
                });
#pragma warning restore 612, 618
        }
    }
}
