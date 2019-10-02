#https://www.hackerrank.com/challenges/circular-array-rotation/problem

n, k, q = map(int, input().split())
a = list(map(int, input().split()))
k = k % n
op = a[n-k:] + a[:n-k]
for _ in range(q):
    print(op[int(input())])
