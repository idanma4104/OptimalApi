using System;
using System.Collections.Generic;
using System.Text;
using OptimalApi.Models.BaseModels;

namespace OptimalApi.Models.DataBase
{
    public class Contact : BaseModel
    {
        public int ContactStatusID { get; set; }
        public bool IsActive { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public int IdentityNumber { get; set; }
        public string Address { get; set; }
        public int DefaultAccountID { get; set; }
        public zContactStatus ContactStatus { get; set; }
    }
}
