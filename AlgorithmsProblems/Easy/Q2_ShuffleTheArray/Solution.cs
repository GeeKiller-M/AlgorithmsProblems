namespace AlgorithmsProblems.Easy.Q2_ShuffleTheArray;

public class Solution
{
    public int[] Shuffle(int[] nums, int n)
    {
        int[] result = new int[nums.Length];
        int index = 0;

        for (int i = 0; i < n; i++)
        {
            result[index++] = nums[i];
            result[index++] = nums[i + n];
        }

        return result;
    }
}