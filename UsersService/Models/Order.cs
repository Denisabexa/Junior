namespace UsersService.Models
{
	public class Order
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public DateTime Date { get; set; }
		public double Total { get; set; }
	}
}
