#Project Euler #5: Smallest multiple

# The sum of the squares of the first ten natural numbers is, 1^2 + 2^2 + ... + 10^2 = 385. The square of the sum of the first ten natural numbers is, (1 + 2 + ... + 10)^2 = 55^2 = 3025. 
# Hence the absolute difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 - 385 = 2640.
# Find the absolute difference between the sum of the squares of the first N natural numbers and the square of the sum.


#!/bin/python3

import sys
t=int(input())
while t>0:
    n=int(input())
    j=n*(n+1)*(2*n+1)//6
    m=n*(n+1)//2
    m=m*m
    print(m-j)
    t -=1