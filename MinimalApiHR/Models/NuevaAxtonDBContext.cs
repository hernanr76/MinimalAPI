using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MinimalApiHR.Models
{
    public partial class NuevaAxtonDBContext : DbContext
    {
        public NuevaAxtonDBContext()
        {
        }

        public NuevaAxtonDBContext(DbContextOptions<NuevaAxtonDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Empresa> Empresas { get; set; } = null!;
        public virtual DbSet<Legajo> Legajos { get; set; } = null!;
        public virtual DbSet<LegajoNodo> LegajoNodos { get; set; } = null!;
        public virtual DbSet<MiembroEmpresa> MiembroEmpresas { get; set; } = null!;
        public virtual DbSet<Persona> Personas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=192.168.200.17;Database=NuevaAxtonDB;User ID=axton;Password=*$8893;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("db_datareader")
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.EmpNro)
                    .HasName("PK__Empresa__650DB527");

                entity.ToTable("Empresa", "dbo");

                entity.Property(e => e.CviempNro).HasColumnName("CVIEmpNro");

                entity.Property(e => e.Cviurl)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CVIURL");

                entity.Property(e => e.EcliNro).HasColumnName("ECliNro");

                entity.Property(e => e.EmpActividadFirma)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.EmpAfipFecha).HasColumnType("date");

                entity.Property(e => e.EmpAfipMensaje)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.EmpArtFijo)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.6))");

                entity.Property(e => e.EmpArtProc)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmpCuit)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmpCUIT");

                entity.Property(e => e.EmpDescripCobranza)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmpDetalle)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.EmpDomLibroLey)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmpDominio)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmpFactAnual).HasColumnType("money");

                entity.Property(e => e.EmpFceDde).HasColumnType("date");

                entity.Property(e => e.EmpFechAlta)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmpFechBaja)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.EmpFechSist)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmpIngBrut)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNomComerc)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNroCentLab)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNroHabilitacion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmpNroInscripcion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmpReducido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpRsocial)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("EmpRSocial");

                entity.Property(e => e.EncuestaUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("EncuestaURL");

                entity.Property(e => e.FconNro).HasColumnName("FConNro");

                entity.Property(e => e.GempNro).HasColumnName("GEmpNro");

                entity.Property(e => e.IganNro).HasColumnName("IGanNro");

                entity.Property(e => e.InscIbnro).HasColumnName("InscIBNro");

                entity.Property(e => e.MempNroAutoriza).HasColumnName("MEmpNroAutoriza");

                entity.Property(e => e.PerRelNro).HasDefaultValueSql("((0))");

                entity.Property(e => e.Pivanro).HasColumnName("PIVANro");

                entity.Property(e => e.ReconNro).HasColumnName("REconNro");

                entity.Property(e => e.TopeOc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TopeOC");

                entity.Property(e => e.TprdNro).HasColumnName("TPrdNro");

                entity.Property(e => e.UltStarNumero).HasColumnName("UltSTarNumero");

                entity.HasOne(d => d.PerRelNroNavigation)
                    .WithMany(p => p.Empresas)
                    .HasForeignKey(d => d.PerRelNro)
                    .HasConstraintName("FK_Empresa_Persona");
            });

            modelBuilder.Entity<Legajo>(entity =>
            {
                entity.HasKey(e => e.LegNro)
                    .HasName("PK__Legajo__5852D887");

                entity.ToTable("Legajo", "dbo");

                entity.HasIndex(e => new { e.LegNumero, e.EmpNro }, "IX_Legajo_LegNumero_EmpNro")
                    .IsUnique();

                entity.HasIndex(e => e.PerNro, "IX_Legajo_PerNro");

                entity.HasIndex(e => new { e.EmpNro, e.LegFecIngreso, e.PosibleSucursal, e.PosibleBanco, e.PerNro, e.LegNro }, "_dta_index_Legajo_17_1686401177__K2_K12_K48_K47_K5_K1_25_37_49_64");

                entity.HasIndex(e => new { e.LegNro, e.PerNro, e.EmpNro }, "_dta_index_Legajo_6_1686401177__K1_K5_K2_37_48");

                entity.Property(e => e.AfNiNro).HasDefaultValueSql("((0))");

                entity.Property(e => e.CcosNro).HasColumnName("CCosNro");

                entity.Property(e => e.ConvenioBanco)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CproNro).HasColumnName("CProNro");

                entity.Property(e => e.ExpAfipLnodNro).HasColumnName("ExpAfipLNodNro");

                entity.Property(e => e.FechaPedidoTarjeta)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaRecepcionTarjeta).HasColumnType("date");

                entity.Property(e => e.FtcNro).HasDefaultValueSql("((0))");

                entity.Property(e => e.LegAdicional1).HasColumnType("money");

                entity.Property(e => e.LegAdicional2).HasColumnType("money");

                entity.Property(e => e.LegBaseOs)
                    .HasColumnType("money")
                    .HasColumnName("LegBaseOS");

                entity.Property(e => e.LegBrutoSalFam).HasColumnType("money");

                entity.Property(e => e.LegCat)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LegCAT")
                    .IsFixedLength();

                entity.Property(e => e.LegCelular)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LegCorta).HasDefaultValueSql("((0))");

                entity.Property(e => e.LegEndoso).HasDefaultValueSql("((0))");

                entity.Property(e => e.LegFactualizacion)
                    .HasColumnType("datetime")
                    .HasColumnName("LegFActualizacion");

                entity.Property(e => e.LegFecAntig)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LegFecBinterba)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("LegFecBINTERBA")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.LegFecEgreso)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LegFecIngreso)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LegFecUltPago)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LegFecVtoPerPrueba)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LegFecVtoSalFam)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LegFechaProceso)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.LegFproceso)
                    .HasColumnType("datetime")
                    .HasColumnName("LegFProceso");

                entity.Property(e => e.LegHorasMes).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LegJornada).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LegLiquidaGanancias).HasDefaultValueSql("((2))");

                entity.Property(e => e.LegMoto).HasDefaultValueSql("((0))");

                entity.Property(e => e.LegNcdescripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("LegNCDescripcion");

                entity.Property(e => e.LegNcvalor)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("LegNCValor");

                entity.Property(e => e.LegNumero)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LegObservaciones)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.LegOpcDei).HasColumnName("LegOpcDEI");

                entity.Property(e => e.LegOrigen)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LegPorcDec1242).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LegPosAdic)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("LegPOsAdic");

                entity.Property(e => e.LegPromArt)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("LegPromART");

                entity.Property(e => e.LegSegVidOb).HasDefaultValueSql("((2))");

                entity.Property(e => e.LegSueldo).HasColumnType("money");

                entity.Property(e => e.LegSueldoFactura).HasColumnType("money");

                entity.Property(e => e.LegTipoSueldo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LegVacacionesPorLegajoAsignacion).HasComment("0 No definido, 1 Asignacion, 2 Legajo");

                entity.Property(e => e.MconNro).HasColumnName("MConNro");

                entity.Property(e => e.OsocNro).HasColumnName("OSocNro");

                entity.Property(e => e.PosibleBanco).HasDefaultValueSql("((0))");

                entity.Property(e => e.PosibleSucursal).HasDefaultValueSql("((0))");

                entity.Property(e => e.PosocNro).HasColumnName("POsocNro");

                entity.Property(e => e.PreNro).HasDefaultValueSql("((0))");

                entity.Property(e => e.UnegNro)
                    .HasColumnName("UNegNro")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.EmpNroNavigation)
                    .WithMany(p => p.Legajos)
                    .HasForeignKey(d => d.EmpNro)
                    .HasConstraintName("FK__Legajo__EmpNro__0C91969C");

                entity.HasOne(d => d.PerNroNavigation)
                    .WithMany(p => p.Legajos)
                    .HasForeignKey(d => d.PerNro)
                    .HasConstraintName("FK__Legajo__PerNro__0D85BAD5");
            });

            modelBuilder.Entity<LegajoNodo>(entity =>
            {
                entity.HasKey(e => e.LnodNro)
                    .HasName("PK__LegajoNodo__5C23696B");

                entity.ToTable("LegajoNodo", "dbo");

                entity.HasIndex(e => new { e.NodNro, e.LegNro }, "IX_LegajoNodo")
                    .HasFillFactor(100);

                entity.HasIndex(e => new { e.LegNro, e.LnodFecIng }, "_dta_index_LegajoNodo_17_155967732__K5_K6_1_2_7");

                entity.Property(e => e.LnodNro).HasColumnName("LNodNro");

                entity.Property(e => e.CcosNro)
                    .HasColumnName("CCosNro")
                    .HasComment("");

                entity.Property(e => e.CproNro).HasColumnName("CProNro");

                entity.Property(e => e.EsalNro).HasColumnName("ESalNro");

                entity.Property(e => e.IntervieneEnLiquidacion).HasDefaultValueSql("((2))");

                entity.Property(e => e.LnodAdicional1)
                    .HasColumnType("money")
                    .HasColumnName("LNodAdicional1");

                entity.Property(e => e.LnodAdicional2)
                    .HasColumnType("money")
                    .HasColumnName("LNodAdicional2");

                entity.Property(e => e.LnodBaseOs)
                    .HasColumnType("money")
                    .HasColumnName("LNodBaseOS");

                entity.Property(e => e.LnodCat)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LNodCAT")
                    .IsFixedLength();

                entity.Property(e => e.LnodCobroLiqFinal).HasColumnName("LNodCobroLiqFinal");

                entity.Property(e => e.LnodDerivado).HasColumnName("LNodDerivado");

                entity.Property(e => e.LnodDiasMes).HasColumnName("LNodDiasMes");

                entity.Property(e => e.LnodEfecUsuaria).HasColumnName("LNodEfecUsuaria");

                entity.Property(e => e.LnodFactualizacion)
                    .HasColumnType("datetime")
                    .HasColumnName("LNodFActualizacion");

                entity.Property(e => e.LnodFecBajaCat)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("LNodFecBajaCAT")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.LnodFecEgr)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("LNodFecEgr")
                    .IsFixedLength();

                entity.Property(e => e.LnodFecIng)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("LNodFecIng")
                    .IsFixedLength();

                entity.Property(e => e.LnodFecIngRecibo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("LNodFecIngRecibo")
                    .IsFixedLength();

                entity.Property(e => e.LnodFechLiqFinal)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("LNodFechLiqFinal")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.LnodFechaProceso)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("LNodFechaProceso")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.LnodFproceso)
                    .HasColumnType("datetime")
                    .HasColumnName("LNodFProceso");

                entity.Property(e => e.LnodHorasMes)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("LNodHorasMes");

                entity.Property(e => e.LnodInactiva).HasColumnName("LNodInactiva");

                entity.Property(e => e.LnodJornada)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("LNodJornada");

                entity.Property(e => e.LnodLiquidaGanancias)
                    .HasColumnName("LNodLiquidaGanancias")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.LnodMailPrepaga).HasColumnName("LNodMailPrepaga");

                entity.Property(e => e.LnodMailxBaja).HasColumnName("LNodMailxBaja");

                entity.Property(e => e.LnodMedFecha)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("LNodMedFecha")
                    .IsFixedLength();

                entity.Property(e => e.LnodMedNro).HasColumnName("LNodMedNro");

                entity.Property(e => e.LnodMedNroCajaAr)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("LNodMedNroCajaAr");

                entity.Property(e => e.LnodMedNumero)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("LNodMedNumero");

                entity.Property(e => e.LnodMedNumeroBaja)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("LNodMedNumeroBaja");

                entity.Property(e => e.LnodNoAnuales).HasColumnName("LNodNoAnuales");

                entity.Property(e => e.LnodNoSemestrales).HasColumnName("LNodNoSemestrales");

                entity.Property(e => e.LnodNroOrigen).HasColumnName("LNodNroOrigen");

                entity.Property(e => e.LnodNumero)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("LNodNumero");

                entity.Property(e => e.LnodObservaciones)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("LNodObservaciones");

                entity.Property(e => e.LnodOrigen)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LNodOrigen")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LnodPorcRet)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("LNodPorcRet");

                entity.Property(e => e.LnodPromArt)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("LNodPromART");

                entity.Property(e => e.LnodPromFeriado)
                    .HasColumnType("numeric(19, 4)")
                    .HasColumnName("LNodPromFeriado");

                entity.Property(e => e.LnodPromVacacional)
                    .HasColumnType("numeric(19, 4)")
                    .HasColumnName("LNodPromVacacional");

                entity.Property(e => e.LnodReincorporable).HasColumnName("LNodReincorporable");

                entity.Property(e => e.LnodReservado)
                    .HasColumnName("LNodReservado")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.LnodSueldo)
                    .HasColumnType("money")
                    .HasColumnName("LNodSueldo");

                entity.Property(e => e.LnodSueldoFactura)
                    .HasColumnType("money")
                    .HasColumnName("LNodSueldoFactura");

                entity.Property(e => e.LnodTipoSueldo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LNodTipoSueldo")
                    .IsFixedLength();

                entity.Property(e => e.LnodTraAgrop).HasColumnName("LNodTraAgrop");

                entity.Property(e => e.LnodTrabajaDomingo).HasColumnName("LNodTrabajaDomingo");

                entity.Property(e => e.LnodTrabajaSabados).HasColumnName("LNodTrabajaSabados");

                entity.Property(e => e.LnodVerificado)
                    .IsRequired()
                    .HasColumnName("LNodVerificado")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Para que la asignación no sea visible o liquidable hasta tanto no sea revisada por personal de rrhh");

                entity.Property(e => e.MconNro)
                    .HasColumnName("MConNro")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SecNro).HasDefaultValueSql("((0))");

                entity.Property(e => e.UnegNro)
                    .HasColumnName("UNegNro")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.LegNroNavigation)
                    .WithMany(p => p.LegajoNodos)
                    .HasForeignKey(d => d.LegNro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LegajoNod__LegNr__19EB91BA");
            });

            modelBuilder.Entity<MiembroEmpresa>(entity =>
            {
                entity.HasKey(e => e.MempNro)
                    .HasName("PK__MiembroEmpresa__67951C17");

                entity.ToTable("MiembroEmpresa", "dbo");

                entity.HasIndex(e => e.MempAutorizadoRetirar, "_dta_index_MiembroEmpresa_6_467584804__K13");

                entity.HasIndex(e => e.MempNro, "_dta_index_MiembroEmpresa_6_467584804__K2_3");

                entity.Property(e => e.MempNro).HasColumnName("MEmpNro");

                entity.Property(e => e.MempAutorizadoRetirar).HasColumnName("MEmpAutorizadoRetirar");

                entity.Property(e => e.MempColor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MEmpColor");

                entity.Property(e => e.MempFegr)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MEmpFEgr")
                    .IsFixedLength();

                entity.Property(e => e.MempFingr)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MEmpFIngr")
                    .IsFixedLength();

                entity.Property(e => e.MempNroPropietario).HasColumnName("MEmpNroPropietario");

                entity.Property(e => e.MempObservac)
                    .HasMaxLength(6000)
                    .IsUnicode(false)
                    .HasColumnName("MEmpObservac");

                entity.Property(e => e.MempSoporte).HasColumnName("MEmpSoporte");

                entity.Property(e => e.OrgNro).HasDefaultValueSql("(0)");

                entity.HasOne(d => d.EmpNroNavigation)
                    .WithMany(p => p.MiembroEmpresas)
                    .HasForeignKey(d => d.EmpNro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MiembroEmpresa_Empresa");

                entity.HasOne(d => d.PerNroNavigation)
                    .WithMany(p => p.MiembroEmpresas)
                    .HasForeignKey(d => d.PerNro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MiembroEm__PerNr__255D4466");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.PerNro)
                    .HasName("PK__Persona__2BD537CB");

                entity.ToTable("Persona", "dbo");

                entity.HasIndex(e => e.PerCuil, "IX_PerCuil")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.PerNro, "_dta_index_Persona_6_1439396247__K1_2_4_7_16_17_18_20_21");

                entity.Property(e => e.EcivNro).HasColumnName("ECivNro");

                entity.Property(e => e.NinsNro).HasColumnName("NInsNro");

                entity.Property(e => e.PerApeCasada)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PerApellido)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PerBenLibroLey)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.PerCuil)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PerCUIL")
                    .IsFixedLength();

                entity.Property(e => e.PerDocumento)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PerDomLibLey)
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.PerFechaCambioPwd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PerFechaNac)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.PerFechaUltLogin)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PerHoraCambioPwd)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PerHoraUltLogin)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PerNombres)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PerPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PerSexo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.PerUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TdocNro).HasColumnName("TDocNro");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
