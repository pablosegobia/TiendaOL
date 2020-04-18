using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaOL.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaOL.Models
{
    [Table("Products", Schema = "dbo")]
    public class Product
	{
		[Key]
        public int Id { get; set; }
		[Required]
        public string Code { get; set; }
		[Required]
		public string Description { get; set; }
		public HeadingType HeadingType { get; set; }		
		public bool Outstanding { get; set; }

        //Tanto price como rating se obtendran en el viewmodel.
    }
}
