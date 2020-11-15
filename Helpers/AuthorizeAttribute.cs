using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using  OptimalApi.Models.DataBase;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class AuthorizeAttribute : Attribute, IAuthorizationFilter
{
    private readonly int[] _roles;

    public AuthorizeAttribute(params int[] roles)
    {
        _roles = roles ?? new int[] { };
    }

    public void OnAuthorization(AuthorizationFilterContext context)
    {
        //var user = (User)context.HttpContext.Items["User"];
        //if (user == null || (_roles.Any() && !_roles.Contains(user.RoleID)))
        //{
        //    // not logged in or role not authorized
        //    context.Result = new JsonResult(new { message = "Unauthorized" }) { StatusCode = StatusCodes.Status401Unauthorized };
        //}
    }
}