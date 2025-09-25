n = int(input("Ingrese la cantidad de numeros: "))
contador = 0

for i in range(n):
    numero = int(input(f"Ingrese el numero {i+1}: "))
    if numero > 0 and numero % 2 != 0:
        contador += 1

print("La cantidad de numeros impares y positivos es:", contador)

