using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crear lista de animales y sus nombres
            Caballo miCaballo = new Caballo("Capataz");
            Humano miHumano = new Humano("Ludwin");
            Gorila miGorila = new Gorila("Kong");
            Ballena miBallena = new Ballena("Willy");
            Cocodrilo miCocodrilo = new Cocodrilo("Hera");

            Mamifero[] almacenAnimales = new Mamifero[4];
            almacenAnimales[0] = miCaballo;
            almacenAnimales[1] = miHumano;
            almacenAnimales[2] = miGorila;
            almacenAnimales[3] = miBallena;

            for(int i = 0; i < 3; i++)
            {
                almacenAnimales[i].pensar();
            }

            Mamifero miMamifero = new Mamifero("");
            miMamifero.pensar();

            miCaballo.cuidarCrias();
            miHumano.getNombre();
            miGorila.trepar();

        }

    }
    //crear clase abstracta de animales
    abstract class Animales
    {
        public void respirar()
        {
            Console.WriteLine("Soy Capaz de respirar");
        }

        public abstract void getNombre();
    }
    //id por el que llamaremos a los animales terrestres en una clase o metodo
    interface IAnimalesTerrestres
    {
        int numeroPatas();
    }
    //crear clase de reptiles
    class Reptil:Animales
    {
        public Reptil(String nombre)
        {
            String nombreSerVivo = nombre;
        }

        public override void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es: " + nombreSerVivo);
        }

        private String nombreSerVivo;
    }
    //crear clase de mamiferos y lo que pueden realizar
    class Mamifero :Animales
    {
        public Mamifero(String nombre)
        {
            String nombreSerVivo = nombre;
        }


        public void pensar()
        {
            Console.WriteLine("Pensamientos básico instintivos");
        }
        
        public void cuidarCrias()
        {
            Console.WriteLine("Cuidar de las crias hasta que se valgan por si solar");
        }

       
        public override void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es: " + nombreSerVivo);
        }

        private String nombreSerVivo;


    }
    //crear clase de ballena y las funciones que puede realizar el ser vivo
    class Ballena : Mamifero
    {
        public Ballena(String nombreBallena) : base(nombreBallena)
        {

        }

        public void nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }
    }
    //crear clase de caballo y las funciones que puede realizar el ser vivo
    class Caballo : Mamifero, IAnimalesTerrestres
{
    public Caballo(String nombreCaballo):base(nombreCaballo)
    {

    }

    public void galopar()
        {
            Console.WriteLine("Soy Capaz de galopar");
        }

    public int numeroPatas()
        {
            return 4;
        }

    }

    class Humano: Mamifero
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {

        }
        
        public void pensar()
        {
            Console.WriteLine("Soy capaz de pensar ¿?");
        }
    }
    //crear clase de gorila y las funciones que puede realizar el ser vivo
    class Gorila :Mamifero, IAnimalesTerrestres
    {
        public Gorila(String nombreGorila) : base(nombreGorila)
        {

        }
        
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
        public int numeroPatas()
        {
            return 2;
        }
    }
    //crear clase de cocodrilo y las funciones o caracteristicas que puede realizar el ser vivo
    class Cocodrilo :Reptil,IAnimalesTerrestres
    {
        public Cocodrilo(String nombreCocodrilo) : base(nombreCocodrilo)
        {

        }
        
        public void muerde()
        {
            Console.WriteLine("Soy Capaz de morder");
        }
        public int numeroPatas()
        {
            return 4;
        }
    }


}
