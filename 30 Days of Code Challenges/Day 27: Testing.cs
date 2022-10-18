using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int t = 5;
        Random rnd = new Random();
        HashSet<int> nSet = new HashSet<int>();

        Console.WriteLine(t);
        for (int i = 0; i < t; i++)
        {
            int n = rnd.Next(3, 200);
            while (nSet.Contains(n))
            {
                n = rnd.Next(3, 200);
            }
            nSet.Add(n);
            int k = rnd.Next(1, n);
            Console.WriteLine(n + " " + k);
            int[] A = new int[n];
            for (int j = 0; j < n; j++)
            {
                A[j] = rnd.Next(-1000, 1000);
            }
            A[n / 2] = 0;
            A[0] = -1;
            A[n - 1] = 1;
            for (int j = 0; j < n; j++)
            {
                Console.Write(A[j] + " ");
            }
            Console.WriteLine();
        }
    }
}