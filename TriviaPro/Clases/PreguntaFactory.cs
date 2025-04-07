using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaPro.Clases
{
  public static class PreguntaFactory
{
    private static readonly Random random = new Random();

    public static Pregunta CrearPregunta(string categoria, string nivel)
    {
        var opciones = new List<string> { "A", "B", "C", "D" };
        var texto = $"¿Ejemplo de pregunta de {categoria} ({nivel})?";
        var respuesta = "A";

        if (nivel == "Fácil")
        {
            return new PreguntaFacil(texto, opciones, respuesta, categoria);
        }
        else if (nivel == "Medio")
        {
            return new PreguntaMedia(texto, opciones, respuesta, categoria);
        }
        else if (nivel == "Difícil")
        {
            return new PreguntaDificil(texto, opciones, respuesta, categoria);
        }
        else
        {
            throw new ArgumentException("Nivel no válido");
        }
    }
}

}
