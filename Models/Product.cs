namespace ecommerceproject.Models;

public class Product
{
	public int Id { get; set; }
	public string Title { get; set; } = "";
	public double Price { get; set; }
	public string? Description { get; set; }
	public string? Image { get; set; }
	public int CategoryId { get; set; }
	public Category? Category { get; set; }
	public int RatingId { get; set; }
	public Rating? Rating { get; set; }
}

public class Category
{
	public int Id { get; set; }
	public string Title { get; set; } = "";
	public string Description { get; set; } = "";
}

public class Rating
{
	public int Id { get; set; }
	public int Rate { get; set; }
	public int Count { get; set; }
}