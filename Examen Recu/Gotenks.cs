public class Gotenks : Fusion
{
    public Gotenks(Personaje personaje1, Personaje personaje2) : base(personaje1, personaje2)
    {
    }

    public override string ObtenerNombre()
    {
        return $"{personaje1.ObtenerNombre()} + {personaje2.ObtenerNombre()} = Gotenks";
    }
}