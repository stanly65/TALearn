using System;
using System.Collections.Generic;

class BinarySearch
{
    static void Main()
    {
      
        int n = int.Parse(Console.ReadLine());
        List<int> ls = new List<int>();
       
        for (int i = 0; i < n; i++)
        {
            int temp = int.Parse(Console.ReadLine());
            ls.Add(temp);
        }
        // find the m element binary search 
        int m = int.Parse(Console.ReadLine());

        int result = ls.BinarySearch(m);
     
        Console.WriteLine(result<0? -1:result);
    }
}
