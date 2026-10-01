public class MenuAplicacio
{
    public void Iniciar()
    {
        bool sortir = false;

        while (!sortir)
        {
            Console.Clear();
            Console.WriteLine("=== TRES EN RAYA ===");
            Console.WriteLine("1. Jugar");
            Console.WriteLine("2. Salir");
            Console.Write("Elige una opción: ");
            string opcio = (Console.ReadLine() ?? "").Trim();

            switch (opcio)
            {
                case "1":
                    do
                    {
                        new Partida().Jugar();
                    } while (DemanarRejugar());
                    break;
                case "2":
                    sortir = true;
                    Console.WriteLine("¡Hasta pronto!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Pulsa una tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
        }
    }

    private bool DemanarRejugar()
    {
        while (true)
        {
            Console.Write("¿Jugar otra vez? (S/N): ");
            string resposta = (Console.ReadLine() ?? "").Trim().ToUpper();

            if (resposta == "S") return true;
            if (resposta == "N") return false;

            Console.WriteLine("Error: responde S o N.");
        }
    }
}