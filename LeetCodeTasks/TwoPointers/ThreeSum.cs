namespace TwoPointers;

//задача на нахождение триплетов без повторения триплетов в плане значений чисел
public static class ThreeSum
{
    public static int[][] Execute(int[] nums)
    {
        Array.Sort(nums);
        var result = new List<int[]>();

        for(var i = 0; i < nums.Length-2; i++){
            if(i>0 && nums[i-1]==nums[i]){
                continue;
            }
            var left = i+1;
            var right = nums.Length-1;

            while(left<right){
                if(nums[i]+nums[left]+nums[right]>0){
                    right--;
                    continue;
                }
                if(nums[i]+nums[left]+nums[right]<0){
                    left++;
                    continue;
                }

                result.Add(new int[]{nums[i], nums[left], nums[right]});

                left++;

                while(nums[left-1]==nums[left]&&left<right){
                    left++;
                }
            }

        }

        return result.ToArray();
    }
}