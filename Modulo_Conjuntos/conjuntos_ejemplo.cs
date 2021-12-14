using linQ.Model;
namespace linQ.Modulo_Conjuntos
{
    public class conjuntos_ejemplo
    {
          public static List<Persona> personas = new List<Persona>() {
                            new Persona { Name = "Eduardo", EmployeeId = 1, },
                            new Persona { Name = "Nidia",  EmployeeId = 1 },
                            new Persona { Name = "Alejandro", EmployeeId = 3 },
                            new Persona { Name = "Valentina",  EmployeeId = 2 },
                            new Persona { Name = "Roberto",  EmployeeId = 3 },
                            new Persona { Name = "Eugenia"},
                            new Persona { Name = "Esmerlin", EmployeeId = 3 }
                            };

                             public static List<Persona> personasB = new List<Persona>() {
                            new Persona { Name = "Paco", EmployeeId = 1, },
                            new Persona { Name = "Lidia",  EmployeeId = 1 },
                            new Persona { Name = "Alejandro", EmployeeId = 3 },
                            new Persona { Name = "Valentina",  EmployeeId = 2 },
                            new Persona { Name = "Rigoberto",  EmployeeId = 3 },
                            new Persona { Name = "Eufrátes"},
                            new Persona { Name = "Merlin", EmployeeId = 3 }
                            };


                             public static List<Empresa> empresas = new List<Empresa>()
            {
                new Empresa{Id = 1, Nombre = "Electrodomésticos Felipe"},
                new Empresa{Id = 2, Nombre = "Bicicletas Valentina"},
                new Empresa{Id = 3, Nombre = "Gimnasio Esmerlin"},
                new Empresa{Id = 4, Nombre = "Ferreteria Lorenzo"}
            };
        

        public static void DisctinctExample(){

            int[] numeros={1,2,3,1,1,6};

            var numerosSinRepeticiones= numeros.Distinct();
            var personasNombreDistinto= personas.DistinctBy(x=> x.Age);//.Where(x=> x.Age>18);

        }

        public static void unionExample(){
            int [] numA={1,2,3,1,1,6};
            int [] numB={1,2,15};

            //fusiona sin repetir
            var unionNumeros=numA.Union(numB);

            var unionBy=numA.UnionBy(numB,t=> t>0);
        }
        public static void exceptExample(){
            //todo lo q esta en A a excepción de lo q está en B
            int [] numA={1,2,3,1,1,6};
            int [] numB={1,2,15};
            var soloEnA=numA.Except(numB);
            var personasBnombres= personasB.Select(x=> x.Name);
            var personasEnAQueNoEstanEnB=personas.ExceptBy(personasBnombres, x=> x.Name);

        }
        public static void intersectExample(){
            //busca elementos comunes entre 2 colecciones
            int [] numA={1,2,3,1,1,6};
            int [] numB={1,2,15};
            var numerosEnAyB=numA.Intersect(numB);
            var nombresEnB=personasB.Select(x=> x.Name);
            var nombresEnAmbasListas= personas.IntersectBy(nombresEnB, t=> t.Name);
        }
    }
}