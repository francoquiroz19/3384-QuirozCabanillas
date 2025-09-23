a = int(input("Ingrese a: "))
b = int(input("Ingrese b: "))
c = int(input("Ingrese c: "))

mayor = a
if b > mayor:
    mayor = b
if c > mayor:
    mayor = c

print("El mayor es:", mayor)

