public class LeetcodeProblemsSolution
{
    public long MaximumSubarraySum(int[] nums, int k)
    {

        long maxSum = 0;
        long currentSum = 0;
        HashSet<int> windowElements = new HashSet<int>();
        int start = 0;

        for (int end = 0; end < nums.Length; end++)
        {
            while (windowElements.Contains(nums[end]) || windowElements.Count >= k)
            {
                windowElements.Remove(nums[start]);
                currentSum -= nums[start];
                start++;
            }

            windowElements.Add(nums[end]);
            currentSum += nums[end];

            if (windowElements.Count == k)
            {
                maxSum = Math.Max(maxSum, currentSum);
            }
        }

        return maxSum;
    }

}