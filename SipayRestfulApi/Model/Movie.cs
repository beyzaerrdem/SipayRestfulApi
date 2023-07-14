using System.ComponentModel.DataAnnotations;

namespace SipayRestfulApi.Model
{
    public class Movie
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        public int Time { get; set; }

        public int ImdbPoint { get; set; }

    }
}
