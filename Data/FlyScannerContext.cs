using Microsoft.EntityFrameworkCore;
using flyscanner_backend.Data.Models;

namespace flyscanner_backend.Data{
	public class FlyScannerContext: DbContext{
		public FlyScannerContext(DbContextOptions<FlyScannerContext> options) :base(options){}
		public DbSet<Flight> Flights { get; set; }
		public DbSet<Plane> Planes { get; set; }
		public DbSet<Seat> Seats { get; set; }
		public DbSet<User> Users {get; set; }
		public DbSet<FlightBooking> FlightBookings { get; set; }

	}
}