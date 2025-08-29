namespace IntervalsMerge;

//56. Merge Intervals - дан массив интервалов, необходимо обехденить все пересекающееся интервалы.
public static class MergeIntervals
{
    public static int[][] Execute(int[][] intervals) {
        intervals = intervals.OrderBy(x=>x[0]).ToArray();

        var result = new List<int[]>();

        for(var i = 0; i<intervals.Length; i++){
            
            if(i == intervals.Length-1){
                result.Add(intervals[i]);
                continue;
            }

            if(intervals[i][1]<intervals[i+1][0]){
                result.Add(intervals[i]);
                continue;
            }

            var left = intervals[i][0];
            var right = intervals[i][1];

            while( i <= intervals.Length-2 && right >= intervals[i+1][0]){
                right = Max(intervals[i+1][1], right);
                i++;
            }

            result.Add(new int[]{left, right});
        }

        return result.ToArray();
    }

    static int Max(int first, int second ){
        if(first > second){
            return first;
        }
        return second;
    }
}