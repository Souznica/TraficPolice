//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TraficPolice
{
    using System;
    using System.Collections.Generic;
    
    public partial class Violation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Violation()
        {
            this.IncidentsVolations = new HashSet<IncidentsVolations>();
        }
    
        public int id { get; set; }
        public string title { get; set; }
        public string penaltyRange { get; set; }
        public string deprivationLicense { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IncidentsVolations> IncidentsVolations { get; set; }
    }
}
