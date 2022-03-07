﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServicoMedico.Data;

namespace ServicoMedico.Migrations
{
    [DbContext(typeof(MedicoContext))]
    partial class MedicoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("ServicoMedico.Models.Consulta", b =>
                {
                    b.Property<int>("Ìd_Consulta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Especialidade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Id_Med")
                        .HasColumnType("int");

                    b.Property<int>("Id_Paci")
                        .HasColumnType("int");

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome_Med")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome_Paci")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Ìd_Consulta");

                    b.ToTable("Consultas");
                });

            modelBuilder.Entity("ServicoMedico.Models.Medico", b =>
                {
                    b.Property<int>("Id_Med")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Crm")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Especialidade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome_Med")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id_Med");

                    b.ToTable("Medicos");
                });

            modelBuilder.Entity("ServicoMedico.Models.Paciente", b =>
                {
                    b.Property<int>("Id_Paci")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Contato")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome_Paci")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id_Paci");

                    b.ToTable("Pacientes");
                });
#pragma warning restore 612, 618
        }
    }
}
