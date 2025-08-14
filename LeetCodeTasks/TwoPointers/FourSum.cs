namespace TwoPointers;
//18. 4Sum - задача на поиск 4 элементов в массиве для получения числа target, без повторений наборров
public static class FourSum
{
    public static int[][] Execute(int[] nums, int target)
    {
        var result = new List<int[]>();

        Array.Sort(nums);

        for (var i = 0; i < nums.Length - 3; i++)
        {
            for (var j = i + 1; j < nums.Length - 2; j++)
            {
                var left = j + 1;
                var right = nums.Length - 1;

                while (left < right)
                {
                    long currentSum = (long)nums[i] + (long)nums[j] + (long)nums[left] + (long)nums[right];

                    if (currentSum == target)
                    {
                        result.Add(new[] { nums[i], nums[j], nums[left], nums[right] });


                        while (left < right && nums[left] == nums[left + 1])
                        {
                            left++;
                        }

                        ;
                        left++;
                        continue;
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

                while (j < nums.Length - 2 && nums[j] == nums[j + 1])
                {
                    j++;
                }
            }

            while (i < nums.Length - 3 && nums[i] == nums[i + 1])
            {
                i++;
            }
        }

        return result.ToArray();
    }
}