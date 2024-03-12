// Exception handling uses the try, catch, and finally keywords.
// Exceptions are created by using the throw keyword.

int x = 300;
int y = 0;
int result = 0;

// try catch block facilitates error checking
try
{

    // user-defined exceptions
    if (x > 100)
    {
        throw new ArgumentOutOfRangeException("x",
            "\n\n x must be less than 100 \n\n");
    }

    result = x / y;
    Console.WriteLine($"result = {result}");

}
catch (DivideByZeroException e)
{
    Console.WriteLine($"\n\n {e.Message} \n\n");
}
catch (ArgumentOutOfRangeException e2)
{
    Console.WriteLine($"\n\n {e2.Message} \n\n");
}
finally // this block will always run
{
    Console.WriteLine("Clean up resources here");
}
