using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;


namespace TempManager.Models
{
    public class Temp
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Enter a date.")]
        [Remote("CheckDate", "Validation")]
        public DateTime? Date { get; set; }

        [Required(ErrorMessage = "Enter a low temperature.")]
        [Range(-200, 200, ErrorMessage = "Range: -200 and 200.")]
        public double? Low { get; set; }

        [Required(ErrorMessage = "Enter a high temparature.")]
        [Range(-200, 200, ErrorMessage = "Range: -200 and 200.")]
        public double? High { get; set; }
    }
}
