using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace AspNetServer_TelusInternational.Data
{
    internal sealed class Post
    {
        [Key]
        public int PostId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Queue_Group_Name { get; set; } = string.Empty;

        [Required]
        public int Offered { get; set; }

        [Required]
        public int Handled { get; set; }

        [Required]
        public string ATT { get; set; }

        [Required]
        public string AHT { get; set; }

        [Required]
        public int ServiceLevel { get; set; }
    }
}
