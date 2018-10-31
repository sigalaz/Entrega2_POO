using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    class Bitmom
    { 
        string nombre;
        int stamina;
        int vida;
        string naturaleza;  //1-trueno, 2-Fuego , 3-Agua, 4-Tierra, 5-Aire
        //public int estado;
        int ataqueBase;
        int defensaBase;

        public Bitmom(string nombre, int stamina, int vida, string naturaleza, int attack, int def)
        {
            this.nombre = nombre;
            this.stamina = stamina;//stamina = new int[2]{stamina1, stamina2}
            this.vida = vida;
            this.naturaleza = naturaleza;
            ataqueBase = attack;
            defensaBase = def;
        }

        public void verInfoBitmom()
        {
            Console.WriteLine(" - Nombre : {0}\n - Stamina: {1}\n - Vida: {2}\n - Naturalera: {3}\n - Ataque: {4}\n - Defensa: {5}\n", nombre, stamina, vida, naturaleza, ataqueBase, defensaBase);

        }

        public string getNaturaleza()
        {
            return naturaleza;
        }

        public void cambiarEstado()
        {
            //********Por completar
        }

        public void cambiarVida(int golpe)
        {
            if(golpe >= vida)
                vida -= golpe;

            vida = 0;
            /////************Por Completar, aqui podria incliorse el cambio debido al estado
        }

        public void cambiarEstamina(int gasto)
        {
            if (gasto >= stamina)
                stamina -= gasto;

            else
            {
                Console.WriteLine("stamina Insuficiente :((");
            }

            //*********¨Por terminar... se podria agregar lo que pasa si no alcanza la stamina para el poder
            //pierde el turno o le da derecho a ejecutar otra poder o vuelve al menu principal para poder cambiar el bitmom

        }

        public bool estaVivo()
        {
            if (vida > 0)
            {
                return true;
            }
            return false;
        }

        public void Descansar()
        {
            stamina += 20;
            vida += 5;
        }

        public void Atacar(Bitmom bEnemigo)
        {
            

        }
        



    }

     


}
