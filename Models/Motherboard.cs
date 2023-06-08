using System.ComponentModel.DataAnnotations;

namespace StoreCatalog.Models
{
    public class Motherboard
    {
        [Key]
        public int MotherboardId { get; set; }
        [Required]
        public string Manufacturer { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Socket { get; set; }
        [Required]
        public string FormFactor { get; set; }
        [Required]
		[Range(0, int.MaxValue, ErrorMessage = "Impossible to set mnegative values !")]
		public int RAMSlots { get; set; }
		[Range(0, int.MaxValue, ErrorMessage = "Impossible to set mnegative values !")]
		public double Price { get; set; }
        [Required]
        public bool IsAvailable { get; set; }
    }
}
