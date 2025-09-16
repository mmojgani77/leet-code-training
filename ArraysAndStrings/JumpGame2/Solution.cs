namespace ArraysAndStrings.JumpGame2;

public class Solution
{
    public int Jump1(ReadOnlySpan<int> nums)
    {
        var destination = nums.Length - 1;
        var steps = 0;
        var maxIdx = 0;
        int j;
        for (var i = 0; i < destination; i++)
        {
            var to = i + nums[i];

            if (to >= destination)
                return steps + 1;

            for (j = i + 1; j <= to; j++)
            {
                if (j + nums[j] > maxIdx + nums[maxIdx])
                {
                    maxIdx = j;
                }
            }

            i = maxIdx - 1;
            steps++;
        }

        return steps;
    }

    public int Jump(ReadOnlySpan<int> nums)
    {
        var destination = nums.Length - 1;
        var steps = 0;
        var farthest = 0;
        var currentEnd = 0;
        
        for (var i = 0; i < destination; i++)
        {
            var to = i + nums[i];

            if (to > farthest)
                farthest = to;

            if (i != currentEnd) continue;
            
            steps++;
            currentEnd = farthest;

            if (currentEnd >= destination)
                break;
        }

        return steps;
    }

    public static void Main()
    {
        Console.Write(new Solution().Jump([2, 3, 1, 1, 4]));
        Console.WriteLine("----");

        Console.Write(new Solution().Jump([2, 3, 0, 1, 4]));
        Console.WriteLine("----");

        Console.Write(new Solution().Jump([7, 0, 9, 6, 9, 6, 1, 7, 9, 0, 1, 2, 9, 0, 3]));
        Console.WriteLine("---- 2");
    }
}