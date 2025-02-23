using Library_Management_System_MVC.Validation;
using System.ComponentModel.DataAnnotations;

namespace Library_Management_System_MVC.Models
{
    public class AuthorCreateViewModel
    {
        [Required(ErrorMessage = "Ad boş bırakılamaz.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Ad 3 ile 50 karakter arasında olmalıdır.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyad boş bırakılamaz.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Soyad 3 ile 50 karakter arasında olmalıdır.")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [ValidDateOfBirth(ErrorMessage = "Geçerli bir doğum tarihi giriniz.")]
        public DateTime DateOfBirth { get; set; }
    }
}
