def maskify(cc):
    numberArray = list(cc)
    print(numberArray)
    for number in range(len(numberArray) - 4):
        number[numberArray] = '#'
        
    result = ''.join(numberArray)
    
    return result

print(maskify("1234567"))