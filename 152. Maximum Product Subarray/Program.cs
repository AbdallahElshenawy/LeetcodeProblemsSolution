public class LeetcodeProblemsSolution
{
    public int MaxProduct(int[] nums)
    {
        int n = nums.Length;
        int leftProduct=1, rightProduct=1;
        int maxProduct = nums[0];

        for(int i = 0; i < n; i++)
        {
            if (leftProduct==0) leftProduct = 1;
            if (rightProduct==0) rightProduct = 1;
            leftProduct *= nums[i]; 
            rightProduct *= nums[n-1-i];
            maxProduct = Math.Max(maxProduct,Math.Max(leftProduct,rightProduct));
        }
        return maxProduct;

    }
}