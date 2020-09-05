using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AAronsAmmoShack.DATA.EF.Metadata
{

    #region Ammo Metadata

    public class AmmoMetadata
    {
        [Required(ErrorMessage = "*Name of Ammo is Required*")]
        [StringLength(20, ErrorMessage = "Ammo name must be 15 characters or less")]
        [Display(Name = "Ammo")]
        public string AmmoName { get; set; }

        [UIHint("MultilineText")]
        [DisplayFormat(NullDisplayText = "X")]
        public string AmmoDescription { get; set; }

        [DisplayAttribute(Name = "Class Active")]
        public bool IsAvailable { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "value must be a valid number, 0 or larger")]
        [DisplayFormat(DataFormatString = "{0:c}", NullDisplayText = "[NA]")]
        public decimal Price { get; set; }

        [DisplayAttribute(Name = "Class Active")]
        public bool IsTracer { get; set; }

        [DisplayAttribute(Name = "Class Active")]
        public bool IsSubsonic { get; set; }

        [Required(ErrorMessage = "Book status is required")]
        public int MuzzleVelocity { get; set; }

        [Display(Name = "Cover")]
        public string ProductImage { get; set; }
    }

    [MetadataType(typeof(AmmoMetadata))]
    public partial class Ammo
    {

    }

    #endregion

    #region Caliber Metadata

    public class CaliberMetadata
    {
        [Required(ErrorMessage = "*")]
        [StringLength(20, ErrorMessage = "Max 20 characters for Caliber Name")]
        [Display(Name = "Caliber")]
        [UIHint("MultilineText")]
        public string CaliberName { get; set; }

        [UIHint("MultilineText")]
        [DisplayFormat(NullDisplayText = "[N/A]")]
        public string CaliberDescription { get; set; }
    }
    [MetadataType(typeof(CaliberMetadata))]
    public partial class Caliber
    {

    }

    #endregion

    #region DamageMetadata

    public class DamageMetadata
    {

        [DisplayFormat(NullDisplayText = "[N/A]")]
        public decimal Penetration { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        public decimal Damage { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        public decimal ArmorDamage { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        public decimal FragmentationChange { get; set; }

    }

    [MetadataType(typeof(DamageMetadata))]
    public partial class Damage
    {

    }

    #endregion

    #region Manufacturer Metadata

    public class ManufacturerMetadata
    {
        [StringLength(20, ErrorMessage = "* City must be 20 characters or less.")]
        [DisplayFormat(NullDisplayText = "[N/A]")]
        public string City { get; set; }

        [StringLength(2, ErrorMessage = "* State must be 2 characters.")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string State { get; set; }

        [StringLength(20, ErrorMessage = "* Country must be 20 characters or less.")]
        [DisplayFormat(NullDisplayText = "[N/A]")]
        public string Country { get; set; }

        [StringLength(50, ErrorMessage = "* Name must be 20 characters or less.")]
        [DisplayFormat(NullDisplayText = "[N/A]")]
        public string Name { get; set; }
    }
    [MetadataType(typeof(ManufacturerMetadata))]
    public partial class Manufacturer
    {

    }

    #endregion

    #region RelatedFirearms

    public class RelatedFirearmMetadata
    {
        [Required(ErrorMessage = "*")]
        [StringLength(20, ErrorMessage = "The value must be 20 characters or less")]
        [Display(Name = "Family Name")]
        [UIHint("MultilineText")]
        public string FamilyName { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(50, ErrorMessage = "The value must be 50 characters or less")]
        [DisplayFormat(NullDisplayText = "[N/A]")]
        [UIHint("MultilineText")]
        public string FamilyDescription { get; set; }

    }
    [MetadataType(typeof(RelatedFirearmMetadata))]
    public partial class RelatedFirearm
    {

    }
    
    #endregion

}
