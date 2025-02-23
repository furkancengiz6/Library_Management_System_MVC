namespace Library_Management_System_MVC.Models
{
    public class BookUpdateViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string Genre { get; set; }
        public int CopiesAvailable { get; set; }
        public List<AuthorViewModel> Authors { get; set; }

    }
}
