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
    
    public partial class Eksploziv
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Eksploziv()
        {
            this.Projekts = new HashSet<Projekt>();
        }
    
        public int IDEksploziv { get; set; }
        public string Oznaka { get; set; }
        public string Status { get; set; }
        public string Vrsta { get; set; }
        public decimal Tezina { get; set; }
        public decimal Kolicina { get; set; }
        public Nullable<int> IDProjekta { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Projekt> Projekts { get; set; }
    }
}