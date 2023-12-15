using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAPP.Repository
{
    public interface ICalculatorRepository
    {
        int AddNumbers(int num1, int num2);
        int Multiply(int num1, int num2);
        bool AreAllEvenNumbers(int[] arr);
        int Factorial(int n);

    }
}
