using Microsoft.AspNetCore.Mvc;

namespace WebAppEmployeeCrudMvc.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
