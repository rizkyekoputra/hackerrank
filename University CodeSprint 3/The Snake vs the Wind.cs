using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        char d = Convert.ToChar(Console.ReadLine());
        string[] tokens_x = Console.ReadLine().Split(' ');
        int x = Convert.ToInt32(tokens_x[0]);
        int y = Convert.ToInt32(tokens_x[1]);
        // Write Your Code Here
        Dictionary<char, int[,]> direction = new Dictionary<char, int[,]>()
        {
            {'s', new int[,]{ { 1, 0 }, { 0, 1 }, { 0, -1 }, { -1, 0 } } },
            {'n', new int[,]{ { -1, 0 }, { 0, 1 }, { 0, -1 }, { 1, 0 } } },
            {'e', new int[,]{ { 0, 1 }, { 1, 0 }, { -1, 0 }, { 0, -1 } } },
            {'w', new int[,]{ { 0, -1 }, { -1, 0 }, { 1, 0 }, { 0, 1 } } },
        };
             
        int[,] area = new int[n,n];
        int[,] prioDirection = direction[d];
        area[x,y] = 1;
        for (int i = 2; i <= n * n; i++) {
            for (int j = 0; j < 4; j++) {
                int _x = x + prioDirection[j, 0];
                int _y = y + prioDirection[j, 1];
                if (_x < 0 || _y < 0 || _x >= n || _y >= n || area[_x,_y] > 0) {
                    continue;
                }
                x = _x;
                y = _y;
                area[x,y] = i;
                break;
            }
        }
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                Console.Write(area[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
}
