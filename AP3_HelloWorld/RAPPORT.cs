//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AP3_HelloWorld
{
    using System;
    using System.Collections.Generic;
    
    public partial class RAPPORT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RAPPORT()
        {
            this.OFFRIR = new HashSet<OFFRIR>();
        }
    
        public int idRapport { get; set; }
        public Nullable<System.DateTime> dateRapport { get; set; }
        public Nullable<int> idMotif { get; set; }
        public string bilan { get; set; }
        public string idVisiteur { get; set; }
        public int idMedecin { get; set; }
    
        public virtual MEDECIN MEDECIN { get; set; }
        public virtual MOTIF MOTIF { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OFFRIR> OFFRIR { get; set; }
        public virtual Visiteur Visiteur { get; set; }
    }
}
