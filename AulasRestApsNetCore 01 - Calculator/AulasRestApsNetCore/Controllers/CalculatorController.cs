using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AulasRestApsNetCore.Controllers
{
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        // GET api/<CalculatorController>/5/5
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if(IsNumeric(firstNumber)  && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult Subtaction(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult Division(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplication(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("mean/{firstNumber}/{secondNumber}")]
        public IActionResult Mean(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = (ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber))/2;
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("square-root/{firstNumber}")]
        public IActionResult SquareRoot(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber))
            {
                var sum = Math.Sqrt((double)ConvertToDecimal(firstNumber));
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }

        private decimal ConvertToDecimal(string stringtNumber)
        {
            decimal decimalValue;
            if(decimal.TryParse(stringtNumber, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }

        private bool IsNumeric(string stringNumber)
        {
            double number;

            bool isNumber = double.TryParse(stringNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);

            return isNumber;
        }
    }
}
