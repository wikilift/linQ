using linQ.Model;
namespace linQ.Modulo_Extra
{
    public class miscelanea
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

        public static void concatExample()
        {
            //permite empalmar dos colecciones
            int[] numA = { 1, 2, 3, 1, 1, 6 };
            int[] numB = { 1, 2, 15 };
            var result = numA.Concat(numB);

        }
        public static void sequenceEqualExample()
        {
            //comprueba si dos colecciones tienen exáctamente la misma secuencia, es decir, si son iguales
            string[] A = { "felipe", "fernando" };

            string[] B = { "felipe", "fernando" };

            string[] C = { "FEliPE", "FernandO" };

            string[] D = { "fernando", "felipe" };

            var AB = A.SequenceEqual(B); //true


            var AC = A.SequenceEqual(C);//false

            var AD = A.SequenceEqual(D);//false


            //ignoral mayúsculas
            var ACSinImportarMayusculas = A.SequenceEqual(C, StringComparer.OrdinalIgnoreCase);// true

            
        }

        public static void chunkExample(){
            //permite hacer subcolecciones
            int[]A={1,2,3,4,5,6,7,8,9,10};
            var result= A.Chunk(2); // => esto devuelve un array de array pos 0= [1,2] pos 1=[3,4]....
        }

        public static void zipExample(){
            //permite realizar tareas sobre dos colecciones según el orden

             int[] A = { 1, 2, 3 };
            int[] B = { 4, 5, 6 };

            var combinados = A.Zip(B);
            foreach (var combinacion in combinados)
            {
                Console.WriteLine($"({combinacion.First}, {combinacion.Second})");
            }

            //realiza la operación para cada valor
            var resultado = A.Zip(B, (a, b) => a * b);

        }
        
        public static void tryCount(){
            int[]A={1,2,3,4,5,6,7,8,9,10};
            var count=0;
            var contadoSinEnumerar=A.TryGetNonEnumeratedCount(out count);//true o false; si no puede contar d una manera eficiente
            
        }
    }
}