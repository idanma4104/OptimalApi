using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using  OptimalApi.Models.DataBase;

namespace  OptimalApi.Controllers
{
    [Controller]
    public abstract class BaseController : ControllerBase
    {
        // returns the current authenticated account (null if not logged in)
        public User User => (User)HttpContext.Items["User"];
    }
}
