using linQ.Modulo_FirstOrDefault;
using linQ.Model;
namespace linQ.Modulo_Join
{
    public class joinModule
    {

        public static IEnumerable<Persona> pers = firstOrDefault.perss;
  public static List<Persona> personas = new List<Persona>() {
                            new Persona { Name = "Eduardo", EmployeeId = 1, },
                            new Persona { Name = "Nidia",  EmployeeId = 1 },
                            new Persona { Name = "Alejandro", EmployeeId = 3 },
                            new Persona { Name = "Valentina",  EmployeeId = 2 },
                            new Persona { Name = "Roberto",  EmployeeId = 3 },
                            new Persona { Name = "Eugenia"},
                            new Persona { Name = "Esmerlin", EmployeeId = 3 }
                            };

        public static List<Empresa> empresas = new List<Empresa>()
            {
                new Empresa{Id = 1, Nombre = "Electrodomésticos Felipe"},
                new Empresa{Id = 2, Nombre = "Bicicletas Valentina"},
                new Empresa{Id = 3, Nombre = "Gimnasio Esmerlin"},
                new Empresa{Id = 4, Nombre = "Ferreteria Lorenzo"}
            };

        public static void joinExample()
        {
            var personasYempresas= personas.Join(empresas, p=> p.EmployeeId, e=> e.Id, (persona, empresa)=> new{
                Persona=persona,
                Empresa= empresa,
            });

            foreach (var item in personasYempresas)
            {
                Console.WriteLine($"{item.Persona.Name} trabaja en {item.Empresa.Nombre}");
            }

            //query
            var personasYempresasQuery= from p in personas
                                    join e in empresas
                                    on p.EmployeeId equals e.Id
                                    select new {
                                        Persona=p,
                                        Empresa=e,
                                    };
        }

         public static void leftJoinExample(){
             var empresasYSusEmpleados= empresas.GroupJoin(personas, e=> e.Id, p=> ((byte)p.EmployeeId), (empresa,personas)=>new {
                 Empresa=empresa,
                 Persona=personas,
             });
              foreach (var item in empresasYSusEmpleados)
            {
                Console.WriteLine($"Las siguientes personas trabajan en {item.Empresa.Nombre}");

                foreach (var persona in item.Persona)
                {
                    Console.WriteLine($"-{persona.Name}");
                }
            }
         }
    }
}