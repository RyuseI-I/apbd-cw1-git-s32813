public static class StatisticsHelper
{
    public static int Sum(this int[] values) => values.Sum();
    
    public static double Average(this int[] values) => values.Any() ? values.Average() : 0;
}