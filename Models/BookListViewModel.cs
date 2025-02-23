using Microsoft.AspNetCore.Mvc;

namespace Library_Management_System_MVC.Models
{
    public class BookListViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public string Genre { get; set; }
        public DateTime PublishDate { get; set; }
        public string ISBN { get; set; }
        public int CopiesAvailable { get; set; }

        //Controllerda birleştirme işlemi yapmak istememden kaynaklı burda yapmak istedim, kodlar çok karmaşık hale geliyor.Göz var izan derim. :)
        // Eğer Author nesnesi null değilse, ad ve soyad bilgilerini birleştirip döndür.
        // Eğer Author null ise, "Bilinmiyor" yazısını döndür.
        public string AuthorName => Author != null ? Author.FirstName + " " + Author.LastName : "Bilinmiyor";
    }
}
