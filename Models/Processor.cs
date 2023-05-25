using System.ComponentModel.DataAnnotations;

namespace StoreCatalog.Models
{
    public class Processor
    {
        [Key]
        public int ProcessorId { get; set; }
        [Required]
        public string Manufacturer { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public int CoreCount { get; set; }
        [Required]
        public int ThreadCount { get; set; }
        public double Price { get; set; }
        [Required]
        public bool IsAvailable { get; set; }
    }
}
