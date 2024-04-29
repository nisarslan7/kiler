namespace Kiler4.Models
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string ProductExplanation { get; set; }
		public string ProductImage { get; set; }
		public Region Region { get; set; }
	}
}
