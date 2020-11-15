using OptimalApi.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptimalApi.Models.DataBase
{
    public class Invite : BaseModel
    {
        public int AccountID { get; set; }
        public int FromContactID { get; set; }
        public string ToMail { get; set; }
        public string ToName { get; set; }
        public int RoleID { get; set; }
        public int ExpirationInHours { get; set; }
        public int InviteStatusID { get; set; }
        public bool IsExpired { get; set; }
        public Contact FromContact { get; set; }
        public zInviteStatus InviteStatus { get; set; }
        public Account Account { get; set; }
        public DateTime? CompletedDate { get; set; }
    }
}
