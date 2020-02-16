def find_outlier(integers):
    odd = filter(lambda x: x % 2 == 1, integers)
    even = filter(lambda x: x % 2 == 0, integers)
    return odd[0] if len(odd) == 1 else even[0]




print(find_outlier([5,7,8,9,3,5]));
