using System.Xml.Xsl;

var testNotSortedArray = new[] { 5, 123, 547, 44, 1, 5889, 654, 456, 321, 7774125, 547, 111, 3215, 111, 5, 489 };
QuickSort2(testNotSortedArray);
Console.ReadKey();
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

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

void InsertionSort(int[] array)
{
    for (var i = 1; i < array.Length; i++)
    {
        var currentNumber = array[i];
        var j = i;
        while (j > 0 && array[j - 1] > currentNumber)
        {
            array[j] = array[j - 1];
            j--;
        }

        array[j] = currentNumber;
    }
}

void MergeSort(int[] array)
{
    MergeSort(array, 0, array.Length - 1, new int[array.Length]);

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
            if (temp[leftPtr] < temp[rightPtr])
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
}

void QuickSort(int[] array)
{
    QuickSort(array, 0, array.Length - 1);

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
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, pivot);

        QuickSort(array, left, i);
        QuickSort(array, i + 2, right);
    }
}

void MergeSort2(int[] array)
{
    MergeSort(array, 0, array.Length - 1, new int[array.Length]);

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
            if (temp[leftPtr] < temp[rightPtr])
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
}

void QuickSort2(int[] array)
{
    QuickSort(array, 0, array.Length-1);
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
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, pivot);
        
        QuickSort(array, left, i);
        QuickSort(array, i+2, right);
    }
}

void Swap(int[] array, int firstIndex, int secondIndex)
{
    var temp = array[firstIndex];
    array[firstIndex] = array[secondIndex];
    array[secondIndex] = temp;
}