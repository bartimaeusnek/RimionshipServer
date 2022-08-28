﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RimionshipServer.Data;

#nullable disable

namespace RimionshipServer.Migrations
{
    [DbContext(typeof(RimionDbContext))]
    partial class RimionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("RimionshipServer.Data.AllowedMod", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte>("LoadOrder")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PackageId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<ulong>("SteamId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PackageId")
                        .IsUnique();

                    b.HasIndex("SteamId")
                        .IsUnique();

                    b.ToTable("AllowedMods");
                });

            modelBuilder.Entity("RimionshipServer.Data.HistoryStats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AmountBloodCleaned")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnimalMeatCreated")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Caravans")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Colonists")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ColonistsKilled")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ColonistsNeedTending")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Conditions")
                        .HasColumnType("INTEGER");

                    b.Property<float>("DamageDealt")
                        .HasColumnType("REAL");

                    b.Property<float>("DamageTakenPawns")
                        .HasColumnType("REAL");

                    b.Property<float>("DamageTakenThings")
                        .HasColumnType("REAL");

                    b.Property<int>("DownedColonists")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Electricity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Enemies")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Fire")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Food")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GreatestPopulation")
                        .HasColumnType("INTEGER");

                    b.Property<int>("InGameHours")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MapCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MedicalConditions")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Medicine")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MentalColonists")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumRaidsEnemy")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumThreatBigs")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Prisoners")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Rooms")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TamedAnimals")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Temperature")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TicksIgnoringBloodGod")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TicksLowColonistMood")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Timestamp")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Visitors")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Wealth")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WeaponDps")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WildAnimals")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("HistoryStats");
                });

            modelBuilder.Entity("RimionshipServer.Data.LatestStats", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<int>("AmountBloodCleaned")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnimalMeatCreated")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Caravans")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Colonists")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ColonistsKilled")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ColonistsNeedTending")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Conditions")
                        .HasColumnType("INTEGER");

                    b.Property<float>("DamageDealt")
                        .HasColumnType("REAL");

                    b.Property<float>("DamageTakenPawns")
                        .HasColumnType("REAL");

                    b.Property<float>("DamageTakenThings")
                        .HasColumnType("REAL");

                    b.Property<int>("DownedColonists")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Electricity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Enemies")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Fire")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Food")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GreatestPopulation")
                        .HasColumnType("INTEGER");

                    b.Property<int>("InGameHours")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MapCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MedicalConditions")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Medicine")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MentalColonists")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumRaidsEnemy")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumThreatBigs")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Prisoners")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Rooms")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TamedAnimals")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Temperature")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TicksIgnoringBloodGod")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TicksLowColonistMood")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Timestamp")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Visitors")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Wealth")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WeaponDps")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WildAnimals")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId");

                    b.ToTable("LatestStats");
                });

            modelBuilder.Entity("RimionshipServer.Data.MiscSettings+BroadcastMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("BroadcastMessage", (string)null);
                });

            modelBuilder.Entity("RimionshipServer.Data.MiscSettings+Punishment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Sqlite", "Autoincrement");

                    b.Property<int>("FinalPauseInterval")
                        .HasColumnType("INTEGER");

                    b.Property<float>("MaxThoughtFactor")
                        .HasColumnType("REAL");

                    b.Property<float>("MinThoughtFactor")
                        .HasColumnType("REAL");

                    b.Property<int>("StartPauseInterval")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("fk_Settings")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("fk_Settings")
                        .IsUnique();

                    b.ToTable("Punishment");
                });

            modelBuilder.Entity("RimionshipServer.Data.MiscSettings+Rising", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Sqlite", "Autoincrement");

                    b.Property<int>("MaxFreeColonistCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RisingCooldown")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RisingInterval")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RisingIntervalMinimum")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RisingReductionPerColonist")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("fk_Settings")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("fk_Settings")
                        .IsUnique();

                    b.ToTable("Rising");
                });

            modelBuilder.Entity("RimionshipServer.Data.MiscSettings+Settings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Sqlite", "Autoincrement");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("RimionshipServer.Data.MiscSettings+Traits", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Sqlite", "Autoincrement");

                    b.Property<float>("BadTraitSuppression")
                        .HasColumnType("REAL");

                    b.Property<float>("GoodTraitSuppression")
                        .HasColumnType("REAL");

                    b.Property<int>("MaxMeleeFlames")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxMeleeSkill")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxShootingFlames")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxShootingSkill")
                        .HasColumnType("INTEGER");

                    b.Property<float>("ScaleFactor")
                        .HasColumnType("REAL");

                    b.Property<int?>("fk_Settings")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("fk_Settings")
                        .IsUnique();

                    b.ToTable("Traits");
                });

            modelBuilder.Entity("RimionshipServer.Data.RimionUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AvatarUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsSuspicious")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("LockoutEnd")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("WasBanned")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("RimionshipServer.Data.RimionUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("RimionshipServer.Data.RimionUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RimionshipServer.Data.RimionUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("RimionshipServer.Data.RimionUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RimionshipServer.Data.HistoryStats", b =>
                {
                    b.HasOne("RimionshipServer.Data.RimionUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RimionshipServer.Data.LatestStats", b =>
                {
                    b.HasOne("RimionshipServer.Data.RimionUser", "User")
                        .WithOne("LatestStats")
                        .HasForeignKey("RimionshipServer.Data.LatestStats", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RimionshipServer.Data.MiscSettings+Punishment", b =>
                {
                    b.HasOne("RimionshipServer.Data.MiscSettings+Settings", null)
                        .WithOne("Punishment")
                        .HasForeignKey("RimionshipServer.Data.MiscSettings+Punishment", "fk_Settings");
                });

            modelBuilder.Entity("RimionshipServer.Data.MiscSettings+Rising", b =>
                {
                    b.HasOne("RimionshipServer.Data.MiscSettings+Settings", null)
                        .WithOne("Rising")
                        .HasForeignKey("RimionshipServer.Data.MiscSettings+Rising", "fk_Settings");
                });

            modelBuilder.Entity("RimionshipServer.Data.MiscSettings+Traits", b =>
                {
                    b.HasOne("RimionshipServer.Data.MiscSettings+Settings", null)
                        .WithOne("Traits")
                        .HasForeignKey("RimionshipServer.Data.MiscSettings+Traits", "fk_Settings");
                });

            modelBuilder.Entity("RimionshipServer.Data.MiscSettings+Settings", b =>
                {
                    b.Navigation("Punishment")
                        .IsRequired();

                    b.Navigation("Rising")
                        .IsRequired();

                    b.Navigation("Traits")
                        .IsRequired();
                });

            modelBuilder.Entity("RimionshipServer.Data.RimionUser", b =>
                {
                    b.Navigation("LatestStats");
                });
#pragma warning restore 612, 618
        }
    }
}
