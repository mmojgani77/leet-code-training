using System.Collections.Frozen;

namespace ArraysAndStrings.RomanToInteger;

public class Solution
{
    private static readonly Dictionary<char, int> _symbols = new()
    {
        { 'I',  1 },
        { 'V',  5 },
        { 'X',  10 },
        { 'L',  50 },
        { 'C',  100 },
        { 'D',  500 },
        { 'M',  1000 },
    };
    
    public int RomanToInt(string s)
    {
        var span = s.AsSpan();
        var result = 0;
        for (var i = 0; i < span.Length; i++)
        {
            int number = _symbols[span[i]];

            if (i < span.Length - 1 && _symbols[span[i + 1]] / number is 5 or 10)
            {
                number = _symbols[span[i + 1]] - number;
                i += 1;
            }

            result += number;
        }

        return result;
    }
    
    public int RomanToInt2(string s)
    {
        var top = _symbols[s[^1]];
        var result = top;
        for (var i = s.Length - 2; i >= 0; i--)
        {
            var value = _symbols[s[i]];

            if (value < top)
            {
                value = top - value;
                result -= top;
            }

            result += value;
            top = value;
        }

        return result;
    }
    
    public int RomanToInt3(string s)
    {
        var top = s[^1] switch
        {
             'I'=>  1 ,
             'V'=>  5 ,
             'X'=>  10 ,
             'L'=>  50 ,
             'C'=>  100 ,
             'D'=>  500 ,
             'M'=>  1000 ,
        };
        var result = top;
        for (var i = s.Length - 2; i >= 0; i--)
        {
            var value = s[i] switch
            {
                'I'=>  1 ,
                'V'=>  5 ,
                'X'=>  10 ,
                'L'=>  50 ,
                'C'=>  100 ,
                'D'=>  500 ,
                'M'=>  1000 ,
            };

            if (value < top)
            {
                value = top - value;
                result -= top;
            }

            result += value;
            top = value;
        }

        return result;
    }
    
    public static void Main()
    {
        Console.WriteLine(new Solution().RomanToInt3("III"));
        Console.WriteLine(new Solution().RomanToInt3("LVIII"));
        Console.WriteLine(new Solution().RomanToInt3("MCMXCIV"));
    }
}