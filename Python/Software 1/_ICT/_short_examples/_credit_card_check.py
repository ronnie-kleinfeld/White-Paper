card = ""
sum = 0

for i in range(16):
    digit = input()
    card += digit
    number = int(digit)
    if (i + 1) % 2 == 0:
        sum += number
    else:
        number *= 2
        if number > 9:
            number -= 9
        sum += number
print(sum)
print(card, "is", "Valid" if sum % 10 == 0 else "Invalid")
