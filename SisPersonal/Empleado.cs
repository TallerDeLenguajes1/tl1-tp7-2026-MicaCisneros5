namespace EspacioEmpleado; //organiza la clase para poder usarla desde otros archivos

//Un enum define los valores posibles para una variable, se lo escribe por fuera porque no pertenece a un solo empleado, es como un tipo de dato nuevo
public enum Cargo
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador,
}

public class Empleado
{
    //creamos los atributos
    private string Nombre;
    private string Apellido;
    private DateTime FechaNacimiento;//DateTime: tipo de dato que guarda fechas y horas
    private char EstadoCivil;
    private DateTime FechaIngreso;
    private double SueldoBasico;
    private Cargo cargo;

    //creamos los metodos
    public int CalcularEdad()//en el ejercicio de la calculadora se utilizo Void porque no devolvia un dato, simplemete modificaba un atributo, aqui utilizamos Int porque va a deviolver un dato la edad en años enteros, en cuanto a los parentesis estos entan vasios porque no necesita resibir ningun dato
    {
        DateTime FechaActual = DateTime.Now; //obtenemos la fecha y hora actual del sitema
        int AñoActual = FechaActual.Year; //obtenemos el año de la fecha actual
        int AñoNacimiento = FechaNacimiento.Year; //obtenemos el año de la fecha de nacimiento
        int Edad = AñoActual - AñoNacimiento; //la resta nos da una edad aproximada

        //verificamos si este año ya cumplio años o tadavia no para saber la edad exacta

        if (FechaActual.Month < FechaNacimiento.Month)
        {
            Edad = Edad - 1;
        }
        if (FechaActual.Month == FechaNacimiento.Month && FechaActual.Day < FechaNacimiento.Day)
        {
            Edad = Edad - 1;
        }
        
        return Edad;
    }

    public int CalcularAntiguedad()
    {
        DateTime FechaActual = DateTime.Now;
    
        int Antiguedad = FechaActual.Year - FechaIngreso.Year;

        if (FechaActua.Month < FechaIngreso.Month)
        {
            Antiguedad = Antiguedad - 1;
        }
        if (FechaActua.Month == FechaIngreso.Month && FechaActual.Day < FechaIngreso.Day)
        {
            Antiguedad = Antiguedad - 1;
        }

        return Antiguedad;
    }

    public int CalcularAniosParaJubilarse()
    {
        int edad = CalcularEdad(); //llamamos al metodo anterior para obtener la edad actual del empleado
        int AniosParaJubilarse = 65 - edad;

        return AniosParaJubilarse;
    }

    public double CalcularSalario()
    {
        double adicional = 0;
        int antiguedad = CalcularAntiguedad();
        
        //calculamos el porcentaje
        int porcentaje;
        if (antiguedad <= 20)
        {
            porcentaje = antiguedad;
        }
        else
        {
            porcentaje = 25;
        }

        adicional = SueldoBasico * (porcentaje / 100.0); //100.0 conseva los decimales

        //ahora aumento por cargo
        //Si el cargo es Ingeniero o Especialista, el adicional se incrementa en un 50%
        if (cargo == Cargo.Ingeniero || cargo == Cargo.Especialista)
        {
            adicional = adicional * 1.5;//lo incrementa un 50%
            //adicional = adicional + (adicional * 0.5);//le suma el 50% del valor original
        }

        //ahora aumento por estado civil
        if (EstadoCivil == 'C')
        {
            adicional = adicional + 150000;
        }

        return SueldoBasico + adicional;
    }
}