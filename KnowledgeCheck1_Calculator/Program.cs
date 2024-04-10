
using KnowledgeCheck1_Calculator;
 
var calculator = new Calculator();

string whatOperation = GetUserInstruction();

while(!whatOperation.Equals("1") && !whatOperation.Equals("2") && !whatOperation.Equals("3") && !whatOperation.Equals("4"))
{
    Console.WriteLine("Wrong input.");
    whatOperation = GetUserInstruction();
}

string[] numbers = GetUserNumbers();

double numOne;
double numTwo = 0;
bool areNumbers = double.TryParse(numbers[0], out numOne) && double.TryParse(numbers[1], out numTwo);


while(!areNumbers)
{
    Console.WriteLine("One or more of the numbers is not a number");
    numbers = GetUserNumbers();
    
} 

switch (whatOperation)
{
    case "1":

        Console.Write($"{numbers[0]} + {numbers[1]} = ");
        Console.WriteLine(calculator.Add(numOne, numTwo));
        break;

    case "2":

        Console.Write($"{numbers[0]} - {numbers[1]} = ");
        Console.WriteLine(calculator.Subtract(numOne, numTwo));
        break;

    case "3":

        Console.Write($"{numbers[0]} X {numbers[1]} = ");
        Console.WriteLine(calculator.Multiply(numOne, numTwo));
        break;

    case "4":

        Console.Write($"\n{numbers[0]} / {numbers[1]} = ");
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


string[] GetUserNumbers()
{
    Console.WriteLine($"\nEnter 2 numbers:");
    string[] inputArray = new string[2];
    string? numberOne = Console.ReadLine() ?? "none";
    string? numberTwo = Console.ReadLine() ?? "none";
    inputArray[0] = numberOne;
    inputArray[1] = numberTwo;
    return inputArray;
}

