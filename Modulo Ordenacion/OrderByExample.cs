using linQ.Modulo_FirstOrDefault;
using linQ.Model;
namespace linQ.Modulo_Ordenacion
{
    public class OrderByExample
    {
        public  int[] numbers={1,2,3,4,78,987,47,111,444,56426,0};
        public  IEnumerable<int> exampleOrderNumbers()=> numbers.OrderBy(x=>x);
        public IEnumerable<Persona> exampleOrderBy()=>
                         firstOrDefault.perss.OrderByDescending(x=>x.Name);
                         //orderby

        public IEnumerable<Persona> exampleMultpleOrdering()=>
            firstOrDefault.perss.OrderByDescending(x=>x.Name).ThenBy(x=>x.Single);
                                                            //ThenByDescending

          //Query
          /*
            from p in personas orderby p.Age,p.Name descending
            select p


          */                                                      
        
    }
}