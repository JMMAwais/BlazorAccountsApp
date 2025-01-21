﻿// <auto-generated />
using System;
using BlazorAccountsApp.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorAccountsApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorAccountsApp.Model.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AccountCode")
                        .HasColumnType("int");

                    b.Property<int?>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("OpeningBalance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ParentAcccountId")
                        .HasColumnType("int");

                    b.Property<int?>("Types")
                        .HasColumnType("int");

                    b.Property<int?>("accountId")
                        .HasColumnType("int");

                    b.Property<decimal?>("credit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("debit")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("accountId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("BlazorAccountsApp.Model.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BranchCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BranchLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BranchName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("branches");
                });

            modelBuilder.Entity("BlazorAccountsApp.Model.JournalEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateOnly?>("date")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("journalEntry");
                });

            modelBuilder.Entity("BlazorAccountsApp.Model.JournalEntryItems", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("CreditAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("DebutAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("JournalEntriesId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("oppositeAccountId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("JournalEntriesId");

                    b.HasIndex("oppositeAccountId");

                    b.ToTable("journalEntryItems");
                });

            modelBuilder.Entity("BlazorAccountsApp.Model.Account", b =>
                {
                    b.HasOne("BlazorAccountsApp.Model.Branch", "BranchName")
                        .WithMany()
                        .HasForeignKey("BranchId");

                    b.HasOne("BlazorAccountsApp.Model.Account", "account")
                        .WithMany()
                        .HasForeignKey("accountId");

                    b.Navigation("BranchName");

                    b.Navigation("account");
                });

            modelBuilder.Entity("BlazorAccountsApp.Model.JournalEntryItems", b =>
                {
                    b.HasOne("BlazorAccountsApp.Model.Account", "account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorAccountsApp.Model.JournalEntry", "JournalEntries")
                        .WithMany()
                        .HasForeignKey("JournalEntriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorAccountsApp.Model.Account", "oppositeAccount")
                        .WithMany()
                        .HasForeignKey("oppositeAccountId");

                    b.Navigation("JournalEntries");

                    b.Navigation("account");

                    b.Navigation("oppositeAccount");
                });
#pragma warning restore 612, 618
        }
    }
}
