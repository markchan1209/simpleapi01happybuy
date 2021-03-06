// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleWebApi2.Entity;

#nullable disable

namespace SimpleWebApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220507161358_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SimpleWebApi.Entity.Shop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("rebeat")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("shopImgUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("shopName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("shopSrc")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Shops");
                });
#pragma warning restore 612, 618
        }
    }
}
