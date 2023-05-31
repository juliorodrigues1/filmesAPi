﻿// <auto-generated />
using System;
using FilmeApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FilmeApi.Migrations
{
    [DbContext(typeof(FilmeApiContext))]
    [Migration("20230531220605_sessao e  cinema")]
    partial class sessaoecinema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FilmeApi.Models.CinemaModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("enderecoId")
                        .HasColumnType("integer");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("enderecoId")
                        .IsUnique();

                    b.ToTable("Cinemas");
                });

            modelBuilder.Entity("FilmeApi.Models.EnderecoModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("logradouro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("numero")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("FilmeApi.Models.FilmeModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("duracao")
                        .HasColumnType("integer");

                    b.Property<string>("genero")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("titulo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Filmes");
                });

            modelBuilder.Entity("FilmeApi.Models.SessaoModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int?>("CinemaId")
                        .HasColumnType("integer");

                    b.Property<int>("filmeId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("CinemaId");

                    b.HasIndex("filmeId");

                    b.ToTable("Sessoes");
                });

            modelBuilder.Entity("FilmeApi.Models.CinemaModel", b =>
                {
                    b.HasOne("FilmeApi.Models.EnderecoModel", "Endereco")
                        .WithOne("Cinema")
                        .HasForeignKey("FilmeApi.Models.CinemaModel", "enderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("FilmeApi.Models.SessaoModel", b =>
                {
                    b.HasOne("FilmeApi.Models.CinemaModel", "Cinema")
                        .WithMany("Sessoes")
                        .HasForeignKey("CinemaId");

                    b.HasOne("FilmeApi.Models.FilmeModel", "Filme")
                        .WithMany("Sessoes")
                        .HasForeignKey("filmeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");

                    b.Navigation("Filme");
                });

            modelBuilder.Entity("FilmeApi.Models.CinemaModel", b =>
                {
                    b.Navigation("Sessoes");
                });

            modelBuilder.Entity("FilmeApi.Models.EnderecoModel", b =>
                {
                    b.Navigation("Cinema")
                        .IsRequired();
                });

            modelBuilder.Entity("FilmeApi.Models.FilmeModel", b =>
                {
                    b.Navigation("Sessoes");
                });
#pragma warning restore 612, 618
        }
    }
}