using OptimalApi.Models.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OptimalApi.Models.BaseModels
{
    public class BaseModel
    {
        public int ID { get; set; }
        public Guid UID { get; set; }
        public bool IsDeleted { get; set; }
        public Guid CreatedByID { get; set; }
        public Guid UpdatedByID { get; set; }
        [Required]
        public DateTime CreateOn { get; set; }
        [Required]
        public DateTime ModifiedOn { get; set; }
        
        public User CreatedBy { get; set; }
      
        public User UpdatedBy { get; set; }
    }
}
