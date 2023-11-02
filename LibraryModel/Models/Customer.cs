using LibraryModel.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryModel.Models
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

