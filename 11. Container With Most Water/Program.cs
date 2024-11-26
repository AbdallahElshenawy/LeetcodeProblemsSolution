public class LeetcodeProblemsSolution
{
    public int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int MaxArea = 0;
        while (left < right)
        {
            int area = Math.Min(height[left],height[right])*(right - left);

            MaxArea = Math.Max(area, MaxArea);

            if (height[left] < height[right]) left++;

            else right--;
        }
        return MaxArea;
    }


}
