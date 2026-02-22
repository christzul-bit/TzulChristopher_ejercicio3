//Programa con Repositorio 3
double descuento = 0;
double descuentoCupon = 0;
int nvlSospecha = 0;
double recargo = 0;
Console.WriteLine("Ingrese el tipo de cliente \n" +
    "1)Estudiante \n" +
    "2)Docente \n" +
    "3)Administrativo \n" +
    "4)Externo_");
int opcion = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el monto a pagar_");
double monto = double.Parse(Console.ReadLine());
Console.WriteLine("seleccione el metodo de pago \n" +
    "1)Efectivo \n" +
    "2)Tarjeta \n" +
    "3)Transferencia_");
int pago = int.Parse(Console.ReadLine());
Console.WriteLine("Posee cupon? (s/n)_");
string cupon = Console.ReadLine();
if(monto > 0 && cupon == "s" || cupon == "n")
{
    switch (opcion)
    {
        case 1:
            if(monto > 5000)
            {
                nvlSospecha += 1;
            }
            switch (pago)
            {
                case 1:
                    nvlSospecha -= 1;
                    descuento = monto * 0.1;
                    break;
                case 2:
                    descuento = monto * 0.07;
                    break;
                case 3:
                    if(monto > 200)
                    {
                        descuento = monto * 0.05;
                    }break;
                default: Console.WriteLine("Opcion invalida en el metodo de pago"); break;
            }
            break;
        case 2:
            if (monto > 6000)
            {
                nvlSospecha += 1;
            }
            switch (pago)
            {
                case 1:
                    nvlSospecha -= 1;
                    if(monto > 200)
                    {
                        descuento = monto * 0.1;
                    }break;
                case 2:
                    if(monto > 200)
                    {
                        descuento = monto * 0.07;
                    }break;
                case 3:
                    if(monto > 300)
                    {
                        descuento = monto * 0.08;
                    }break;
                default: Console.WriteLine("Opcion invalida en el metodo de pago"); break;
            }
            break;
        case 3:
            if(monto > 10000)
            {
                nvlSospecha += 2;
            }
            switch (pago)
            {
                case 1:
                    nvlSospecha -= 1;
                    if (monto > 200)
                    {
                        descuento = monto * 0.12;
                    }
                    break;
                case 2:
                    if (monto > 200)
                    {
                        descuento = monto * 0.1;
                    }
                    break;
                case 3:
                    if (monto > 300)
                    {
                        descuento = monto * 0.1;
                    }
                    break;
                default: Console.WriteLine("Opcion invalida en el metodo de pago"); break;
            }
            break;
        case 4:
            if(monto > 10000)
            {
                nvlSospecha += 2;
            }
            switch (pago)
            {
                case 1:
                    nvlSospecha -= 1;
                    if (monto > 250)
                    {
                        descuento = monto * 0.1;
                    }
                    break;
                case 2:
                    if (monto > 300)
                    {
                        descuento = monto * 0.1;
                    }
                    break;
                case 3:
                    if (monto > 350)
                    {
                        descuento = monto * 0.08;
                    }
                    break;
                default: Console.WriteLine("Opcion invalida en el metodo de pago"); break;
            }
            break;
        default: Console.WriteLine("Opcion invalida en el tipo de cliente"); break;
    }
    if(cupon == "s")
    {
        Console.WriteLine("Ingrese el primer caracter del codigo_");
        string codigoCupon = Console.ReadLine();
        Console.WriteLine("Ingrese solo la secuencia numerica del codigo_");
        int numCupon = int.Parse(Console.ReadLine());
        if(codigoCupon == "u" && numCupon %2 == 0)
        {
            descuentoCupon = monto * 0.15;
        }
        else
        {
            if(codigoCupon != "u")
            {
                nvlSospecha += 1;
            }
            if(numCupon  %2 != 0)
            {
                nvlSospecha += 1;
            }
        }
    }
    if(nvlSospecha >= 3)
    {
        Console.WriteLine($"Se a detectado una amenaza de fraude de nivel {nvlSospecha} \n" +
            $"se anularan los descuentos y se aplicara un recargo del 20%");
        descuento = 0;
        descuentoCupon = 0;
        recargo = monto * 0.2;
    }
    Console.WriteLine($"Descuento aplicado {descuento} \n" +
        $"Descuento por cupon de {descuentoCupon} \n" +
        $"recargo aplicado {recargo} \n" +
        $"El pago total es de {monto - descuento - descuentoCupon + recargo}");
}else
{
    Console.WriteLine("Valor invalido, revise sus respuestas en monto y cupon");
}