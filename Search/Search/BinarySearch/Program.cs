var array = new int[] { 1, 45, 222, 224, 543, 1112, 3211, 11000 };

var searchIndex = BinarySearch(array, 1);

Console.WriteLine(searchIndex);

int BinarySearch(int[] array, int searchNumber)
{
    var left = 0;
    var right = array.Length - 1;

    while (true)
    {
        var mid = (left + right) / 2;
        
        if (array[mid] == searchNumber)
        {
            return mid;
        }

        if (left >= right)
        {
            break;
        }

        if (array[mid] > searchNumber)
        {
            right = mid;
        }
        else
        {
            left = mid;
        }
    }

    return -1;
}