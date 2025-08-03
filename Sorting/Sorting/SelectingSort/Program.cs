var array = new[] { 6, 4, 9, 12, 445, 55, 234, 9, 6 };

SelectionSortImplementation(array);

foreach (var item in array)
{
    Console.Write($@"{item} ");
}
Console.WriteLine();
Console.WriteLine();

var arrayTask1 = new[] { 5, 3, 6, 2, 10, 8 };

SelectionSortTask1(arrayTask1, 5);

foreach (var item in arrayTask1)
{
    Console.Write($@"{item} ");
}

void SelectionSortImplementation(int[] array)
{
    for (var i = array.Length - 1; i > 0; i--)
    {
        var largestNumIndex = 0;

        for (var j = 0; j <= i; j++)
        {
            if (array[largestNumIndex] < array[j])
            {
                largestNumIndex = j;
            }

            if (j == i)
            {
                var temp = array[j];
                array[j] = array[largestNumIndex];
                array[largestNumIndex] = temp;
            }
        }
    }
}

//задача - остсортировать массив так, чтобы элементы с определённом делителем оставались на своём порядковом месте.
void SelectionSortTask1(int[] array, int del)
{
    var end = false;
    for (var i = array.Length - 1; i > 0; i--)
    {
        int largestNumIndex = -1;
        
        for (var k = 0; k <= i; k++)
        {
            if (array[k] % del != 0)
            {
                largestNumIndex = k;
                break;
            }

            if (largestNumIndex == -1 && k==i)
            {
                end = true;
            }
        }

        if (end)
        {
            return;
        }
        
        for (var j = 0; j <= i; j++)
        {
            if (array[largestNumIndex] < array[j])
            {
                if (array[j] % del == 0)
                {
                    continue;
                }

                largestNumIndex = j;
            }

            if (j == i)
            {
                var temp = array[j];
                array[j] = array[largestNumIndex];
                array[largestNumIndex] = temp;
            }
        }
    }
}