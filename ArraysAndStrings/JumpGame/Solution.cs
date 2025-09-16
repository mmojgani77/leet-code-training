namespace ArraysAndStrings.JumpGame;

public class Solution
{

    public bool CanJump1(int[] nums)
    {
        var destination = nums.Length - 1;

        int source, from, to;
        source = 0;

        do
        {
            if (source >= destination)
                return true;

            if (nums[source] == 0)
                return false;

            from = source + 1;
            to = source + nums[source];

            if (to >= destination)
                return true;

            source = to;
            // var maxIdx = from;
            // for (var i = from; i <= to; i++)
            // {
            //     if (nums[i] + i > nums[maxIdx] + maxIdx)
            //         maxIdx = i;
            // }
            //
            // source = maxIdx;
        } while (true);

        return true;
    }

    public bool CanJump(int[] nums)
    {
        var destination = nums.Length - 1;
        var max = 0;
        int from, to;
        Span<int> nums1 = nums;
        
        for (var i = 0; i < destination; i++)
        {
            from = i + 1;
            to = i + nums1[i];

            if (to >= destination)
                return true;

            if (to >= max)
                max = to;

            if (from > max)
                return false;
        }

        return true;
    }

    public static void Main()
    {
        Console.Write(new Solution().CanJump([1, 2, 0, 1])); // True
        Console.Write(" === True");
        Console.WriteLine("----");

        Console.Write(new Solution().CanJump([2, 0])); // True
        Console.Write(" === True");
        Console.WriteLine("----");

        Console.Write(new Solution().CanJump([3, 2, 1, 0, 4])); //False
        Console.Write(" === False");
        Console.WriteLine("----");

        Console.Write(new Solution().CanJump([0])); //True
        Console.Write(" === True");
        Console.WriteLine("----");

        Console.Write(new Solution().CanJump([1, 0, 1, 0])); // False
        Console.Write(" === False");
        Console.WriteLine("----");

        Console.Write(new Solution().CanJump([0, 2, 3])); // False
        Console.Write(" === False");
        Console.WriteLine("----");

        Console.Write(new Solution().CanJump([2, 5, 0, 0])); // True
        Console.Write(" === True");
        Console.WriteLine("----");

        // windowing
        Console.Write(new Solution().CanJump([2, 3, 1, 1, 4])); // True
        Console.Write(" === True");
        Console.WriteLine("----");
        Console.Write(new Solution().CanJump([3, 2, 1, 0, 4])); // False
        Console.Write(" === False");
        Console.WriteLine("----");
        // Console.WriteLine(new Solution().CanJump2([0,2,3]));
        
        Console.Write(new Solution().CanJump([3,0,8,2,0,0,1])); // False
        Console.Write(" === True");
        Console.WriteLine("----");
    }
}