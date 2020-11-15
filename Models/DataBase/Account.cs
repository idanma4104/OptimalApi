using OptimalApi.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OptimalApi.Models.DataBase
{
    public class Account : BaseModel
    {
        public int AccountTypeID { get; set; }
        public int? ParentAccountID { get; set; }
        public bool IsActive { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public zAccountType AccountType { get; set; }
        public Account ParentAccount { get; set; }
        public string Address { get; set; }
    }
}
