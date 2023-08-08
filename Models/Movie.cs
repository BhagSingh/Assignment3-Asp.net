using System.ComponentModel.DataAnnotations;// is nneded for atributes

namespace Assignment3_Asp.net.Models
{
    public class Movie
    {


        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Genere { get; set; }
        [Required]

        public DateTime DateTime { get; set; }
       

    }    
    
}
