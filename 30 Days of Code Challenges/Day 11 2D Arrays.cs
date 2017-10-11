using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int[][] arr = new int[6][];
        for(int arr_i = 0; arr_i < 6; arr_i++){
           string[] arr_temp = Console.ReadLine().Split(' ');
           arr[arr_i] = Array.ConvertAll(arr_temp,Int32.Parse);
        }
        int count = -1000;
        int tempCount = 0;
        for (int i = 1; i < 5; i++) {
            for (int j = 1; j < 5; j++) {
                tempCount = arr[i-1][j-1] + arr[i-1][j] + arr[i-1][j+1] + arr[i+1][j-1] + arr[i+1][j] + arr[i+1][j+1] + arr[i][j];
                count = Math.Max(count, tempCount);
            }
        }
        Console.WriteLine(count);
    }
}
