public class LeetcodeProblemsSolution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        int sum = 0;
        for (int i = 0; i < k; i++)
            sum += nums[i];
        int maxSum = sum;
        int firstElement = 0;
        int endElement = k;
        while (endElement < nums.Length) 
        {
            sum -= nums[firstElement];
            firstElement++;
            sum += nums[endElement];
            endElement++;
            maxSum = Math.Max(maxSum, sum);
        }
        return (double) maxSum / k;
        

    }
}