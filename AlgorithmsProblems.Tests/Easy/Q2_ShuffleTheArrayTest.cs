using AlgorithmsProblems.Easy.Q2_ShuffleTheArray;
using AlgorithmsProblems.Tests.Helpers;

namespace AlgorithmsProblems.Tests.Easy;

public class Q2_ShuffleTheArrayTests
{
    [Theory]
[MemberData(nameof(TestCases))]
public void Shuffle_ShouldReturnExpected(int[] input, int n, int[] expected)
{
    var solution = new Solution();

    var actual = solution.Shuffle(input, n);

    TestHelper.PrintResult(
        "Q2 - Shuffle the Array",
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
        new[] {2,5,1,3,4,7},
        3,
        new[] {2,3,5,4,1,7}
    },
    new object[]
    {
        new[] {1,3,2,1},
        2,
        new[] {1,2,3,1}
    },
    new object[]
    {
        new[] {1,9,3,4,7,9,0,3},
        4,
        new[] {1,7,9,9,3,0,4,3}
    }
];
}