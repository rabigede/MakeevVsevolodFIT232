maxi = int(input())

cm = 0
for n in range(1, maxi + 1):
    for i in range(2, 18):
        if n % (2 ** i - 1) == 0:
            cm += 1

print(maxi + cm)
