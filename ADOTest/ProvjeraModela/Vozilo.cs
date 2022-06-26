//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProvjeraModela
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vozilo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vozilo()
        {
            this.Dijelovis = new HashSet<Dijelovi>();
            this.ZaposleniciNaProjektus = new HashSet<ZaposleniciNaProjektu>();
        }
    
        public string IDVozila { get; set; }
        public string BrojSasije { get; set; }
        public System.DateTime GodinaKupnje { get; set; }
        public string TablicaVozila { get; set; }
        public string Kilometraza { get; set; }
        public int BrojPoliceOsiguranja { get; set; }
        public int MjesecTehnickogPregleda { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dijelovi> Dijelovis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZaposleniciNaProjektu> ZaposleniciNaProjektus { get; set; }
    }
}
