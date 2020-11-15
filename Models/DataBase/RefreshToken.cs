using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace OptimalApi.Models.DataBase
{
    [Owned]
    public class RefreshToken
    {
        [Key]
        public int Id { get; set; }

        private User user;

        public User GetUser()
        {
            return user;
        }

        public void SetUser(User value)
        {
            user = value;
        }

        public string Token { get; set; }
        public DateTime Expires { get; set; }
        public bool IsExpired => DateTime.UtcNow >= Expires;
        public DateTime Created { get; set; }
        public string CreatedByIp { get; set; }
        public DateTime? Revoked { get; set; }
        public string RevokedByIp { get; set; }
        public string ReplacedByToken { get; set; }
        public bool IsActive => Revoked == null && !IsExpired;
    }
}