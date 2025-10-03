
n = int(input("Ingrese la cantidad de alumnos: "))


nota = float(input("Ingrese la nota del alumno 1: "))

suma_notas = nota
aprobados = 1 if nota >= 11 else 0
desaprobados = 0 if nota < 11 else 1

mayor = nota
menor = nota

for i in range(2, n + 1):
    nota = float(input(f"Ingrese la nota del alumno {i}: "))
    
    suma_notas += nota
    
    if nota >= 11:
        aprobados += 1
    else:
        desaprobados += 1
    
    if nota > mayor:
        mayor = nota
    if nota < menor:
        menor = nota


promedio = suma_notas / n

print("\nResultados:")
print("Promedio grupal:", promedio)
print("Numero de aprobados:", aprobados)
print("Numero de desaprobados:", desaprobados)
print("Nota mas alta:", mayor)
print("Nota mas baja:", menor)

