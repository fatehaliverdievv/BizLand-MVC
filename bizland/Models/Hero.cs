using System.ComponentModel.DataAnnotations;

namespace bizland.Models
{
    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        [Required]
        public string VideoUrl { get; set; }

        public string BackgroundImgUrl { get; set; }
        [Required]
        public string ButtonName { get; set; }
    }
}
