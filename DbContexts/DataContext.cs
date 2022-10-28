using Microsoft.EntityFrameworkCore;
using ecommerceproject.Models;

namespace ecommerceproject.DbContexts;

public class DataContext : DbContext
{
	public DbSet<Product> Products => Set<Product>();
	public DbSet<User> Users => Set<User>();
	public DbSet<Customer> Customers => Set<Customer>();


	public DataContext(DbContextOptions<DataContext> options) : base(options)
	{

	}


}