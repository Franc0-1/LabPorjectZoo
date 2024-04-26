using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace zoologico2_2024
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal a = new Animal("Leon", "Felino", "Carne");

            Cuidador c = new Cuidador(56565);
            c.nombre = "Pablo";
            c.legajo = 234353;



            z.AgregarAnimal(new ave("Agila", "Ave", "carne"));
            z.AgregarAnimal(new mamifero("Elefante", "Paquidermo", "pasto"));
            z.AgregarAnimal(new mamifero("Hiena", "Hiena", "carne"));
            z.AgregarAnimal(new pez("Tiburon", "Pez", "Carne"));
            z.AgregarAnimal(new PlantaCarnivora("planta carnivora", "Planta", "Carne"));

            //z.poblacion();

            //Console.WriteLine("****************************************");

            //z.lista_cuidadores[0].alimentar(z.lista_animales);

            //Console.WriteLine("Hello World!");
            int opcion = 0;
            while (opcion != 6)
            {
                Console.WriteLine("Por favor, selecciona una opción:");
                Console.WriteLine("1. Agregar animal");
                Console.WriteLine("2. Eliminar animal");
                Console.WriteLine("3. Actualizar animal");
                Console.WriteLine("4. Mostrar animales");
                Console.WriteLine("5. Salir");
                Console.WriteLine("6. Terminar programa");

                opcion = int.Parse(Console.ReadLine());

                if (opcion <= 5)
                {
                    switch (opcion)
                    {z
                        case 1:
                            // Aquí puedes agregar el código para agregar un animal
                            Console.WriteLine("Que Especie de animal es");
                            string especie = Console.ReadLine();
                            Console.WriteLine("Cual es el nombre del animal");
                            string nombre = Console.ReadLine();
                            Console.WriteLine("Cual es el tipo de comida del animal");
                            string comida = Console.ReadLine();
                            z.AgregarAnimal(new Animal(nombre, especie, comida));
                            break;
                        case 2:
                            Console.WriteLine("Que animal desea eliminar");
                            z.poblacion();

                            String nombreAnimal = Console.ReadLine();
                            Animal animalAEliminar = (Animal)z.lista_animales.FirstOrDefault(n => n.nombre == nombreAnimal);

                            z.EliminarAnimal(animalAEliminar);
                            Console.WriteLine("nueva lista");
                            z.poblacion();
                            Console.ReadLine();
                            break;
                        case 3:
                            // Aquí puedes agregar el código para actualizar un animal
                            break;
                        case 4:
                            // Aquí puedes agregar el código para mostrar animales
                            break;
                        case 5:
                            return;
                        default:
                            Console.WriteLine("Opción no válida. Por favor, intenta de nuevo.");
                            break;
                    }
                }
                else if (opcion == 6)
                {
                    Console.WriteLine("ADIOS");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Opción no válida. Por favor, intenta de nuevo.");
                    Console.ReadLine();
                }
                Console.Clear();
            }



        }
    }
}

