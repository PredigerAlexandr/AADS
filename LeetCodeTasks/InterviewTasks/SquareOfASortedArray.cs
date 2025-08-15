namespace InterviewTasks;

public static class SquareOfASortedArray
{
    public static int[] Execute(int[] sortedArray)
    {
        var left = 0;
        var right = sortedArray.Length - 1;

        var res = new int[sortedArray.Length];

        for (var i = sortedArray.Length - 1; i >= 0; i--)
        {
            if (Math.Pow(sortedArray[left], 2) > Math.Pow(sortedArray[right], 2))
            {
                res[i] = (int)Math.Pow(sortedArray[left], 2);
                left++;
            }
            else
            {
                res[i] = (int)Math.Pow(sortedArray[right], 2);
                right--;
            }
        }

        return res;
    }
}