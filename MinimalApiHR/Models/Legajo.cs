using System;
using System.Collections.Generic;

namespace MinimalApiHR.Models
{
    public partial class Legajo
    {
        public Legajo()
        {
            LegajoNodos = new HashSet<LegajoNodo>();
        }

        public int LegNro { get; set; }
        public int? EmpNro { get; set; }
        public bool LegAsigFam { get; set; }
        public int? NodNro { get; set; }
        public int? PerNro { get; set; }
        public int? SecNro { get; set; }
        public int? LugNro { get; set; }
        public int? CarNro { get; set; }
        public int? CatNro { get; set; }
        public int? MconNro { get; set; }
        public int? OsocNro { get; set; }
        public string LegFecIngreso { get; set; } = null!;
        public int? LegEstado { get; set; }
        public string LegFecEgreso { get; set; } = null!;
        public decimal? LegSueldo { get; set; }
        public string LegFecAntig { get; set; } = null!;
        public decimal? LegJornada { get; set; }
        public decimal? LegHorasMes { get; set; }
        public int? LegPerPrueba { get; set; }
        public string LegFecVtoPerPrueba { get; set; } = null!;
        public double? LegCoefSalFam { get; set; }
        public string LegFecUltPago { get; set; } = null!;
        public string LegFecVtoSalFam { get; set; } = null!;
        public decimal? LegAdicional1 { get; set; }
        public string? LegObservaciones { get; set; }
        public int? CproNro { get; set; }
        public decimal? LegAdicional2 { get; set; }
        public int? CcosNro { get; set; }
        public decimal? LegSueldoFactura { get; set; }
        public decimal? LegBrutoSalFam { get; set; }
        public double? LegCoefNormal { get; set; }
        public double? LegCoefPerPrueba { get; set; }
        public double? LegPromFeriado { get; set; }
        public double? LegPromVacacional { get; set; }
        public int? LegCodigoEmpresa { get; set; }
        public bool LegConsolidaAsigEnRecibo { get; set; }
        public string? LegNumero { get; set; }
        public string? LegTipoSueldo { get; set; }
        public int? ZonNro { get; set; }
        public int? CnvNro { get; set; }
        public string? LegCat { get; set; }
        public bool? LegValidaCuit { get; set; }
        public int? UnegNro { get; set; }
        public int? PreNro { get; set; }
        public bool LegDerivado { get; set; }
        public bool LegReservado { get; set; }
        public int? PosibleBanco { get; set; }
        public int? PosibleSucursal { get; set; }
        public string? FechaPedidoTarjeta { get; set; }
        public byte LegLiquidaGanancias { get; set; }
        public string LegFechaProceso { get; set; } = null!;
        public int? AfNiNro { get; set; }
        public bool LegIncapacidad { get; set; }
        public int ExpAfipLnodNro { get; set; }
        public string LegFecBinterba { get; set; } = null!;
        public decimal LegPromArt { get; set; }
        public int? FtcNro { get; set; }
        public int LegHorasPeriodo { get; set; }
        public decimal LegBaseOs { get; set; }
        public short LegSegVidOb { get; set; }
        public int? FilNro { get; set; }
        public string LegCelular { get; set; } = null!;
        public bool LegNoAsignable { get; set; }
        public DateTime? LegFproceso { get; set; }
        public DateTime? LegFactualizacion { get; set; }
        public string? LegOrigen { get; set; }
        public int RamNro { get; set; }
        /// <summary>
        /// 0 No definido, 1 Asignacion, 2 Legajo
        /// </summary>
        public int LegVacacionesPorLegajoAsignacion { get; set; }
        public bool LegParamGcias { get; set; }
        public decimal LegPorcDec1242 { get; set; }
        public string? ConvenioBanco { get; set; }
        public bool LegUsaPrepaga { get; set; }
        public int EmpNroPrepaga { get; set; }
        public bool? LegEndoso { get; set; }
        public bool? LegCorta { get; set; }
        public bool? LegMoto { get; set; }
        public DateTime? FechaRecepcionTarjeta { get; set; }
        public decimal? LegNcvalor { get; set; }
        public string? LegNcdescripcion { get; set; }
        public bool LegGciaLargaDist { get; set; }
        public int? PosocNro { get; set; }
        public decimal LegPosAdic { get; set; }
        public bool LegAltaDig { get; set; }
        public byte LegOpcDei { get; set; }

        public virtual Empresa? EmpNroNavigation { get; set; }
        public virtual Persona? PerNroNavigation { get; set; }
        public virtual ICollection<LegajoNodo> LegajoNodos { get; set; }
    }
}
