using linQ.Model;
namespace linQ.WhereWith_Objects
{
    class where_withObjects
    {

        public static  void whereWithObjects()
        {

            Console.WriteLine("Pene");
            var perss = new List<Persona>() {
        new Persona { Name = "Eduardo", Age = 30, dateOfStart = new DateTime(2021, 1, 2), Single = true },
        new Persona { Name = "Nidia", Age = 19, dateOfStart = new DateTime(2015, 11, 22), Single = true },
        new Persona { Name = "Alejandro", Age = 45, dateOfStart = new DateTime(2020, 4, 12), Single = false },
        new Persona { Name = "Valentina", Age = 24, dateOfStart = new DateTime(2021, 7, 8), Single = false },
        new Persona { Name = "Roberto", Age = 61, dateOfStart = DateTime.Now.AddDays(-1), Single = false }
        };

        var peopleUnder25years=perss.Where(p=>p.Age<=25).ToList();
        peopleUnder25years.ForEach(x=>Console.WriteLine($"{x.Name} tiene {x.Age} años"));
        
        var singles=perss.Where(p=>p.Single && p.Age<=25).ToList();
        singles.ForEach(s=>Console.WriteLine($"{s.Name} es soltero"));

        var newEmployee= perss.Where(p=>p.dateOfStart >= DateTime.Now.AddMonths(-3)).ToList();
        newEmployee.ForEach(e=>Console.WriteLine($"{e.Name} es un nuevo employee"));

        //sintaxis query
        var newEmployee2= from p in perss  
                            where p.dateOfStart>=DateTime.Now.AddMonths(-3)
                            select p;


        
        }
        
    }


}

