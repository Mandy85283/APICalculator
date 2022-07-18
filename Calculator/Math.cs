using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Math : IMath
    {
        /// <summary>
        /// Calculator method to perform addition opertion on two integers
        /// </summary>
        /// <param name="Value1"></param>
        /// <param name="Value2"></param>
        /// <returns></returns>
        public int Addition(int Value1, int Value2)
        {
            return Value1 + Value2;
        }

        /// <summary>
        /// Calculator method to perform substraction opertion on two integers
        /// </summary>
        /// <param name="Value1"></param>
        /// <param name="Value2"></param>
        /// <returns></returns>
        public int Subtraction(int Value1, int Value2)
        {
            return Value1 - Value2;
        }

        /// <summary>
        /// Calculator method to perform multiplication opertion on two integers
        /// </summary>
        /// <param name="Value1"></param>
        /// <param name="Value2"></param>
        /// <returns></returns>
        public int Multiplication(int Value1, int Value2)
        {
            return Value1 * Value2;
        }

        /// <summary>
        /// Calculator method to perform division opertion on two integers
        /// </summary>
        /// <param name="Value1"></param>
        /// <param name="Value2"></param>
        /// <returns></returns>
        public int Division(int Value1, int Value2)
        {
            return Value1 / Value2;
        }
    }
}
