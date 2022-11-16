using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Monitor
    {
        public int Id { get; set; }

        [Required, StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }
        [Required, Range(0, 100_000)]
        public double ScreenSize { get; set; }
        [Required, StringLength(100, MinimumLength = 3)]
        public string Display { get; set; }
        [Required, Range(0, 100_000)]
        public int Refresh { get; set; }
        [Required, Range(0, 100_000_000)]
        public double Price { get; set; }
        [Required, StringLength(100, MinimumLength = 3)]
        public string ImgLink { get; set; }

        public int MatrixId { get; set; }
        public Matrix? Matrix { get; set; }
    }
}
