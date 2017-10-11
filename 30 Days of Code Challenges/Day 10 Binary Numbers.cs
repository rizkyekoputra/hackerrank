using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string bin = Convert.ToString(n, 2);
        int count = 0;
        int tempCount = 0;
        foreach(var item in bin) {
            if (item == '1') {
                tempCount++;
            } else {
                tempCount =0;
            }
            count = Math.Max(tempCount, count);
        }
        Console.WriteLine(count);
    }
}
