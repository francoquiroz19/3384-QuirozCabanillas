print("Calculando promedio de notas, nota>=12 sera aprobado")

nota1 = int(input("Ingresar primera nota: "))
nota2 = int(input("Ingresar segunda nota: "))
nota3 = int(input("Ingresar tercera nota: "))
nota4 = int(input("Ingresar cuarta nota: "))

prom = (nota1 + nota2 + nota3 + nota4) / 4

if prom >= 12:
    print(f"nota: {prom} APROBADO")
else:
    print(f"nota: {prom} DESAPROBADO")

