using System;
namespace Pasca_Andrei_Alexandru_Lab2.Models
{
	public class Author
	{
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}

