using TwoPointers;

//Container With Most Water - суть задачи, что кадждый индекс массива это высота границы для воды, нужно найти максимально большую площадь покрытия воды в пределах массива,
var array = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
var result1 = TwoPointerImplementation.Execute(array);
Console.ReadKey();

//15. 3Sum - суть заключается в нахгождения триплетов на массиве, которые в сумме дают 0. триплеты не должны повторяться.
var result2 = ThreeSum.Execute(new[] { -1, 0, 1, 2, -1, -4 });
Console.ReadKey();

//16. 3Sum Closest - суть в том, чтобы найти максимально близкую сумму триплета к числу target
var result3 = ThreeSumClosest.Execute(new[] { -1, 2, 1, -4 }, 1);
Console.ReadKey();

//18. 4Sum - задача на поиск 4 элементов в массиве для получения числа target, без повторений наборров
var result4 = FourSum.Execute(new[]{1,0,-1,0,-2,2}, 0);
Console.ReadKey();