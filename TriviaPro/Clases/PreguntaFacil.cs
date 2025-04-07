using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaPro.Clases
{
    public class PreguntaFacil : Pregunta
    {
        public PreguntaFacil(string texto, List<string> opciones, string respuestaCorrecta, string categoria)
            : base(texto, opciones, respuestaCorrecta, categoria, "Fácil") { }

        public override int EvaluarRespuesta(string respuesta) => respuesta == RespuestaCorrecta ? 5 : -2;

        public override int ObtenerTiempoLimite() => 20;
    }

}
