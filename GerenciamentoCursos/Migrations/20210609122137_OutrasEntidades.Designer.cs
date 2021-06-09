﻿// <auto-generated />
using System;
using GerenciamentoCursos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GerenciamentoCursos.Migrations
{
    [DbContext(typeof(GerenciamentoCursosContext))]
    [Migration("20210609122137_OutrasEntidades")]
    partial class OutrasEntidades
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GerenciamentoCursos.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("LocalidadeId");

                    b.Property<string>("Nome");

                    b.Property<int>("Tipo");

                    b.HasKey("Id");

                    b.HasIndex("LocalidadeId");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("GerenciamentoCursos.Models.Localidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cidade");

                    b.Property<string>("Estado");

                    b.HasKey("Id");

                    b.ToTable("Localidade");
                });

            modelBuilder.Entity("GerenciamentoCursos.Models.Oferta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CursoId");

                    b.Property<int?>("LocalidadeId");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.HasIndex("LocalidadeId");

                    b.ToTable("Oferta");
                });

            modelBuilder.Entity("GerenciamentoCursos.Models.Curso", b =>
                {
                    b.HasOne("GerenciamentoCursos.Models.Localidade")
                        .WithMany("Cursos")
                        .HasForeignKey("LocalidadeId");
                });

            modelBuilder.Entity("GerenciamentoCursos.Models.Oferta", b =>
                {
                    b.HasOne("GerenciamentoCursos.Models.Curso")
                        .WithMany("Disponibilidade")
                        .HasForeignKey("CursoId");

                    b.HasOne("GerenciamentoCursos.Models.Localidade", "Localidade")
                        .WithMany()
                        .HasForeignKey("LocalidadeId");
                });
#pragma warning restore 612, 618
        }
    }
}
