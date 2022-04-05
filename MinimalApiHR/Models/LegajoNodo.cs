using System;
using System.Collections.Generic;

namespace MinimalApiHR.Models
{
    public partial class LegajoNodo
    {
        public int LnodNro { get; set; }
        public int? NodNro { get; set; }
        public int? MiNodNro { get; set; }
        public int? CatNro { get; set; }
        public int LegNro { get; set; }
        public string LnodFecIng { get; set; } = null!;
        public string LnodFecEgr { get; set; } = null!;
        public decimal? LnodSueldo { get; set; }
        public decimal? LnodAdicional1 { get; set; }
        public decimal? LnodAdicional2 { get; set; }
        public decimal? LnodSueldoFactura { get; set; }
        public bool LnodTrabajaSabados { get; set; }
        public decimal? LnodHorasMes { get; set; }
        public int? CproNro { get; set; }
        public int? ZonNro { get; set; }
        public decimal? LnodJornada { get; set; }
        public string? LnodObservaciones { get; set; }
        public int? CntNro { get; set; }
        public int? LnodDiasMes { get; set; }
        public string? LnodTipoSueldo { get; set; }
        public int? PreNro { get; set; }
        public int? LugNro { get; set; }
        public int? CnvNro { get; set; }
        public int CcosNro { get; set; }
        public int? UnegNro { get; set; }
        public bool LnodDerivado { get; set; }
        public int LnodMedNro { get; set; }
        public string? LnodMedNumero { get; set; }
        public string? LnodMedFecha { get; set; }
        public string? LnodMedNroCajaAr { get; set; }
        public string? LnodMedNumeroBaja { get; set; }
        public bool LnodCobroLiqFinal { get; set; }
        public string LnodFechLiqFinal { get; set; } = null!;
        public bool LnodInactiva { get; set; }
        public int? SecNro { get; set; }
        public string? LnodCat { get; set; }
        public int? MconNro { get; set; }
        public byte LnodLiquidaGanancias { get; set; }
        public decimal LnodPromFeriado { get; set; }
        public decimal LnodPromVacacional { get; set; }
        public int DomNro { get; set; }
        public string LnodFechaProceso { get; set; } = null!;
        public bool LnodTraAgrop { get; set; }
        public int AfMoNro { get; set; }
        public string LnodFecBajaCat { get; set; } = null!;
        public int IntervieneEnLiquidacion { get; set; }
        public decimal LnodPromArt { get; set; }
        public decimal LnodBaseOs { get; set; }
        public int MdoNro { get; set; }
        public int? LnodReincorporable { get; set; }
        public string? LnodFecIngRecibo { get; set; }
        public int? LnodEfecUsuaria { get; set; }
        public string? LnodNumero { get; set; }
        public byte? LnodReservado { get; set; }
        public int? FilNro { get; set; }
        public int? EsalNro { get; set; }
        public int? LnodNroOrigen { get; set; }
        public DateTime? LnodFproceso { get; set; }
        public DateTime? LnodFactualizacion { get; set; }
        public string? LnodOrigen { get; set; }
        public int RamNro { get; set; }
        public bool LnodTrabajaDomingo { get; set; }
        public int? EstSalPreNro { get; set; }
        /// <summary>
        /// Para que la asignación no sea visible o liquidable hasta tanto no sea revisada por personal de rrhh
        /// </summary>
        public bool? LnodVerificado { get; set; }
        public bool LnodMailxBaja { get; set; }
        public bool LnodNoSemestrales { get; set; }
        public bool LnodNoAnuales { get; set; }
        public bool LnodMailPrepaga { get; set; }
        public int? ConNro { get; set; }
        public int? CarNro { get; set; }
        public decimal LnodPorcRet { get; set; }

        public virtual Legajo LegNroNavigation { get; set; } = null!;
    }
}
