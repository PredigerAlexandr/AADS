namespace InterviewTasks;

public static class BinarySearch
{
    public static int Implementation(int[] array, int target)
    {
        Array.Sort(array);

        var left = 0;
        var right = array.Length - 1;

        while (left <= right)
        {
            var mid = (left + right) / 2;

            if (array[mid] == target)
            {
                return mid;
            }

            if (array[mid] < target)
            {
                left = mid+1;
            }
            else
            {
                right = mid-1;
            }
        }

        return -1;
    }
}