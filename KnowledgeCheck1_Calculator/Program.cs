
using KnowledgeCheck1_Calculator;
 
var calculator = new Calculator();
string whatOpertion = GetUserInstruction();
string[] numbers = GetUserNumbers();
bool areIntegers = int.TryParse(numbers[0], out int numOne) && int.TryParse(numbers[1], out int numTwo);

switch (whatOpertion)
{
    case "1":
        if(areIntegers)
        {
            numTwo = int.Parse(numbers[1]);
            Console.Write($"{numbers[0]} + {numbers[1]} = ");
            Console.WriteLine(calculator.Add(numOne, numTwo));
        }
        else
        {
            Console.WriteLine("One or more of the numbers is not an int");
        }
        break;

    case "2":
        if(areIntegers)
        {
            numTwo = int.Parse(numbers[1]);
            Console.Write($"{numbers[0]} - {numbers[1]} = ");
            Console.WriteLine(calculator.Subtract(numOne, numTwo));
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("One or more of the numbers is not an int");
        }
        break;

    case "3":
        if(areIntegers)
        {
            numTwo = int.Parse(numbers[1]);
            Console.Write($"{numbers[0]} X {numbers[1]} = ");
            Console.WriteLine(calculator.Multiply(numOne, numTwo));
        }
        else
        {
            Console.WriteLine("One or more of the numbers is not an int");
        }
        break;

    case "4":
        if(areIntegers)
        {
            numTwo = int.Parse(numbers[1]);
            Console.Write($"\n{numbers[0]} / {numbers[1]} = ");
            Console.WriteLine(calculator.Divide(numOne, numTwo));
        }
        else
        {
            Console.WriteLine("One or more of the numbers is not an int");
        }
        break;
        

    default:
        Console.WriteLine("Unknown input");
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
    Console.WriteLine($"\nEnter 2 integers:");
    string[] inputArray = new string[2];
    string? numberOne = Console.ReadLine() ?? "none";
    string? numberTwo = Console.ReadLine() ?? "none";
    inputArray[0] = numberOne;
    inputArray[1] = numberTwo;
    return inputArray;
}

