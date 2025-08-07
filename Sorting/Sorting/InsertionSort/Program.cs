var array = new[] { 6, 4, 9, 12, 445, 55, 234, 9, 6 };

InsertionSortImplementation(array);

foreach (var item in array)
{
    Console.Write($@"{item} ");
}

//Суть алгоритма заключается в том, что мы берём каждый раз новое число и смещаем вс элементы до него на +1, пока не найдём нужно место в последовательности
//для вставки рассматриваемого числа, чтобы оно наша последовательность была по возрастанию. По умолчания считается, что первый жлемент массива отсортировн, поэтому начинаем итераци. с 1.
void InsertionSortImplementation(int[] array)
{
    for (var i = 1; i < array.Length; i++)
    {
        int j;
        var calculationNumber = array[i];
        for (j = i; j > 0 && array[j - 1] > calculationNumber; j--)
        {
            array[j] = array[j - 1];
        }

        array[j] = calculationNumber;
    }
}
