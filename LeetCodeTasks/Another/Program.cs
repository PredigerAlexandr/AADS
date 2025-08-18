using Another;

// Задача сумма двух. Необходимо в массиве найти индексы элементов, которые в сумме дают target.
var nums = new int[]{2,7,11,15};
var target = 9;
var result1 = TwoSum.Execute(nums, target);
Console.ReadKey();

// Задача заключается в том, что необходимо найти максимально длинный префикс всех строк в массиве
var strs = new string[]{"flower","flow","flight"};
var result2 = LongestCommonPrefix.Execute(strs);
Console.ReadKey();

//49. Group Anagrams - суть на вход даёт список строк, найти группы всех строк, которые составлены из одних и тех же букв
var result3 = GroupAnagrams.Execute(new []{"eat","tea","tan","ate","nat","bat"});
Console.ReadKey();