i=int(input())
c=0
while i!=1:
    c+=1
    if i%2:
        i=(i*3)+1
    else:
        i=i/2
print(c+1)
