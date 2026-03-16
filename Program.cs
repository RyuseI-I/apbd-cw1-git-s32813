Console.WriteLine("Program started");
Console.WriteLine("Enter number:");
int number = Convert.ToInt32(Console.ReadLine());
if (number, out int result)) {
    Console.WriteLine($"You inserted: {result}");
} else {
    Console.WriteLine("Error! It's not a number!");
}
Console.WriteLine("Enter number:");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2, out int result)) {
    Console.WriteLine($"You inserted: {result}");
} else {
    Console.WriteLine("Error! It's not a number!");
}
int number3 = Convert.ToInt32(Console.ReadLine());
if (number3, out int result)) {
    Console.WriteLine($"You inserted: {result}");
} else {
    Console.WriteLine("Error! It's not a number!");
}
int[] numbers = new[] { number, number2, number3 };
Console.WriteLine("Average: "+CalculateAverage(numbers));
Console.WriteLine("Min: "+CalculateMin(numbers));
Console.WriteLine("Max: "+CalculateMax(numbers));
public static double CalculateAverage(int[] values)
{
    return values.Average();
}

public static int CalculateMax(int[] values)
{
    return values.Max();
}

public static int CalculateMin(int[] values)
{
    return values.Min();
}