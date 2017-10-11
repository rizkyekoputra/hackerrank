max_length = 10000000

def minimumLength(text, keys):
    answer = max_length
    text += " $"
    text = text.split()
    lentext = len(text)
    for i in xrange(lentext - 1):
        if text[i] not in keys:
            continue
        dup = list(keys)
        length = len(text[i])
        dup.remove(text[i])
        for j in xrange(i+1, lentext):
            length = length + 1 + len(text[j])
            if text[j] not in dup:
                continue
            dup.remove(text[j])
            if len(dup) == 0:
                answer = answer if (answer < length) else length
                break
            
    if(answer == max_length):
        return -1

    return answer