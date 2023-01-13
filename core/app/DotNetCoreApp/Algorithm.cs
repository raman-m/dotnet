using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreApp;

public class Algorithm
{
    private readonly Dictionary<int, long> values = new Dictionary<int, long>();

    /// <summary>
    /// Input:  1, 1, 1, 3, 5, 9, 17, 31, 57
    /// <para>
    /// StepNo: 1, 2, 3, 4, 5, 6,  7,  8,  9
    /// </para>
    /// </summary>
    /// <param name="stepNo">Step or index.</param>
    public long TripleFibonacci(int stepNo = 1)
    {
        if (stepNo < 0)
            stepNo = 1;

        if (stepNo <= 3)
            return 1;

        if (values.ContainsKey(stepNo))
            return values[stepNo];

        var value = TripleFibonacci(stepNo - 3) + TripleFibonacci(stepNo - 2) + TripleFibonacci(stepNo - 1);

        var overflow = value < 0 || value >= long.MaxValue;
        value = overflow ? long.MaxValue : value;

        if (!values.ContainsKey(stepNo))
            values.Add(stepNo, value);

        return value;
    }

    private static void PrintTripleFibonacci(int step, Func<int, long> getter)
    {
        Console.Write($"Step: {step};  ");

        long value = getter(step);

        var overflow = value < 0 || value >= long.MaxValue
            ? "Overflow!!!" : "No overflow";
        var remainder = $"{Math.Log10(long.MaxValue) - Math.Log10(value)} signs from {nameof(long.MaxValue)}";
        Console.WriteLine($"Value: {value}, {overflow}, {remainder}");
    }

    public static void RunTripleFibonacci()
    {
        Console.WriteLine("\n\nAlgorithm NoFibonacci utility");

        var algo = new Algorithm();
        var step = 47;
        while (true)
        {
            PrintTripleFibonacci(step++, algo.TripleFibonacci);

            if (ConsoleUtils.AskQuit())
                return;
        }
    }
}
