public class LeetcodeProblemsSolution
{
    public bool ContainsDuplicate(int[] nums)
    {

        HashSet<int> Duplicate = new HashSet<int>();
        foreach (int num in nums)
        {
            if (Duplicate.Contains(num))
            {
                return true;
            }
            Duplicate.Add(num);
        }

        return false;
    }
}