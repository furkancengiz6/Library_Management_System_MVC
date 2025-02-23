using Library_Management_System_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library_Management_System_MVC.Controllers
{
    public class AuthorController : Controller
    {
        public static List<Author> authors = new List<Author>
        {
            new Author { Id = 1, FirstName = "George", LastName = "Orwell", DateOfBirth = new DateTime(1903, 6, 25) },
            new Author { Id = 2, FirstName = "J.K.", LastName = "Rowling", DateOfBirth = new DateTime(1965, 7, 31) },
            new Author { Id = 3, FirstName = "Agatha", LastName = "Christie", DateOfBirth = new DateTime(1890, 9, 15) },
            new Author { Id = 4, FirstName = "Stephen", LastName = "King", DateOfBirth = new DateTime(1947, 9, 21) },
            new Author { Id = 5, FirstName = "George", LastName = "Orwell", DateOfBirth = new DateTime(1903, 6, 25) },
            new Author { Id = 6, FirstName = "J.K.", LastName = "Rowling", DateOfBirth = new DateTime(1965, 7, 31) },
            new Author { Id = 7, FirstName = "Agatha", LastName = "Christie", DateOfBirth = new DateTime(1890, 9, 15) },
            new Author { Id = 8, FirstName = "Stephen", LastName = "King", DateOfBirth = new DateTime(1947, 9, 21) },
            new Author { Id = 9, FirstName = "J.R.R.", LastName = "Tolkien", DateOfBirth = new DateTime(1892, 1, 3) },
            new Author { Id = 10, FirstName = "Isaac", LastName = "Asimov", DateOfBirth = new DateTime(1920, 1, 2) },
            new Author { Id = 11, FirstName = "Ray", LastName = "Bradbury", DateOfBirth = new DateTime(1920, 8, 22) },
            new Author { Id = 12, FirstName = "Harper", LastName = "Lee", DateOfBirth = new DateTime(1926, 4, 28) }


        };
        public IActionResult List()
        {
            var viewModel =authors.Select(x=> new AuthorViewModel
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                DateOfBirth =  x.DateOfBirth
            } ).ToList();
            return View(viewModel);
        }
        
        public IActionResult Details(int id)
        {
            var author = authors.FirstOrDefault(a => a.Id == id);
            if (author == null) return NotFound();

            var books = BookController.books.Where(b => b.AuthorId == author.Id).ToList();
            //Yazarın kitaplarını gösteren bir viewmodel oluşturuldu.
            var viewModel = new AuthorDetailsViewModel
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                DateOfBirth = author.DateOfBirth,
                Books = books
            };

            return View(viewModel);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AuthorCreateViewModel model)
        {


            if (ModelState.IsValid)
            {
                // Yeni bir yazar nesnesi oluşturuyoruz.
                var newAuthor = new Author
                {
                    Id = authors.Count + 1,  // ID, mevcut yazar sayısına göre belirleniyor
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    DateOfBirth = model.DateOfBirth
                };

                // Yazar listesine ekliyoruz.
                authors.Add(newAuthor);

                // Yazarlar listesini gösteren sayfaya yönlendiriyoruz.
                return RedirectToAction("List");
            }

            // Model geçerli değilse, kullanıcıya aynı formu tekrar gösteriyoruz.
            return View(model);
        }


        //Update işlemi için
        public IActionResult Update(int id)
        {// Güncellenecek yazarı buluyoruz.
            var author = authors.FirstOrDefault(a => a.Id == id);
            if (author == null) return NotFound();
            
            var viewAuthorUpdateViewModel = new AuthorUpdateViewModel
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                DateOfBirth = author.DateOfBirth
            };

            return View(viewAuthorUpdateViewModel);
        }
        //Update işlemi için
        [HttpPost]
        public IActionResult Update(AuthorUpdateViewModel formData) 
        {
            // Güncellenecek yazarı buluyoruz.
            var author = authors.FirstOrDefault(a => a.Id == formData.Id);
            if (author == null) return NotFound();
            // Yazarın bilgilerini güncelliyoruz.
            author.FirstName = formData.FirstName;
            author.LastName = formData.LastName;
            author.DateOfBirth = formData.DateOfBirth;
            // Yazarlar listesini gösteren sayfaya yönlendiriyoruz.
            return RedirectToAction("List");
        }
        //Delete işlemi için
        public IActionResult Delete(int id) 
        {
            // Silinecek yazarı buluyoruz.
            var author = authors.FirstOrDefault(a => a.Id == id);
            // Eğer yazar bulunamazsa NotFound döndürüyoruz.
            if (author == null) return NotFound();
            // Yazarı gösteren sayfayı gösteriyoruz.
            return View(author);
        }

     
        [HttpPost]
        public IActionResult Delete(Author author)
        {
            // Silinecek yazarı buluyoruz.
            var authorToDelete = authors.FirstOrDefault(a => a.Id == author.Id);
            // Eğer yazar bulunamazsa NotFound döndürüyoruz.
            if (authorToDelete == null) return NotFound();
            // Yazarı listeden siliyoruz.
            authors.Remove(authorToDelete);
            // Yazarlar listesini gösteren sayfaya yönlendiriyoruz.
            return RedirectToAction("List");
        }

    }

}
