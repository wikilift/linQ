using linQ.Modulo_FirstOrDefault;
using linQ.Model;
namespace linQ.Modulo_agrupacion
{
    public class group_example
    {
        public static IEnumerable<Persona> pers=firstOrDefault.perss;

        public static void grouByExample(){
            //genera key
            var soloSolteros=pers.GroupBy(z=> z.Single);
            //en rangos de 5 por edad
            var edad= pers.GroupBy(edad=> edad.Age/5).ToList() ;
            //va a recorrer todos los grupos, dando el valor de las vvariables
            foreach (var grupo in soloSolteros)
            {
                Console.WriteLine($"grupo de personas donde soltero es{grupo.Key} total {grupo.Count()}");
                foreach (var persona in grupo)
                {
                      Console.WriteLine($"{persona.Name}"); 
                }
           }

           var queryExample= from p in pers
                            group p by p.Single into grupos
                            select grupos;
        
         foreach (var grupo in edad)

            {
                //se multiplica x lo q se ha divido
                Console.WriteLine($"grupo de personas donde soltero es{grupo.Key*5}-{grupo.Key*5+5-1} total {grupo.Count()}");
                foreach (var persona in grupo)
                {
                      Console.WriteLine($"Nombre: {persona.Name} Edad: {persona.Age}"); 
                }
           }

        
        }
        
    }
}