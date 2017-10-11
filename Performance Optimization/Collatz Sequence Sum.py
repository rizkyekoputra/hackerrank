def collatzSequenceSum(T, A, B):
    def collatzSequenceLen(k):
        if k == 0:
            return 0
        if k == 1:
            return 1
        elif k % 2 == 0:
            return 1+collatzSequenceLen(k/2)
        return 1+collatzSequenceLen(3*k+1)
    
    n = 0
    result = 0
    best_len = 0
    best_num = 0
    for _ in xrange(T):
        n = (A*n + B) % 5003
        for k in xrange(1, n+1):
            cur_len = collatzSequenceLen(k)
            if cur_len >= best_len:
                best_len = cur_len
                best_num = k
        result += best_num
        best_len = 0
        best_num = 0
    return result
  