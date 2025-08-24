var testNotSortedArray = new[] { 5, 123, 547, 44, 1, 5889, 654, 456, 321, 7774125, 547, 111, 3215, 111, 5, 489 };
SelectionSort(testNotSortedArray);
Console.ReadKey();

void BubbleSort(int[] array)
{
    for (var i = array.Length - 1; i > 1; i--)
    {
        for (var j = 0; j < i; j++)
        {
            if (array[j] > array[j + 1])
            {
                var temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
}

void SelectionSort(int[] array)
{
    for (var i = array.Length - 1; i > 1; i--)
    {
        var maxElIndex = 0;
        for (var j = 0; j <= i; j++)
        {
            if (array[j] > array[maxElIndex])
            {
                maxElIndex = j;
            }
        }

        var tmp = array[i];
        array[i] = array[maxElIndex];
        array[maxElIndex] = tmp;
    }
}