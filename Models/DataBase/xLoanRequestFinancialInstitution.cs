using OptimalApi.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptimalApi.Models.DataBase
{
    public class xLoanRequestFinancialInstitution : BaseModel
    {
        public int LoanRequestID { get; set; }
        public LoanRequest LoanRequest { get; set; }

        public int FinancialInstitutionID { get; set; }
        public zFinancialInstitution FinancialInstitution { get; set; }
    }
}
