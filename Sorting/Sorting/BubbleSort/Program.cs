using System;

var array = new[] { 6, 4, 9, 12, 445, 55, 234, 9, 6 };

BubbleSortImplementation(array);

foreach (var item in array)
{
    Console.Write($@"{item} ");
}

Console.WriteLine();
Console.WriteLine();

var firstArrayTask1 = new[] { 1, 2, 3, 4, 5 };
Console.WriteLine(firstArrayTask1.Length);
foreach (var item in firstArrayTask1)
{
    Console.Write($@"{item} ");
}

Console.WriteLine();
Console.WriteLine(BubbleSortTask1(firstArrayTask1, firstArrayTask1.Length));

Console.WriteLine();
Console.WriteLine();

var secondArrayTask1 = new[] { 5, 4, 3, 2, 1 };
Console.WriteLine(secondArrayTask1.Length);
foreach (var item in secondArrayTask1)
{
    Console.Write($@"{item} ");
}

Console.WriteLine();
Console.WriteLine(BubbleSortTask1(secondArrayTask1, secondArrayTask1.Length));

void BubbleSortImplementation(int[] array)
{
    for (int i = array.Length - 1; i > 0; i--)
    {
        for (var j = 0; j < i; j++)
        {
            if (array[j] > array[j + 1])
            {
                var temp = array[j + 1];
                array[j + 1] = array[j];
                array[j] = temp;
            }
        }
    }
}

//задачка - на вход подаётся массив, и кол-во элементов в нём. Нужно подсчитать кол-во перестановок в пузырьковой сортировке
int BubbleSortTask1(int[] array, int N)
{
    var swapCount = 0;

    for (var i = N - 1; i > 0; i--)
    {
        for (var j = 0; j < i; j++)
        {
            if (array[j] > array[j + 1])
            {
                var temp = array[j + 1];
                array[j + 1] = array[j];
                array[j] = temp;

                swapCount++;
            }
        }
    }

    return swapCount;
}