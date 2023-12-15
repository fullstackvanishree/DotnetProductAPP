using CalculatorAPP.Repository;

ICalculatorRepository calculatorRepository = new CalculatorRepository();
Console.WriteLine(calculatorRepository.AddNumbers(1, 2));
calculatorRepository.Factorial(5);