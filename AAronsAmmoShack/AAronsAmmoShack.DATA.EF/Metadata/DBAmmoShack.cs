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
        [DisplayFormat(NullDisplayText= "X")]
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


}
