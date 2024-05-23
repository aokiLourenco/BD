import csv

with open('MOCK_DATA.csv', 'r') as file:
    reader = csv.reader(file)
    for row in reader:
        new_row = row
        out = f'[{new_row[0]}, {new_row[1]}, {new_row[2]}, {new_row[3]}, {new_row[4]}, {new_row[5]}],'
        save = open('output.txt', 'a')
        save.write(out + '\n')