namespace ArraysAndStrings.MajorityElement;

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        var selected = nums[0];
        var vote = 1;
        for (var i = 1; i < nums.Length; i++)
        {
            if (selected == nums[i])
            {
                vote++;
            }
            else
            {
                vote--;
            }

            if (vote < 0)
            {
                selected = nums[i];
                vote = 1;
            }
        }

        return selected;
    }
}