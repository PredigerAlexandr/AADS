namespace Another;

//49. Group Anagrams - суть на вход даёт список строк, найти группы всех строк, которые составлены из одних и тех же букв.
//Проходимся циклом по массиву, сортируем каждый рассматриваемый элемент и добавляем отсортированную строку в словарь,
//перед этим проверяем нет ли уже такой отсортирвоанной строки в роли ключа в словаре и если есть, то добавлем строку с писок этого ключа.
public static class GroupAnagrams
{
    public static string[][] Execute(string[] strs) {
        var sortedStrDict = new Dictionary<string, List<string>>();

        if(strs.Length==1){
            return new []{new []{strs[0]}};
        }

        foreach(var str in strs){
            var localStr = str.ToCharArray();
            Array.Sort(localStr);
            
            var sortedStr = new string(localStr); 

            if(sortedStrDict.ContainsKey(sortedStr)){
                sortedStrDict[sortedStr].Add(str);
            }else{
                sortedStrDict.Add(sortedStr, new List<string>(){str});
            }
        }

        return sortedStrDict.Select(x=>x.Value.ToArray()).ToArray();
    }
}