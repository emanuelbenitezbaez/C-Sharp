using Microsoft.AspNetCore.Mvc;
using WebAppEmployeeCrudMvc.Models;
using WebAppEmployeeCrudMvc.Data;
using Microsoft.EntityFrameworkCore;


namespace WebAppEmployeeCrudMvc.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _appdbContext;
        public EmployeeController(AppDbContext appdbContext)
        {
            _appdbContext = appdbContext;
        }
        [HttpGet]
        public async Task<IActionResult>  List()
        {
            List<Employee> List = await _appdbContext.Employees.ToListAsync();
            return View(List);
        }
    }
}
