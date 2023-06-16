using ForeignKeyImplementation.Data;
using ForeignKeyImplementation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCrudApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly AppDbContext context;
        public CustomerController(AppDbContext apiDbContext)
        {
            context = apiDbContext;
        }

        [HttpGet]
        [Route("GetCustomer")]
        public IActionResult GetEmployees()
        {
            var emp = context.Customers.ToList();
            if (emp.Count == 0)
            {
                return NotFound("Employees are not available in database");
            }
            return Ok(emp);
        }
        [HttpPost]
        [Route("AddCustomer")]
        public IActionResult AddEmployees(Customer employee)
        {
            context.Customers.Add(employee);
            context.SaveChanges();
            return Ok("Employee Added successfully");
        }
        [HttpGet]
        [Route("GetOrder")]
        public IActionResult GetOrder()
        {
            var emp = context.Orders.ToList();
            if (emp.Count == 0)
            {
                return NotFound("Employees are not available in database");
            }
            return Ok(emp);
        }
        [HttpPost]
        [Route("AddOrders")]
        public IActionResult AddOrders(Order employee)
        {
            context.Orders.Add(employee);
            context.SaveChanges();
            return Ok("Employee Added successfully");
        }

    }
}
