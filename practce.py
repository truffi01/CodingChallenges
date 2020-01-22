python 

students = [['Harry', 37.21], ['Berry', 37.21], ['Tina', 37.2], ['Akriti', 41], ['Harsh', 39]]

#Given the names and grades for each student in a Physics class of  students, store them in a nested list and print the name(s) of any student(s) having the second lowest grade.

for _ in range(int(raw_input())):
    name = raw_input()
    score = float(raw_input())

n=int(input())
arr=[[input(),float(input())] for _ in range(0,n)]
arr.sort(key=lambda x: (x[1],x[0]))
names = [i[0] for i in arr]
marks = [i[1] for i in arr]
min_val=min(marks)
while marks[0]==min_val:
    marks.remove(marks[0])
    names.remove(names[0])    
for x in range(0,len(marks)):
    if marks[x]==min(marks):
        print(names[x])



