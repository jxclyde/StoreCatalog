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
		[Range(0, int.MaxValue,ErrorMessage = "Impossible to set mnegative values !")]
		public int CoreCount { get; set; }
        [Required]
		[Range(0, int.MaxValue, ErrorMessage = "Impossible to set mnegative values !")]
		public int ThreadCount { get; set; }
		[Range(0, int.MaxValue, ErrorMessage = "Impossible to set mnegative values !")]
		public double Price { get; set; }
        [Required]
        public bool IsAvailable { get; set; }
    }
}
