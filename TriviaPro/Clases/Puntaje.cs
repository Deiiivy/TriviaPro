using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaPro.Clases
{
    public class Puntaje
    {
        public int ValorActual { get; private set; }

        public Puntaje()
        {
            ValorActual = 0;
        }

        public void Sumar(string nivel)
        {
            switch (nivel)
            {
                case "Fácil":
                    ValorActual += 5;
                    break;
                case "Medio":
                    ValorActual += 10;
                    break;
                case "Difícil":
                    ValorActual += 15;
                    break;
            }
        }

        public void Restar()
        {
            ValorActual -= 2;
            if (ValorActual < 0)
            {
                ValorActual = 0;
            }
        }

        public void Reiniciar()
        {
            ValorActual = 0;
        }
    }
}
