using Microsoft.EntityFrameworkCore;

namespace ParkingApp.Models
{
	public class ParkingAppDbContext : DbContext
	{
		public ParkingAppDbContext(DbContextOptions<ParkingAppDbContext> options) : base(options) 
		{
			
		}	

		public DbSet<Booking> Bookings { get; set; }	
	}
}
