//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SKI_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class MagazineSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MagazineSet()
        {
            this.SalesSet = new HashSet<SalesSet>();
            this.SupplySet = new HashSet<SupplySet>();
        }
    
        public int Id { get; set; }
        public int IdManager { get; set; }
        public Nullable<long> Profit { get; set; }
        public string City { get; set; }
    
        public virtual PersonalSet PersonalSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesSet> SalesSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplySet> SupplySet { get; set; }
    }
}
