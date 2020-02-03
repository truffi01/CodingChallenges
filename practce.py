def works(x):
    return x[1:] + x[0] + "ay"

def pig_it(text):
    result = text.split(" ")

    print(result)

    finished = map(works, result)
    finishedTwo = " ".join(finished)

    print(finishedTwo) 





print(pig_it("I love gummies!"))