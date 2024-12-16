public class LeetcodeProblemsSolution
{
    public int CoinChange(int[] coins, int amount)
    {
        if(amount < 1) return 0;
        int[] minCoins = new int[amount + 1];

        for (int i = 1; i <= amount; i++)
        {
            minCoins[i] = int.MaxValue; 
            foreach (int coin in coins)
            {
                if(coin <= i && minCoins[i-coin] != int.MaxValue)
                {
                    minCoins[i] = Math.Min(minCoins[i], 1 + minCoins[i - coin]);
                }      
            }
        }
        if (minCoins[amount]==int.MaxValue)
            return -1;
        return minCoins[amount];
    }


}
