using System.Text;

namespace Another;

/// <summary>
/// 14. Longest Common Prefix
/// </summary>
public static class LongestCommonPrefix {
    public static string Execute(string[] strs) {
        var sortArray = strs.Order().ToArray();

        var i = 0; 
        StringBuilder result = new StringBuilder();
        while(i<sortArray[0].Length){
            if(sortArray[0][i]==sortArray[^1][i]){
                result.Append(sortArray[0][i]);
                i++;
            }else{break;}
        }

        return result.ToString();
    }
}