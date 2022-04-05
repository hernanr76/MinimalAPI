using System;
using System.Collections.Generic;

namespace MinimalApiHR.Models
{
    public partial class Persona
    {
        public Persona()
        {
            Empresas = new HashSet<Empresa>();
            Legajos = new HashSet<Legajo>();
            MiembroEmpresas = new HashSet<MiembroEmpresa>();
        }

        public int PerNro { get; set; }
        public string PerApellido { get; set; } = null!;
        public string PerApeCasada { get; set; } = null!;
        public string PerNombres { get; set; } = null!;
        public string PerFechaNac { get; set; } = null!;
        public string PerSexo { get; set; } = null!;
        public int? NacNro { get; set; }
        public string? PerUserName { get; set; }
        public string? PerPassword { get; set; }
        public bool PerDebeCambiarPwd { get; set; }
        public string? PerFechaCambioPwd { get; set; }
        public string? PerHoraCambioPwd { get; set; }
        public string? PerFechaUltLogin { get; set; }
        public string? PerHoraUltLogin { get; set; }
        public bool PerAccDisabled { get; set; }
        public string? PerCuil { get; set; }
        public int? TdocNro { get; set; }
        public string? PerDocumento { get; set; }
        public int? NinsNro { get; set; }
        public int? PrvNro { get; set; }
        public int? EcivNro { get; set; }
        public int? AfjpNro { get; set; }
        public string? PerDomLibLey { get; set; }
        public string? PerBenLibroLey { get; set; }
        public bool PerAutoLogin { get; set; }

        public virtual ICollection<Empresa> Empresas { get; set; }
        public virtual ICollection<Legajo> Legajos { get; set; }
        public virtual ICollection<MiembroEmpresa> MiembroEmpresas { get; set; }
    }
}
