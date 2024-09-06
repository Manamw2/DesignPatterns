using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayrollSystem.Helpers;
using PayrollSystem.Models;

namespace PayrollSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PayrollCalculatorController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public ActionResult<decimal> Calculate(Employee employee)
        {
            PayrollCalculator calculator = new PayrollCalculator();
            return Ok(calculator.Calculate(employee));
        }
    }
}
