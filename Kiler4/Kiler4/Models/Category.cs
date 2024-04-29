using System.Collections.Generic;

namespace Kiler4.Models
{
	public class Category
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string CategoryImage { get; set; }
		public ICollection<Food> Foods { get; set; }

	}
}
