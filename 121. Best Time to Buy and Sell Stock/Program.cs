public class LeetcodeProblemsSolution
{
    public int MaxProfit(int[] prices)
    {
        int buyPrice = prices[0];
        int profit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < buyPrice)
            {
                buyPrice = prices[i];
            }
            else
            {
                int currentProfit = prices[i] - buyPrice;
                profit = Math.Max(currentProfit, profit);
            }
        }

        return profit;
    }
}