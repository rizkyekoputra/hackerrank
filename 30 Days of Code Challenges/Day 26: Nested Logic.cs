using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        string[] actualString = Console.ReadLine().Split(' ');
        string[] expectedString = Console.ReadLine().Split(' ');
        int[] actualInt = Array.ConvertAll(actualString, Int32.Parse);
        int[] expectedInt = Array.ConvertAll(expectedString, Int32.Parse);
        int cost = 0;
        if (actualInt[2] > expectedInt[2]) cost += 10000;
        else if (actualInt[2] < expectedInt[2]) { }
        else {
            if (actualInt[1] > expectedInt[1]) cost += (actualInt[1] - expectedInt[1]) * 500;
            else if (actualInt[1] < expectedInt[1]) { }
            else {
                if (actualInt[0] > expectedInt[0]) cost += (actualInt[0] - expectedInt[0]) * 15;
                else if (actualInt[0] < expectedInt[0]) { }
            }
        }
        Console.WriteLine(cost);
    }
}