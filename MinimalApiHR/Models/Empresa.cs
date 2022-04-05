using System;
using System.Collections.Generic;

namespace MinimalApiHR.Models
{
    public partial class Empresa
    {
        public Empresa()
        {
            Legajos = new HashSet<Legajo>();
            MiembroEmpresas = new HashSet<MiembroEmpresa>();
        }

        public int EmpNro { get; set; }
        public int? GempNro { get; set; }
        public int? ReconNro { get; set; }
        public int? FconNro { get; set; }
        public string? EmpRsocial { get; set; }
        public string? EmpCuit { get; set; }
        public int? Pivanro { get; set; }
        public bool EmpPropia { get; set; }
        public string? EmpNomComerc { get; set; }
        public string? EmpIngBrut { get; set; }
        public string? EmpFechAlta { get; set; }
        public string? EmpFechSist { get; set; }
        public string? EmpDetalle { get; set; }
        public bool EmpMultinac { get; set; }
        public int? EmpCantPersonal { get; set; }
        public decimal? EmpFactAnual { get; set; }
        public int? UltVisNumero { get; set; }
        public int? UltStarNumero { get; set; }
        public string? EmpDominio { get; set; }
        public string EmpFechBaja { get; set; } = null!;
        public bool EmpExtranjera { get; set; }
        public int? IganNro { get; set; }
        public int? CviempNro { get; set; }
        public string EmpNroHabilitacion { get; set; } = null!;
        public string? Cviurl { get; set; }
        public string? EncuestaUrl { get; set; }
        public string? EmpActividadFirma { get; set; }
        public int? MempNroAutoriza { get; set; }
        public string? EmpNroInscripcion { get; set; }
        public string EmpDomLibroLey { get; set; } = null!;
        public string? EmpNroCentLab { get; set; }
        public int? PerRelNro { get; set; }
        public string? EmpReducido { get; set; }
        public int? EcliNro { get; set; }
        public decimal? EmpArtProc { get; set; }
        public decimal? EmpArtFijo { get; set; }
        public int? InscIbnro { get; set; }
        public string? EmpDescripCobranza { get; set; }
        public bool? EmpGiroFact { get; set; }
        public int? TprdNro { get; set; }
        public int? PaiNro { get; set; }
        public decimal TopeOc { get; set; }
        public DateTime? EmpFceDde { get; set; }
        public bool? EmpAfipActivo { get; set; }
        public string? EmpAfipMensaje { get; set; }
        public DateTime? EmpAfipFecha { get; set; }

        public virtual Persona? PerRelNroNavigation { get; set; }
        public virtual ICollection<Legajo> Legajos { get; set; }
        public virtual ICollection<MiembroEmpresa> MiembroEmpresas { get; set; }
    }
}
