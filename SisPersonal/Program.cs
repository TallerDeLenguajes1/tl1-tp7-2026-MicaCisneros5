using EspacioEmpleado;//Permite usar la clase Empleado desde este archivo

//creamos el arreglo de empleados
Empleado[] empleados = new Empleado[3];
//Empleado es la clase que nosotros creamos. Con Empleado[] estamos creando un arreglo que podrá guardar objetos de tipo Empleado. empleados es el nombre de la variable. new reserva memoria para el arreglo y new Empleado[3] crea un arreglo con espacio para almacenar 3 empleados. En este momento todavía no se crean los empleados, solo se crean los tres espacios donde luego los guardaremos.

double totalSalarios = 0; //para guardar el calculo total de los salarios

Empleado masCercanoJubilarse = null;//todavia no ahi emplados cragados en el sistema

//cargamos los 3 empleados
for (int i = 0; i < 3; i++)
{
    empleados[i] = new Empleado();

    Console.WriteLine("Ingrese Nombre: ");
    empleados[i].Nombre = Console.ReadLine();

    Console.WriteLine("Ingrese sueldo basico: ");
    empleados[i].SueldoBasico = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese fecha de nacimiento (yyyy-mm-dd): ");
    empleados[i].FechaNacimiento = DateTime.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese fecha de ingreso (yyyy-mm-dd): ");
    empleados[i].FechaIngreso = DateTime.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese estado civil (C/S): ");
    empleados[i].EstadoCivil = char.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese cargo (0 Auxiliar, 1 Administrativo, 2 Ingeniero, 3 Especialista, 4 Investigador): ");
    empleados[i].Cargo = (Cargos)int.Parse(Console.ReadLine()); //convertir un numero que escribe el usuario en un enum

    totalSalarios += empleados[i].CalcularSalario();

    //analizamos el empleado mas cercano a jubilarce
    if (i == 0)
    {
        masCercanoJubilarse = empleados[0]; //para realizar la comparacion de los empleados mas cercanos a jubilarce
    }

    if (i > 0 && empleados[i].CalcularAniosParaJubilarse() < masCercanoJubilarse.CalcularAniosParaJubilarse())
    {
        masCercanoJubilarse = empleados[i];
    }
    
}

Console.WriteLine("Monto Total de Salarios: " + totalSalarios);
Console.WriteLine("Empleado mas cercano a jubilarse: ");
Console.WriteLine("Nombre: " + masCercanoJubilarse.Nombre);
Console.WriteLine("Edad: " + masCercanoJubilarse.CalcularEdad());
Console.WriteLine("Antiguedad: " + masCercanoJubilarse.CalcularAntiguedad());
Console.WriteLine("Anios para jubilarce: " + masCercanoJubilarse.CalcularAniosParaJubilarse());
Console.WriteLine("Salario: " + masCercanoJubilarse.CalcularSalario());