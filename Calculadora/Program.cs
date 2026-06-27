using EspacioCalculadora;//Permite usar la clase calculadora desde este archivo

Calculadora calculadora = new Calculadora();//crea un objeto de la clase Calculadora y guardalo en la variable calculadora
//Calculadora -> tipo (nuestra clase)
//calculadora -> variable
//new -> Crear un nuevo objeto de la clase Calculadora (construye una calculadora nueva)
//Calculadora() -> Quiero crear una nueva calculadora

int opcion = -1; //guarda la opcion elejida por el usuario

while (opcion != 0) //repite el menu hasta que el usuario elija salir
{
    Console.WriteLine("----- CALCULADORA -----");
    Console.WriteLine("1 - Sumar");
    Console.WriteLine("2 - Restar");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Limpiar");
    Console.WriteLine("0 - Salir");
    Console.Write("Seleccione una opcion: ");
    opcion = int.Parse(Console.ReadLine());//Lee la opcion ingresada y la convierte a entero
    double numero = 0;
    if (opcion >= 1 && opcion <= 4)
    {
        Console.Write("Ingrese un numero: ");
         numero = double.Parse(Console.ReadLine());
    }
    switch (opcion)
    {
        case 1:
        calculadora.Sumar(numero);

        Console.WriteLine("Resultado : " + calculadora.Resultado);
        break;

        case 2:
        calculadora.Restar(numero);

        Console.WriteLine("Resultado: " + calculadora.Resultado);
        break;

        case 3:
        calculadora.Multiplicar(numero);

        Console.WriteLine("Resultado: " + calculadora.Resultado);
        break;

        case 4:
        calculadora.Dividir(numero);

        Console.WriteLine("Resultado: " + calculadora.Resultado);
        break;

        case 5:
        calculadora.Limpiar();
        Console.WriteLine("La calculadora fue reiniciada correctamente");
        Console.WriteLine("Resultado: " + calculadora.Resultado);
        break;

        case 0:
        Console.WriteLine("Hasta luego");
        break;
        
        default:
        Console.WriteLine("Opcion incorrecta");
        break;
    }
    if (opcion >= 1 && opcion <= 5)
    {
        Console.Write("¿Desea realizar otra operación? (S/N): ");
        string respuesta = Console.ReadLine();
        if (respuesta == "s")
        {
            opcion = 0;
            Console.WriteLine("Gracias por usar la calculadora");
        }
    }
}
//Parse → Convierte el texto a número. Si el texto no es un número, da error.
//TryParse → Intenta convertir el texto. Si no puede, no da error y permite controlar la situación.