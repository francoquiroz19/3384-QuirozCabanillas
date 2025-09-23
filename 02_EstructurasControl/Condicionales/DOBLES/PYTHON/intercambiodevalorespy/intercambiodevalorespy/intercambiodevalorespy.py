
a = int(input("Ingrese el valor de a: "))
b = int(input("Ingrese el valor de b: "))


if a > b:
    a, b = b, a
else:
   
    a += 1
    b += 1

print("a =", a)
print("b =", b)
