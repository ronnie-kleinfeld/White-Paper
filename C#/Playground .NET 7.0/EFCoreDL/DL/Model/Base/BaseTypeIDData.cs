using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EFCoreDL.DL.Model.Base {
    public abstract class BaseTypeIDData : BaseIDData {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [MaxLength(255)]
        public string Description { get; set; }

        public int OrderBy { get; set; }

        [DefaultValue(false)]
        public bool IsDefault { get; set; }

        [DefaultValue(false)]
        public bool Disabled { get; set; }
    }
}