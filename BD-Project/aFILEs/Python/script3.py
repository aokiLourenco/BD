import random
import json

def replace_last_two_elements(arrays):
    for array in arrays:
        if len(array) >= 2:
            array[2] = random.randint(1, 120)
            array[3] = random.randint(1, 120)
    return arrays

# Test the function
arrays = [["Dragon's Bane", 8, "Melee", "Physical", "Dragon's Fury", "Strength & Dexterity"],
["Excalibur", 2, "Melee", "Physical", "Holy Strike", "Strength"],
["Starfire Blade", 3, "Melee", "Magical", "Starfall Slash", "Intelligence"],
["Abyssal Blade", 4, "Melee", "Physical", "Abyssal Rage", "Strength"],
["Scepter of the Elements", 5, "Melee", "Magical", "Elemental Burst", "Intelligence"],
["Godsbane", 6, "Melee", "Physical", "Divine Judgment", "Strength"],
["Eldritch Orb", 7, "Ranged", "Magical", "Eldritch Blast", "Intelligence"],
["Elemental Staff", 8, "Melee", "Magical", "Elemental Wave", "Intelligence"],
["Starfall Talisman", 9, "Melee", "Magical", "Starfall Explosion", "Intelligence"],
["Primordial Orb", 10, "Ranged", "Magical", "Primordial Blast", "Intelligence"]]

modified_arrays = replace_last_two_elements(arrays)

with open('arrays.txt', 'w') as f:
    for array in modified_arrays:
        f.write(json.dumps(array) + '\n')