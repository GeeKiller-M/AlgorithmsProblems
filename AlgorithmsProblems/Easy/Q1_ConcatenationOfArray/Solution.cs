namespace AlgorithmsProblems.Easy.Q1_ConcatenationOfArray;

public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        int n = nums.Length;
        int c = n * 2;
        int[] ans = new int[c];

        for (int x = 0; x < nums.Length; x++)
        {
            ans[x] = nums[x];
            ans[x + n] = nums[x];
        }

        return ans;
    }
}