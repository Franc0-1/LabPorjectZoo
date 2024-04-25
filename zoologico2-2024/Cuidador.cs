using System;
using System.Collections.Generic;
using System.Text;

namespace zoologico2_2024
{


    class persona {
        public string nombre { get; set; }

        public persona()
        {
           this.nombre = "Pedro";
        }

        public persona(string n)
        {
            this.nombre = n;
        }
    }



    class Cuidador:persona
    {
        public int legajo { get; set; }
        public Cuidador(int l)
            : base()
        {
            this.legajo = l;
        }
        
        public void alimentar(List<Animal> L)
        {
            Console.WriteLine("{0} es el cuidador, su legajo es:{1}",this.nombre,this.legajo);
            foreach (var item in L)
            {
                Console.WriteLine("El {0} come {1}",item.nombre,item.comida);
            }
        }

        internal void alimentar(List<IAnimal> lista_animales)
        {
            throw new NotImplementedException();
        }
    }
}
