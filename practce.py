def maskify(cc):
    numberArray = list(cc)
    print(numberArray)
    for numbery in range(len(numberArray) - 4):
        numberArray[numbery] = '#'
        
    result = ''.join(numberArray)
    
    return result

print(maskify("1234567"))