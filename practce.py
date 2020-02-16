def find_outlier(integers):
    a = [x for x in integers if x % 2 == 0]
    b = [x for x in integers if x % 2 != 0]
    print(a)
    print(b)



print(find_outlier([5,7,8,9,3,5]));
