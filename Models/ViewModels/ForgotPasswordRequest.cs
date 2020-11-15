using System.ComponentModel.DataAnnotations;

namespace  OptimalApi.Models.ViewModels
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}