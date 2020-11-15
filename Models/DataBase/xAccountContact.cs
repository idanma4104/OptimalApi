using OptimalApi.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace OptimalApi.Models.DataBase
{
    public class xAccountContact :BaseModel
    {
        public int AccountID { get; set; }
        public int ContactID { get; set; }
        public int RoleID { get; set; }
        public Account Account { get; set; }
        public Contact Contact { get; set; }
        public Role Role { get; set; }
    }
}
