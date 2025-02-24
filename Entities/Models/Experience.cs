using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Experience
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string JobTitle { get; set; } = string.Empty;

        [Required]
        [StringLength(255)]
        public string Company { get; set; } = string.Empty;

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; } // Eğer şu anki işse, bitiş tarihi boş olabilir.

        public string Responsibilities { get; set; } = string.Empty; // Görevler ve sorumluluklar
    }
}
