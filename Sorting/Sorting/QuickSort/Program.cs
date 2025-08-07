var array = new[] { 6 };

QuickSortImplementation(array);

foreach (var item in array)
{
    Console.Write($@"{item} ");
}


void QuickSortImplementation(int[] array)
{
    QuickSort(array, 0, array.Length-1);
}

void QuickSort(int[] array, int left, int right)
{
    if (left >= right)
    {
        return;
    }

    var pivot = right;
    var i = left - 1;

    for (var j = left; j < right; j++)
    {
        if (array[j] <= array[pivot])
        {
            i++;
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }

    var tmp = array[i+1];
    array[i+1] = array[pivot];
    array[pivot] = tmp;
    
    QuickSort(array, left, i);
    QuickSort(array, i+2, right);
}