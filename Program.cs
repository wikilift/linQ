using System;
using System.Collections.Generic;
using linQ.Modulo_Filtado;
using linQ.Modulo_FirstOrDefault;
using linQ.Modulo_where;
using linQ.WhereWith_Objects;
using linQ.Modulo_Ordenacion;
using linQ.Modulo_Proyecciones;
using linQ.Modulo_Escalares;
/* using linQ.WhereWith_Objects;
using linQ.Modulo_where;
using linQ.M Modulo_FirstOrDefault; */

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //modulo 2 filtros
            // where_simple.exampleWhereSimple();
            // where_withObjects.whereWithObjects();
            //var f=new firstOrDefault();

            /*   f.exampleFirstOrDefault();
              f.exampleLastOrDefault();
              Console.WriteLine(f.exampleElementAt(0).Name); */
            //Console.WriteLine(f.exampleSingle().Name);

            //Modulo 3 ordenacion
        /*     var filter = new OrderByExample();
            var otherOrderTest = filter.numbers.ToList().OrderBy(x => x);
            Console.WriteLine(String.Join(",", otherOrderTest));
            var orderQuery = (from n in filter.numbers.ToList()
                              select n).OrderBy(z => z);
            Console.WriteLine(String.Join(",", otherOrderTest));
            var personasAlfabeticoYsolteras=filter.exampleMultpleOrdering().ToList();
            personasAlfabeticoYsolteras.ForEach(X=>Console.WriteLine(X.Name));
            //crea una nueva lista por valor
            var enumerable=filter.numbers.AsEnumerable().Reverse();
            Console.WriteLine(String.Join(",", enumerable));
            //por referencia actua sobre la original
            personasAlfabeticoYsolteras.Reverse();
            personasAlfabeticoYsolteras.ForEach(X=>Console.WriteLine(X.Name));

            //creamos una nueva lista
            var invertidos=personasAlfabeticoYsolteras.AsEnumerable().Reverse().ToList();
         */
         
         //Modulo 4 proyecciones

         //select.exampleSelect();
        //Modulo escalares
        Console.WriteLine($"Int max value: {int.MaxValue.ToString("N")}");
        var t=new Escalares_Count();
        t.escalaresExample();
         
         
         
         }
    }
}