﻿// <auto-generated />
using System;
using KitobNur.Data.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace KitobNur.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("KitobNur.Domain.Entities.Books.BestsellerBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("BestsellerBooks");
                });

            modelBuilder.Entity("KitobNur.Domain.Entities.Books.Book", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Author")
                        .HasColumnType("text");

                    b.Property<decimal>("Balance")
                        .HasColumnType("numeric");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<short>("Count")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ImagePath")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<long?>("RentalId")
                        .HasColumnType("bigint");

                    b.Property<byte>("Status")
                        .HasColumnType("smallint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("VistorLogId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("RentalId");

                    b.HasIndex("VistorLogId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Author = "Harper Lee",
                            Balance = 100m,
                            CategoryId = 1,
                            Count = (short)10,
                            CreatedAt = new DateTime(2024, 4, 8, 4, 41, 31, 639, DateTimeKind.Utc).AddTicks(3420),
                            Description = "A novel by Harper Lee",
                            ImagePath = "C:\\Users\\User\\source\\repos\\KitobNur\\KitobNur\\src\\KitobNur.Data\\photo_5217546724271315430_x.jpg",
                            Name = "To Kill a Mockingbird",
                            Status = (byte)0
                        },
                        new
                        {
                            Id = 2L,
                            Author = "George Orwell",
                            Balance = 90m,
                            CategoryId = 1,
                            Count = (short)8,
                            CreatedAt = new DateTime(2024, 4, 8, 4, 41, 31, 639, DateTimeKind.Utc).AddTicks(3424),
                            Description = "A novel by George Orwell",
                            ImagePath = "C:\\Users\\User\\source\\repos\\KitobNur\\KitobNur\\src\\KitobNur.Data\\photo_5217546724271315430_x.jpg",
                            Name = "1984",
                            Status = (byte)0
                        },
                        new
                        {
                            Id = 3L,
                            Author = "Yuval Noah Harari",
                            Balance = 120m,
                            CategoryId = 2,
                            Count = (short)15,
                            CreatedAt = new DateTime(2024, 4, 8, 4, 41, 31, 639, DateTimeKind.Utc).AddTicks(3426),
                            Description = "A book by Yuval Noah Harari",
                            ImagePath = "C:\\Users\\User\\source\\repos\\KitobNur\\KitobNur\\src\\KitobNur.Data\\photo_5217546724271315430_x.jpg",
                            Name = "Sapiens: A Brief History of Humankind",
                            Status = (byte)0
                        });
                });

            modelBuilder.Entity("KitobNur.Domain.Entities.Books.InitBook", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("BookId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("InitBooks");
                });

            modelBuilder.Entity("KitobNur.Domain.Entities.Books.OrderBook", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("OrderBooks");
                });

            modelBuilder.Entity("KitobNur.Domain.Entities.Categories.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 4, 8, 4, 41, 31, 639, DateTimeKind.Utc).AddTicks(3250),
                            Name = "Fiction"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 4, 8, 4, 41, 31, 639, DateTimeKind.Utc).AddTicks(3258),
                            Name = "Non-fiction"
                        });
                });

            modelBuilder.Entity("KitobNur.Domain.Entities.Users.VistorLog", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("VistorLogs");
                });

            modelBuilder.Entity("KitobNur.Domain.Library.Rental", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("KitobNur.Domain.Users.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<byte>("GenderType")
                        .HasColumnType("smallint");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("MiddleName")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("PassportNumber")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<string>("StudyPlaces")
                        .HasColumnType("text");

                    b.Property<string>("TelegramId")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("WorkPlace")
                        .HasColumnType("text");

                    b.Property<int>("userStatus")
                        .HasColumnType("integer");

                    b.Property<byte>("userType")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("KitobNur.Domain.Entities.Books.Book", b =>
                {
                    b.HasOne("KitobNur.Domain.Entities.Categories.Category", "category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KitobNur.Domain.Library.Rental", null)
                        .WithMany("Books")
                        .HasForeignKey("RentalId");

                    b.HasOne("KitobNur.Domain.Entities.Users.VistorLog", null)
                        .WithMany("Books")
                        .HasForeignKey("VistorLogId");

                    b.Navigation("category");
                });

            modelBuilder.Entity("KitobNur.Domain.Entities.Books.InitBook", b =>
                {
                    b.HasOne("KitobNur.Domain.Entities.Books.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("KitobNur.Domain.Entities.Users.VistorLog", b =>
                {
                    b.HasOne("KitobNur.Domain.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("KitobNur.Domain.Library.Rental", b =>
                {
                    b.HasOne("KitobNur.Domain.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("KitobNur.Domain.Entities.Users.VistorLog", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("KitobNur.Domain.Library.Rental", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
