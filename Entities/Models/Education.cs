using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Education
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Degree { get; set; } = string.Empty; 

        [Required]
        [StringLength(255)]
        public string SchoolName { get; set; } = string.Empty;

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; } 

    }
}
