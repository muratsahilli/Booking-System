﻿// <auto-generated />
using System;
using DAL.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220818123135_migration_deneme")]
    partial class migration_deneme
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Entity.Concrete.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Entity.Concrete.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Entity.Concrete.Arama", b =>
                {
                    b.Property<int>("Arama_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Arama_id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("AramaTipiId")
                        .HasColumnType("integer");

                    b.Property<int>("ArananId")
                        .HasColumnType("integer");

                    b.Property<int>("ArayanTipiId")
                        .HasColumnType("integer");

                    b.Property<int>("KaydedenId")
                        .HasColumnType("integer");

                    b.Property<string>("Konu")
                        .HasColumnType("text");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Arama_id");

                    b.HasIndex("AramaTipiId");

                    b.HasIndex("ArananId");

                    b.HasIndex("ArayanTipiId");

                    b.HasIndex("KaydedenId");

                    b.ToTable("Arama");
                });

            modelBuilder.Entity("Entity.Concrete.AramaTipi", b =>
                {
                    b.Property<int>("Arama_tipi_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Arama_tipi_id"));

                    b.Property<string>("Arama_tipi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Arama_tipi_id");

                    b.ToTable("AramaTipi");
                });

            modelBuilder.Entity("Entity.Concrete.ArayanTipi", b =>
                {
                    b.Property<int>("Arayan_tipi_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Arayan_tipi_id"));

                    b.Property<string>("Arayan_tipi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Arayan_tipi_id");

                    b.ToTable("ArayanTipi");
                });

            modelBuilder.Entity("Entity.Concrete.KullanıcıRandevu", b =>
                {
                    b.Property<int>("randevuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("randevuID"));

                    b.Property<int>("UserIDId")
                        .HasColumnType("integer");

                    b.HasKey("randevuID");

                    b.HasIndex("UserIDId");

                    b.ToTable("KullanıcıRandevu");
                });

            modelBuilder.Entity("Entity.Concrete.RandevuDurumu", b =>
                {
                    b.Property<int>("RandevuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RandevuID"));

                    b.Property<string>("Randevu_Durumu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("RandevuID");

                    b.ToTable("RandevuDurumu");
                });

            modelBuilder.Entity("Entity.Concrete.Randevular", b =>
                {
                    b.Property<int>("Randevu_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Randevu_id"));

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<DateTimeOffset>("EndTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Konu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("KullanıcırandevuID")
                        .HasColumnType("integer");

                    b.Property<int>("Randevu_DurumRandevuID")
                        .HasColumnType("integer");

                    b.Property<int>("Randevu_KayıtId")
                        .HasColumnType("integer");

                    b.Property<string>("Randevuya_Gelen")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("StartTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Ziyaret_EdilId")
                        .HasColumnType("integer");

                    b.HasKey("Randevu_id");

                    b.HasIndex("KullanıcırandevuID");

                    b.HasIndex("Randevu_DurumRandevuID");

                    b.HasIndex("Randevu_KayıtId");

                    b.HasIndex("Ziyaret_EdilId");

                    b.ToTable("Randevu");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Entity.Concrete.Arama", b =>
                {
                    b.HasOne("Entity.Concrete.AramaTipi", "AramaTipi")
                        .WithMany("Aramalar")
                        .HasForeignKey("AramaTipiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Concrete.AppUser", "Aranan")
                        .WithMany()
                        .HasForeignKey("ArananId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Concrete.ArayanTipi", "ArayanTipi")
                        .WithMany("Aramalar")
                        .HasForeignKey("ArayanTipiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Concrete.AppUser", "Kaydeden")
                        .WithMany()
                        .HasForeignKey("KaydedenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AramaTipi");

                    b.Navigation("Aranan");

                    b.Navigation("ArayanTipi");

                    b.Navigation("Kaydeden");
                });

            modelBuilder.Entity("Entity.Concrete.KullanıcıRandevu", b =>
                {
                    b.HasOne("Entity.Concrete.AppUser", "UserID")
                        .WithMany()
                        .HasForeignKey("UserIDId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserID");
                });

            modelBuilder.Entity("Entity.Concrete.Randevular", b =>
                {
                    b.HasOne("Entity.Concrete.KullanıcıRandevu", "Kullanıcı")
                        .WithMany("Randevu")
                        .HasForeignKey("KullanıcırandevuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Concrete.RandevuDurumu", "Randevu_Durum")
                        .WithMany("Appoints")
                        .HasForeignKey("Randevu_DurumRandevuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Concrete.AppUser", "Randevu_Kayıt")
                        .WithMany()
                        .HasForeignKey("Randevu_KayıtId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Concrete.AppUser", "Ziyaret_Edil")
                        .WithMany()
                        .HasForeignKey("Ziyaret_EdilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanıcı");

                    b.Navigation("Randevu_Durum");

                    b.Navigation("Randevu_Kayıt");

                    b.Navigation("Ziyaret_Edil");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Entity.Concrete.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Entity.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Entity.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Entity.Concrete.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Entity.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entity.Concrete.AramaTipi", b =>
                {
                    b.Navigation("Aramalar");
                });

            modelBuilder.Entity("Entity.Concrete.ArayanTipi", b =>
                {
                    b.Navigation("Aramalar");
                });

            modelBuilder.Entity("Entity.Concrete.KullanıcıRandevu", b =>
                {
                    b.Navigation("Randevu");
                });

            modelBuilder.Entity("Entity.Concrete.RandevuDurumu", b =>
                {
                    b.Navigation("Appoints");
                });
#pragma warning restore 612, 618
        }
    }
}
