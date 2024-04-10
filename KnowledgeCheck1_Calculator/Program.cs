
using KnowledgeCheck1_Calculator;
using System.Runtime.ExceptionServices;

var calculator = new Calculator();

string whatOperation = GetUserInstruction();

while(!whatOperation.Equals("1") && !whatOperation.Equals("2") && !whatOperation.Equals("3") && !whatOperation.Equals("4"))
{
    Console.WriteLine("Wrong input.");
    whatOperation = GetUserInstruction();
}

(string one, string two) numbers = GetUserNumbers();


double numOne;
double numTwo = 0;
bool areNumbers = double.TryParse(numbers.one, out numOne) && double.TryParse(numbers.two, out numTwo);


while(!areNumbers)
{
    Console.WriteLine("One or more of the numbers is not a number");
    numbers = GetUserNumbers();
    
} 

switch (whatOperation)
{
    case "1":

        Console.Write($"{numbers.one} + {numbers.two} = ");
        Console.WriteLine(calculator.Add(numOne, numTwo));
        break;

    case "2":

        Console.Write($"{numbers.one} - {numbers.two} = ");
        Console.WriteLine(calculator.Subtract(numOne, numTwo));
        break;

    case "3":

        Console.Write($"{numbers.one} X {numbers.two} = ");
        Console.WriteLine(calculator.Multiply(numOne, numTwo));
        break;

    case "4":

        Console.Write($"\n{numbers.one} / {numbers.two} = ");
        Console.WriteLine(calculator.Divide(numOne, numTwo));
        break;


    default:
        Console.WriteLine("Unknown Error.");
        break;
}




Console.WriteLine();


string GetUserInstruction()
{
    Console.WriteLine(
    """
    Hello....
    Press 1 for addition,
    2 for subtraction, 
    3 for multiplication,
    or 4 for division:
    """
    );

    string? userInstruction = Console.ReadLine() ?? "0";
    return userInstruction;        
}


(string first, string second) GetUserNumbers()
{
    Console.WriteLine($"\nEnter 2 numbers:");
    string? numberOne = Console.ReadLine() ?? "none";
    string? numberTwo = Console.ReadLine() ?? "none";
    return (numberOne, numberTwo);
}

