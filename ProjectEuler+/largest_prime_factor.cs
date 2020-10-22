/* 
Project Euler #3: Largest prime factor

The prime factors of 13195 are 5, 7, 13 and 29.
What is the largest prime factor of a given number N?

*/ 


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            long n = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(primeFactor(n));
        }
    }
    
    static long primeFactor(long n) {
        while (n % 2 == 0) {
            n = n / 2;
        }
        if (n == 1) {
            return 2;
        }
        int i;
        for(i = 3; i <= Math.Sqrt(n); i = i + 2) {
            while (n % i == 0) {
                n = n / i;
            }
        }
        if (n > 2) {
            return n;
        } else {
            return i-2;
        }
    }
}