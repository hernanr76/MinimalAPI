using System;
using System.Collections.Generic;

namespace MinimalApiHR.Models
{
    public partial class MiembroEmpresa
    {
        public int EmpNro { get; set; }
        public int MempNro { get; set; }
        public int PerNro { get; set; }
        public int? AreNro { get; set; }
        public int? DomNro { get; set; }
        public int? UniNro { get; set; }
        public int? OrgNro { get; set; }
        public int? NodNro { get; set; }
        public int? PueNro { get; set; }
        public string? MempObservac { get; set; }
        public string? MempFingr { get; set; }
        public string? MempFegr { get; set; }
        public bool MempAutorizadoRetirar { get; set; }
        public int MempNroPropietario { get; set; }
        public bool MempSoporte { get; set; }
        public string? MempColor { get; set; }

        public virtual Empresa EmpNroNavigation { get; set; } = null!;
        public virtual Persona PerNroNavigation { get; set; } = null!;
    }
}
