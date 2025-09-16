namespace ArraysAndStrings.RotateArray;

public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        k %= nums.Length;
        var lastIdx = nums.Length - 1;
        Reverse(nums, 0, lastIdx);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, lastIdx);
    }

    public void Reverse(int[] nums, int i, int j)
    {
        while (i < j)
        {
            (nums[i], nums[j]) = (nums[j], nums[i]);
            j--;
            i++;
        }
    }
    
    public static void Main()
    {
        int[] arr = [1, 2, 3, 4, 5, 6, 7];
        int[] result = [5, 6, 7, 1, 2, 3, 4];
        new Solution().Rotate(arr, 3);
        Console.WriteLine(arr.SequenceEqual(result));
    }
}