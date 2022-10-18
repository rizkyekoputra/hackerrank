using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            int result = 0;
            bool flag = false;
            for (int i = 1; i < n; i++)
            {
                for (int j = i + 1; j <= n; j++)
                {
                    int temp = i & j;
                    if (temp < k)
                    {
                        result = Math.Max(result, temp);
                    }
                    else
                    {
                        Console.WriteLine(result);
                        flag = true;
                        break;
                    }
                }
                if (flag) break;
            }
            if (!flag || result == 0) Console.WriteLine(result);
            result = 0;
        }
    }
}