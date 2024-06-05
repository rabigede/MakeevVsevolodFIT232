from math import inf


def around(x, y):
    var_list = []
    if x != 1:
        if y != 1:
            var_list.append(a[x - 2][y - 2])
        if y != m:
            var_list.append(a[x - 2][y])
        var_list.append(a[x - 2][y - 1])
    if x != n:
        if y != 1:
            var_list.append(a[x][y - 2])
        if y != m:
            var_list.append(a[x][y])
        var_list.append(a[x][y - 1])
    if y != 1:
        var_list.append(a[x - 1][y - 2])
    if y != m:
        var_list.append(a[x - 1][y])

    return min([x + 1 for x in var_list if x != -1] + [a[x - 1][y - 1]])


n, m = 11, 7
start_x, start_y = 4, 1
end_x, end_y = 11, 7
a = [[inf for _ in range(m)] for x in range(n)]
a[start_x - 1][start_y - 1] = 0
cannot = [(9, 2), (10, 2), (11, 2), (3, 3), (4, 3), (5, 3), (6, 3), (2, 5), (3, 5), (4, 5), (8, 5), (8, 6), (8, 7)]
for x, y in cannot:
    a[x - 1][y - 1] = -1

for iteration in range(n * m):
    already = False
    prev_a = a[::]
    for x in range(1, n + 1):
        for y in range(1, m + 1):
            a[x - 1][y - 1] = around(x, y)

for i in a:
    print(i)

length = a[end_x - 1][end_y - 1]
path = [(end_x, end_y)]

print()
print(length)

x = end_x
y = end_y
while not (x == start_x and y == start_y):
    for dx in range(-1, 2):
        for dy in range(-1, 2):
            if x + dx - 1 < 0 or y + dy - 1 < 0:
                continue
            if a[x + dx - 1][y + dy - 1] == length - 1:
                path.append((x + dx, y + dy))
                x += dx
                y += dy
                length -= 1

print(list(reversed(path)))
