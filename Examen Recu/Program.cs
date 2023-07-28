internal class Program
{
    public static void Main(string[] args)
    {
        // Crear instancias de personajes
        Personaje goku = new Goku();
        Personaje vegeta = new Vegeta();
        Personaje goten = new Goten();
        Personaje trunks = new Trunks();

        // Realizar fusiones
        Personaje gogeta = new Fusion(goku, vegeta);
        Personaje gotenks = new Fusion(goten, trunks);

        // Mostrar nombres de las fusiones resultantes
        Console.WriteLine($"{gogeta.ObtenerNombre()} = Gogeta");   // Gogeta
        Console.WriteLine($"{gotenks.ObtenerNombre()} = Gotenks");  // Gotenks
    }
}
