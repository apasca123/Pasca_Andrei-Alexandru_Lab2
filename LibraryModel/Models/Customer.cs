using System;
using Pasca_Andrei_Alexandru_Lab2.Models;

namespace Pasca_Andrei_Alexandru_Lab2.Models
{
	public class Customer
	{
		public Customer(){}
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public DateTime BirthDate { get; set; }
		public IEnumerable<Order> Orders { get; set; }
	}
}

