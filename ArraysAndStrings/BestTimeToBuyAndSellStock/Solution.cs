namespace ArraysAndStrings.BestTimeToBuyAndSellStock;

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        var min = prices[0];
        var max = prices[0];
        var profit = 0;

        for (var i = 1; i < prices.Length; i++)
        {
            if (prices[i] < min)
            {
                if (max - min > profit)
                    profit = max - min;

                min = prices[i];
                max = prices[i];
            }
            else if (prices[i] > max)
            {
                max = prices[i];
            }
        }

        return profit > max - min ? profit : max - min;
    }

    
    private bool IsMountain(int[] prices, int i)
    {
        if (i >= prices.Length - 1 || i <= 0)
            return false;

        return prices[i - 1] <= prices[i] && prices[i] > prices[i + 1];
    }
    
    public int MaxProfit2(int[] prices)
    {
        var minPrice = prices[0];
        var profit = 0;

        for (var i = 0; i < prices.Length - 1; i++)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
            else if (IsMountain(prices, i))
            {
                profit += prices[i] - minPrice;
                minPrice = prices[i + 1];
            }
        }

        if (prices[^1] - minPrice > 0)
        {
            profit += prices[^1] - minPrice;
        }

        return profit;
    }

    public static void Main()
    {
        Console.WriteLine(new Solution().MaxProfit2([7,1,5,3,6,4]));
        Console.WriteLine(new Solution().MaxProfit2([1,2,3,4,5]));
        Console.WriteLine(new Solution().MaxProfit2([7,6,4,3,1]));
        
        Console.WriteLine(new Solution().MaxProfit2([5,2,3,2,6,6,2,9,1,0,7,4,5,0]));
    }
}