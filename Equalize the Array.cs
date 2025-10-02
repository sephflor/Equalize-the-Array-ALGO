using System;
using System.Collections.Generic;
using System.Linq;

class Result
{
    public static int equalizeArray(List<int> arr)
    {
       
        var countDict = new Dictionary<int, int>();
        
        foreach (int num in arr)
        {
            if (countDict.ContainsKey(num))
                countDict[num]++;
            else
                countDict[num] = 1;
        }
        
        
        int maxCount = countDict.Values.Max();
        
        
        return arr.Count - maxCount;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ')
            .Select(arrTemp => Convert.ToInt32(arrTemp))
            .ToList();
        
        int result = Result.equalizeArray(arr);
        Console.WriteLine(result);
    }
}
