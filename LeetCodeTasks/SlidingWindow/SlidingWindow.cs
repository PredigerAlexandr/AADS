namespace SlidingWindow;

public static class SlidingWindow
{
    public static int SlidingWindowImplementation1(string s)
    {
        var containsCharDict = new Dictionary<char, int>();
        var largestCount = 0;
        var localCount = 0;


        for (int i = 0; i < s.Length; i++)
        {
            if (containsCharDict.ContainsKey(s[i]))
            {
                if (containsCharDict[s[i]] < i - localCount)
                {
                    containsCharDict[s[i]] = i;
                    localCount++;
                    continue;
                }

                if (localCount > largestCount)
                {
                    largestCount = localCount;
                }

                var difIndexCount = containsCharDict[s[i]];
                
                localCount = (i - difIndexCount);
                localCount++;
                
                containsCharDict[s[i]] = i;
                continue;
            }
            
            containsCharDict.Add(s[i], i);
            
            localCount++;
        }

        if (localCount > largestCount)
        {
            largestCount = localCount;
        }

        return largestCount;
    }
}