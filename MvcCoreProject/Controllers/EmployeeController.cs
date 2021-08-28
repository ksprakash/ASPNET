using Microsoft.AspNetCore.Mvc;
using MvcCoreProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreProject.Controllers
{
    public class EmployeeController : Controller
    {
       
    // GET: /<controller>/
    public IActionResult Index()
        {
            DbContext context = HttpContext.RequestServices.GetService(typeof(MvcCoreProject.Models.DbContext)) as DbContext;

            return View(context.GetAllEmployees());
        }
    }
}
