
renta = float(input("Ingrese el monto de su renta: "))
UIT = 5250  
limite = 7 * UIT

if renta > limite:
    impuesto = renta * 0.05
    print("Debe pagar impuesto de:", impuesto)
else:
    impuesto = 0
    print("No paga impuesto.")

