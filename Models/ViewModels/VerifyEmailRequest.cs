using System.ComponentModel.DataAnnotations;

namespace  OptimalApi.Models.ViewModels
{
    public class VerifyEmailRequest
    {
        [Required]
        public string Token { get; set; }
    }
}