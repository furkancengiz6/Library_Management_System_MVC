using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
//
namespace Library_Management_System_MVC.Models
{
    public class BookCreateViewModel
    {
        [Required(ErrorMessage = "Kitap başlığı boş bırakılamaz.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Kitap başlığı en az 3 karakter, en fazla 100 karakter olmalıdır.")]
        public string Title { get; set; }


        [Required(ErrorMessage = "Yazar adı boş bırakılamaz.")]
        public int AuthorId { get; set; }

        [Required(ErrorMessage = "Tür boş bırakılamaz.")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "ISBN boş bırakılamaz.")]
        [RegularExpression(@"^(97(8|9))?\d{9}(\d|X)$", ErrorMessage = "Geçerli bir ISBN giriniz.")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "Adet sayısı boş bırakılamaz.")]
        [Range(1, int.MaxValue, ErrorMessage = "En az 1 adet olmalıdır.")]
        public int CopiesAvailable { get; set; }

        public List<AuthorViewModel> Authors { get; set; } // Yazar listesini tutmak için
    }
}
