using System.ComponentModel.DataAnnotations.Schema;

namespace MBooks.Models
{
    public class Book
    {
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string pageLength { get; set; }
        public bool inCollection { get; set; }
    }

    public class User
    {
        public int id { get; set; }

        //Foreign key relating to book model
        [ForeignKey("book")]
        public int bookID { get; set; }

        public Book book { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
