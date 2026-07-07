using AlgorithmsProblems.Easy.Q3_MaxConsecutiveOnes;
using AlgorithmsProblems.Tests.Helpers;

namespace AlgorithmsProblems.Tests.Easy;

public class Q3_MaxConsecutiveOnesTests
{
    [Theory]
    [MemberData(nameof(TestCases))]
    public void FindMaxConsecutiveOnes_ShouldReturnExpected(int[] input, int expected)
    {
        var solution = new Solution();

        var actual = solution.FindMaxConsecutiveOnes(input);

        TestHelper.PrintResult(
            "Q3 - Max Consecutive Ones",
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
            new[] {1,0,1,1,1,1},
            4
        },
        new object[]
        {
            new[] {1,0,0,1,1,0,1,1,1},
            3
        },
        new object[]
        {
            new[] {1,1,1,1,1,0,1,1,0,1,0,1,1,1,1},
            5
        }
    ];
}