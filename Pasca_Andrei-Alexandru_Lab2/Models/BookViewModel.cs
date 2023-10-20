using System;
namespace Pasca_Andrei_Alexandru_Lab2.Models
{
	public class BookViewModel
	{
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public decimal Price { get; set; }
        public List<Author> Authors { get; set; }
    }
}

