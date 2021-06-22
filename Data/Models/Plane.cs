using System.Collections.Generic;

namespace flyscanner_backend.Data.Models{
	public class Plane: TEntity{
		public string Name{ get; set; }
		public int Capacity{ get; set; }
		public ICollection<Seat> Seats { get; set; }
	}
}