using Microsoft.EntityFrameworkCore;
using ecommerceproject.Models;

namespace ecommerceproject.DbContexts;

public class DataContext : DbContext
{
	public DbSet<Product> Products;
	public DbSet<User> Users;
	public DbSet<Customer> Customers;


	public DataContext(DbContextOptions<DataContext> options) : base(options)
	{

	}


}