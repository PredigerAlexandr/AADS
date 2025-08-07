var array = new[] { 6, 4, 9, 12, 445, 55, 234, 9, 6 };

var count = 0;

MergeSortImplementation(array);

foreach (var item in array)
{
    Console.Write($@"{item} ");
}




void MergeSortImplementation(int[] array)
{
    if (array.Length <= 0)
    {
        return;
    }

    var temp = new int[array.Length];

    MergeSort(array, 0, array.Length - 1, temp);
}

void MergeSort(int[] array, int left, int right, int[] temp)
{
    if (left >= right)
    {
        return;
    }

    var mid = (left + right) / 2;

    MergeSort(array, left, mid, temp);
    MergeSort(array, mid + 1, right, temp);

    Merge(array, left, mid, right, temp);
}

void Merge(int[] array, int left, int mid, int right, int[] temp)
{
    for (var i = left; i <= right; i++)
    {
        temp[i] = array[i];
    }

    var leftPtr = left;
    var rightPtr = mid + 1;

    var currentIndex = left;

    while (leftPtr <= mid && rightPtr <= right)
    {
        if (temp[leftPtr] <= temp[rightPtr])
        {
            array[currentIndex] = temp[leftPtr];
            leftPtr++;
        }
        else
        {
            array[currentIndex] = temp[rightPtr];
            rightPtr++;
        }

        currentIndex++;
    }

    while (leftPtr <= mid)
    {
        array[currentIndex] = temp[leftPtr];
        leftPtr++;
        currentIndex++;
    }
}