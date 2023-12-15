using CalculatorAPP.Repository;

ICalculatorRepository calculatorRepository = new CalculatorRepository();
Console.WriteLine(calculatorRepository.AddNumbers(1, 2));
calculatorRepository.Factorial(5);


Console.WriteLine("created feature branch");
Console.WriteLine("push code to new feature branch");
