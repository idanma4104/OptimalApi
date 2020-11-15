using OptimalApi.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptimalApi.Models.DataBase
{
    public class LoanRequest : BaseModel
    {
        public int LoanApplicationID { get; set; }
        public  LoanApplication LoanApplication { get; set; }
        
    }
}
