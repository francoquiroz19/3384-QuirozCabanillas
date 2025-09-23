a = int(input("Ingrese a: "))
b = int(input("Ingrese b: "))
c = int(input("Ingrese c: "))

mayor = a
medio = b
menor = c

if b > mayor:
    mayor = b
    medio = a
if c > mayor:
    mayor = c
    medio = mayor
    menor = medio

if medio < menor:
    medio, menor = menor, medio

print("Orden de mayor a menor:", mayor, medio, menor)

