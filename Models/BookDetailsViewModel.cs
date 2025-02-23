namespace Library_Management_System_MVC.Models
{
    public class BookDetailsViewModel
    {
        public int Id { get; set; }
        
        public string Title { get; set; }
        public Author Author { get; set; }
        public string Genre { get; set; }
        public DateTime PublishDate { get; set; }
        public string ISBN { get; set; }
        public int CopiesAvailable { get; set; }

        public string AuthorName => Author != null ? Author.FirstName + " " + Author.LastName : "Bilinmiyor";
    }
}
