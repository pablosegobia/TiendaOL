using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaOL.Models
{
    [Table("Stocks", Schema = "dbo")]
    public class Stock
	{
		[Key]
		public int Id { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProducId")]
        public Product Product { get; set; }
        [Required]
		public decimal Quantity { get; set; } //Si es positivo, es un ingreso, si es negativo, es un egreso
        public decimal Price { get; set; }        
        [Required]
        public decimal Balance { get; set; }

		public DateTime TransactionDate { get; set; }
    }
}
