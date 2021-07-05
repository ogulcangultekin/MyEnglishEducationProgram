using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("tab_Bilgiler")]
    public class English
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Soru { get; set; }
        [Required]
        [StringLength(50)]
        public string Cevap { get; set; }

        public DateTime? EklemeTarihi { get; set; } = DateTime.Now;
        [Required]
        [StringLength(500)]
        public string TurengLink  { get; set; }

    }
}
