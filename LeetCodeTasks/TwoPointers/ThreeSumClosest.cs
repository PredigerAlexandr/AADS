namespace TwoPointers;

public static class ThreeSumClosest
{
    public static int Execute(int[] nums, int target)
    {
        var closestNumber = 150000;
        Array.Sort(nums);


        for (var i = 0; i < nums.Length - 2; i++)
        {
            var left = i + 1;
            var right = nums.Length - 1;
            while (left < right)
            {
                var currentSum = nums[i] + nums[left] + nums[right];
                if (Math.Abs(closestNumber - target) > Math.Abs(currentSum - target))
                {
                    closestNumber = currentSum;
                }

                if (currentSum == target)
                {
                    return target;
                }

                if (currentSum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

        return closestNumber;
    }
}