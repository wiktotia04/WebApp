using System.ComponentModel.DataAnnotations;

namespace lab5._1.Components.Class
{
    public class Movie
{
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime? RelaseDate { get; set; }
        public List<Rating> Ratings { get; set; } = new List<Rating>();
        public float? Rate { get; set; }

        public int RateCount { get; set; } 

        public double AverageRating => (RateCount > 0) ? (double)Rate / RateCount : 0;
        public string ImageUrl { get; set; }


    }
}

    
