using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using services;

namespace app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : ControllerBase
    {

        public readonly Calculator _calculator;

        public OperationController()
        {
            _calculator = new Calculator();
        }

        [HttpGet("sum/{num1}/{num2}")]
        public ActionResult<int> SumGet(int num1, int num2)
        {
            return _calculator.Sum(num1, num2);
        }

        [HttpGet("sub/{num1}/{num2}")]
        public ActionResult<int> SubGet(int num1, int num2)
        {
            return _calculator.Sub(num1, num2);
        }

    }
}
