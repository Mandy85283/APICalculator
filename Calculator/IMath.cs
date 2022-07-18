using System;

namespace Calculator
{
    public interface IMath
    {
        public int Addition(int Value1, int Value2);
        public int Subtraction(int Value1, int Value2);
        public int Multiplication(int Value1, int Value2);
        public int Division(int Value1, int Value2);
    }
}
