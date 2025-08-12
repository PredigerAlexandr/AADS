namespace IntervalsMerge;

public static class IntervalMergeImplementation
{
    public static int[][] Execute(int[][] intervals, int[] newInterval)
    {
        if (intervals.Length == 0)
        {
            return new int[][] { newInterval };
        }

        var left = newInterval[0];
        var right = newInterval[1];

        var result = new List<int[]>();

        var i = 0;

        while (i < intervals.Length && newInterval[0] > intervals[i][1])
        {
            result.Add(intervals[i]);
            i++;
        }

        while (i < intervals.Length && newInterval[1] >= intervals[i][0])
        {
            left = Math.Min(intervals[i][0], left);
            
            right = Math.Max(intervals[i][1], right);

            i++;
        }

        result.Add(new[] { left, right });

        while (i < intervals.Length)
        {
            result.Add(intervals[i]);
            i++;
        }

        return result.ToArray();
    }
}