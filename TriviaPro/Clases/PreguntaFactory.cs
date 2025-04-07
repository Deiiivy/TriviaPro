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

        private static readonly Dictionary<(string categoria, string nivel), List<Pregunta>> baseDePreguntas =
            new Dictionary<(string categoria, string nivel), List<Pregunta>>()
            {
                // --- CIENCIA ---
                {
                    ("Ciencia", "Fácil"), new List<Pregunta>()
                    {
                        new PreguntaFacil("¿Cuál es el planeta más cercano al Sol?", new List<string> { "Mercurio", "Venus", "Tierra", "Marte" }, "Mercurio", "Ciencia"),
                        new PreguntaFacil("¿Qué gas respiramos principalmente?", new List<string> { "Oxígeno", "Nitrógeno", "CO2", "Hidrógeno" }, "Nitrógeno", "Ciencia"),
                        new PreguntaFacil("¿Qué líquido necesitamos para vivir?", new List<string> { "Agua", "Aceite", "Alcohol", "Gasolina" }, "Agua", "Ciencia")
                    }
                },
                {
                    ("Ciencia", "Medio"), new List<Pregunta>()
                    {
                        new PreguntaMedia("¿Qué órgano produce insulina?", new List<string> { "Hígado", "Riñón", "Páncreas", "Estómago" }, "Páncreas", "Ciencia"),
                        new PreguntaMedia("¿Qué parte del cuerpo humano contiene el fémur?", new List<string> { "Pierna", "Brazo", "Cabeza", "Torso" }, "Pierna", "Ciencia"),
                        new PreguntaMedia("¿Cuál es el elemento químico con símbolo O?", new List<string> { "Oxígeno", "Oro", "Osmio", "Oxalato" }, "Oxígeno", "Ciencia")
                    }
                },
                {
                    ("Ciencia", "Difícil"), new List<Pregunta>()
                    {
                        new PreguntaDificil("¿Cuál es la fórmula química de la sal común?", new List<string> { "NaCl", "KCl", "CaCO3", "Na2SO4" }, "NaCl", "Ciencia"),
                        new PreguntaDificil("¿Qué científico propuso la teoría de la relatividad?", new List<string> { "Einstein", "Newton", "Tesla", "Bohr" }, "Einstein", "Ciencia"),
                        new PreguntaDificil("¿Qué partícula subatómica tiene carga negativa?", new List<string> { "Electrón", "Protón", "Neutrón", "Quark" }, "Electrón", "Ciencia")
                    }
                },

                // --- HISTORIA ---
                {
                    ("Historia", "Fácil"), new List<Pregunta>()
                    {
                        new PreguntaFacil("¿Quién descubrió América?", new List<string> { "Cristóbal Colón", "Simón Bolívar", "Hernán Cortés", "Napoleón" }, "Cristóbal Colón", "Historia"),
                        new PreguntaFacil("¿En qué año se firmó la independencia de EE.UU.?", new List<string> { "1776", "1492", "1810", "1945" }, "1776", "Historia"),
                        new PreguntaFacil("¿Qué civilización construyó las pirámides de Egipto?", new List<string> { "Egipcia", "Romana", "Griega", "Azteca" }, "Egipcia", "Historia")
                    }
                },
                {
                    ("Historia", "Medio"), new List<Pregunta>()
                    {
                        new PreguntaMedia("¿En qué año comenzó la Segunda Guerra Mundial?", new List<string> { "1939", "1945", "1914", "1929" }, "1939", "Historia"),
                        new PreguntaMedia("¿Quién fue el líder de la Alemania nazi?", new List<string> { "Hitler", "Stalin", "Churchill", "Mussolini" }, "Hitler", "Historia"),
                        new PreguntaMedia("¿Qué país fue invadido al inicio de la Segunda Guerra Mundial?", new List<string> { "Polonia", "Francia", "Rusia", "Austria" }, "Polonia", "Historia")
                    }
                },
                {
                    ("Historia", "Difícil"), new List<Pregunta>()
                    {
                        new PreguntaDificil("¿Qué emperador romano legalizó el cristianismo?", new List<string> { "Nerón", "Constantino", "César", "Augusto" }, "Constantino", "Historia"),
                        new PreguntaDificil("¿En qué año cayó el Imperio Romano de Occidente?", new List<string> { "476", "1492", "800", "1200" }, "476", "Historia"),
                        new PreguntaDificil("¿Qué guerra ocurrió entre 1914 y 1918?", new List<string> { "Primera Guerra Mundial", "Segunda Guerra Mundial", "Guerra Fría", "Guerra de Corea" }, "Primera Guerra Mundial", "Historia")
                    }
                },

                // --- CULTURA GENERAL ---
                {
                    ("Cultura General", "Fácil"), new List<Pregunta>()
                    {
                        new PreguntaFacil("¿Cuál es la capital de Francia?", new List<string> { "París", "Roma", "Madrid", "Londres" }, "París", "Cultura General"),
                        new PreguntaFacil("¿Cuántos días tiene una semana?", new List<string> { "7", "5", "10", "6" }, "7", "Cultura General"),
                        new PreguntaFacil("¿Qué color resulta de mezclar azul y amarillo?", new List<string> { "Verde", "Rojo", "Naranja", "Morado" }, "Verde", "Cultura General")
                    }
                },
                {
                    ("Cultura General", "Medio"), new List<Pregunta>()
                    {
                        new PreguntaMedia("¿Cuántos continentes hay en el mundo?", new List<string> { "5", "6", "7", "8" }, "7", "Cultura General"),
                        new PreguntaMedia("¿Cuál es el océano más grande?", new List<string> { "Pacífico", "Atlántico", "Índico", "Ártico" }, "Pacífico", "Cultura General"),
                        new PreguntaMedia("¿Qué país tiene forma de bota?", new List<string> { "Italia", "España", "Chile", "Egipto" }, "Italia", "Cultura General")
                    }
                },
                {
                    ("Cultura General", "Difícil"), new List<Pregunta>()
                    {
                        new PreguntaDificil("¿Qué país tiene la mayor cantidad de islas en el mundo?", new List<string> { "Suecia", "Indonesia", "Canadá", "Filipinas" }, "Suecia", "Cultura General"),
                        new PreguntaDificil("¿Cuál es la lengua más hablada del mundo?", new List<string> { "Chino mandarín", "Inglés", "Español", "Árabe" }, "Chino mandarín", "Cultura General"),
                        new PreguntaDificil("¿En qué país se originaron los Juegos Olímpicos?", new List<string> { "Grecia", "Italia", "Egipto", "China" }, "Grecia", "Cultura General")
                    }
                }
            };


        public static Pregunta CrearPregunta(string categoria, string nivel)
        {
            var clave = (categoria, nivel);

            if (!baseDePreguntas.ContainsKey(clave) || baseDePreguntas[clave].Count == 0)
            {
                return new PreguntaFacil("No hay preguntas disponibles para esta categoría y nivel.",
                                         new List<string> { "N/A", "N/A", "N/A", "N/A" }, "N/A", categoria);
            }

            var preguntas = baseDePreguntas[clave];
            int indice = random.Next(preguntas.Count);
            return preguntas[indice];
        }


        public static List<Pregunta> ObtenerPreguntas(string categoria, string nivel)
        {
            var clave = (categoria, nivel);

            if (baseDePreguntas.ContainsKey(clave))
            {
                return baseDePreguntas[clave];
            }

            return new List<Pregunta>();
        }
    }
}
