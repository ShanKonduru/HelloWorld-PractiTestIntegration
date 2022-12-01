// See https://aka.ms/new-console-template for more information
Random rnd = new Random(10);
int value = rnd.Next(1, 10);

for (int i = 1; i <= 1000; i++)
{
    Console.WriteLine(i + " Hello, World!");
}

if(value<=5 )
{
    Console.WriteLine("Success");
    return (int)MyExitCode.Success;
}
else
{
    Console.WriteLine("UnknownError");
    return (int)MyExitCode.UnknownError;
}