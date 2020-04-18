using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaOL.Helpers;
using TiendaOL.Models;
using TiendaOL.Services.Interfaces;

namespace TiendaOL.Services
{
	//aca es donde van todos los cruds

	public class ProductService : IProductService
	{
		private DataContext context;
		public ProductService(DataContext dataContext)
		{
			context = dataContext;
		}

		public IList<Product> GetAll() { return context.Products.ToList(); }

		public Product GetById(int Id)
		{
			throw new NotImplementedException();
		}

		
	}
}
