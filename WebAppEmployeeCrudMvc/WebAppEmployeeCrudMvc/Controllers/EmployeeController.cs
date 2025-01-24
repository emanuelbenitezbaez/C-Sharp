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

        [HttpGet]
        public IActionResult NewEmployee()
        {
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NewEmployee(Employee employee)
        {
             await _appdbContext.Employees.AddAsync(employee);
            await _appdbContext.SaveChangesAsync(); 
            return RedirectToAction(nameof(List));
        }


        [HttpGet]
        public async Task<IActionResult> EditEmployee(int id)
        {
            Employee employee = await _appdbContext.Employees.FirstAsync(e => e.IdEmployee == id);
            return View(employee);
        }


        [HttpPost]
        public async Task<IActionResult> EditEmployee(Employee employee)
        {
             _appdbContext.Employees.Update(employee);
             await _appdbContext.SaveChangesAsync();
            return RedirectToAction(nameof(List));
        }

        [HttpGet]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            Employee employee = await _appdbContext.Employees.FirstAsync(e => e.IdEmployee == id);
            _appdbContext.Employees.Remove(employee);
            await _appdbContext.SaveChangesAsync();
            return RedirectToAction(nameof(List));
        }


      
       




    }
}
