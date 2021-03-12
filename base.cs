using System; using System.Collections.Generic; using System.Linq; 
using System.Text; 
 
namespace Clases 
{ 
    public class Agenda 
    { 
        float version = 1.0f;  public string N;
    private int S; 
 
        public void DameTuNombre() 
        { 
            if (Version == 1.0f) 
            {   Console.WriteLine("¿ Cual es tu nombre ?"); 
                N = Console.ReadLine(); 
            } 
        } 
 
        public void DameTuNombre(string nombre) 
      			  { 
         				   Nombre = nombre; 
      			  } 
        public string DameTu(string algo) 
        { 
            Console.WriteLine("Escribe tu {0,0:s}", algo); 
            	N = Console.ReadLine(); 
            return Nombre; 
        } 
        private float Version() 
        { 
            return version; 
        } 
 
    } 
 
// Programa donde se crea el objeto que usa la clase
 
    class Program 
    { 
        static void Main(string[] args) 
        { 
            int n = 3; 
            string cadena = "mi cadena"; 
 
            Agenda A = new Agenda (); 
 
         		   A.Nombre = "oscar"; 
 
            A.DameTuNombre();  A.DameTuNombre("Pepito"); 
            cadena=A.DameTu("el nombre de tu abuela"); 
 
            Console.WriteLine("Hola Mundo..." ,cadena); 
 
            Console.ReadLine();  
        } 
    }  
}
