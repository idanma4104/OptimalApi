using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptimalApi.Models.BaseModels
{
    public class BaseError
    {
        public BaseError()
        {
            errors = new List<string>();
        }
        public List<string> errors { get; }
        public bool Success
        {
            get
            {
                return !errors.Any();
            }
        }

        public void AddError(string error)
        {
            errors.Add(error);
        }
    }
}
