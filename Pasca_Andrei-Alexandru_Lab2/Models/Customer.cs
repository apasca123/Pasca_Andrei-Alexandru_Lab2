
using System.ComponentModel.DataAnnotations.Schema;

namespace Pasca_Andrei_Alexandru_Lab2.Models
{
	public class Customer
	{
		public Customer(){}
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public DateTime BirthDate { get; set; }
		public City City { get; set; }
        public int? CityID { get; set; }
		public IEnumerable<Order> Orders { get; set; }
	}
}

