public class Jugador
{
    public string Nom { get; }
    public char Simbol { get; }

    public Jugador(string nom, char simbol)
    {
        Nom = nom;
        Simbol = simbol;
    }
}