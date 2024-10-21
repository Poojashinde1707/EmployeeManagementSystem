using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

    public class RefreshRequest
    {
        public string RefreshToken { get; set; }
    }
    public class RevokeRequest
    {
        public string RefreshToken { get; set; }
    }
}
