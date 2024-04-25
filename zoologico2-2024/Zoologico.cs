using System;
using System.Collections.Generic;
using System.Text;

namespace zoologico2_2024
{
    class Zoologico
    {
        public List<IAnimal> lista_animales = new List<IAnimal>();
        public List<Cuidador> lista_cuidadores = new List<Cuidador>();

        public void AgregarCuidador(Cuidador cuidador) 
        {
            lista_cuidadores.Add(cuidador);
        }

        public void EliminarCuidador(Cuidador cuidador)
        {
            lista_cuidadores.Remove(cuidador);
        }

        public void ActualizarCuidador(Cuidador cuidadorAntiguo, Cuidador cuidadorNuevo)
        {
            int indice = lista_cuidadores.IndexOf(cuidadorAntiguo);
            if (indice != -1)
            {
                lista_cuidadores[indice] = cuidadorNuevo;
            }
        }

        public void AgregarAnimal(Animal animal) {

            lista_animales.Add(animal);
        }
        public void EliminarAnimal(Animal animal)
        {
            lista_animales.Remove(animal);
        }

        public void poblacion() {

            foreach (var animal in lista_animales)
            {
                animal.presentarse();
                
            }
           
            
           
        }
    }
}
