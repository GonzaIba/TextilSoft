﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SL.Infrastructure;

namespace SL.Infrastructure.Migrations
{
    [DbContext(typeof(ServiceLayerDbContext))]
    partial class ServiceLayerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SL.Domain.Model.CompanyAuthenticationModel", b =>
                {
                    b.Property<int>("CompanyAuthenticationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("CanUseLoginAndRegister")
                        .HasColumnType("bit");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("MaxFailedAccessAttempts")
                        .HasColumnType("int");

                    b.Property<bool>("SignInRequireConfirmedAccount")
                        .HasColumnType("bit");

                    b.Property<bool>("UserRequireUniqueEmail")
                        .HasColumnType("bit");

                    b.HasKey("CompanyAuthenticationId");

                    b.HasIndex("CompanyId")
                        .IsUnique();

                    b.ToTable("CompanyAuthentication");
                });

            modelBuilder.Entity("SL.Domain.Model.CompanyCustomizeModel", b =>
                {
                    b.Property<int>("CompanyCustomizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyColor")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyLogo")
                        .HasColumnType("varchar(max)");

                    b.HasKey("CompanyCustomizeId");

                    b.HasIndex("CompanyId")
                        .IsUnique();

                    b.ToTable("CompanyCustomize");
                });

            modelBuilder.Entity("SL.Domain.Model.CompanyModel", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("CompanyApiKey")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.Property<string>("CompanyCuil")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("CompanyLocation")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("CompanyMail")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CompanyPhone")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("CompanyId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("SL.Domain.Model.CompanyPasswordConfigModel", b =>
                {
                    b.Property<int>("CompanyPasswordConfigId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyAuthenticationId")
                        .HasColumnType("int");

                    b.Property<int>("CountLength")
                        .HasColumnType("int");

                    b.Property<bool>("RequireDigit")
                        .HasColumnType("bit");

                    b.Property<bool>("RequireLowercase")
                        .HasColumnType("bit");

                    b.Property<bool>("RequireNonAlphanumeric")
                        .HasColumnType("bit");

                    b.Property<bool>("RequireUppercase")
                        .HasColumnType("bit");

                    b.HasKey("CompanyPasswordConfigId");

                    b.HasIndex("CompanyAuthenticationId")
                        .IsUnique();

                    b.ToTable("CompanyPasswordConfig");
                });

            modelBuilder.Entity("SL.Domain.Model.PermisoModel", b =>
                {
                    b.Property<int>("Id_Permiso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Permiso")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id_Permiso");

                    b.HasIndex("CompanyId");

                    b.ToTable("permiso");
                });

            modelBuilder.Entity("SL.Domain.Model.Permiso_PermisoModel", b =>
                {
                    b.Property<int>("Id_Permiso_Permiso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Id_Permiso_Hijo")
                        .HasColumnType("int");

                    b.Property<int?>("Id_Permiso_Padre")
                        .HasColumnType("int");

                    b.HasKey("Id_Permiso_Permiso");

                    b.ToTable("permiso_permiso");
                });

            modelBuilder.Entity("SL.Domain.Model.UsuarioModel", b =>
                {
                    b.Property<int>("Id_Usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccesFailed")
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<int>("DNI")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateDisabledUser")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateTimeEmail")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(200)");

                    b.Property<bool>("EmailConfirmado")
                        .HasColumnType("bit");

                    b.Property<bool>("EnableAnimators")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<bool>("EnableSlicePanel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<bool>("EnableVolume")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<bool>("IsOwner")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NumeroTeléfono")
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("VerifyCode")
                        .HasColumnType("int");

                    b.Property<int>("Volume")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("Id_Usuario");

                    b.HasIndex("CompanyId");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("SL.Domain.Model.Usuario_PermisoModel", b =>
                {
                    b.Property<int?>("Id_Permiso")
                        .HasColumnType("int");

                    b.Property<int?>("Id_Usuario")
                        .HasColumnType("int");

                    b.HasKey("Id_Permiso", "Id_Usuario");

                    b.HasIndex("Id_Usuario");

                    b.ToTable("usuarios_permisos");
                });

            modelBuilder.Entity("SL.Domain.Model.CompanyAuthenticationModel", b =>
                {
                    b.HasOne("SL.Domain.Model.CompanyModel", "Company")
                        .WithOne("CompanyAuthentication")
                        .HasForeignKey("SL.Domain.Model.CompanyAuthenticationModel", "CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("SL.Domain.Model.CompanyCustomizeModel", b =>
                {
                    b.HasOne("SL.Domain.Model.CompanyModel", "Company")
                        .WithOne("CompanyCustomize")
                        .HasForeignKey("SL.Domain.Model.CompanyCustomizeModel", "CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("SL.Domain.Model.CompanyPasswordConfigModel", b =>
                {
                    b.HasOne("SL.Domain.Model.CompanyAuthenticationModel", "CompanyAuthentication")
                        .WithOne("CompanyPasswordConfig")
                        .HasForeignKey("SL.Domain.Model.CompanyPasswordConfigModel", "CompanyAuthenticationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompanyAuthentication");
                });

            modelBuilder.Entity("SL.Domain.Model.PermisoModel", b =>
                {
                    b.HasOne("SL.Domain.Model.CompanyModel", "Company")
                        .WithMany("Permisos")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("SL.Domain.Model.UsuarioModel", b =>
                {
                    b.HasOne("SL.Domain.Model.CompanyModel", "Company")
                        .WithMany("Usuarios")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("SL.Domain.Model.Usuario_PermisoModel", b =>
                {
                    b.HasOne("SL.Domain.Model.PermisoModel", "PermisoModel")
                        .WithMany("Usuario_Permisos")
                        .HasForeignKey("Id_Permiso")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SL.Domain.Model.UsuarioModel", "UsuarioModel")
                        .WithMany("Usuario_Permisos")
                        .HasForeignKey("Id_Usuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PermisoModel");

                    b.Navigation("UsuarioModel");
                });

            modelBuilder.Entity("SL.Domain.Model.CompanyAuthenticationModel", b =>
                {
                    b.Navigation("CompanyPasswordConfig");
                });

            modelBuilder.Entity("SL.Domain.Model.CompanyModel", b =>
                {
                    b.Navigation("CompanyAuthentication");

                    b.Navigation("CompanyCustomize");

                    b.Navigation("Permisos");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("SL.Domain.Model.PermisoModel", b =>
                {
                    b.Navigation("Usuario_Permisos");
                });

            modelBuilder.Entity("SL.Domain.Model.UsuarioModel", b =>
                {
                    b.Navigation("Usuario_Permisos");
                });
#pragma warning restore 612, 618
        }
    }
}
