def find_outlier(integers):
    determinant = [x for x in integers[:3] if x % 2 == 0]
    print(determinant)
    if len(determinant) > 1:
        # most are even, find the first odd
        mod = 1
    else:
        # most are odd, find the first even
        mod = 0
    for i in integers:
        if i % 2 == mod:
            return i





print(find_outlier([5,7,8,9,3,5]));
