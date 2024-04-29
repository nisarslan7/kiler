namespace Kiler4.Models
{
	public class Food
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Preparation { get; set; }
		public string Time { get; set; }
		public string PersonCount { get; set; }
		public string Story { get; set; }
		public string Ingredients { get; set; }
		public int CategoryId { get; set; }
		public Category Category { get; set; }
	}
}
