namespace ArraysAndStrings.HIndex;

public class Solution
{
    public int HIndex1(int[] citations)
    {
        int maxH = citations.Length;
        int h;
        for (h = maxH; h >= 0; h--)
        {
            int count = 0;
            for (int i = 0; i < citations.Length; i++)
            {
                if (citations[i] >= h)
                    count++;
            }

            if (count >= h)
                break;
        }

        return h;
    }
    
    public int HIndex(int[] citations)
    {
        var hash = new int[citations.Length + 1];
        for (var k = citations.Length - 1; k >= 0; k--)
        {
            if (citations[k] >= citations.Length)
            {
                hash[citations.Length]++;
                continue;
            }

            hash[citations[k]]++;
        }
        
        var sum = 0;
        for (var i = hash.Length - 1; i >= 0; i--)
        {
            sum += hash[i];
            if (sum >= i)
                return i;
        }

        return 0;
    }
    
    public static void Main()
    {
        Console.Write(new Solution().HIndex([1, 0]));
        Console.WriteLine("--1--");
        
        Console.Write(new Solution().HIndex([0]));
        Console.WriteLine("--0--");
        
        Console.Write(new Solution().HIndex([1]));
        Console.WriteLine("----");

        Console.Write(new Solution().HIndex([100]));
        Console.WriteLine("----");

        Console.Write(new Solution().HIndex([3, 0, 6, 1, 5]));
        Console.WriteLine("----");

        Console.Write(new Solution().HIndex([1, 3, 1]));
        Console.WriteLine("----");
    }
}