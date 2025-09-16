namespace ArraysAndStrings.RemoveDuplicatesFromSortedArray;

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        short k = 1;
        for (short i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[k++] = nums[i];
            }
        }

        return k;
    }
    
    public int RemoveDuplicates2(int[] nums)
    {
        if (nums.Length <= 2)
            return nums.Length;
        
        int k = 2;
        
        for (int i = 2; i < nums.Length; i++)
        {
            if (nums[i] != nums[k - 2])
                nums[k++] = nums[i];
        }

        return k;
    }
}