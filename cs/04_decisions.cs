
// sample value
int balance = 100;

// if else statement
if (balance == 100)
{
    Console.WriteLine("the value is 100");
}
else
{
    Console.WriteLine("the value is not 100.\n");
}

// if else can be replaced by ternary operator
Console.WriteLine(balance < 100 ? "the val is less than 100" : "the val is 100 and above");


// sample value
int studentGrade = 53;

// switch statement
switch (studentGrade)
{
    case 00:
    case 59:
        Console.WriteLine("failing grade");
        break;
    case 60:
        Console.WriteLine("the val is 60");
        break;
    case 61:
    case 100:
        Console.WriteLine("passing grade");
        break;
    default:
        Console.WriteLine("invalid grade");
        break;
}
