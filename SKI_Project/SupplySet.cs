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
    
    public partial class SupplySet
    {
        public int Id { get; set; }
        public int IdProvider { get; set; }
        public int IdMagazine { get; set; }
        public string Name { get; set; }
        public int Pieces { get; set; }
        public long Price { get; set; }
    
        public virtual MagazineSet MagazineSet { get; set; }
        public virtual ProviderSet ProviderSet { get; set; }
    }
}
