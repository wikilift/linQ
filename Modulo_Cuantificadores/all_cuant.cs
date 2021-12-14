using linQ.Modulo_FirstOrDefault;
namespace linQ.Modulo_Cuantificadores
{
    public class all_cuant
    {
        public static void exampleUseAll(){
            var p=firstOrDefault.perss;
            //devuelve bool
            var mayoresDeEdad= p.All(p=> p.Age>18);
            //devuelve bool
            var existeMenor= p.Any(p=> p.Age>18);


        }

        public static void containsExample(){
            var num=Enumerable.Range(1,25);
            var is3In=num.Contains(3);
            var is26in=num.Contains(26);
        }

        public static void takeExample(){

            var num=Enumerable.Range(1,125);
            var primeros10=num.Take(10);
            var ultimos10=num.TakeLast(10);
        }

        public static void skipExample(){
             var num=Enumerable.Range(1,125);
              var primeros10=num.Take(10);
              var segundoDe10=num.Skip(10).Take(10);
              var penultimoLote= num.SkipLast(10).TakeLast(10);

        }
        public static void paginacionExample(){
            var num=Enumerable.Range(1,125);
            foreach (var item in Enumerable.Range(0,9))
            {
                Console.WriteLine($"Página {item}");
                var paginado=num.Paginar(item,10);
                foreach (var numero in paginado)
                {
                    Console.WriteLine(numero);
                }
            }


        }

        public static void takeWhileExample(){
               int[] numbers={1,2,3,4,78,987,47,111,444,56426,0};
               //toma los primeros elementos que cumplan, después ignora el resultado
               var resultadoTakeWhile=numbers.TakeWhile(x=> x>5).ToList();
                //saltará mientras la condición sea verdadera
               var resulttadoTakeWhile=numbers.SkipWhile(x=>
               x<5).ToList();
        }
    }

    public static class IEnumerableExtensions{
        public static IEnumerable<T> Paginar<T>(this IEnumerable<T> coleccion,int pagina, int tamanyoLote){
            return coleccion.Skip((pagina-1)*tamanyoLote).Take(tamanyoLote);
        }

        
    }
}