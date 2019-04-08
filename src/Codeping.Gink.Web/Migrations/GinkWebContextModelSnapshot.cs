﻿// <auto-generated />
using Codeping.Gink.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Codeping.Gink.Web.Migrations
{
    [DbContext(typeof(GinkWebContext))]
    partial class GinkWebContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0-preview3.19153.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Codeping.Gink.Core.Link", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LongUrl");

                    b.Property<int>("Total");

                    b.HasKey("Id");

                    b.HasIndex("LongUrl");

                    b.ToTable("Links");
                });
#pragma warning restore 612, 618
        }
    }
}
