def get_sum(a,b):
    if (a == b):
        return a
    
    sum = 0
    x = max(a,b)
    y = min(a,b)
    
    for var in range(y,x+1):
        sum += var
        
    return sum







print(get_sum(5,7));
