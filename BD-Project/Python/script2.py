with open('output.txt', 'r') as file:
    lines = file.readlines()

with open('output.txt', 'w') as file:
    for i, line in enumerate(lines, start=1):
        file.write(f'array{i} = {line}')