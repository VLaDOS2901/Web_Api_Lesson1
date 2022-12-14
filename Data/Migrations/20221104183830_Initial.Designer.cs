// <auto-generated />
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    [Migration("20221104183830_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Data.Models.Matrix", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Matrixes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "LED"
                        },
                        new
                        {
                            Id = 2,
                            Name = "IPS"
                        },
                        new
                        {
                            Id = 3,
                            Name = "TFT"
                        },
                        new
                        {
                            Id = 4,
                            Name = "OLED"
                        });
                });

            modelBuilder.Entity("Data.Models.Monitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Display")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ImgLink")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("MatrixId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Refresh")
                        .HasColumnType("int");

                    b.Property<double>("ScreenSize")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("MatrixId");

                    b.ToTable("Monitors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Display = "1920 x 1080",
                            ImgLink = "https://m.media-amazon.com/images/I/71rXSVqET9L._AC_SX450_.jpg",
                            MatrixId = 1,
                            Name = "Sceptre",
                            Price = 129.97,
                            Refresh = 60,
                            ScreenSize = 24.0
                        },
                        new
                        {
                            Id = 2,
                            Display = "1920 x 1080",
                            ImgLink = "https://m.media-amazon.com/images/I/81QpkIctqPL._AC_SY450_.jpg",
                            MatrixId = 2,
                            Name = "Acer",
                            Price = 129.99000000000001,
                            Refresh = 75,
                            ScreenSize = 21.5
                        },
                        new
                        {
                            Id = 3,
                            Display = "1920 x 1080",
                            ImgLink = "https://m.media-amazon.com/images/I/81WrBJdJcIL._AC_SX522_.jpg",
                            MatrixId = 3,
                            Name = "LG",
                            Price = 129.97,
                            Refresh = 60,
                            ScreenSize = 24.0
                        },
                        new
                        {
                            Id = 4,
                            Display = "1920 x 1080",
                            ImgLink = "https://m.media-amazon.com/images/I/81j9OvhbxbL._AC_SY450_.jpg",
                            MatrixId = 4,
                            Name = "Sceptre",
                            Price = 129.97,
                            Refresh = 60,
                            ScreenSize = 24.0
                        });
                });

            modelBuilder.Entity("Data.Models.Monitor", b =>
                {
                    b.HasOne("Data.Models.Matrix", "Matrix")
                        .WithMany("Monitors")
                        .HasForeignKey("MatrixId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Matrix");
                });

            modelBuilder.Entity("Data.Models.Matrix", b =>
                {
                    b.Navigation("Monitors");
                });
#pragma warning restore 612, 618
        }
    }
}
