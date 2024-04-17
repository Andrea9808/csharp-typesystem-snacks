namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Snack 1
            //L’utente inserisce due numeri in successione.
            //Il software stampa il maggiore.

            int numero_uno;
            int numero_due;

            Console.WriteLine("Inserisci il primo numero");
            numero_uno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci il secondo numero");
            numero_due = Convert.ToInt32(Console.ReadLine());

            if (numero_uno > numero_due)
            {
                Console.WriteLine($"Il numero più grande è {numero_uno}");
            }else if(numero_uno < numero_due)
            {
                Console.WriteLine($"Il numero più grande è {numero_due}");
            }
            else
            {
                Console.WriteLine("Il numero è uguale");
            }
          
        }
    }
}
