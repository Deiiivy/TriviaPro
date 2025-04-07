using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaPro.Clases
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public int Puntaje { get; private set; }

        public Jugador(string nombre)
        {
            Nombre = nombre;
            Puntaje = 0;
        }

        public void ActualizarPuntaje(int puntos)
        {
            Puntaje += puntos;
            if (Puntaje < 0) Puntaje = 0;
        }
    }

}
