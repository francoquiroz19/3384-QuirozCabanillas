# Programa que pide las notas de n alumnos y calcula estadísticas

n = int(input("Ingrese la cantidad de alumnos: "))


suma_notas = 0
aprobados = 0
desaprobados = 0


mayor = -9999 
menor = 9999   


for i in range(1, n + 1):
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

