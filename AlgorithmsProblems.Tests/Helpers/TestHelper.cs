using System;
using System.Collections;
using System.Linq;

namespace AlgorithmsProblems.Tests.Helpers;

public static class TestHelper
{
    public static void PrintResult<TInput, TExpected, TActual>(
        string problem,
        string testCase,
        TInput input,
        TExpected expected,
        TActual actual)
    {
        Console.WriteLine();
        Console.WriteLine("======================================");
        Console.WriteLine($"Problem : {problem}");
        Console.WriteLine($"Case    : {testCase}");
        Console.WriteLine("======================================");

        Console.WriteLine($"Input    : {FormatValue(input)}");
        Console.WriteLine($"Expected : {FormatValue(expected)}");
        Console.WriteLine($"Actual   : {FormatValue(actual)}");

        Console.WriteLine();

        if (AreEqual(expected, actual))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("PASS");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("FAIL");
        }

        Console.ResetColor();

        Console.WriteLine("======================================");
        Console.WriteLine();
    }

    private static string FormatValue(object? value)
    {
        if (value is null)
            return "null";

        if (value is string)
            return value.ToString()!;

        if (value is IEnumerable enumerable)
        {
            var items = enumerable
                .Cast<object?>()
                .Select(x => x?.ToString() ?? "null");

            return $"[{string.Join(", ", items)}]";
        }

        return value.ToString()!;
    }

    private static bool AreEqual(object? expected, object? actual)
    {
        if (expected is IEnumerable expectedEnumerable &&
            actual is IEnumerable actualEnumerable &&
            expected is not string &&
            actual is not string)
        {
            return expectedEnumerable
                .Cast<object?>()
                .SequenceEqual(actualEnumerable.Cast<object?>());
        }

        return Equals(expected, actual);
    }
}