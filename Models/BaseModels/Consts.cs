using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptimalApi.Models.BaseModels
{
    public static class Consts
    {
        public const string IdNumberValidation = "תעודת זהות לא תקינה ";
        public const string Phone = "טלפון נייד לא תקין";
        public const string Mobile = "טלפון נייד לא תקין";
        public const string MobileError = "^[0][5][0|1|2|3|4|5|8|9]{1}[-]{0,1}[0-9]{7}$";
        public const string EmailError = "חובה להזין כתובת דואר אלקטרוני";
        public const string Required = "שדה חובה";
        public const string Password = "חייב להיות בין 5 ל 8 אותויות או ספרות";
        public const string ConfirmPassword = "סיסמא לא תואמת";
        public const string LoginEmailNotExists = "לא נמצא משתמש תואם";
        //Status Int
        //xAccount Status , inaiteStatus
    }
}
