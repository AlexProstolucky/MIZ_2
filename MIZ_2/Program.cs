using System.Collections.Immutable;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = { 1, 1, 4, 5,2, 3, 6, 2, 4, 7, 3, 7, 8, 8, 9 };
        var zap =  from i in arr 
                  orderby i
                  select i;
        var res = zap.Distinct();

        foreach (var i in res) 
        {
            Console.Write($"{i} ");
        }
    }
}