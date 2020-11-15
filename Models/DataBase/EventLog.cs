using System;
using System.Collections.Generic;
using System.Text;

namespace OptimalApi.Models.DataBase
{
    public class EventLog
    {
        public int ID { get; set; }
        public string PKID { get; set; }
        public string TableName { get; set; }
        public string Column { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public DateTime DateChanged { get; set; }
    }
}
