using Microsoft.EntityFrameworkCore;
using ecommerceproject.Models;

namespace ecommerceproject.DbContexts;

public class DataContext : DbContext
{
	public DbSet<Customer> Customers { get; set; }
	public DbSet<Product> Products { get; set; }
	public DbSet<Order> Orders { get; set; }

	public DataContext() { }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlite("Data Source=./Database/dev.db");
	}
}