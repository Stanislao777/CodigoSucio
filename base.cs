using System; using System.Collections.Generic; using System.Linq; 
using System.Text;

public class Agenda
{
    const int TAM_MINIMO_CADENA = 1;
    const int TAM_MINIMO_TELEFONO = 8;
    public string nombre;
    public string apellido;
    public string telefono;
    public string correo;

    public Agenda(string _nombre, string _apellido, string _telefono, string _correo)
    {
        nombre = validarTamString(_nombre, TAM_MINIMO_CADENA, "Error sin_nombre");
        apellido  = validarTamString(_apellido, TAM_MINIMO_CADENA, "Error el usuario no definio el apellido");
        telefono  = validarTamString(_telefono, TAM_MINIMO_TELEFONO, "Error el telefono esta incompleto");
        correo = validarTamString(_correo, TAM_MINIMO_CADENA, "no definio el correo");
    }
    public string validarTamString(string cadena, int tamMinimo, string errorMessage)
    {
        cadena = cadena.Length < tamMinimo? errorMessage: cadena;
        return cadena;
    }
    public override string ToString()
    {
        return $"\n \nNOMBRE:{nombre}, APELLIDO:{apellido}, TELEFONO:{telefono}, CORREO:{correo}";
    }
}
class Program{
    static public string pedirCadenaDeConsola(string mensajePedido)
    {
        Console.WriteLine(mensajePedido);
        return Console.ReadLine();
    }
    static void Main(string[] args)
    {   //aplicando foreground para color
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(" \t Agenda\n");
        Console.ForegroundColor = ConsoleColor.Yellow;

        string nombre = pedirCadenaDeConsola("ingrese el nombre:");
        string apellido = pedirCadenaDeConsola("ingrese el apellido:");
        string telefono = pedirCadenaDeConsola("ingrese el numero de telefono de  8 digitos:");
        string correo = pedirCadenaDeConsola("ingrese el Correo:");

        Agenda cliente = new Agenda(nombre, apellido, telefono, correo);
        Console.WriteLine(cliente.ToString());

        Console.WriteLine();
        Console.ReadKey();
    }
}