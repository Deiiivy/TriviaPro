using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaPro
{
    public abstract class Pregunta
    {
        public string Texto { get; set; }
        public List<string> Opciones { get; set; }
        public string RespuestaCorrecta { get; set; }
        public string Categoria { get; set; }
        public string Nivel { get; set; }

        protected Pregunta(string texto, List<string> opciones, string respuestaCorrecta, string categoria, string nivel)
        {
            if (string.IsNullOrWhiteSpace(categoria) || string.IsNullOrWhiteSpace(nivel))
                throw new ArgumentException("La categoría y el nivel no pueden estar vacíos.");

            Texto = texto;
            Opciones = opciones ?? throw new ArgumentNullException(nameof(opciones));
            RespuestaCorrecta = respuestaCorrecta;
            Categoria = categoria;
            Nivel = nivel;
        }

        public abstract int EvaluarRespuesta(string respuesta);
        public abstract int ObtenerTiempoLimite();
    }


}
