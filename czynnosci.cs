//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjektProgramowanie
{
    using System;
    using System.Collections.Generic;
    
    public partial class czynnosci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public czynnosci()
        {
            this.pracownicies = new HashSet<pracownicy>();
        }
    
        public long idCzynnosci { get; set; }
        public string nazwa { get; set; }
        public string opis { get; set; }
        public float czasWykonania { get; set; }
        public long idUslugi { get; set; }
    
        public virtual uslugi uslugi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pracownicy> pracownicies { get; set; }
    }
}