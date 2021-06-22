namespace flyscanner_backend.Data.Models{
	public class Seat: TEntity{
		public bool IsOccupied{ get; set; }
		public int Number { get; set; }
		public User Occupant { get; set; }
	}
}