using Calculator;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly IMath _math;
        public CalculatorController(IMath math)
        {
            _math = math;
        }

        /// <summary>
        /// Calculator api end point to perform addition opertion on two integers
        /// </summary>
        /// <param name="Value1"></param>
        /// <param name="Value2"></param>
        /// <returns></returns>
        [HttpGet("Addition")]
        public int Addition(int Value1, int Value2)
        {
            return _math.Addition(Value1, Value2);
        }

        /// <summary>
        /// Calculator api end point to perform substraction opertion on two integers
        /// </summary>
        /// <param name="Value1"></param>
        /// <param name="Value2"></param>
        /// <returns></returns>
        [HttpGet("Subtraction")]
        public int Subtraction(int Value1, int Value2)
        {
            return _math.Subtraction(Value1, Value2);
        }

        /// <summary>
        /// Calculator api end point to perform multiplication opertion on two integers
        /// </summary>
        /// <param name="Value1"></param>
        /// <param name="Value2"></param>
        /// <returns></returns>
        [HttpGet("Multiplication")]
        public int Multiplication(int Value1, int Value2)
        {
            return _math.Multiplication(Value1, Value2);
        }

        /// <summary>
        /// Calculator api end point to perform division opertion on two integers
        /// </summary>
        /// <param name="Value1"></param>
        /// <param name="Value2"></param>
        /// <returns></returns>
        [HttpGet("Division")]
        public int Division(int Value1, int Value2)
        {
            return _math.Division(Value1, Value2);
        }
    }
}
