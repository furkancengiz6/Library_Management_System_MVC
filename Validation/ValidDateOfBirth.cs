using System.ComponentModel.DataAnnotations;

namespace Library_Management_System_MVC.Validation
{
    //Validasyon işlemleri için kullanılan bir attribute
    //Bu attribute'ü kullanarak doğum tarihinin doğru formatta olup olmadığını kontrol edebiliriz.
    //ValidationAttribute sınıfından türetilmiştir.
    //validationattribute sınıfı, bir sınıfın veya özelliğin doğruluğunu kontrol etmek için kullanıyor.
    public class ValidDateOfBirth : ValidationAttribute
    {

        public override bool IsValid(object value)
        {
            if (value is DateTime dateOfBirth)
            {
                //Yaş hesaplama
                var age = DateTime.Now.Year - dateOfBirth.Year;
                //Doğmamışmı kontrolü
                if (dateOfBirth > DateTime.Now) 
                {
                    this.ErrorMessage = "Daha doğmamışsın!!!";
                    return false;
                }

                if(age > 120) 
                {
                    this.ErrorMessage = "Yaşınız 120'den büyük olamaz.";
                    return false;
                }
                return true;
            }
            return false;
        }




    }
}
