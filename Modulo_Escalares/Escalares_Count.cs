using linQ.Modulo_FirstOrDefault;

using System.Collections;
namespace linQ.Modulo_Escalares
{
    public class Escalares_Count
    {
        public void escalaresExample()
        {
            firstOrDefault.perss.Count();
            firstOrDefault.perss.Count(p => p.Single);
            // longCount-> para longs
            var numeritos = Enumerable.Range(1, 1000);
            Console.WriteLine($"La suma de  numeritos es {numeritos.Sum()}");
            Console.WriteLine($"La suma de  edades es {firstOrDefault.perss.Sum(p => p.Age)}");
            //retorna valor
            Console.WriteLine($"La edad máxima es {firstOrDefault.perss.Max(p => p.Age)}");
            Console.WriteLine($"La edad mínima es {firstOrDefault.perss.Min(p => p.Age)}");
            //retorna objeto
            Console.WriteLine($"Laedad máxima es {firstOrDefault.perss.MaxBy(p => p.Age)}");
            Console.WriteLine($"La edad mínima es {firstOrDefault.perss.MinBy(p => p.Age)}");
            Console.WriteLine($"El promedio de los numeros es {numeritos.Average()}");
            Console.WriteLine($"El promedio de las edades es {firstOrDefault.perss.Average(p => p.Age)}");
            numeritos.Aggregate( (a,b) => a *b); //1*2*3*4*5*6.....
            //con semilla
            var resultSeed= numeritos.Aggregate(10, (a,b) => a *b); //1*2*3*4*5*6.....

        }
    
}
}