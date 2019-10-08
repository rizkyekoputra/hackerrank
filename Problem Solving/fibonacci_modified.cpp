# https://www.hackerrank.com/challenges/fibonacci-modified/

#!/bin/python3
import math
import os
import random
import re
import sys

# Complete the fibonacciModified function below.
def fibonacciModified(t1, t2, n):
    final = [None] * (n+1)

    final[0] = t1
    final[1] = t2
    for i in range(2,n+1):
        final[i] = final[i-2] + final[i-1]**2
        #print(final[i])
    return final[n-1]    

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    t1T2n = input().split()

    t1 = int(t1T2n[0])

    t2 = int(t1T2n[1])

    n = int(t1T2n[2])

    result = fibonacciModified(t1, t2, n)

    fptr.write(str(result) + '\n')

    fptr.close()
