using AlgorithmsProblems.Easy.Q1_ConcatenationOfArray;
using AlgorithmsProblems.Tests.Helpers;

namespace AlgorithmsProblems.Tests.Easy;

public class Q1_ConcatenationOfArrayTests
{
    [Theory]
[MemberData(nameof(TestCases))]
public void GetConcatenation_ShouldReturnExpected(int[] input, int[] expected)
{
    var solution = new Solution();

    var actual = solution.GetConcatenation(input);

    TestHelper.PrintResult(
        "Q1 - Concatenation of Array",
        "Theory",
        input,
        expected,
        actual);

    Assert.Equal(expected, actual);
}

public static IEnumerable<object[]> TestCases =>
[
    new object[]
    {
        new[] {1,2,1},
        new[] {1,2,1,1,2,1}
    },
    new object[]
    {
        new[] {1,3,2,1},
        new[] {1,3,2,1,1,3,2,1}
    },
    new object[]
    {
        new[] {1,9,0,3},
        new[] {1,9,0,3,1,9,0,3}
    }
];
}