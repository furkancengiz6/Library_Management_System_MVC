using Library_Management_System_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library_Management_System_MVC.Controllers
{

    public class BookController : Controller
    {
        //Geçici olarak kitapları burada tutuyoruz.
        public static List<Book> books = new List<Book>
        {
        new Book{ Id = 1, Title = "1984", AuthorId = 1, Genre = "Dystopian", ISBN = "1234567890", CopiesAvailable = 5 },

        new Book{ Id = 2, Title = "Animal Farm", AuthorId = 1, Genre = "Political Satire", ISBN = "0987654321", CopiesAvailable = 3 },

        new Book{ Id = 3, Title = "Harry Potter and the Philosopher's Stone", AuthorId = 2, Genre = "Fantasy",  ISBN = "1357924680", CopiesAvailable = 7 },

        new Book{ Id = 4, Title = "Harry Potter and the Chamber of Secrets", AuthorId = 2, Genre = "Fantasy", ISBN = "2468135790", CopiesAvailable = 4 },

        new Book { Id = 5, Title = "1984", AuthorId = 1, Genre = "Dystopian", ISBN = "1234567890", CopiesAvailable = 5 },

        new Book { Id = 6, Title = "Harry Potter and the Philosopher's Stone", AuthorId = 2, Genre = "Fantasy", ISBN = "9876543210", CopiesAvailable = 3 },

        new Book { Id = 7, Title = "Murder on the Orient Express", AuthorId = 3, Genre = "Mystery", ISBN = "2468135791", CopiesAvailable = 4 },

        new Book { Id = 8, Title = "The Shining", AuthorId = 4, Genre = "Horror", ISBN = "1122334455", CopiesAvailable = 6 },

        new Book { Id = 9, Title = "Animal Farm", AuthorId = 1, Genre = "Political Satire", ISBN = "3344556677", CopiesAvailable = 7 },

        new Book { Id = 10, Title = "Fantastic Beasts and Where to Find Them", AuthorId = 2, Genre = "Fantasy",  ISBN = "5566778899", CopiesAvailable = 3 },

        new Book { Id = 11, Title = "The Murder of Roger Ackroyd", AuthorId = 3, Genre = "Mystery", ISBN = "9988776655", CopiesAvailable = 4 },

        new Book { Id = 12, Title = "It", AuthorId = 4, Genre = "Horror", ISBN = "2233445566", CopiesAvailable = 5 }








        };


        public IActionResult List()
        {
            
            //Select kullanarak her bir kitap için yeni bir booklistviewmodel olustur.
            var viewModel = books.Select(x => new BookListViewModel
            {
                Id = x.Id,
                Title = x.Title,
                 
                Author = AuthorController.authors.FirstOrDefault(y => y.Id == x.AuthorId),
                Genre = x.Genre,
                PublishDate = x.PublishDate,
                ISBN = x.ISBN,
                CopiesAvailable = x.CopiesAvailable

            }).ToList();

            return View(viewModel);

        }
        
        public IActionResult Details(int id)
        {
            //eşleşen ıd bulucak bulamazsa null dönecek. FirstOrDefault
            var book = books.FirstOrDefault(x => x.Id == id);
            if (book == null) return NotFound();

            var viewModel = new BookDetailsViewModel
            {
                Id = book.Id,
                Title = book.Title,
                Author = AuthorController.authors.FirstOrDefault(y => y.Id == book.AuthorId),
                Genre = book.Genre,
                PublishDate = book.PublishDate,
                ISBN = book.ISBN,
                CopiesAvailable = book.CopiesAvailable
            };

            return View(viewModel);

        }
        //HttpGet isteği ile kitap eklemek için formu göterdik
        public IActionResult Create()
        {
            var viewModel = new BookCreateViewModel
            {
                Authors = AuthorController.authors.Select(x => new AuthorViewModel
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName

                }).ToList()
            };

            return View(viewModel);
        }

        //Formdan gelen buton bu Action'ı tetikleyecek [HttpPost]
        [HttpPost]
        public IActionResult Create(BookCreateViewModel formData)
        {
            if (!ModelState.IsValid)
            {
                formData.Authors = AuthorController.authors.Select(x => new AuthorViewModel
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName

                }).ToList();

                return View(formData);
            }

            
            
            

            var newBook = new Book
            {
                //Id var ise en büyük id'ye 1 ekle yok ise id "1" olsun. 
                Id = books.Any() ? books.Max(b => b.Id) + 1 : 1,
                Title = formData.Title,
                AuthorId = formData.AuthorId,
                Genre = formData.Genre,
                ISBN = formData.ISBN,
                CopiesAvailable = formData.CopiesAvailable
            };

            books.Add(newBook);//listeye eklendi 
            return RedirectToAction("List");//yönlendirme yapıldı.
        }



        //Güncelleme işlemi için id ye ihtiyacımız var.
        public IActionResult Update(int id)
        {
            //eşleşen id bulucak bulamazsa null dönecek. FirstOrDefault
            var bookUpdate = books.FirstOrDefault(x => x.Id == id);
            //bulamazsa hata dönecek
            if (bookUpdate == null) return NotFound();
            //Güncelleme işlemi için viewmodel oluşturuldu.
            var varBookUpadateViewModel = new BookUpdateViewModel
            {
                
                Id = bookUpdate.Id,
                Title = bookUpdate.Title,
                AuthorId = bookUpdate.AuthorId,
                Genre = bookUpdate.Genre,
                CopiesAvailable = bookUpdate.CopiesAvailable,
                 Authors = AuthorController.authors.Select(x => new AuthorViewModel
                 {
                     Id = x.Id,
                     FirstName = x.FirstName,
                     LastName = x.LastName

                 }).ToList()
            };
            //Güncelleme işlemi için view gönderildi.
            return View(varBookUpadateViewModel);
        }
        //Güncelllemede açılır listede yazarlar gelmiyor.//Düzeltildi
        [HttpPost]
        public IActionResult Update(BookUpdateViewModel formData)
        {
            var bookUpdate = books.FirstOrDefault(x => x.Id == formData.Id);
            if (bookUpdate == null) return NotFound();//bulamazsa hata dönecek

            bookUpdate.Title = formData.Title;
            bookUpdate.AuthorId = formData.AuthorId;
            bookUpdate.Genre = formData.Genre;
            bookUpdate.CopiesAvailable = formData.CopiesAvailable;

            return RedirectToAction("List");
        }



        //Silme işlemi için id ihticımız var.
        
        public IActionResult Delete(int id)
        {
            var bookDelete = books.FirstOrDefault(x => x.Id == id);//eşleşen id bulunuyor.
            if (bookDelete == null) return NotFound();//bulamazsa hata dönecek

            return View(bookDelete);
        }
        
        [HttpPost]
        public IActionResult Delete(Book book)
        {
            var bookDelete = books.FirstOrDefault(x => x.Id == book.Id);
            if (bookDelete != null)
            {
                books.Remove(bookDelete);
            }

            return RedirectToAction("List");
        }
        
    }
}
