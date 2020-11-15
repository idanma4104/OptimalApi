using OptimalApi.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptimalApi.Models.DataBase
{
    public class OrderItem : BaseModel
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
