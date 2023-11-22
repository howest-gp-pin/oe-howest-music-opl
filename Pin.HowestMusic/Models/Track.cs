using System.ComponentModel.DataAnnotations;

namespace Pin.HowestMusic.Models
{
    public class Track
    {
        public Guid Id { get; set; }
        [Required] public string Name { get; set; }
        [Required] public string Artist { get; set; }

        [Required] public TimeOnly Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
        [Range(0, 5)] public int Rating { get; set; }
        public int PlayCount { get; set; }
        public bool IsFavorite { get; set; }
        //public List<Genre> Genre { get; set; }
    }
    }
