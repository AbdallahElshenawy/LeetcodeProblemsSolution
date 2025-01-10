public class LeetcodeProblemsSolution

{ 
    public int[][] Merge(int[][] intervals)
    {
        if (intervals.Length <= 1)
            return intervals;

        // Sort the intervals by their starting point.
        intervals = intervals.OrderBy(interval => interval[0]).ToArray();

        List<int[]> result = new List<int[]>();

        int[] newInterval = intervals[0];
        result.Add(newInterval);

        foreach (int[] interval in intervals)
        {
            // If the current interval overlaps with the last interval in the result,
            // merge them by updating the end time of the last interval.
            if (interval[0] <= newInterval[1])
            {
                newInterval[1] = Math.Max(newInterval[1], interval[1]);
            }
            else
            {
                // If the current interval does not overlap, add it to the result list.
                newInterval = interval;
                result.Add(newInterval);
            }
        }

        return result.ToArray();
    }
}
