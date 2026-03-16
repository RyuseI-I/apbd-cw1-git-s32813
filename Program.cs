Console.WriteLine("Program started");
Console.WriteLine("Enter number:");
if (int.TryParse(Console.ReadLine(), out int result)) {
    Console.WriteLine($"You inserted: {result}");
} else {
    Console.WriteLine("Error! It's not a number!");
}

public static double CalculateAverage(int[] values)
{
    return values.Average();
}

public static int CalculateMax(int[] values)
{
    return values.Max();
}