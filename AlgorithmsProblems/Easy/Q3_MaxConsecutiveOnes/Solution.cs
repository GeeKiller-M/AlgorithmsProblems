namespace AlgorithmsProblems.Easy.Q3_MaxConsecutiveOnes;

public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int n = nums.Length;
        int count = 0;
        int validator = 0;
        for (int i = 0; i < n; i++)
        {
            if(nums[i] == 1)
            {
                count = count + 1;
            } else if (nums[i] == 0)
            {
                if (validator < count) {
                    validator = count;
                }
                count = 0;
            }
        }
            if (validator > count)
            {
                count = validator;
            }
        return count;
    }
}