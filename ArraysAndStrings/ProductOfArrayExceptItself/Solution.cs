namespace ArraysAndStrings.ProductOfArrayExceptItself;

public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var n = nums.Length;
        var result = new int[n];
        for (var k = 0; k < n; k++)
            result[k] = 1;
        
        var prefix = 1;
        var suffix = 1;
        for (var i = 1; i < n; i++)
        {
            var j = n - i - 1;
            
            prefix *= nums[i - 1];
            result[i] *= prefix;
            
            suffix *= nums[j + 1];
            result[j] *= suffix;
        }


        return result;
    }

    public static void Main()
    {
        Console.WriteLine(string.Join(", ", new Solution().ProductExceptSelf([1, 2, 3, 4])));
        
        Console.WriteLine(string.Join(", ", new Solution().ProductExceptSelf([-1,1,0,-3,3])));
        
    }
}