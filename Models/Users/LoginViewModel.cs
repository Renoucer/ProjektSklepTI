using System.ComponentModel.DataAnnotations;

namespace ProjektSklepTI.Models.Users
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Nie wpisano loginu")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Nie wpisano hasla")]
        public string Password { get; set; }
    }
}
