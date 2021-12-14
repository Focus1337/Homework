﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppHW10.Repository;

namespace WebAppHW10.Migrations
{
    [DbContext(typeof(ComputedExpressionsContext))]
    partial class ComputedExpressionsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAppHW10.Repository.ComputedExpression", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("Op")
                        .HasColumnType("tinyint");

                    b.Property<decimal?>("Res")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("V1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("V2")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("ComputedExpressions");
                });
#pragma warning restore 612, 618
        }
    }
}
