using System;

namespace flyscanner_backend.Data.Models{
	public class FlightBooking: TEntity{
		public Flight Flight { get; set; }
		public Seat Seat { get; set; }
		public DateTime FightBookingDate { get; set; }
		public User Occupant { get; set; }
	}
}