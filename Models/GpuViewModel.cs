namespace StoreCatalog.Models
{
    public class GpuViewModel
    {
        public IEnumerable<string> Manufacturers { get; set; }
        public IEnumerable<string> Models { get; set; }
        public IEnumerable<double> Prices { get; set; }
    }
}
