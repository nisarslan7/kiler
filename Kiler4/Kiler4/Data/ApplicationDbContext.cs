using Kiler4.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kiler4.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
		public DbSet<Region> Regions { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Food> Foods { get; set; }
		public DbSet<Category> Categories { get; set; }
	}
}
