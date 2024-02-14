using System.ComponentModel.DataAnnotations;


namespace Kevin_API.Models.Dto
{
    public class ModelDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Details { get; set; }
        public double Rate { get; set; }
        [Required]
        public string Name { get; set; }

        public int Occupancy { get; set; }
        public int HP { get; set; }
        public string ImageUrl { get; set; }
        public string Amentiy { get; set; }

    }
}
