using System.Collections.Generic;

namespace Kiler4.Models
{
	public class Region
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int ProductId { get; set; }
		public int FoodId { get; set; }
		public ICollection<Product> Products { get; set; }
	}
}
