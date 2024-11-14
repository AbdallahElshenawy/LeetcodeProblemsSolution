public class LeetcodeProblemsSolution
{
    public int LongestCommonSubsequence(string text1, string text2)
    {
       int m = text1.Length;
       int n = text2.Length;
       int[,] result = new int[m+1, n+1];
       
        for (int i = 1; i <=m; i++)
            for (int j = 1; j <=n; j++)
            {
                if (text1[i-1] == text2[j-1])
                    result[i,j] = result[i-1,j-1] + 1;
                else
                    result[i,j]= Math.Max(result[i - 1, j], result[i,j-1]);
            }
        return result[m,n];
    }
}