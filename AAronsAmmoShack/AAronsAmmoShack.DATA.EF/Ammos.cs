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
    
    public partial class Ammos
    {
        public int AmmoID { get; set; }
        public string AmmoName { get; set; }
        public string AmmoDescription { get; set; }
        public bool IsAvailable { get; set; }
        public Nullable<decimal> Price { get; set; }
        public bool IsTracer { get; set; }
        public bool IsSubsonic { get; set; }
        public int MuzzleVelocity { get; set; }
        public string ProductImage { get; set; }
        public int CaliberID { get; set; }
        public int RFID { get; set; }
        public int DamageID { get; set; }
        public int ManufacturerID { get; set; }
    
        public virtual Calibers Caliber { get; set; }
        public virtual Damages Damage { get; set; }
        public virtual Manufacturers Manufacturer { get; set; }
        public virtual RelatedFirearms RelatedFirearm { get; set; }
    }
}
