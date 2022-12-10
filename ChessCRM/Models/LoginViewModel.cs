using System.ComponentModel.DataAnnotations;

namespace ChessCRM.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter a username")]
        public string UserName { get; set; }
        
        [Required(ErrorMessage = "Please enter a username")]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
        
        public bool RememberMe { get; set; }
    }
}
