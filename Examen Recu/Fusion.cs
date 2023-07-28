public class Fusion : Personaje
{
    protected Personaje personaje1;
    protected Personaje personaje2;

    public Fusion(Personaje personaje1, Personaje personaje2)
    {
        this.personaje1 = personaje1;
        this.personaje2 = personaje2;
    }

    public override string ObtenerNombre()
    {
        return $"{personaje1.ObtenerNombre()} + {personaje2.ObtenerNombre()}";
    }
}