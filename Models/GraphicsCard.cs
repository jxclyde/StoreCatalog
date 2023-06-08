using System.ComponentModel.DataAnnotations;

namespace StoreCatalog.Models
{
    public class GraphicsCard
    {
        [Key]
        public int GraphicsCardId { get; set; }
        [Required]
        public string Manufacturer { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
		[Range(0, int.MaxValue, ErrorMessage = "Impossible to set mnegative values !")]
		public int MemorySize { get; set; }
        [Required]
        public string MemoryType { get; set; }
		[Range(0, int.MaxValue, ErrorMessage = "Impossible to set mnegative values !")]
		public double Price { get; set; }
        [Required]
        public bool IsAvailable { get; set; }
    }
}
