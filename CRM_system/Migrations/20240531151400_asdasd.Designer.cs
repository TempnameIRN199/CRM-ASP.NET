﻿// <auto-generated />
using System;
using CRM_system.Models.EntityDataModels.CrmSysModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRM_system.Migrations
{
    [DbContext(typeof(CrmSysContext))]
    [Migration("20240531151400_asdasd")]
    partial class asdasd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.Client", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("DealId")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TBL_Clients", "dbo");
                });

            modelBuilder.Entity("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.ClientNotation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("ClientId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("TBL_ClientsNotations", "dbo");
                });

            modelBuilder.Entity("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.Company", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("Id"));

                    b.Property<DateTime>("DateOfEstab")
                        .HasColumnType("datetime2");

                    b.Property<short>("DirectorId")
                        .HasColumnType("smallint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TBL_Companies", "dbo");
                });

            modelBuilder.Entity("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.Deal", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<long>("ClientId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<byte>("DealStatusId")
                        .HasColumnType("tinyint");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId")
                        .IsUnique();

                    b.HasIndex("DealStatusId");

                    b.HasIndex("ManagerId");

                    b.ToTable("TBL_Deals", "dbo");
                });

            modelBuilder.Entity("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.DealEvent", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<long>("DealId")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("DealId");

                    b.ToTable("TBL_DealsEvents", "dbo");
                });

            modelBuilder.Entity("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.DealStatus", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TBL_DealStatuses", "dbo");
                });

            modelBuilder.Entity("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.Director", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("Id"));

                    b.Property<short>("CompanyId")
                        .HasColumnType("smallint");

                    b.Property<short>("DirectorAcctLogPwdId")
                        .HasColumnType("smallint");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId")
                        .IsUnique();

                    b.HasIndex("DirectorAcctLogPwdId")
                        .IsUnique();

                    b.ToTable("TBL_Directors", "dbo");
                });

            modelBuilder.Entity("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.DirectorAcctLogPwd", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("Id"));

                    b.Property<short>("DirectorId")
                        .HasColumnType("smallint");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TBL_DirectorsAcctsLogsPwds", "dbo");
                });

            modelBuilder.Entity("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.Manager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<short>("CompanyId")
                        .HasColumnType("smallint");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ManagerAcctLogPwdId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ManagerAcctLogPwdId")
                        .IsUnique();

                    b.ToTable("TBL_Managers", "dbo");
                });

            modelBuilder.Entity("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.ManagerAcctLogPwd", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TBL_ManagersAcctsLogsPwds", "dbo");
                });

            modelBuilder.Entity("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.ClientNotation", b =>
                {
                    b.HasOne("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.Client", "Client")
                        .WithMany("ClientNotations")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.Deal", b =>
                {
                    b.HasOne("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.Client", "Client")
                        .WithOne("Deal")
                        .HasForeignKey("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.Deal", "ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.DealStatus", "DealStatus")
                        .WithMany("Deals")
                        .HasForeignKey("DealStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.Manager", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("DealStatus");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.DealEvent", b =>
                {
                    b.HasOne("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.Deal", "Deal")
                        .WithMany("DealEvents")
                        .HasForeignKey("DealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Deal");
                });

            modelBuilder.Entity("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.Director", b =>
                {
                    b.HasOne("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.Company", "Company")
                        .WithOne("Director")
                        .HasForeignKey("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.Director", "CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.DirectorAcctLogPwd", "DirectorAcctLogPwd")
                        .WithOne("Director")
                        .HasForeignKey("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.Director", "DirectorAcctLogPwdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("DirectorAcctLogPwd");
                });

            modelBuilder.Entity("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.Manager", b =>
                {
                    b.HasOne("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.Company", "Company")
                        .WithMany("Managers")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.ManagerAcctLogPwd", "ManagerAcctLogPwd")
                        .WithOne("Manager")
                        .HasForeignKey("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.Manager", "ManagerAcctLogPwdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("ManagerAcctLogPwd");
                });

            modelBuilder.Entity("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.Client", b =>
                {
                    b.Navigation("ClientNotations");

                    b.Navigation("Deal")
                        .IsRequired();
                });

            modelBuilder.Entity("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.Company", b =>
                {
                    b.Navigation("Director")
                        .IsRequired();

                    b.Navigation("Managers");
                });

            modelBuilder.Entity("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.Deal", b =>
                {
                    b.Navigation("DealEvents");
                });

            modelBuilder.Entity("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.DealStatus", b =>
                {
                    b.Navigation("Deals");
                });

            modelBuilder.Entity("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.DirectorAcctLogPwd", b =>
                {
                    b.Navigation("Director")
                        .IsRequired();
                });

            modelBuilder.Entity("CRM_system.Models.EntityDataModels.CrmSysModel.Entities.ManagerAcctLogPwd", b =>
                {
                    b.Navigation("Manager")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
