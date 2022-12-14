// <auto-generated />
using System;
using GestaoDocumentos.Persistence.Contextos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace GestaoDocumentos.Persistence.Migrations
{
    [DbContext(typeof(GestaoDocumentoContext))]
    partial class GestaoDocumentoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("GestaoDocumentos.Domain.Concessao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sigla")
                        .HasColumnType("TEXT");

                    b.Property<string>("concessao")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Concessoes");
                });

            modelBuilder.Entity("GestaoDocumentos.Domain.Documento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Acesso")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ConcessaoId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ElaboradorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TipoDocumentoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("dataAtualizacao")
                        .HasColumnType("TEXT");

                    b.Property<string>("documento")
                        .HasColumnType("TEXT");

                    b.Property<string>("grupoAcesso")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ConcessaoId");

                    b.HasIndex("ElaboradorId");

                    b.HasIndex("TipoDocumentoId");

                    b.ToTable("Documentos");
                });

            modelBuilder.Entity("GestaoDocumentos.Domain.TipoDocumento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sigla")
                        .HasColumnType("TEXT");

                    b.Property<string>("tipoDocumento")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TiposDocumentos");
                });

            modelBuilder.Entity("GestaoDocumentos.Domain.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Admin")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Matricula")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Senha")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("GestaoDocumentos.Domain.Documento", b =>
                {
                    b.HasOne("GestaoDocumentos.Domain.Concessao", "Concessao")
                        .WithMany()
                        .HasForeignKey("ConcessaoId");

                    b.HasOne("GestaoDocumentos.Domain.Usuario", "Elaborador")
                        .WithMany()
                        .HasForeignKey("ElaboradorId");

                    b.HasOne("GestaoDocumentos.Domain.TipoDocumento", "TipoDocumento")
                        .WithMany()
                        .HasForeignKey("TipoDocumentoId");

                    b.Navigation("Concessao");

                    b.Navigation("Elaborador");

                    b.Navigation("TipoDocumento");
                });
#pragma warning restore 612, 618
        }
    }
}
