using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAPP.Repository
{
    public class CalculatorRepository : ICalculatorRepository
    {
        public int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        //{2,4,6,9}
        public bool AreAllEvenNumbers(int[] arr)
        {
            bool result = true;
            foreach(int num in arr)
            {
                if (num % 2 != 0)
                    result = false;

                
                
            }
            return result;
        }

        public int Factorial(int n)
        {
            return Enumerable.Range(1, n).Aggregate(1, (a, b) => a * b);
        }

    }
}

