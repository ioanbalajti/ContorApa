using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContorApa.Models
{
    public class ContorIndex
    {
        public int Id { get; set; }
        [Required]
        public int BucatarieRece { get; set; }
        [Required]
        public int BucatarieCald { get; set; }
        [Required]
        public int BaieRece { get; set; }
        [Required]
        public int BaieCald { get; set; }
        [Required]
        public int Anul { get; set; }
        [Required]
        public string Luna { get; set; }
        [Required]
        public DateTime DataInregistrarii { get; set; }
    }
}
