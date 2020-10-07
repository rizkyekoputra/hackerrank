/* 

Project Euler #5: Smallest multiple

2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
What is the smallest positive number that is evenly divisible(divisible with no remainder) by all of the numbers from 1 to N?

*/ 

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        int[] sieve = new int[51];
        List<int> primes = new List<int>();
        
        for (int i = 2; i <= 50; i++) {
            if (sieve[i] == 0) {
                primes.Add(i);
                for (int j = i*i; j <= 50; j += i) {
                    sieve[j] = 1;
                }
            }
        }
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            ulong num = 1;
            for (int i = 0; i < primes.Count; i++){
                if (primes[i] > n) {
                    break;
                }
                num *= (ulong)Math.Pow(primes[i],logarithm(primes[i],n));
            }
            Console.WriteLine(num);
        }
    }
    
    static int logarithm(int bases, int x) {
        return (int)(Math.Log(x)/Math.Log(bases)); 
    }
}
