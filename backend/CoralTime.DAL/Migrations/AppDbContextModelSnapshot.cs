﻿// <auto-generated />
using CoralTime.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace CoralTime.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoralTime.DAL.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsAdmin");

                    b.Property<bool>("IsManager");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("CoralTime.DAL.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("CreatorId");

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<string>("Email")
                        .HasMaxLength(200);

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastEditorUserId");

                    b.Property<DateTime>("LastUpdateDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("LastEditorUserId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("CoralTime.DAL.Models.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("CreatorId");

                    b.Property<int>("DateFormatId");

                    b.Property<int>("DefaultProjectId");

                    b.Property<int>("DefaultTaskId");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<bool>("IsWeeklyTimeEntryUpdatesSend");

                    b.Property<string>("LastEditorUserId");

                    b.Property<DateTime>("LastUpdateDate");

                    b.Property<int?>("SendEmailDays");

                    b.Property<int>("SendEmailTime");

                    b.Property<int>("TimeFormat");

                    b.Property<string>("TimeZone");

                    b.Property<string>("UserId");

                    b.Property<int>("WeekStart");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("LastEditorUserId");

                    b.HasIndex("UserId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("CoralTime.DAL.Models.MemberImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("ByteArrayAvatar");

                    b.Property<byte[]>("ByteArrayIcon");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("CreatorId");

                    b.Property<string>("FileNameImage")
                        .HasMaxLength(200);

                    b.Property<string>("LastEditorUserId");

                    b.Property<DateTime>("LastUpdateDate");

                    b.Property<int>("MemberId");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("LastEditorUserId");

                    b.HasIndex("MemberId")
                        .IsUnique();

                    b.ToTable("MemberImages");
                });

            modelBuilder.Entity("CoralTime.DAL.Models.MemberProjectRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("CreatorId");

                    b.Property<string>("LastEditorUserId");

                    b.Property<DateTime>("LastUpdateDate");

                    b.Property<int>("MemberId");

                    b.Property<int>("ProjectId");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("LastEditorUserId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("RoleId");

                    b.HasIndex("MemberId", "ProjectId")
                        .IsUnique();

                    b.ToTable("MemberProjectRoles");
                });

            modelBuilder.Entity("CoralTime.DAL.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ClientId");

                    b.Property<int>("Color");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("CreatorId");

                    b.Property<int>("DaysBeforeStopEditTimeEntries");

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsActiveBeforeArchiving");

                    b.Property<bool>("IsNotificationEnabled");

                    b.Property<bool>("IsPrivate");

                    b.Property<bool>("IsTimeLockEnabled");

                    b.Property<string>("LastEditorUserId");

                    b.Property<DateTime>("LastUpdateDate");

                    b.Property<int>("LockPeriod");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("NotificationDay");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("CreatorId");

                    b.HasIndex("LastEditorUserId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("CoralTime.DAL.Models.ProjectRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("ProjectRoles");
                });

            modelBuilder.Entity("CoralTime.DAL.Models.ReportsSettings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("CreatorId");

                    b.Property<DateTime?>("DateFrom");

                    b.Property<DateTime?>("DateTo");

                    b.Property<string>("FilterClientIds");

                    b.Property<string>("FilterMemberIds");

                    b.Property<string>("FilterProjectIds");

                    b.Property<string>("FilterShowColumnIds");

                    b.Property<int?>("GroupById");

                    b.Property<bool>("IsCurrentQuery");

                    b.Property<string>("LastEditorUserId");

                    b.Property<DateTime>("LastUpdateDate");

                    b.Property<int>("MemberId");

                    b.Property<string>("QueryName");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("LastEditorUserId");

                    b.HasIndex("MemberId", "QueryName")
                        .IsUnique()
                        .HasFilter("[QueryName] IS NOT NULL");

                    b.ToTable("ReportsSettings");
                });

            modelBuilder.Entity("CoralTime.DAL.Models.Setting", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Value");

                    b.HasKey("Name");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("CoralTime.DAL.Models.TaskType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Color");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("CreatorId");

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastEditorUserId");

                    b.Property<DateTime>("LastUpdateDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int?>("ProjectId");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("LastEditorUserId");

                    b.HasIndex("ProjectId");

                    b.ToTable("TaskTypes");
                });

            modelBuilder.Entity("CoralTime.DAL.Models.TimeEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("CreatorId");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<bool>("IsFromToShow");

                    b.Property<string>("LastEditorUserId");

                    b.Property<DateTime>("LastUpdateDate");

                    b.Property<int>("MemberId");

                    b.Property<int>("ProjectId");

                    b.Property<int>("TaskTypesId");

                    b.Property<int>("TimeActual");

                    b.Property<int>("TimeEstimated");

                    b.Property<int>("TimeFrom");

                    b.Property<int>("TimeTimerStart");

                    b.Property<int>("TimeTo");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("LastEditorUserId");

                    b.HasIndex("MemberId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("TaskTypesId");

                    b.ToTable("TimeEntries");
                });

            modelBuilder.Entity("CoralTime.DAL.Models.UserForgotPassRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateFrom");

                    b.Property<DateTime>("DateTo");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("RefreshToken")
                        .IsRequired();

                    b.Property<Guid>("UserForgotPassRequestUid");

                    b.HasKey("Id");

                    b.ToTable("UserForgotPassRequests");
                });

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClientId");

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("Data");

                    b.Property<DateTime?>("Expiration");

                    b.Property<string>("SubjectId");

                    b.Property<string>("Type");

                    b.HasKey("Key");

                    b.ToTable("PersistedGrants");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CoralTime.DAL.Models.Client", b =>
                {
                    b.HasOne("CoralTime.DAL.Models.ApplicationUser", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.HasOne("CoralTime.DAL.Models.ApplicationUser", "LastEditor")
                        .WithMany()
                        .HasForeignKey("LastEditorUserId");
                });

            modelBuilder.Entity("CoralTime.DAL.Models.Member", b =>
                {
                    b.HasOne("CoralTime.DAL.Models.ApplicationUser", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.HasOne("CoralTime.DAL.Models.ApplicationUser", "LastEditor")
                        .WithMany()
                        .HasForeignKey("LastEditorUserId");

                    b.HasOne("CoralTime.DAL.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("CoralTime.DAL.Models.MemberImage", b =>
                {
                    b.HasOne("CoralTime.DAL.Models.ApplicationUser", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.HasOne("CoralTime.DAL.Models.ApplicationUser", "LastEditor")
                        .WithMany()
                        .HasForeignKey("LastEditorUserId");

                    b.HasOne("CoralTime.DAL.Models.Member", "Member")
                        .WithOne("MemberImage")
                        .HasForeignKey("CoralTime.DAL.Models.MemberImage", "MemberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoralTime.DAL.Models.MemberProjectRole", b =>
                {
                    b.HasOne("CoralTime.DAL.Models.ApplicationUser", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.HasOne("CoralTime.DAL.Models.ApplicationUser", "LastEditor")
                        .WithMany()
                        .HasForeignKey("LastEditorUserId");

                    b.HasOne("CoralTime.DAL.Models.Member", "Member")
                        .WithMany("MemberProjectRoles")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CoralTime.DAL.Models.Project", "Project")
                        .WithMany("MemberProjectRoles")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CoralTime.DAL.Models.ProjectRole", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoralTime.DAL.Models.Project", b =>
                {
                    b.HasOne("CoralTime.DAL.Models.Client", "Client")
                        .WithMany("Projects")
                        .HasForeignKey("ClientId");

                    b.HasOne("CoralTime.DAL.Models.ApplicationUser", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.HasOne("CoralTime.DAL.Models.ApplicationUser", "LastEditor")
                        .WithMany()
                        .HasForeignKey("LastEditorUserId");
                });

            modelBuilder.Entity("CoralTime.DAL.Models.ReportsSettings", b =>
                {
                    b.HasOne("CoralTime.DAL.Models.ApplicationUser", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.HasOne("CoralTime.DAL.Models.ApplicationUser", "LastEditor")
                        .WithMany()
                        .HasForeignKey("LastEditorUserId");

                    b.HasOne("CoralTime.DAL.Models.Member", "Member")
                        .WithMany("ReportsSettings")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoralTime.DAL.Models.TaskType", b =>
                {
                    b.HasOne("CoralTime.DAL.Models.ApplicationUser", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.HasOne("CoralTime.DAL.Models.ApplicationUser", "LastEditor")
                        .WithMany()
                        .HasForeignKey("LastEditorUserId");

                    b.HasOne("CoralTime.DAL.Models.Project", "Project")
                        .WithMany("TaskTypes")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("CoralTime.DAL.Models.TimeEntry", b =>
                {
                    b.HasOne("CoralTime.DAL.Models.ApplicationUser", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.HasOne("CoralTime.DAL.Models.ApplicationUser", "LastEditor")
                        .WithMany()
                        .HasForeignKey("LastEditorUserId");

                    b.HasOne("CoralTime.DAL.Models.Member", "Member")
                        .WithMany("TimeEntries")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CoralTime.DAL.Models.Project", "Project")
                        .WithMany("TimeEntries")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CoralTime.DAL.Models.TaskType", "TaskType")
                        .WithMany()
                        .HasForeignKey("TaskTypesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CoralTime.DAL.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CoralTime.DAL.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoralTime.DAL.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CoralTime.DAL.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
