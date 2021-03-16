using System; using System.Collections.Generic; using System.Linq; 
using System.Text; 
 

public class Agenda
{

    public string nombre;
    public string apellido;
    public string telefono;
    public string correo;
    
    //sobrecargar
    public Agenda(string pnombre, string papellido, string ptelefono, string pcorreo)
    {
        nombre = pnombre;
        apellido  = papellido;
        telefono  = ptelefono;
        correo = pcorreo;

    }
    //haciendo uso de la sobrecarga e intercambio con el usuario
    public Agenda(string pnombre)
    {
        Console.WriteLine("ingrese el nombre:");
        nombre = (Console.ReadLine());
        if (nombre.Length < 1)
            nombre = "Error sin_nombre";
        else pnombre = nombre;
        //pedir el apellido y validarlo
        Console.WriteLine("ingrese el apellido");
        apellido  = (Console.ReadLine());
        if (apellido.Length < 1)
            
            apellido  = " Error el usuario no definio el apellido";     

        // pedir el telefono y validarlo

        Console.WriteLine("ingrese el numero de telefono de  8 digitos");
        telefono = (Console.ReadLine());
        if (telefono.Length < 8)
            telefono = "Error el telefono esta incompleto";
        // pedir el  
        
        //correo
        Console.WriteLine("ingrese el Correo");
        correo  = (Console.ReadLine());
        if (correo.Length < 1)
            correo  = "no definio el correo";   
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("\n \nNOMBRE:{0}, APELLIDO:{1}, TELEFONO:{2}, CORREO:{3}", nombre, apellido, telefono, correo);
        return (sb.ToString());
    }

    static void Main(string[] args)
    {//aplicando foreground para color
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(" \t Agenda");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        
        Agenda cliente = new Agenda("");
        Console.WriteLine(cliente.ToString());
        Console.WriteLine();
        Console.ReadKey();
    }
}
