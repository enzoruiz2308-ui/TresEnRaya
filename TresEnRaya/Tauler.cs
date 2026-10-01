public class Tauler
{
    private char[,] caselles = new char[3, 3];

    public Tauler()
    {
        Netejar();
    }

    public void Netejar()
    {
        for (int f = 0; f < 3; f++)
            for (int c = 0; c < 3; c++)
                caselles[f, c] = ' ';
    }

    public bool EstaLliure(int fila, int col)
    {
        return caselles[fila, col] == ' ';
    }

    public void ColocarFitxa(int fila, int col, char simbol)
    {
        caselles[fila, col] = simbol;
    }

    public bool HiHaGuanyador(char s)
    {
        for (int i = 0; i < 3; i++)
        {
            if (caselles[i, 0] == s && caselles[i, 1] == s && caselles[i, 2] == s) return true;
            if (caselles[0, i] == s && caselles[1, i] == s && caselles[2, i] == s) return true;
        }
        if (caselles[0, 0] == s && caselles[1, 1] == s && caselles[2, 2] == s) return true;
        if (caselles[0, 2] == s && caselles[1, 1] == s && caselles[2, 0] == s) return true;
        return false;
    }

    public bool EstaPle()
    {
        for (int f = 0; f < 3; f++)
            for (int c = 0; c < 3; c++)
                if (caselles[f, c] == ' ') return false;
        return true;
    }

    public void Dibuixar()
    {
        Console.WriteLine();
        for (int f = 0; f < 3; f++)
        {
            Console.WriteLine($" {Mostrar(f, 0)} | {Mostrar(f, 1)} | {Mostrar(f, 2)} ");
            if (f < 2) Console.WriteLine("---+---+---");
        }
        Console.WriteLine();
    }

    // Si la casilla está vacía, muestra su número (1-9) para ayudar al jugador
    private char Mostrar(int f, int c)
    {
        if (caselles[f, c] == ' ')
            return (char)('1' + f * 3 + c);
        return caselles[f, c];
    }
}