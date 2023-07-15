namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var perro = new Perro();

            Console.WriteLine(perro.HacerSonido());

            Console.WriteLine("--------------------------------------");

            var gato = new Gato();

            Console.WriteLine(gato.HacerSonido());
            
            Console.WriteLine("--------------------------------------");

            var vaca = new Vaca();

            Console.WriteLine(vaca.HacerSonido());

        }
    }
}