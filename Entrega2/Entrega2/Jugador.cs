using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    class Jugador
    {
        public string nombre;   //nombre del jugador
        List<Bitmom> equipo;    //lista de bitmoms elegido por el jugador
        int jugada;             //Variable para elegir el movimiento del jugador (atacar, descansar o cambio de jugador)
        Bitmom bitmonActivo;

        public Jugador(string nombreJugador)
        {
            nombre = nombreJugador;
        }

       
    
        public void agregarBitmom(Bitmom bitmom)    //metodo para agregar un bitmom al equipo del jugador
        {
            equipo.Add(bitmom);
        }

        public void verEquipo() //Metodo para ver la info de todo el equipo (cuanta vida, esta muerto, esta exhausto, etc)
        {


        }

        public void CambiarBitmom()    //Metodo get y set variable bitmomActivo
        {
            

            
        }

        public void elegirJugada(int numOpciones)   //metodo que luego se usara para que los jugadores interactuen con el juego protegiendo las opciones validas
        {
            bool error = true;
            while (error)
            {
                try
                {
                    jugada = int.Parse(Console.ReadLine());
                    error = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Debe Ingresar una opcion numerica!!");
                    Console.WriteLine(e.Message);
                }

                finally
                {
                    if ((jugada > numOpciones) || (jugada <= 0))
                    {
                        error = true;
                        Console.WriteLine($"Opcion {jugada} no valida, intente nuevamente.");
                    }
                }
            }

        }

        public void estrategia()    //metodo que entrega las opciones disponibles al jugador, recibe y llama a los metodos encargados de ejecutar esa decision
        {
            Console.WriteLine("Que movimiento deseas hacer? \n [1] Cambiar Bitmom activo \n [2] Atacar \n [3] Ver info Bitmoms \n [4] Descansar BitmonActivo  \n [5] Guardar Partida");
            
            if (jugada == 1)
            {
                
                
            }
            



        }










        

        


        


    }
}
