using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
//position model
namespace WorkerSchedulingApp.Models
{
    public class Position
    {
        public int PositionId { get; set; } //primary key

        [StringLength(55, ErrorMessage = "Position Name may not exceed 55 characters.")]
        [Required(ErrorMessage = "Please enter a position name.")]//required classes
        public string PositionName { get; set; }

        [Range(1,15, ErrorMessage = "Number of hours can only be between 1 and 15.")]
        [Required(ErrorMessage = "Please enter the number of hours.")]
        public int? HoursPerShift { get; set; }

        [Display(Name = "MilitaryTime")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Please enter numbers only for class time.")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "Class time must be 4 characters long.")]
        [Required(ErrorMessage = "Please enter a start time (in military time format).")]
        public string MilitaryTime { get; set; }

        public int WorkerId { get; set; }  //foreign key on top, navigation property on bottom
        public Worker Worker { get; set; }         

        public int DayId { get; set; }             
        public Day Day { get; set; }                  
    }
}
