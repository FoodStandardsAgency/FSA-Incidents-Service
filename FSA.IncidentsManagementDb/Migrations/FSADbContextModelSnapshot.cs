﻿// <auto-generated />
using System;
using FSA.IncidentsManagementDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FSA.IncidentsManagementDb.Migrations
{
    [DbContext(typeof(FSADbContext))]
    partial class FSADbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FSA.IncidentsManagementDb.Entities.CategoryDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("FSA.IncidentsManagementDb.Entities.ClassificationDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Classifications");
                });

            modelBuilder.Entity("FSA.IncidentsManagementDb.Entities.ContactMethodDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContactMethods");
                });

            modelBuilder.Entity("FSA.IncidentsManagementDb.Entities.CountryDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("FSA.IncidentsManagementDb.Entities.DataSourceDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DataSources");
                });

            modelBuilder.Entity("FSA.IncidentsManagementDb.Entities.DeathIllnessDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DeathIllnesss");
                });

            modelBuilder.Entity("FSA.IncidentsManagementDb.Entities.GatewayErrorCodeDb", b =>
                {
                    b.Property<int>("ReturnCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReturnCode");

                    b.ToTable("GatewayErrorCodes");
                });

            modelBuilder.Entity("FSA.IncidentsManagementDb.Entities.GatewayRequestDetailDb", b =>
                {
                    b.Property<Guid>("RequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AdditionalInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CompletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("JsonParameters")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RequestedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("RequestingAppAccount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ResultCode")
                        .HasColumnType("int");

                    b.Property<string>("TargetProcedure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("RequestId");

                    b.ToTable("GatewayRequestDetails");
                });

            modelBuilder.Entity("FSA.IncidentsManagementDb.Entities.GatewayUserIncidentDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LastReturnedIncidentId")
                        .HasColumnType("int");

                    b.Property<Guid>("RequestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GatewayUserIncidents");
                });

            modelBuilder.Entity("FSA.IncidentsManagementDb.Entities.IncidentCommentDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IncidentId")
                        .HasColumnType("int");

                    b.Property<int?>("IncidentProductId")
                        .HasColumnType("int");

                    b.Property<string>("LastChangedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastChangedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IncidentId");

                    b.ToTable("IncidentComments");
                });

            modelBuilder.Entity("FSA.IncidentsManagementDb.Entities.IncidentDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdminLead")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClassificationId")
                        .HasColumnType("int");

                    b.Property<int>("ContactMethodId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DataSourceId")
                        .HasColumnType("int");

                    b.Property<int>("DeathIllnessId")
                        .HasColumnType("int");

                    b.Property<string>("FieldOfficer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("IncidentClosed")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IncidentCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("IncidentDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IncidentStatusId")
                        .HasColumnType("int");

                    b.Property<string>("IncidentTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IncidentTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("LAAdvised")
                        .HasColumnType("bit");

                    b.Property<int?>("LeadLocalAuthorityId")
                        .HasColumnType("int");

                    b.Property<string>("LeadOfficer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NotifierId")
                        .HasColumnType("int");

                    b.Property<int?>("PrincipalFBOId")
                        .HasColumnType("int");

                    b.Property<int>("PriorityId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReceivedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SignalStatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassificationId");

                    b.HasIndex("ContactMethodId");

                    b.HasIndex("DataSourceId");

                    b.HasIndex("DeathIllnessId");

                    b.HasIndex("IncidentStatusId");

                    b.HasIndex("IncidentTypeId");

                    b.HasIndex("LeadLocalAuthorityId");

                    b.HasIndex("NotifierId");

                    b.HasIndex("PrincipalFBOId");

                    b.HasIndex("PriorityId");

                    b.HasIndex("ProductTypeId");

                    b.HasIndex("SignalStatusId");

                    b.ToTable("Incidents");
                });

            modelBuilder.Entity("FSA.IncidentsManagementDb.Entities.IncidentLinkDb", b =>
                {
                    b.Property<int>("FromIncidentId")
                        .HasColumnType("int");

                    b.Property<int>("ToIncidentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IncidentDbId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FromIncidentId", "ToIncidentId");

                    b.HasIndex("IncidentDbId");

                    b.ToTable("IncidentLinks");
                });

            modelBuilder.Entity("FSA.IncidentsManagementDb.Entities.IncidentOMITGroupDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IncidentDbId")
                        .HasColumnType("int");

                    b.Property<int>("IncidentId")
                        .HasColumnType("int");

                    b.Property<int>("LastChangedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastChangedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OMITGroupId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IncidentDbId");

                    b.HasIndex("OMITGroupId");

                    b.ToTable("IncidentOMITGroups");
                });

            modelBuilder.Entity("FSA.IncidentsManagementDb.Entities.IncidentStatusDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IncidentStatus");
                });

            modelBuilder.Entity("FSA.IncidentsManagementDb.Entities.OMITGroupDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OMITGroups");
                });

            modelBuilder.Entity("FSA.IncidentsManagementDb.Entities.OrganisationDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContactMethodId")
                        .HasColumnType("int");

                    b.Property<string>("County")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FaxAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LastChangedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastChangedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MainContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Organisation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganisationRoleId")
                        .HasColumnType("int");

                    b.Property<string>("PostCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TownCity")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContactMethodId");

                    b.HasIndex("OrganisationRoleId");

                    b.ToTable("Organisations");
                });

            modelBuilder.Entity("FSA.IncidentsManagementDb.Entities.OrganisationRoleDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("CanBeFBO")
                        .HasColumnType("bit");

                    b.Property<bool>("CanBeLocalAuthority")
                        .HasColumnType("bit");

                    b.Property<bool>("CanBeNotifier")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OrganisationRoles");
                });

            modelBuilder.Entity("FSA.IncidentsManagementDb.Entities.PersonaRoleDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("CanBeAdminLead")
                        .HasColumnType("bit");

                    b.Property<bool>("CanBeFieldOfficer")
                        .HasColumnType("bit");

                    b.Property<bool>("CanBeIncidentLead")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PersonaRoles");
                });

            modelBuilder.Entity("FSA.IncidentsManagementDb.Entities.PriorityDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Priorities");
                });

            modelBuilder.Entity("FSA.IncidentsManagementDb.Entities.ProductTypeDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");
                });

            modelBuilder.Entity("FSA.IncidentsManagementDb.Entities.SignalStatusDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsOpen")
                        .HasColumnType("bit");

                    b.Property<bool>("IsUnassigned")
                        .HasColumnType("bit");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("SignalStatus");
                });

            modelBuilder.Entity("FSA.IncidentsManagementDb.Entities.UnitQuantityDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UnitQuantities");
                });

            modelBuilder.Entity("FSA.IncidentsManagementDb.Entities.UserDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstNames")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastChangedByDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LastChangedById")
                        .HasColumnType("int");

                    b.Property<string>("MiddleNames")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surnames")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FSA.IncidentsManagementDb.Entities.UserRoleDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("LastChangedByDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("LastChangedById")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("FSA.IncidentsManagementDb.Entities.IncidentCommentDb", b =>
                {
                    b.HasOne("FSA.IncidentsManagementDb.Entities.IncidentDb", "Incident")
                        .WithMany("Comments")
                        .HasForeignKey("IncidentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FSA.IncidentsManagementDb.Entities.IncidentDb", b =>
                {
                    b.HasOne("FSA.IncidentsManagementDb.Entities.ClassificationDb", "Classification")
                        .WithMany()
                        .HasForeignKey("ClassificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FSA.IncidentsManagementDb.Entities.ContactMethodDb", "ContactMethod")
                        .WithMany()
                        .HasForeignKey("ContactMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FSA.IncidentsManagementDb.Entities.DataSourceDb", "DataSource")
                        .WithMany()
                        .HasForeignKey("DataSourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FSA.IncidentsManagementDb.Entities.DeathIllnessDb", "DeathIllness")
                        .WithMany()
                        .HasForeignKey("DeathIllnessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FSA.IncidentsManagementDb.Entities.IncidentStatusDb", "IncidentStatus")
                        .WithMany()
                        .HasForeignKey("IncidentStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FSA.IncidentsManagementDb.Entities.CategoryDb", "IncidentType")
                        .WithMany()
                        .HasForeignKey("IncidentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FSA.IncidentsManagementDb.Entities.OrganisationDb", "LeadLocalAuthority")
                        .WithMany()
                        .HasForeignKey("LeadLocalAuthorityId");

                    b.HasOne("FSA.IncidentsManagementDb.Entities.OrganisationDb", "Notifier")
                        .WithMany()
                        .HasForeignKey("NotifierId");

                    b.HasOne("FSA.IncidentsManagementDb.Entities.OrganisationDb", "PrincipalFBO")
                        .WithMany()
                        .HasForeignKey("PrincipalFBOId");

                    b.HasOne("FSA.IncidentsManagementDb.Entities.PriorityDb", "Priority")
                        .WithMany()
                        .HasForeignKey("PriorityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FSA.IncidentsManagementDb.Entities.ProductTypeDb", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FSA.IncidentsManagementDb.Entities.SignalStatusDb", "SignalStatus")
                        .WithMany()
                        .HasForeignKey("SignalStatusId");
                });

            modelBuilder.Entity("FSA.IncidentsManagementDb.Entities.IncidentLinkDb", b =>
                {
                    b.HasOne("FSA.IncidentsManagementDb.Entities.IncidentDb", null)
                        .WithMany("Links")
                        .HasForeignKey("IncidentDbId");
                });

            modelBuilder.Entity("FSA.IncidentsManagementDb.Entities.IncidentOMITGroupDb", b =>
                {
                    b.HasOne("FSA.IncidentsManagementDb.Entities.IncidentDb", "IncidentDb")
                        .WithMany()
                        .HasForeignKey("IncidentDbId");

                    b.HasOne("FSA.IncidentsManagementDb.Entities.OMITGroupDb", "OMITGroup")
                        .WithMany()
                        .HasForeignKey("OMITGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FSA.IncidentsManagementDb.Entities.OrganisationDb", b =>
                {
                    b.HasOne("FSA.IncidentsManagementDb.Entities.ContactMethodDb", "ContactMethod")
                        .WithMany()
                        .HasForeignKey("ContactMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FSA.IncidentsManagementDb.Entities.OrganisationRoleDb", "OrganisationRole")
                        .WithMany()
                        .HasForeignKey("OrganisationRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FSA.IncidentsManagementDb.Entities.SignalStatusDb", b =>
                {
                    b.HasOne("FSA.IncidentsManagementDb.Entities.SignalStatusDb", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");
                });
#pragma warning restore 612, 618
        }
    }
}
