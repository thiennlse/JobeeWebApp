﻿// <auto-generated />
using System;
using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BusinessObject.Migrations
{
    [DbContext(typeof(TestContext))]
    partial class TestContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BusinessObject.Models.Application", b =>
                {
                    b.Property<string>("ApplicationId")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("AppliedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("JobId")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("JobSeekerId")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Resume")
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("ApplicationId");

                    b.HasIndex("JobSeekerId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("BusinessObject.Models.InterviewQuestion", b =>
                {
                    b.Property<string>("QuestionId")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Answer")
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Position")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Title")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("QuestionId")
                        .HasName("PK__Intervie__0DC06FACBA3ACAFA");

                    b.ToTable("InterviewQuestion", (string)null);
                });

            modelBuilder.Entity("BusinessObject.Models.Job", b =>
                {
                    b.Property<string>("JobId")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("CreateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("EmployerId")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("JobType")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Location")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("SalaryRange")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Status")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("JobId");

                    b.HasIndex("EmployerId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("BusinessObject.Models.Payment", b =>
                {
                    b.Property<string>("PaymentId")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<decimal?>("Amount")
                        .HasColumnType("decimal(10,2)");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("datetime");

                    b.Property<string>("PaymentMethod")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Status")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UserId")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("PaymentId");

                    b.HasIndex("UserId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("BusinessObject.Models.Profile", b =>
                {
                    b.Property<string>("ProfileId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("Age")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(300)
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("ProfilePicture")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("ProfileId");

                    b.HasIndex("UserId");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("BusinessObject.Models.SubscriptionPlan", b =>
                {
                    b.Property<string>("PlanId")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("PlanName")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("PlanId")
                        .HasName("PK__Subscrip__755C22B73C7E3AC2");

                    b.ToTable("SubscriptionPlans");
                });

            modelBuilder.Entity("BusinessObject.Models.User", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("CreatedAt")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("UserId");

                    b.HasIndex(new[] { "Email" }, "UQ__Users__A9D10534D02B0127")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BusinessObject.Models.UserSubscription", b =>
                {
                    b.Property<string>("UserSubscriptionId")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime");

                    b.Property<string>("PlanId")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime");

                    b.Property<string>("UserId")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserSubscriptionId");

                    b.HasIndex("PlanId");

                    b.HasIndex("UserId");

                    b.ToTable("UserSubscriptions");
                });

            modelBuilder.Entity("BusinessObject.Models.Application", b =>
                {
                    b.HasOne("BusinessObject.Models.User", "JobSeeker")
                        .WithMany("Applications")
                        .HasForeignKey("JobSeekerId")
                        .HasConstraintName("FK_Applications.JobSeekerId");

                    b.Navigation("JobSeeker");
                });

            modelBuilder.Entity("BusinessObject.Models.Job", b =>
                {
                    b.HasOne("BusinessObject.Models.User", "Employer")
                        .WithMany("Jobs")
                        .HasForeignKey("EmployerId")
                        .HasConstraintName("FK_Jobs_EmployerId");

                    b.Navigation("Employer");
                });

            modelBuilder.Entity("BusinessObject.Models.Payment", b =>
                {
                    b.HasOne("BusinessObject.Models.User", "User")
                        .WithMany("Payments")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Payments_UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BusinessObject.Models.Profile", b =>
                {
                    b.HasOne("BusinessObject.Models.User", "User")
                        .WithMany("Profiles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Profiles_UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BusinessObject.Models.UserSubscription", b =>
                {
                    b.HasOne("BusinessObject.Models.SubscriptionPlan", "Plan")
                        .WithMany("UserSubscriptions")
                        .HasForeignKey("PlanId")
                        .HasConstraintName("FK_UserSubscriptions_PlanId");

                    b.HasOne("BusinessObject.Models.User", "User")
                        .WithMany("UserSubscriptions")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_UserSubscriptions_UserId");

                    b.Navigation("Plan");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BusinessObject.Models.SubscriptionPlan", b =>
                {
                    b.Navigation("UserSubscriptions");
                });

            modelBuilder.Entity("BusinessObject.Models.User", b =>
                {
                    b.Navigation("Applications");

                    b.Navigation("Jobs");

                    b.Navigation("Payments");

                    b.Navigation("Profiles");

                    b.Navigation("UserSubscriptions");
                });
#pragma warning restore 612, 618
        }
    }
}