using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerceproject.Models;

public class Customer
{
	public int CustomerId { get; set; }
	public string Lastname { get; set; } = "";
	public string Firstname { get; set; } = "";

	public List<CustomerAddress>? CustomerAddress { get; set; }
}

public class CustomerAddress
{
	public int CustomerAddressId { get; set; }

	public int CustomerId { get; set; }
	public Customer? Customer;

	public CustomerAddressType AddressType { get; set; } = CustomerAddressType.DeliveryAddress;

	public string? UnitNumber;
	public string? StreetNumber;
	public string? StreetName;
	public string? Suburb;
}

public enum CustomerAddressType
{
	DeliveryAddress,
	BillingAddress
}