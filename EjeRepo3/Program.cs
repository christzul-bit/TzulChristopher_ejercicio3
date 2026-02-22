//Programa con Repositorio 3
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
