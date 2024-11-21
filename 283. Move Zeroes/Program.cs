public class LeetcodeProblemsSolution
{
    public void MoveZeroes(int[] nums)
    {
        int nonZeroElement = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[nonZeroElement] = nums[i];
                nonZeroElement++;
            }
        }
        for (int i = nonZeroElement; i < nums.Length; i++)
        { nums[i] = 0; }



    }
}