using linQ.Modulo_FirstOrDefault;
using System.Collections;
using linQ.Model;
namespace linQ.Modulo_Proyecciones
{
    public class select
    {
        public static  List<Persona> personas = new List<Persona>() {
new Persona { Name = "Eduardo", Phones = { "123-456", "789-852" } },
new Persona { Name = "Nidia", Phones = { "998-478", "568-222" } },
new Persona { Name = "Alejandro", Phones = { "712-132" } },
new Persona { Name = "Valentina" }
};
        public static void exampleSelect()
        {
            var names = firstOrDefault.perss.Select(p => p.Name).ToList();
            //proyecta hacia una clase anonima nueva
            var nombresYedades = firstOrDefault.perss.Select(p => new { Name = p.Name, culo = p.Age }).ToList();
            var nombresYedadesDTO = firstOrDefault.perss.Select(t => new PersonaDTO { Name = t.Name, edad = t.Age }).ToList();

            //con numeros
            var numbers = Enumerable.Range(1, 8).ToList();
            var numbersX2 = numbers.Select(n => 2 * n);

            //personas con indice
            var personasConIndice = firstOrDefault.perss.Select((p, index) => new { Persona = p, Index = index }).ToList();
            foreach (var es in personasConIndice)
            {
                Console.WriteLine($"{es.Index}{es.Persona.Name}");
            }

            //query
            var queryNames = (from name in firstOrDefault.perss
                              select name.Name);
            var queryNamesAndAge = from p in firstOrDefault.perss
                                   select new { Putilla = p.Name, Penecillo = p.Age };
            var numbersX2Query = from n in numbers
                                 select n * 2;
            //var personasConIndiceX2   no se puede hacer con query.

            //*********************************************************
            //select many
            var telefonos=personas.SelectMany(p=> p.Phones).ToList();

            //dos colecciones
            int[] numeritos={1,2,3};
            var personasYnumeros=personas.SelectMany(p=> numeritos,(persona,numerito) => new {
                    Persona=persona,
                    numeritos=numerito
            });

            //practico misma persona distintos telefonos.
            var personasYtelefonos=personas.SelectMany(p=> p.Phones,(persona,telefono)=> new {
                Persona=persona,
                Phones=telefono,
            });
            //querys
            var telefonos_2= from p in personas from telefono in p.Phones select telefono;

            var personasYnumeros_2= from p in personas from n in numeritos 
                                    select new {
                                        Personaje=p,
                                        Numerito=n
                                    };
        }
    }
}