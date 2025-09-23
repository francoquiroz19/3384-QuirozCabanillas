num = int(input("Ingrese un numero: "))

if num % 2 != 0 and num % 5 == 0:
    print(num, "es impar y multiplo de 5.")
else:
    if num % 2 == 0 and num % 5 == 0:
        print(num, "es par y multiplo de 5.")
    elif num % 2 != 0 and num % 5 != 0:
        print(num, "es impar pero no multiplo de 5.")
    else:
        print(num, "es par y no multiplo de 5.")

