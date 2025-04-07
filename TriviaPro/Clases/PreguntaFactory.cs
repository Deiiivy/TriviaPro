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
        new PreguntaFacil("¿Cuál es el planeta más cercano al Sol?", MezclarOpciones(new List<string> { "Mercurio", "Venus", "Tierra", "Marte" }), "Mercurio", "Ciencia"),
        new PreguntaFacil("¿Qué gas respiramos principalmente?", MezclarOpciones(new List<string> { "Oxígeno", "Nitrógeno", "CO2", "Hidrógeno" }), "Nitrógeno", "Ciencia"),
        new PreguntaFacil("¿Qué líquido necesitamos para vivir?", MezclarOpciones(new List<string> { "Agua", "Aceite", "Alcohol", "Gasolina" }), "Agua", "Ciencia"),
        new PreguntaFacil("¿Qué parte del cuerpo usamos para ver?", MezclarOpciones(new List<string> { "Ojos", "Manos", "Nariz", "Pies" }), "Ojos", "Ciencia"),
        new PreguntaFacil("¿Cuál es el órgano encargado de bombear la sangre?", MezclarOpciones(new List<string> { "Corazón", "Pulmón", "Hígado", "Estómago" }), "Corazón", "Ciencia"),
        new PreguntaFacil("¿Cuántos planetas hay en el sistema solar?", MezclarOpciones(new List<string> { "8", "7", "9", "10" }), "8", "Ciencia"),
        new PreguntaFacil("¿Qué estrella da luz y calor a la Tierra?", MezclarOpciones(new List<string> { "El Sol", "La Luna", "Estrella Polar", "Marte" }), "El Sol", "Ciencia"),
        new PreguntaFacil("¿Qué animal es conocido por cambiar de color?", MezclarOpciones(new List<string> { "Camaleón", "Perro", "Gato", "Elefante" }), "Camaleón", "Ciencia"),
        new PreguntaFacil("¿Cuál es el hueso más largo del cuerpo humano?", MezclarOpciones(new List<string> { "Fémur", "Húmero", "Radio", "Peroné" }), "Fémur", "Ciencia"),
        new PreguntaFacil("¿Qué animal pone huevos?", MezclarOpciones(new List<string> { "Gallina", "Perro", "Vaca", "Tigre" }), "Gallina", "Ciencia"),
        new PreguntaFacil("¿Qué insecto produce miel?", MezclarOpciones(new List<string> { "Abeja", "Mosca", "Mariposa", "Escarabajo" }), "Abeja", "Ciencia"),
        new PreguntaFacil("¿Qué planeta es conocido como el planeta rojo?", MezclarOpciones(new List<string> { "Marte", "Venus", "Júpiter", "Saturno" }), "Marte", "Ciencia"),
        new PreguntaFacil("¿Qué usamos para medir la temperatura corporal?", MezclarOpciones(new List<string> { "Termómetro", "Barómetro", "Telescopio", "Microscopio" }), "Termómetro", "Ciencia"),
        new PreguntaFacil("¿Qué tipo de animal es una ballena?", MezclarOpciones(new List<string> { "Mamífero", "Pez", "Reptil", "Anfibio" }), "Mamífero", "Ciencia"),
        new PreguntaFacil("¿Qué órgano usamos para oír?", MezclarOpciones(new List<string> { "Oídos", "Ojos", "Manos", "Pies" }), "Oídos", "Ciencia")
    }
},
               {
    ("Ciencia", "Medio"), new List<Pregunta>()
    {
        new PreguntaMedia("¿Qué órgano produce insulina?", MezclarOpciones(new List<string> { "Hígado", "Riñón", "Páncreas", "Estómago" }), "Páncreas", "Ciencia"),
        new PreguntaMedia("¿Qué parte del cuerpo humano contiene el fémur?", MezclarOpciones(new List<string> { "Pierna", "Brazo", "Cabeza", "Torso" }), "Pierna", "Ciencia"),
        new PreguntaMedia("¿Cuál es el elemento químico con símbolo O?", MezclarOpciones(new List<string> { "Oxígeno", "Oro", "Osmio", "Oxalato" }), "Oxígeno", "Ciencia"),
        new PreguntaMedia("¿Cuál es el proceso por el cual las plantas producen su alimento?", MezclarOpciones(new List<string> { "Fotosíntesis", "Respiración", "Digestión", "Transpiración" }), "Fotosíntesis", "Ciencia"),
        new PreguntaMedia("¿Qué nombre recibe el cambio de estado de líquido a gas?", MezclarOpciones(new List<string> { "Evaporación", "Condensación", "Solidificación", "Sublimación" }), "Evaporación", "Ciencia"),
        new PreguntaMedia("¿Qué órgano del cuerpo humano filtra la sangre?", MezclarOpciones(new List<string> { "Riñón", "Pulmón", "Corazón", "Hígado" }), "Riñón", "Ciencia"),
        new PreguntaMedia("¿Cómo se llama la fuerza que nos mantiene pegados al suelo?", MezclarOpciones(new List<string> { "Gravedad", "Fricción", "Inercia", "Empuje" }), "Gravedad", "Ciencia"),
        new PreguntaMedia("¿Qué estructura del átomo tiene carga positiva?", MezclarOpciones(new List<string> { "Protón", "Electrón", "Neutrón", "Núcleo" }), "Protón", "Ciencia"),
        new PreguntaMedia("¿Cuál es la fórmula química del agua?", MezclarOpciones(new List<string> { "H2O", "CO2", "O2", "H2SO4" }), "H2O", "Ciencia"),
        new PreguntaMedia("¿Qué capa de la atmósfera protege de los rayos UV?", MezclarOpciones(new List<string> { "Capa de ozono", "Troposfera", "Estratósfera", "Ionosfera" }), "Capa de ozono", "Ciencia"),
        new PreguntaMedia("¿Qué planeta tiene los anillos más visibles?", MezclarOpciones(new List<string> { "Saturno", "Júpiter", "Urano", "Neptuno" }), "Saturno", "Ciencia"),
        new PreguntaMedia("¿Cómo se llama el órgano que permite respirar?", MezclarOpciones(new List<string> { "Pulmones", "Corazón", "Estómago", "Riñones" }), "Pulmones", "Ciencia"),
        new PreguntaMedia("¿Qué animal es un mamífero marino?", MezclarOpciones(new List<string> { "Delfín", "Tiburón", "Pulpo", "Pez espada" }), "Delfín", "Ciencia"),
        new PreguntaMedia("¿Cuál es el nombre del satélite natural de la Tierra?", MezclarOpciones(new List<string> { "La Luna", "Marte", "Venus", "Estrella del Norte" }), "La Luna", "Ciencia"),
        new PreguntaMedia("¿Qué nombre recibe la ciencia que estudia los seres vivos?", MezclarOpciones(new List<string> { "Biología", "Física", "Química", "Astronomía" }), "Biología", "Ciencia")
    }
},
               {
    ("Ciencia", "Difícil"), new List<Pregunta>()
    {
        new PreguntaDificil("¿Cuál es el proceso por el cual las plantas convierten nitrógeno en una forma utilizable?", MezclarOpciones(new List<string> { "Fijación de nitrógeno", "Fotosíntesis", "Respiración celular", "Transpiración" }), "Fijación de nitrógeno", "Ciencia"),
        new PreguntaDificil("¿Qué partícula subatómica no tiene carga eléctrica?", MezclarOpciones(new List<string> { "Neutrón", "Electrón", "Protón", "Quark" }), "Neutrón", "Ciencia"),
        new PreguntaDificil("¿Cuál es el nombre del efecto que describe el cambio en la frecuencia de una onda en movimiento?", MezclarOpciones(new List<string> { "Efecto Doppler", "Efecto Fotoeléctrico", "Efecto Coriolis", "Efecto Joule" }), "Efecto Doppler", "Ciencia"),
        new PreguntaDificil("¿Qué glándula regula el metabolismo en el cuerpo humano?", MezclarOpciones(new List<string> { "Tiroides", "Hipófisis", "Páncreas", "Suprarrenal" }), "Tiroides", "Ciencia"),
        new PreguntaDificil("¿Cuál es el segundo elemento más abundante en la atmósfera terrestre?", MezclarOpciones(new List<string> { "Oxígeno", "Nitrógeno", "Argón", "Dióxido de carbono" }), "Oxígeno", "Ciencia"),
        new PreguntaDificil("¿Qué ley física establece que la energía no se crea ni se destruye?", MezclarOpciones(new List<string> { "Ley de conservación de la energía", "Ley de gravitación universal", "Ley de acción y reacción", "Ley de la inercia" }), "Ley de conservación de la energía", "Ciencia"),
        new PreguntaDificil("¿Qué científico propuso la teoría del electromagnetismo?", MezclarOpciones(new List<string> { "James Clerk Maxwell", "Isaac Newton", "Albert Einstein", "Galileo Galilei" }), "James Clerk Maxwell", "Ciencia"),
        new PreguntaDificil("¿Qué tipo de célula carece de núcleo definido?", MezclarOpciones(new List<string> { "Procariota", "Eucariota", "Neuronas", "Glóbulos blancos" }), "Procariota", "Ciencia"),
        new PreguntaDificil("¿Cómo se denomina el estudio de los seres microscópicos?", MezclarOpciones(new List<string> { "Microbiología", "Virología", "Parasitología", "Genética" }), "Microbiología", "Ciencia"),
        new PreguntaDificil("¿Cuál es el nombre del gas noble con menor masa atómica?", MezclarOpciones(new List<string> { "Helio", "Neón", "Argón", "Krypton" }), "Helio", "Ciencia"),
        new PreguntaDificil("¿Qué nombre recibe la distancia entre dos crestas sucesivas de una onda?", MezclarOpciones(new List<string> { "Longitud de onda", "Frecuencia", "Amplitud", "Ciclo" }), "Longitud de onda", "Ciencia"),
        new PreguntaDificil("¿Cuál es la función principal del ribosoma en una célula?", MezclarOpciones(new List<string> { "Síntesis de proteínas", "Almacenar energía", "Contener ADN", "Moverse" }), "Síntesis de proteínas", "Ciencia"),
        new PreguntaDificil("¿Qué teoría explica el origen del universo?", MezclarOpciones(new List<string> { "Big Bang", "Creacionismo", "Evolución", "Inflación cósmica" }), "Big Bang", "Ciencia"),
        new PreguntaDificil("¿Qué fenómeno ocurre cuando la luz cambia de dirección al pasar de un medio a otro?", MezclarOpciones(new List<string> { "Refracción", "Reflexión", "Difracción", "Dispersión" }), "Refracción", "Ciencia"),
        new PreguntaDificil("¿Qué científico formuló las leyes del movimiento?", MezclarOpciones(new List<string> { "Isaac Newton", "Galileo Galilei", "Stephen Hawking", "Nikola Tesla" }), "Isaac Newton", "Ciencia")
    }
},
             
                // --- HISTORIA ---
              {
    ("Historia", "Fácil"), new List<Pregunta>()
    {
        new PreguntaFacil("¿Quién fue el primer presidente de Estados Unidos?", MezclarOpciones(new List<string> { "George Washington", "Abraham Lincoln", "Thomas Jefferson", "John Adams" }), "George Washington", "Historia"),
        new PreguntaFacil("¿En qué año se descubrió América?", MezclarOpciones(new List<string> { "1492", "1500", "1600", "1453" }), "1492", "Historia"),
        new PreguntaFacil("¿Qué civilización construyó las pirámides de Egipto?", MezclarOpciones(new List<string> { "Egipcia", "Griega", "Romana", "Persa" }), "Egipcia", "Historia"),
        new PreguntaFacil("¿Quién fue el libertador de varios países de América del Sur?", MezclarOpciones(new List<string> { "Simón Bolívar", "Cristóbal Colón", "José Martí", "Pancho Villa" }), "Simón Bolívar", "Historia"),
        new PreguntaFacil("¿Qué muralla famosa se encuentra en China?", MezclarOpciones(new List<string> { "La Gran Muralla", "Muralla de los Lamentos", "Muro de Berlín", "Muralla de Adriano" }), "La Gran Muralla", "Historia"),
        new PreguntaFacil("¿Qué país lanzó las bombas atómicas en la Segunda Guerra Mundial?", MezclarOpciones(new List<string> { "Estados Unidos", "Alemania", "Japón", "Rusia" }), "Estados Unidos", "Historia"),
        new PreguntaFacil("¿Quién fue el líder del nazismo en Alemania?", MezclarOpciones(new List<string> { "Adolf Hitler", "Benito Mussolini", "Josef Stalin", "Winston Churchill" }), "Adolf Hitler", "Historia"),
        new PreguntaFacil("¿Qué imperio gobernó gran parte de Europa en la antigüedad?", MezclarOpciones(new List<string> { "Imperio Romano", "Imperio Otomano", "Imperio Persa", "Imperio Bizantino" }), "Imperio Romano", "Historia"),
        new PreguntaFacil("¿Cómo se llamaba el barco en el que viajó Cristóbal Colón?", MezclarOpciones(new List<string> { "La Santa María", "La Pinta", "La Niña", "El Mayflower" }), "La Santa María", "Historia"),
        new PreguntaFacil("¿Qué famosa reina tuvo seis esposos?", MezclarOpciones(new List<string> { "Catalina de Aragón", "Isabel I", "Ana Bolena", "Enrique VIII (era rey)" }), "Enrique VIII (era rey)", "Historia"),
        new PreguntaFacil("¿En qué continente ocurrió la Primera Guerra Mundial?", MezclarOpciones(new List<string> { "Europa", "Asia", "África", "América" }), "Europa", "Historia"),
        new PreguntaFacil("¿Qué país construyó el Muro de Berlín?", MezclarOpciones(new List<string> { "Alemania Oriental", "Alemania Occidental", "Rusia", "Francia" }), "Alemania Oriental", "Historia"),
        new PreguntaFacil("¿Qué guerra se luchó entre el Norte y el Sur de Estados Unidos?", MezclarOpciones(new List<string> { "Guerra Civil", "Guerra de Independencia", "Guerra Fría", "Guerra de Vietnam" }), "Guerra Civil", "Historia"),
        new PreguntaFacil("¿Quién escribió el 'Manifiesto Comunista'?", MezclarOpciones(new List<string> { "Karl Marx", "Lenin", "Trotsky", "Stalin" }), "Karl Marx", "Historia"),
        new PreguntaFacil("¿Qué acontecimiento marcó el inicio de la Edad Media?", MezclarOpciones(new List<string> { "Caída del Imperio Romano", "Descubrimiento de América", "Inicio del Renacimiento", "Revolución Francesa" }), "Caída del Imperio Romano", "Historia")
    }
},

               {
    ("Historia", "Medio"), new List<Pregunta>()
    {
        new PreguntaMedia("¿En qué año cayó el Imperio Romano de Occidente?", MezclarOpciones(new List<string> { "476", "1492", "1453", "1066" }), "476", "Historia"),
        new PreguntaMedia("¿Quién fue el emperador que dividió el Imperio Romano?", MezclarOpciones(new List<string> { "Diocleciano", "Constantino", "Julio César", "Nerón" }), "Diocleciano", "Historia"),
        new PreguntaMedia("¿Cuál fue el tratado que puso fin a la Primera Guerra Mundial?", MezclarOpciones(new List<string> { "Tratado de Versalles", "Tratado de París", "Tratado de Viena", "Tratado de Tordesillas" }), "Tratado de Versalles", "Historia"),
        new PreguntaMedia("¿Qué país fue invadido por Alemania para iniciar la Segunda Guerra Mundial?", MezclarOpciones(new List<string> { "Polonia", "Francia", "Bélgica", "Checoslovaquia" }), "Polonia", "Historia"),
        new PreguntaMedia("¿Qué reina inglesa fue conocida como 'La Reina Virgen'?", MezclarOpciones(new List<string> { "Isabel I", "Victoria", "Catalina de Aragón", "María Tudor" }), "Isabel I", "Historia"),
        new PreguntaMedia("¿Qué revolucionario cubano participó en la Revolución de 1959?", MezclarOpciones(new List<string> { "Fidel Castro", "Che Guevara", "Camilo Cienfuegos", "Todos los anteriores" }), "Todos los anteriores", "Historia"),
        new PreguntaMedia("¿Cuál fue el conflicto armado más largo del siglo XX?", MezclarOpciones(new List<string> { "Guerra Fría", "Guerra de Vietnam", "Segunda Guerra Mundial", "Guerra de Corea" }), "Guerra Fría", "Historia"),
        new PreguntaMedia("¿Qué rey francés fue apodado el 'Rey Sol'?", MezclarOpciones(new List<string> { "Luis XIV", "Luis XVI", "Luis XIII", "Luis XV" }), "Luis XIV", "Historia"),
        new PreguntaMedia("¿En qué batalla fue derrotado Napoleón Bonaparte definitivamente?", MezclarOpciones(new List<string> { "Waterloo", "Austerlitz", "Trafalgar", "Borodino" }), "Waterloo", "Historia"),
        new PreguntaMedia("¿Cuál fue el motivo de la Revolución Francesa?", MezclarOpciones(new List<string> { "Desigualdad social", "Crisis económica", "Ideas ilustradas", "Todas las anteriores" }), "Todas las anteriores", "Historia"),
        new PreguntaMedia("¿Qué dinastía gobernó China por última vez?", MezclarOpciones(new List<string> { "Qing", "Ming", "Yuan", "Han" }), "Qing", "Historia"),
        new PreguntaMedia("¿Quién fue el primer emperador romano?", MezclarOpciones(new List<string> { "Augusto", "Julio César", "Nerón", "Tiberio" }), "Augusto", "Historia"),
        new PreguntaMedia("¿Qué civilización usó el quipu como método de registro?", MezclarOpciones(new List<string> { "Inca", "Maya", "Azteca", "Tolteca" }), "Inca", "Historia"),
        new PreguntaMedia("¿Qué país colonizó la India hasta 1947?", MezclarOpciones(new List<string> { "Reino Unido", "Francia", "Portugal", "Países Bajos" }), "Reino Unido", "Historia"),
        new PreguntaMedia("¿Quién fue derrotado en la batalla de Hastings en 1066?", MezclarOpciones(new List<string> { "Harold II", "Guillermo el Conquistador", "Ricardo Corazón de León", "Eduardo el Confesor" }), "Harold II", "Historia")
    }
},

               {
    ("Historia", "Difícil"), new List<Pregunta>()
    {
        new PreguntaDificil("¿Cuál fue la principal causa de la Guerra de los Cien Años?", MezclarOpciones(new List<string> { "Disputa por la sucesión al trono francés", "Conflicto territorial", "Diferencias religiosas", "Comercio de lana" }), "Disputa por la sucesión al trono francés", "Historia"),
        new PreguntaDificil("¿Qué documento inglés limitó el poder del rey en 1215?", MezclarOpciones(new List<string> { "Carta Magna", "Acta de Unión", "Bill of Rights", "Tratado de Londres" }), "Carta Magna", "Historia"),
        new PreguntaDificil("¿Cuál fue el nombre del plan económico para reconstruir Europa tras la Segunda Guerra Mundial?", MezclarOpciones(new List<string> { "Plan Marshall", "Plan Molotov", "Plan Truman", "Plan Dawes" }), "Plan Marshall", "Historia"),
        new PreguntaDificil("¿Qué civilización antigua construyó la ciudad de Mohenjo-Daro?", MezclarOpciones(new List<string> { "Civilización del valle del Indo", "Sumerios", "Egipcios", "Hititas" }), "Civilización del valle del Indo", "Historia"),
        new PreguntaDificil("¿Qué tratado estableció las fronteras actuales entre México y EE.UU.?", MezclarOpciones(new List<string> { "Tratado de Guadalupe Hidalgo", "Tratado de Tordesillas", "Tratado Adams-Onís", "Tratado de Versalles" }), "Tratado de Guadalupe Hidalgo", "Historia"),
        new PreguntaDificil("¿Quién fue el primer canciller de la Alemania unificada en 1871?", MezclarOpciones(new List<string> { "Otto von Bismarck", "Guillermo I", "Hindenburg", "Ludwig Erhard" }), "Otto von Bismarck", "Historia"),
        new PreguntaDificil("¿Qué emperador romano legalizó el cristianismo en el Imperio?", MezclarOpciones(new List<string> { "Constantino", "Teodosio", "Juliano", "Nerón" }), "Constantino", "Historia"),
        new PreguntaDificil("¿Qué país fue el primero en independizarse en América Latina?", MezclarOpciones(new List<string> { "Haití", "Venezuela", "México", "Argentina" }), "Haití", "Historia"),
        new PreguntaDificil("¿Quién lideró la expedición que dio la primera vuelta al mundo?", MezclarOpciones(new List<string> { "Magallanes y Elcano", "Colón", "Díaz", "Américo Vespucio" }), "Magallanes y Elcano", "Historia"),
        new PreguntaDificil("¿Qué imperio fue derrotado en la batalla de Lepanto en 1571?", MezclarOpciones(new List<string> { "Imperio Otomano", "Imperio Español", "Imperio Austrohúngaro", "Imperio Bizantino" }), "Imperio Otomano", "Historia"),
        new PreguntaDificil("¿Cuál fue la capital del Imperio Carolingio?", MezclarOpciones(new List<string> { "Aquisgrán", "París", "Roma", "Tours" }), "Aquisgrán", "Historia"),
        new PreguntaDificil("¿Qué guerra fue conocida como 'La guerra para terminar todas las guerras'?", MezclarOpciones(new List<string> { "Primera Guerra Mundial", "Segunda Guerra Mundial", "Guerra Civil Española", "Guerra de Vietnam" }), "Primera Guerra Mundial", "Historia"),
        new PreguntaDificil("¿Qué general cartaginés cruzó los Alpes para invadir Roma?", MezclarOpciones(new List<string> { "Aníbal", "Escipión", "Amílcar", "César" }), "Aníbal", "Historia"),
        new PreguntaDificil("¿Cuál fue el líder de la Revolución Rusa en 1917?", MezclarOpciones(new List<string> { "Lenin", "Trotsky", "Stalin", "Kerensky" }), "Lenin", "Historia"),
        new PreguntaDificil("¿Qué evento inició la Edad Contemporánea?", MezclarOpciones(new List<string> { "Revolución Francesa", "Descubrimiento de América", "Caída de Constantinopla", "Reforma Protestante" }), "Revolución Francesa", "Historia")
    }
},

             

                // --- CULTURA GENERAL ---
               {
    ("Cultura General", "Fácil"), new List<Pregunta>()
    {
        new PreguntaFacil("¿Cuál es el océano más grande del mundo?", MezclarOpciones(new List<string> { "Pacífico", "Atlántico", "Índico", "Ártico" }), "Pacífico", "Cultura General"),
        new PreguntaFacil("¿Qué país es famoso por la Torre Eiffel?", MezclarOpciones(new List<string> { "Francia", "Italia", "España", "Alemania" }), "Francia", "Cultura General"),
        new PreguntaFacil("¿Qué día se celebra la Navidad?", MezclarOpciones(new List<string> { "25 de diciembre", "24 de diciembre", "31 de diciembre", "6 de enero" }), "25 de diciembre", "Cultura General"),
        new PreguntaFacil("¿Cuál es el metal cuyo símbolo es Au?", MezclarOpciones(new List<string> { "Oro", "Plata", "Aluminio", "Cobre" }), "Oro", "Cultura General"),
        new PreguntaFacil("¿Qué planeta es conocido como el planeta rojo?", MezclarOpciones(new List<string> { "Marte", "Venus", "Júpiter", "Saturno" }), "Marte", "Cultura General"),
        new PreguntaFacil("¿Cuál es el animal más grande del mundo?", MezclarOpciones(new List<string> { "Ballena azul", "Elefante africano", "Tiburón blanco", "Jirafa" }), "Ballena azul", "Cultura General"),
        new PreguntaFacil("¿Qué instrumento tiene teclas blancas y negras?", MezclarOpciones(new List<string> { "Piano", "Violín", "Guitarra", "Flauta" }), "Piano", "Cultura General"),
        new PreguntaFacil("¿Cuántos colores tiene el arcoíris?", MezclarOpciones(new List<string> { "7", "6", "8", "5" }), "7", "Cultura General"),
        new PreguntaFacil("¿Cuál es el país más poblado del mundo?", MezclarOpciones(new List<string> { "China", "India", "Estados Unidos", "Indonesia" }), "China", "Cultura General"),
        new PreguntaFacil("¿Qué gas respiramos para vivir?", MezclarOpciones(new List<string> { "Oxígeno", "Dióxido de carbono", "Hidrógeno", "Nitrógeno" }), "Oxígeno", "Cultura General"),
        new PreguntaFacil("¿Qué instrumento se usa para ver estrellas?", MezclarOpciones(new List<string> { "Telescopio", "Microscopio", "Binoculares", "Reloj solar" }), "Telescopio", "Cultura General"),
        new PreguntaFacil("¿Cómo se llama el continente donde está Egipto?", MezclarOpciones(new List<string> { "África", "Asia", "Europa", "América" }), "África", "Cultura General"),
        new PreguntaFacil("¿Qué día de la semana empieza con 'L'?", MezclarOpciones(new List<string> { "Lunes", "Martes", "Miércoles", "Jueves" }), "Lunes", "Cultura General"),
        new PreguntaFacil("¿Cuántas patas tiene una araña?", MezclarOpciones(new List<string> { "8", "6", "10", "4" }), "8", "Cultura General"),
        new PreguntaFacil("¿Cuál es el idioma más hablado del mundo?", MezclarOpciones(new List<string> { "Chino mandarín", "Inglés", "Español", "Árabe" }), "Chino mandarín", "Cultura General")
    }
},

              {
    ("Cultura General", "Medio"), new List<Pregunta>()
    {
        new PreguntaMedia("¿Quién pintó la Mona Lisa?", MezclarOpciones(new List<string> { "Leonardo da Vinci", "Pablo Picasso", "Vincent van Gogh", "Miguel Ángel" }), "Leonardo da Vinci", "Cultura General"),
        new PreguntaMedia("¿Cuál es la capital de Canadá?", MezclarOpciones(new List<string> { "Ottawa", "Toronto", "Vancouver", "Montreal" }), "Ottawa", "Cultura General"),
        new PreguntaMedia("¿Qué civilización construyó Machu Picchu?", MezclarOpciones(new List<string> { "Inca", "Maya", "Azteca", "Olmeca" }), "Inca", "Cultura General"),
        new PreguntaMedia("¿Qué científico propuso la teoría de la relatividad?", MezclarOpciones(new List<string> { "Albert Einstein", "Isaac Newton", "Stephen Hawking", "Galileo Galilei" }), "Albert Einstein", "Cultura General"),
        new PreguntaMedia("¿Cuál es el río más largo del mundo?", MezclarOpciones(new List<string> { "Nilo", "Amazonas", "Yangtsé", "Misisipi" }), "Amazonas", "Cultura General"),
        new PreguntaMedia("¿En qué país se encuentra la Torre de Pisa?", MezclarOpciones(new List<string> { "Italia", "Francia", "España", "Grecia" }), "Italia", "Cultura General"),
        new PreguntaMedia("¿Qué país tiene forma de bota?", MezclarOpciones(new List<string> { "Italia", "Brasil", "Chile", "Portugal" }), "Italia", "Cultura General"),
        new PreguntaMedia("¿Cuál es el elemento químico con símbolo Fe?", MezclarOpciones(new List<string> { "Hierro", "Flúor", "Fósforo", "Francio" }), "Hierro", "Cultura General"),
        new PreguntaMedia("¿Qué año marcó el fin de la Segunda Guerra Mundial?", MezclarOpciones(new List<string> { "1945", "1939", "1942", "1950" }), "1945", "Cultura General"),
        new PreguntaMedia("¿Cuántos planetas hay en el sistema solar?", MezclarOpciones(new List<string> { "8", "9", "7", "10" }), "8", "Cultura General"),
        new PreguntaMedia("¿Qué escritor escribió 'Cien años de soledad'?", MezclarOpciones(new List<string> { "Gabriel García Márquez", "Mario Vargas Llosa", "Julio Cortázar", "Pablo Neruda" }), "Gabriel García Márquez", "Cultura General"),
        new PreguntaMedia("¿Quién fue el primer presidente de los Estados Unidos?", MezclarOpciones(new List<string> { "George Washington", "Thomas Jefferson", "Abraham Lincoln", "John Adams" }), "George Washington", "Cultura General"),
        new PreguntaMedia("¿En qué país se celebraron los primeros Juegos Olímpicos modernos?", MezclarOpciones(new List<string> { "Grecia", "Francia", "Inglaterra", "Alemania" }), "Grecia", "Cultura General"),
        new PreguntaMedia("¿Qué continente no tiene desiertos?", MezclarOpciones(new List<string> { "Europa", "América", "Oceanía", "Asia" }), "Europa", "Cultura General"),
        new PreguntaMedia("¿Cuál es el órgano más grande del cuerpo humano?", MezclarOpciones(new List<string> { "La piel", "El hígado", "Los pulmones", "El intestino" }), "La piel", "Cultura General")
    }
},

              {
    ("Cultura General", "Difícil"), new List<Pregunta>()
    {
        new PreguntaDificil("¿Cuál es el país más joven del mundo?", MezclarOpciones(new List<string> { "Sudán del Sur", "Kosovo", "Timor Oriental", "Montenegro" }), "Sudán del Sur", "Cultura General"),
        new PreguntaDificil("¿Qué científico desarrolló la tabla periódica?", MezclarOpciones(new List<string> { "Dmitri Mendeléyev", "Marie Curie", "John Dalton", "Lavoisier" }), "Dmitri Mendeléyev", "Cultura General"),
        new PreguntaDificil("¿Cuál es la capital de Mongolia?", MezclarOpciones(new List<string> { "Ulán Bator", "Astana", "Tashkent", "Bakú" }), "Ulán Bator", "Cultura General"),
        new PreguntaDificil("¿En qué año cayó el muro de Berlín?", MezclarOpciones(new List<string> { "1989", "1991", "1985", "1993" }), "1989", "Cultura General"),
        new PreguntaDificil("¿Quién fue el autor de *La República*?", MezclarOpciones(new List<string> { "Platón", "Aristóteles", "Sócrates", "Demócrito" }), "Platón", "Cultura General"),
        new PreguntaDificil("¿Qué país tiene más islas en su territorio?", MezclarOpciones(new List<string> { "Suecia", "Filipinas", "Indonesia", "Canadá" }), "Suecia", "Cultura General"),
        new PreguntaDificil("¿Qué gas es más abundante en la atmósfera terrestre?", MezclarOpciones(new List<string> { "Nitrógeno", "Oxígeno", "Dióxido de carbono", "Argón" }), "Nitrógeno", "Cultura General"),
        new PreguntaDificil("¿Cuál es el idioma más hablado del mundo como lengua materna?", MezclarOpciones(new List<string> { "Chino mandarín", "Inglés", "Hindú", "Español" }), "Chino mandarín", "Cultura General"),
        new PreguntaDificil("¿Cuál es el país con más premios Nobel de la Paz?", MezclarOpciones(new List<string> { "Estados Unidos", "Suiza", "Francia", "Reino Unido" }), "Estados Unidos", "Cultura General"),
        new PreguntaDificil("¿Qué filósofo dijo 'Pienso, luego existo'?", MezclarOpciones(new List<string> { "René Descartes", "Nietzsche", "Immanuel Kant", "Hegel" }), "René Descartes", "Cultura General"),
        new PreguntaDificil("¿Qué país no tiene fuerzas armadas permanentes?", MezclarOpciones(new List<string> { "Costa Rica", "Panamá", "Islandia", "Liechtenstein" }), "Costa Rica", "Cultura General"),
        new PreguntaDificil("¿Cuál es el animal nacional de Escocia?", MezclarOpciones(new List<string> { "Unicornio", "León", "Ciervo rojo", "Zorro" }), "Unicornio", "Cultura General"),
        new PreguntaDificil("¿Qué año marcó la fundación de la ONU?", MezclarOpciones(new List<string> { "1945", "1919", "1939", "1950" }), "1945", "Cultura General"),
        new PreguntaDificil("¿Cuál es la capital de Bután?", MezclarOpciones(new List<string> { "Thimphu", "Katmandú", "Daca", "Colombo" }), "Thimphu", "Cultura General"),
        new PreguntaDificil("¿Qué país tiene más volcanes activos del mundo?", MezclarOpciones(new List<string> { "Indonesia", "Japón", "Estados Unidos", "Italia" }), "Indonesia", "Cultura General")
    }
},

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

        private static List<string> MezclarOpciones(List<string> opciones)
        {
            return opciones.OrderBy(x => Guid.NewGuid()).ToList();
        }

    }
}
