using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WorkerSchedulingApp.Models
{
    //day model
    public class Day
    {
        public int DayId { get; set; } //primary key
       
        [StringLength(10)]
        [Required(ErrorMessage ="Please enter a day")]//required class
        public string Name { get; set; }

        public ICollection<Position> Positions { get; set; }    // Navigation property
    }
}

