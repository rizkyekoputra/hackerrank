using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution {
class Solution {
    static void Main(string[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT */
        int n = Convert.ToInt32(Console.ReadLine());
        int[] p = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        for (int i = 1; i <= n; i++) {
            int temp = Array.IndexOf(p, i) + 1;
            temp = Array.IndexOf(p, temp) + 1;
            Console.WriteLine(temp);
        }
    }
}
}
