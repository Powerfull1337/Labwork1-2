using System.ComponentModel.DataAnnotations;

namespace WebApplication1lab.Models
{
	public class Purchase
	{
		// ID покупки
		[Key]
		public int PurchaseId { get; set; }
		// ім’я і прізвище покупця
		public string Person { get; set; }
		// адреса покупця
		public string Address { get; set; }
		// ID книги
		public int PhoneId { get; set; }
		// дата покупки
		public DateTime Date { get; set; }

	}
}
