using System.ComponentModel.DataAnnotations;

namespace  OptimalApi.Models.ViewModels
{
    public class ValidateResetTokenRequest
    {
        [Required]
        public string Token { get; set; }
    }
}