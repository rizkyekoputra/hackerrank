/* 
Project Euler #4: Largest palindrome product

A palindromic number reads the same both ways. The smallest 6 digit palindrome made from the product of two 3-digit numbers is 101101 = 143 x 707
Find the largest palindrome made from the product of two 3-digit numbers which is less than N.

*/ 


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            n = firstPalindrome(n - 1);
            Console.WriteLine(largestPalindrome(n));
        }
    }

    static int largestPalindrome(int n)
    {
        for (int i = 100; i <= 999; i++)
        {
            if(n % i == 0 && n / i >= 100 && n / i <= 999)
            {
                return n;
            }
        }

        int newN = n - 1; 

        return largestPalindrome(firstPalindrome(newN));
    }

    static int firstPalindrome(int n)
    {
        List<int> number = new List<int>();
        while(n > 0)
        {
            number.Add(n % 10);
            n /= 10;
        }
        number.Reverse();

        if (number[2] > number[3])
        {
            number[2]--;
            number[3] = number[2]; 
            number[4] = number[1]; 
            number[5] = number[0]; 
        } else if (number[2] < number[3])
        {
            number[3] = number[2]; 
            number[4] = number[1]; 
            number[5] = number[0]; 
        } else if (number[2] == number[3]) 
        {
            if (number[1] > number[4])
            {
                number[2]--;
                if (number[2] == -1) { 
                    number[2] = 9;
                    number[1]--;
                }
                number[3] = number[2];
                number[4] = number[1];
                number[5] = number[0];
            } else if (number[1] < number[4]) 
            {
                number[4] = number[1];
                number[5] = number[0];
            } else if (number[1] == number[4])
            {
                if (number[0] > number[5]) 
                {
                    number[2]--;
                    if (number[2] == -1)
                    {
                        number[2] = 9;
                        number[1]--;
                        if (number[1] == -1)
                        {
                            number[1] = 9;
                            number[0]--;
                        }
                    }
                    number[3] = number[2];
                    number[4] = number[1];
                    number[5] = number[0];
                } else
                {
                    number[5] = number[0];
                }
            }
        }
        int total = 0;
        foreach (var item in number)
        {
            total = 10 * total + item;
        }
        return total;
    }
}
