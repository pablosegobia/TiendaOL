using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaOL.Models
{
    [Table("Ratings", Schema = "dbo")]
    public class Rating
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }

        [ForeignKey("ProducId")]
        public Product Product { get; set; }

        [Required]
        public int Value { get; set; }
        
        public string Commentary { get; set; }
    }
}
