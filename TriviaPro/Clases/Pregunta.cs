using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaPro
{
    public abstract class Pregunta
    {
        public string Texto { get; protected set; }
        public List<string> Opciones { get; protected set; }
        public string RespuestaCorrecta { get; protected set; }
        public string Categoria { get; protected set; }
        public string Nivel { get; protected set; }

        public Pregunta(string texto, List<string> opciones, string respuestaCorrecta, string categoria, string nivel)
        {
            if (string.IsNullOrEmpty(texto) || opciones == null || opciones.Count < 3)
                throw new ArgumentException("Pregunta u opciones inválidas");

            Texto = texto;
            Opciones = opciones;
            RespuestaCorrecta = respuestaCorrecta;
            Categoria = categoria;
            Nivel = nivel;
        }

        public abstract int GetPuntaje();
        public bool EvaluarRespuesta(string respuestaUsuario)
        {
            return RespuestaCorrecta.Equals(respuestaUsuario, StringComparison.OrdinalIgnoreCase);
        }

        public abstract int GetTiempo(); 
    }

}
