using OptimalApi.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OptimalApi.Models.DataBase
{
    public class User
    {
        
        public int  ID { get; set; }
        public Guid UID { get; set; }
        public bool IsDeleted { get; set; }
        [Required]
        public DateTime CreateOn { get; set; }
        [Required]
        public DateTime ModifiedOn { get; set; }

        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public bool AcceptTerms { get; set; }
        public string VerificationToken { get; set; }
        public DateTime? Verified { get; set; }
        public bool IsVerified => Verified.HasValue || PasswordReset.HasValue;
        public string ResetToken { get; set; }
        public DateTime? ResetTokenExpires { get; set; }
        public DateTime? PasswordReset { get; set; }
        public List<RefreshToken> RefreshTokens { get; set; }
        

        public bool OwnsToken(string token) 
        {
            return this.RefreshTokens?.Find(x => x.Token == token) != null;
        }
    }
}