# https://www.hackerrank.com/challenges/magic-square-forming/problem

pre = [
    [[8, 1, 6], [3, 5, 7], [4, 9, 2]],
    [[6, 1, 8], [7, 5, 3], [2, 9, 4]],
    [[4, 9, 2], [3, 5, 7], [8, 1, 6]],
    [[2, 9, 4], [7, 5, 3], [6, 1, 8]],
    [[8, 3, 4], [1, 5, 9], [6, 7, 2]],
    [[4, 3, 8], [9, 5, 1], [2, 7, 6]],
    [[6, 7, 2], [1, 5, 9], [8, 3, 4]],
    [[2, 7, 6], [9, 5, 1], [4, 3, 8]],
]

l = []
l.append(list(map(int, input().split())))
l.append(list(map(int, input().split())))
l.append(list(map(int, input().split())))

totals = []
for p in pre:
    total = 0
    for prow, lrow in zip(p, l):
        for i, j in zip(prow, lrow):
            if i != j:
                total += max(i, j) - min(i, j)
    totals.append(total)
print(min(totals))
