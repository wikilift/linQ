using linQ.Model;

namespace linQ.Modulo_FirstOrDefault
{
    public class firstOrDefault
    {
        public static List<Persona> perss = new List<Persona>() {
        new Persona { Name = "Eduardo", Age = 30, dateOfStart = new DateTime(2021, 1, 2), Single = true },
        new Persona { Name = "Nidia", Age = 19, dateOfStart = new DateTime(2015, 11, 22), Single = true },
        new Persona { Name = "Alejandro", Age = 45, dateOfStart = new DateTime(2020, 4, 12), Single = false },
        new Persona { Name = "Valentina", Age = 24, dateOfStart = new DateTime(2021, 7, 8), Single = false },
        new Persona { Name = "Roberto", Age = 61, dateOfStart = DateTime.Now.AddDays(-1), Single = false }
        };
        public void exampleFirstOrDefault()
        {


            var firstPerson = perss.FirstOrDefault(p => !p.Single && p.Age > 50);

            //sintaxis de query
            var firstPerson2 = (from p in perss
                                where !p.Single && p.Age > 50
                                select p).FirstOrDefault();
            Console.WriteLine(firstPerson2?.Name);
        }

        public void exampleLastOrDefault()
        {
            var firstPerson = perss.FirstOrDefault(p => !p.Single && p.Age < 50);
            Console.WriteLine(firstPerson?.Name);
        }
        public Persona exampleElementAt(int x) =>
             perss.ElementAt(x);

#pragma warning disable CS8603
        public Persona exampleElementAtOrDefault(int x) =>
           (x < perss.Count()) ? perss.ElementAtOrDefault(x) : new Persona();


        public Persona exampleElementAtOrDefaultQuery(int x) => (from p in perss
                                                                 select p).ElementAtOrDefault(x);


        //PERSONA mayor de 60 solo si hay 1 sino revienta
#pragma warning disable CS8603
        public Persona exampleSingle() => perss.SingleOrDefault(p => p.Age > 60);
        //query mode:
        /*
        var x= from p in persona where p.Age>60 select p).SingleOrDefault()
        */
    }
}