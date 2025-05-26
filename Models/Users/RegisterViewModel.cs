using System.ComponentModel.DataAnnotations;

namespace ProjektSklepTI.Models.Users
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Wpisz maila albo spierdalaj")]
        [EmailAddress(ErrorMessage ="Nie umiesz chuju maila wpisac?")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Hasła muszą być jednakowe i chuj")]
        public string ConfirmPassword { get; set; }

        public string UserName { get; set; }    

        public string FirstName { get; set; }

        public string LastName { get; set; }
        


    }
}
