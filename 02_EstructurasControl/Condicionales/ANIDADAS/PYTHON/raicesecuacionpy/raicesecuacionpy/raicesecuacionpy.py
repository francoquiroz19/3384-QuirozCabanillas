import math

a = float(input("Ingrese a: "))
b = float(input("Ingrese b: "))
c = float(input("Ingrese c: "))

discriminante = b**2 - 4*a*c

if discriminante > 0:
    x1 = (-b + math.sqrt(discriminante)) / (2*a)
    x2 = (-b - math.sqrt(discriminante)) / (2*a)
    print("Raices reales y distintas: x1 =", x1, ", x2 =", x2)
else:
    if discriminante == 0:
        x = -b / (2*a)
        print("Raiz real doble: x =", x)
    else:
        print("No existen raices reales.")

