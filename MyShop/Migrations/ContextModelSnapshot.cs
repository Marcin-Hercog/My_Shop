﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyShop;

namespace MyShop.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyShop.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cntry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Country");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.ToTable("Adresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Katowice",
                            Cntry = "Poland",
                            PostalCode = "40-800",
                            Street = "Długa",
                            UserID = 1
                        },
                        new
                        {
                            Id = 2,
                            City = "Chorzów",
                            Cntry = "Poland",
                            PostalCode = "42-900",
                            Street = "Krótka",
                            UserID = 2
                        },
                        new
                        {
                            Id = 3,
                            City = "Siemianowice Śląskie",
                            Cntry = "Poland",
                            PostalCode = "43-900",
                            Street = "Szeroka",
                            UserID = 3
                        },
                        new
                        {
                            Id = 4,
                            City = "Katowice",
                            Cntry = "Poland",
                            PostalCode = "44-880",
                            Street = "Wąska",
                            UserID = 4
                        });
                });

            modelBuilder.Entity("MyShop.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("MyShop.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Prize")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MyShop.ProductUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("ProductUsers");
                });

            modelBuilder.Entity("MyShop.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "someemail1@gmail.com",
                            LastName = "Kowalski",
                            Name = "Marcin"
                        },
                        new
                        {
                            Id = 2,
                            Email = "someemail2@gmail.com",
                            LastName = "Nowak",
                            Name = "Anna"
                        },
                        new
                        {
                            Id = 3,
                            Email = "someemail3@gmail.com",
                            LastName = "Wybicki",
                            Name = "Tomasz"
                        },
                        new
                        {
                            Id = 4,
                            Email = "someemail4@gmail.com",
                            LastName = "Nadgórski",
                            Name = "Marek"
                        });
                });

            modelBuilder.Entity("MyShop.Address", b =>
                {
                    b.HasOne("MyShop.User", "User")
                        .WithOne("Address")
                        .HasForeignKey("MyShop.Address", "UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MyShop.Product", b =>
                {
                    b.HasOne("MyShop.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyShop.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MyShop.ProductUser", b =>
                {
                    b.HasOne("MyShop.Product", "Product")
                        .WithMany("ProductUsers")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyShop.User", "User")
                        .WithMany("ProductUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MyShop.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("MyShop.Product", b =>
                {
                    b.Navigation("ProductUsers");
                });

            modelBuilder.Entity("MyShop.User", b =>
                {
                    b.Navigation("Address");

                    b.Navigation("ProductUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
