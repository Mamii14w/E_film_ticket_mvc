﻿// <auto-generated />
using System;
using E_film_ticket.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace E_film_ticket.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230714142748_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("E_film_ticket.Models.Actor", b =>
                {
                    b.Property<int>("Aid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Aid"));

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pictureYRL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Aid");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("E_film_ticket.Models.ActorMovie", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("ActorId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("actorMovies");
                });

            modelBuilder.Entity("E_film_ticket.Models.Cinema", b =>
                {
                    b.Property<int>("Cid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cid"));

                    b.Property<string>("CName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cid");

                    b.ToTable("cinemas");
                });

            modelBuilder.Entity("E_film_ticket.Models.MovieModel", b =>
                {
                    b.Property<int>("Mid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Mid"));

                    b.Property<int>("CinemaId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieCatagory")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProducerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.HasKey("Mid");

                    b.HasIndex("CinemaId");

                    b.HasIndex("ProducerId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("E_film_ticket.Models.Producer", b =>
                {
                    b.Property<int>("PID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PID"));

                    b.Property<string>("Biography")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PID");

                    b.ToTable("producers");
                });

            modelBuilder.Entity("E_film_ticket.Models.ActorMovie", b =>
                {
                    b.HasOne("E_film_ticket.Models.Actor", "Actor")
                        .WithMany("Actors_Movies")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_film_ticket.Models.MovieModel", "MovieModel")
                        .WithMany("Actor_Movie")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("MovieModel");
                });

            modelBuilder.Entity("E_film_ticket.Models.MovieModel", b =>
                {
                    b.HasOne("E_film_ticket.Models.Cinema", "Cinema")
                        .WithMany("movies")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_film_ticket.Models.Producer", "Producer")
                        .WithMany("movies")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("E_film_ticket.Models.Actor", b =>
                {
                    b.Navigation("Actors_Movies");
                });

            modelBuilder.Entity("E_film_ticket.Models.Cinema", b =>
                {
                    b.Navigation("movies");
                });

            modelBuilder.Entity("E_film_ticket.Models.MovieModel", b =>
                {
                    b.Navigation("Actor_Movie");
                });

            modelBuilder.Entity("E_film_ticket.Models.Producer", b =>
                {
                    b.Navigation("movies");
                });
#pragma warning restore 612, 618
        }
    }
}
