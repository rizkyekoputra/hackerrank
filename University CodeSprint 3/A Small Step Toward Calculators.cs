using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int solve(string opr) {
        // Complete this function
        int a = (int)Char.GetNumericValue(opr[0]);
        int b = (int)Char.GetNumericValue(opr[2]);
        if (opr[1] == '+') {
            return a+b;
        } else {
            return a-b;
        }
    }

    static void Main(String[] args) {
        string opr = Console.ReadLine();
        int result = solve(opr);
        Console.WriteLine(result);
    }
}
