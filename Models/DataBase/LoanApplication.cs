using OptimalApi.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptimalApi.Models.DataBase
{
    public class LoanApplication : BaseModel
    {
        public string BusinessAdress { get; set; }
        public string BusinessOpenDate { get; set; }
        public int MonthCredit { get; set; }
        public decimal RequestCreditAmount { get; set; }
        public string MaamNumber { get; set; }
        public string CreditTarget { get; set; }
        public string CreditTargetDetailes { get; set; }
        public int AccountID { get; set; }
        public Account Account { get; set; }
    }
}
