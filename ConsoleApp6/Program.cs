while (true)
{
    try
    {
        Console.WriteLine("Enter the 2 numbers you want to divide(a/b)");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = a / b;
        int c1 = a % b;
        Console.WriteLine("Dividing these numbers, it turned out: " + c + ", " + c1);
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("An error has occurred: You can't divide by zero!");
    }
}