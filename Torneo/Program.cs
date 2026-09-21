using System.ComponentModel.Design;

class Program
{
    public static void Main()
    {
        int opcioMenu = 0;
        int nouValor = 0;
        int suma = 0;
        int media = 0;
        int mayor = 0;
        int contador = 0;
        do
        {
            opcioMenu = EscollirOpcio();
            if (opcioMenu == 1)
            {
                nouValor = InsertarValor();
                contador++;
                if (nouValor > mayor)
                    mayor = nouValor;
                suma += nouValor;
                media = suma / contador;
                continue;
            }
            else if (opcioMenu == 2)
            {
                VeureResum(contador, suma, media, mayor);
                continue;
            }

        } while (opcioMenu != 0);
    }

    static int EscollirOpcio()
    {
        int opcio = 0;

        do
        {            
            Console.WriteLine("1.- Afegir dades");
            Console.WriteLine("2.- Veure resum");
            Console.WriteLine("0.- Sortir");
            Console.Write("Escull una opcio: ");
            string? resposta = Console.ReadLine();
            if (!int.TryParse(resposta, out opcio))
            {
                Console.WriteLine("L'opció ha de ser un número sencer");
                continue;
            }
            else if (opcio < 0 || opcio > 2)
            {
                Console.WriteLine("L'opció ha de ser 0, 1 o 2.");
                continue;
            }

            break;

        } while (true);

        return opcio;

    }

    static int InsertarValor()
    {
        int valor = 0;
        do
        {
            Console.Write("Inserta un nou valor: ");
            string? resposta = Console.ReadLine();
            if (!int.TryParse(resposta, out valor))
            {
                Console.WriteLine("El valor ha de ser un número sencer");
                continue;
            }
            else if (valor < 0 || valor > 100)
            {
                Console.WriteLine("El valor ha de ser un número entre 0 i 100.");
                continue;
            }

            break;

        } while (true);

        return valor;
    }

    static void VeureResum(int contador, int suma, int media, int mayor)
    {
        if(contador > 0)
        {
            Console.WriteLine($"S'han introduit {contador} valors");
            Console.WriteLine($"Sumen un total de {suma}");
            Console.WriteLine($"La mitja es de {media}");
            Console.WriteLine($"El valor mes gran es {mayor}");

        } else
        {
            Console.WriteLine("Encara no s'han introduit dades");
        }
    }  
}
