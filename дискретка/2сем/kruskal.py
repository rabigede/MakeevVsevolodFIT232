#длина, вершина, вершина
R = [(15, 1, 2), (14, 1, 5), (23, 1, 4), (19, 2, 3), (16, 2, 4),
     (15, 2, 5), (14, 3, 5), (26, 3, 6), (25, 4, 5), (23,4,7),(20,4,8),(24,5,6),(27,5,8),(18,5,9),(14,7,8),(18,8,9)]

Rs = sorted(R, key=lambda x: x[0])
U = set()   
D = {}   
T = []  

for r in Rs:
    if r[1] not in U or r[2] not in U:
        if r[1] not in U and r[2] not in U:
            D[r[1]] = [r[1], r[2]]          
            D[r[2]] = D[r[1]]   
        else:
            if not D.get(r[1]):
                D[r[2]].append(r[1])
                D[r[1]] = D[r[2]]
            else:
                D[r[1]].append(r[2])
                D[r[2]] = D[r[1]]

        T.append(r)
        U.add(r[1])
        U.add(r[2])

for r in Rs:
    if r[2] not in D[r[1]]:
        T.append(r)
        gr1 = D[r[1]]
        D[r[1]] += D[r[2]]
        D[r[2]] += gr1
print(T)
summ=0
for x in T:
    summ=x[0]+summ
print(summ)
