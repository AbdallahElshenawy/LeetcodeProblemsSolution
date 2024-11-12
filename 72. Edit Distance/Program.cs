public class LeetcodeProblemsSolution
{
    public int MinDistance(string word1, string word2)
    {
        int m = word1.Length;
        int n = word2.Length;
        int[,] cost = new int[m + 1 , n + 1];
        
        for(int i = 1; i <= m; i++)
            cost[i, 0] = i;
        
        for (int j = 1; j <= n; j++)
            cost[0, j] = j;
        
        for (int i = 1; i <= m; i++)
            for (int j = 1; j <= n; j++)

                if (word1[i - 1] == word2[j-1])
                    cost[i,j] = cost[i-1 , j-1];
                else
                {
                    int topLeft = cost[i - 1, j - 1];
                    int top = cost[i - 1, j];
                    int left= cost[i, j-1];
                    cost[i,j]= Math.Min(topLeft,Math.Min(left,top)) + 1;
                }
        return cost[m,n];
                

    }
}