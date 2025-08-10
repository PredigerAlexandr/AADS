namespace Another;

//на вход подаётся массив и число, которое должно получиться из 2 элементов массива. Нужно вывести индексы первых двух
//вхождений чисел, которые в сумме дают число target
public static class TwoSum
{
    public static int[] Execute(int[] nums, int target)
    {
        var difDict = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var dif = target - nums[i];
            
            if (difDict.ContainsKey(dif))
            {
                return new int[] { difDict[dif], i };
            }
            else
            {
                difDict.TryAdd(nums[i], i);
            }
        }

        return new int[] { };
    }
}