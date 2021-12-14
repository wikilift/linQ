namespace linQ.Modulo_Filtado
{

    public class Filtrado
    {
        void init(){
            List<Object> l = new List<object>(){"paco",2,"pene",2.5f,true};
            var strings=l.OfType<string>();

            //query mode
            var stringsQ=from s in l.OfType<string>() select s;
            //utilizANdo herencia
            var listadoAnimales=new List<Animal>(){
                new Perro(){Nombre="Firulais"},
                new Gato(){Nombre="Garfield"}
            };
             var perros=listadoAnimales.OfType<Perro>();
        }


         
    }

     public abstract class Animal
        {
            public abstract string? Nombre { get; set; }
        }

        public class Perro : Animal
        {
            public override string? Nombre { get; set; }
        }

        public class Gato : Animal
        {
            public override string? Nombre { get; set; }
        }
}