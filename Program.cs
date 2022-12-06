// See https://aka.ms/new-console-template for more information
Random rnd = new Random();
int value = rnd.Next();
Console.WriteLine("Value " + value);
if(value%2==0 )
{
    Console.WriteLine("Test will be PASSED");
}
else
{
    Console.WriteLine("Test Will fail with UnknownError");
}

for (int i = 1; i <= 1000; i++)
{
    Console.Write("[" + i + "] Hello, World!");
}

if(value%2==0 )
{
    Console.WriteLine("Success");
    return (int)MyExitCode.Success;
}
else
{
    Console.WriteLine("UnknownError");
    return (int)MyExitCode.UnknownError;
}