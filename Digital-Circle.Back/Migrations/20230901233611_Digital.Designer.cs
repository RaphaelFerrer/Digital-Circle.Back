﻿// <auto-generated />
using System;
using Digital_Circle.Back.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Digital_Circle.Back.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230901233611_Digital")]
    partial class Digital
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("Digital_Circle.Back.Domain.Entidades.Entidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("Id");

                    b.Property<DateTime>("Data")
                        .HasColumnType("TIMESTAMP")
                        .HasColumnName("col_dt");

                    b.Property<string>("Texto")
                        .HasColumnType("TEXT")
                        .HasColumnName("col_texto");

                    b.HasKey("Id");

                    b.ToTable("TB01", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
