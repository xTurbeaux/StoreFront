//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AAronsAmmoShack.DATA.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Calibers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Calibers()
        {
            this.Ammos = new HashSet<Ammos>();
        }
    
        public int CaliberID { get; set; }
        public string CaliberName { get; set; }
        public string CaliberDescription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ammos> Ammos { get; set; }
        public virtual Calibers Calibers1 { get; set; }
        public virtual Calibers Caliber1 { get; set; }
    }
}