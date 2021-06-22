namespace flyscanner_backend.Data.Models{
	public class Flight: TEntity{
		public City FromCity { get; set;} 
		public City ToCity { get; set; }
		public Plane Plane{ get; set; }
		public double Duration {get; set; }
	}
}