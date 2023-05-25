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
        public int MemorySize { get; set; }
        [Required]
        public string MemoryType { get; set; }
        public double Price { get; set; }
        [Required]
        public bool IsAvailable { get; set; }
    }
}
