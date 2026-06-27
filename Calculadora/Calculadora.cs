namespace EspacioCalculadora; //Espacio de nombres de la clase, agrupa y organiza las clases del proyecto
public class Calculadora //declaramos la clase Calculadora, la cual es accesible desde otros archivos(public)
{
    //dentro de estas llaves iran los atributos, metodos y propiedades
    private double dato; //agregamos el atributo/campo dato, el cual guarda el resultado actual de la calculadora, esta variable pertenece a la clase. es privado porque nadie desde fuera deberia modificar el resultado
    //Todas las operaciones van a trabajar sobre ese mismo dato

    //Los metodos seran las acciones que puede hacer la calculadora
    public void Sumar(double termino)//Suma un numero al resultado actual
    {
        dato = dato + termino;
    }
    public void Restar(double termino)//Resta un numero al resultado actual
    {
        dato = dato - termino;
    }
    public void Multiplicar(double termino)//Multiplica el resultado actual
    {
        dato = dato * termino;
    }

    public void Dividir(double termino)//Divide el resultado actual
    {
        dato = dato / termino;
    }
    
    public void Limpiar() //Reinicia el resultado de la calculadora
    {
        dato = 0;
    }

    //Creamos la propiedad Resultado
    public double Resultado //la propiedad Resultado permite acceder al valor de dato sin modificarlo
    {
        get//Permite leer el valor
        {
            return dato; //devolvemos el valor que tiene la variable dato
        }
    }
}
//Clase: suele ser un sustantivo (Calculadora, Perro, Auto).
//_________________significado de cada palabra del metodo_________________
//public: Significa que podemos usar desde afuera de la clase.
//void: Este método no devuelve ningún valor, solo realiza una accion
//sumar: numbre del metodo
//(double termino): dato que recibe el metodo
//Atributo → Guarda información.
//Metodo → Hace una accion.
//Propiedad → Permite acceder a la información de forma controlada.