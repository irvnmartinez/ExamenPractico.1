using System;
using System.Collections.Generic;

namespace Examen_Parcial_Practico_1
{
    class Program
    {

        private static List<string> Contactos = new List<string>();
        private static List<string> ApellContactos = new List<string>();
        private static List<string> TelContactos = new List<string>();

        static void Main(string[] args)
        {

            //Realizar una aplicación que permita registrar contactos telefónicos , también editarlo , listarlo y eliminarlo. Del contacto se debe pedir los siguientes datos: su nombre , apellido y numero telefónico.//
            Menu();

        }
        private static void Menu()
        {

            Console.WriteLine("Bienvenido a su confiable agenda de contactos, para continuar, seleccione una opcion\n [1] Agregar contacto\n [2] Listar contactos\n [3] Editar contacto\n [4] Eliminar contacto");
            int menu = int.Parse(Console.ReadLine());

            switch(menu)
            {
                case 1:
                    AgregarContacto();
                    break;
                case 2:
                    ListarContactos();
                    break;
                case 3:
                    EditarContactos();
                    break;
                case 4:
                    EliminarContactos();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("...Esa opcion no se encuentra disponible...");
                    Console.Clear();
                    Menu();
                    break;
            }

        }
        private static void AgregarContacto()
        {
            Console.Clear();
            Console.WriteLine("Favor ingresar el nombre del contacto que desea agregar");
            string name = Console.ReadLine();
            Console.WriteLine("¿Que apellido prefiere asignar a este contacto?");
            string lastname = Console.ReadLine();
            Console.WriteLine("Por ultimo, agregar un numero telefonico a este contacto");
            string phone = Console.ReadLine();


            if (TelContactos.Contains(phone))
            {
                Console.Clear();
                Console.WriteLine("Lo sentimos, el numero que intenta registrar ya se encuentra agendado");
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            else
            {               
                Add(Contactos, name);
                Add(ApellContactos, lastname);
                Add(TelContactos, phone);
                Console.Clear();
                Menu();
            }
        }
        private static void Add<T>(List<T> listado, T item)
        {             
            
            listado.Add(item);

       
        }
        
        private static void ListarContactos()
        {
            Console.Clear();
            Console.WriteLine("Contactos guardados:\n");
            Console.WriteLine("--------Nombres--------"); List(Contactos); Console.WriteLine("--------Apellidos-------"); List(ApellContactos); Console.WriteLine("--------Numeros Telefonicos-------"); List(TelContactos);
            Console.ReadKey();
            Console.Clear();
            Menu();
        }


        private static void List<T>(List<T> listado)
        {
            int contador = 1;
            foreach (T item in listado) 
            {
                Console.WriteLine(contador + "-" + item);
                
                contador++;
            }
        }

        private static void EditarContactos()
        {
            Console.Clear();
            Console.WriteLine("Seleccione el cotancto que desea editar\n");
            List(Contactos);
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Que parte del contacto desea editar?\n [1] Nombre\n [2] Apellido\n [3] Telefono");
            int menu = int.Parse(Console.ReadLine());
            switch(menu)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Introduzca el nuevo nombre del contacto");
                    string name = Console.ReadLine();
                    Editar(Contactos, (index - 1), name);
                    Console.Clear();
                    Menu();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Introduzca el nuevo apellido del contacto");
                    string lastname = Console.ReadLine();
                    Editar(ApellContactos, (index - 1), lastname);
                    Console.Clear();
                    Menu();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Introduzca el nuevo telefono del contacto");
                    string phone = Console.ReadLine();
                    Editar(TelContactos, (index - 1), phone);
                    Console.Clear();
                    Menu();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("...Esa opcion no se encuentra disponible...");
                    Console.Clear();
                    Menu();
                    break;
            }
            

        }

        private static void Editar<T>(List<T> listado, int index, T value )
        {
            listado[index] = value;
        }

        private static void EliminarContactos()
        {
            Console.Clear();
            Console.WriteLine("Seleccione el contacto que desea eliminar");
            List(Contactos);
            int index = int.Parse(Console.ReadLine());
            Eliminar(Contactos, (index - 1));
            Eliminar(ApellContactos, (index - 1));
            Eliminar(TelContactos, (index - 1));
            Console.Clear();
            Menu();
        }

        private static void Eliminar<T>(List<T> listado, int index, T value = default)
        {
            listado[index] = value;
        }


    }
}

  

    

