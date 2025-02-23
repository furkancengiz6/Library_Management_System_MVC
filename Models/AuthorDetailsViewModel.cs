namespace Library_Management_System_MVC.Models
{
    public class AuthorDetailsViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public List<Book> Books { get; set; } //kitapları
    }
}
