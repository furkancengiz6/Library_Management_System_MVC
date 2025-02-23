using System.ComponentModel.DataAnnotations;

namespace Library_Management_System_MVC.Models
{
    public class Book
    {
        //Yayınlanma tarihi Constructer ile 
        public Book() 
        {
            PublishDate = DateTime.Now;
        }


        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string Genre { get; set; }
        public DateTime PublishDate { get; set; }
        public string ISBN { get; set; }
        public int CopiesAvailable { get; set; }


    }
}
