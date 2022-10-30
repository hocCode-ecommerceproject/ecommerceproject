using System.ComponentModel.DataAnnotations;

namespace ecommerceproject.Models;

public class Order
{
	public int Id { get; set; }

	public int CustomerId { get; set; }
	public Customer? Customer { get; set; }

	public List<OrderLine>? OrderLines { get; set; }

	public double Total { get; set; }
	public double Gst { get; set; }
	public DateTime OrderDate { get; set; }
}