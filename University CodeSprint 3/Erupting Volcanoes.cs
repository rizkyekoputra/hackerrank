using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[n, n];
        int result = 0;
        for(int a0 = 0; a0 < m; a0++){
            string[] tokens_x = Console.ReadLine().Split(' ');
            int x = Convert.ToInt32(tokens_x[0]);
            int y = Convert.ToInt32(tokens_x[1]);
            int w = Convert.ToInt32(tokens_x[2]);
            // Write Your Code Here
            for (int mx = 0; mx < n; mx++) {
                for (int my = 0; my < n; my++) {
                    int temp = mx > my ? my : mx;
                    int power = (w - (Math.Abs(x - mx) > Math.Abs(y - my) ? Math.Abs(x - mx) : Math.Abs(y - my)));
                    array[mx,my] += power < 0 ? 0 : power;
                }
            }
        }
        for (int mx = 0; mx < n; mx++) {
            for (int my = 0; my < n; my++) {
                result = result < array[mx,my] ? array[mx,my] : result;
            }
        }
        Console.WriteLine(result);
    }
}
