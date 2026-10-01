public class Partida
{
    private Tauler tauler = new Tauler();
    private Jugador[] jugadors =
    {
        new Jugador("Jugador 1", 'X'),
        new Jugador("Jugador 2", 'O')
    };
    private int torn = 0;

    public void Jugar()
    {
        while (true)
        {
            Console.Clear();
            tauler.Dibuixar();

            Jugador actual = jugadors[torn];
            int numero = DemanarCasella(actual);
            int fila = (numero - 1) / 3;
            int col = (numero - 1) % 3;

            tauler.ColocarFitxa(fila, col, actual.Simbol);

            if (tauler.HiHaGuanyador(actual.Simbol))
            {
                Console.Clear();
                tauler.Dibuixar();
                Console.WriteLine($"¡Gana {actual.Nom} ({actual.Simbol})!");
                return;
            }

            if (tauler.EstaPle())
            {
                Console.Clear();
                tauler.Dibuixar();
                Console.WriteLine("¡Empate!");
                return;
            }

            torn = 1 - torn; // alterna entre 0 y 1
        }
    }

    private int DemanarCasella(Jugador jugador)
    {
        while (true)
        {
            Console.Write($"Turno de {jugador.Nom} ({jugador.Simbol}). Elige casilla (1-9): ");
            string entrada = Console.ReadLine() ?? "";

            if (!int.TryParse(entrada, out int numero))
            {
                Console.WriteLine("Error: introduce un número.");
                continue;
            }
            if (numero < 1 || numero > 9)
            {
                Console.WriteLine("Error: el número debe estar entre 1 y 9.");
                continue;
            }
            if (!tauler.EstaLliure((numero - 1) / 3, (numero - 1) % 3))
            {
                Console.WriteLine("Error: esa casilla ya está ocupada.");
                continue;
            }
            return numero;
        }
    }
}