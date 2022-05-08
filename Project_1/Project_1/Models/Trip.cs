using System;
using System.ComponentModel.DataAnnotations;

namespace Project_1.Models
{
    public class Trip
    {
        public int TripId { get; set; }

        [Required(ErrorMessage = "Please enter a Destination.")]
        public string? Destination { get; set; }

        [Required(ErrorMessage = "Please enter a start date.")]
        public int? StartDate { get; set; }

        [Required(ErrorMessage = "Please enter an end date.")]
        public int? EndDate { get; set; }

        [Required(ErrorMessage = "Please enter Accomodations.")]
        public string? Accomodations { get; set; }
        
        public string? ToDo { get; set; }
        public string Slug =>
        Destination
            ?.Replace(' ', '-').ToLower() + '-' + Accomodations?.ToString();




    }
}
