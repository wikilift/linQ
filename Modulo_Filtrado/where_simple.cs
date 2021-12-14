namespace linQ.Modulo_where
{
    public class where_simple
    {


        public static void exampleWhereSimple()
        {
            int[] numbers = Enumerable.Range(1, 100).ToArray();


            //sintaxis de lambda
            var pairs = numbers.Where(n =>
            {
                Console.WriteLine("pene");
                return n % 2 == 0;
            });
            //tolist fuerza a que ocurra, sinó queda en standby como un yield
            //pasa parámetros como un yield si no es un ToList
            /*foreach (var i in pairs)
            {
                Console.WriteLine($"Sí, el número {i}, es par");
            }*/

            //multifiltro


            var numbersPairsGreaterThan10 = numbers.Where(n => n % 2 == 0 && n <= 10);

            foreach (var i in numbersPairsGreaterThan10)
            {
                Console.WriteLine(i);
            }

            //sintaxis de query

            var numbersPairsGreaterThan10_2 = from n in numbers
                                              where n % 2 == 0 && n < 10
                                              select n;


        }
        //rango de numeros.
    }
}