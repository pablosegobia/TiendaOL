using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaOL.Models
{
    [Table("Prices", Schema = "dbo")]
    public class Price
	{
        [Key, Column(Order = 0)]
        public int Id { get; set; }
        [Key, Column(Order = 1)]
        public DateTime Date { get; set; }

        public int ProductId { get; set; }

		[ForeignKey("ProductId")]
		public Product Product { get; set; }

        public decimal Value { get; set; }

    }
}
