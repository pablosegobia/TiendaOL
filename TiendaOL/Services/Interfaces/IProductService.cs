using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaOL.Models;

namespace TiendaOL.Services.Interfaces
{
	public interface IProductService
	{
		public IList<Product> GetAll();
		public Product GetById( int Id);
	}
}
