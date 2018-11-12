﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using pmcrr.DataContext;

namespace pmcrr.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181014075644_readd_clothes")]
    partial class readd_clothes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("pmcrr.Models.Clothes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("category");

                    b.Property<int?>("userid");

                    b.HasKey("id");

                    b.HasIndex("userid");

                    b.ToTable("Clothes");
                });

            modelBuilder.Entity("pmcrr.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("email");

                    b.Property<string>("name")
                        .IsRequired();

                    b.HasKey("id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("pmcrr.Models.Clothes", b =>
                {
                    b.HasOne("pmcrr.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userid");
                });
#pragma warning restore 612, 618
        }
    }
}