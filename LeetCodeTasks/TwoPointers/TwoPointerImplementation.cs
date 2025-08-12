namespace TwoPointers;

public static class TwoPointerImplementation
{
    public static int Execute(int[] height) {
        var left = 0; 
        var right = height.Length-1;
        var maxArea = 0;
        while(left<right){
            var area = (right-left)*Min(height[left],height[right]);
            if (area > maxArea)
            {
                maxArea = area;
            }

            if (height[right] > height[left])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }

    public static int Min(int firstNumber, int secondNumber){
        if(firstNumber<secondNumber){
            return firstNumber;
        }

        return secondNumber;
    }
}