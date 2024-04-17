using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;
using System;
using System.Xml.Linq;

namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Snack 1
            //L’utente inserisce due numeri in successione.
            //Il software stampa il maggiore.
            Console.WriteLine("Snack 1");

            int numero_uno;
            int numero_due;

            Console.WriteLine("Inserisci il primo numero");
            numero_uno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci il secondo numero");
            numero_due = Convert.ToInt32(Console.ReadLine());

            if (numero_uno > numero_due)
            {
                Console.WriteLine($"Il numero più grande è : {numero_uno}");
            }else if(numero_uno < numero_due)
            {
                Console.WriteLine($"Il numero più grande è : {numero_due}");
            }
            else
            {
                Console.WriteLine("Il numero è uguale");
            }

            //Snack 2
            //L’utente inserisce due parole in successione.
            //Il software stampa prima la parola più corta, poi la parola più lunga.
            Console.WriteLine("Snack 2");

            string parola_uno;
            string parola_due;

            Console.WriteLine("Inserisci una prima parola");
            parola_uno = Console.ReadLine();

            Console.WriteLine("Inserisci una seconda parola");
            parola_due = Console.ReadLine();

            if(parola_uno.Length > parola_due.Length)
            {
                Console.WriteLine($"la parola più corta è : {parola_due}");
                Console.WriteLine($"la parola più lunga è : {parola_uno}");
            }
            else if(parola_uno.Length < parola_due.Length)
            {
                Console.WriteLine($"la parola più corta è : {parola_uno}");
                Console.WriteLine($"la parola più lunga è : {parola_due}");
            }
            else
            {
                Console.WriteLine($"le parole hanno lunghezza uguale");
            }

            //Snack 3
            //Il software deve chiedere per 10 volte all’utente di inserire un numero.
            //Il programma stampa la somma di tutti i numeri inseriti.
            Console.WriteLine("Snack 3");
            Console.WriteLine("Adesso ti chiederemo di inserire un numero per 10 volte per poi effettuare la somma");
            int somma = 0;
            int numero;

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Inserisci un numero");
                numero = Convert.ToInt32(Console.ReadLine());
                somma += numero;
            }

            Console.WriteLine($"La somma è {somma}");

            //Snack 4
            //Calcola la somma e la media dei numeri da 2 a 10.

            //Snack 5
            //Il software chiede all’utente di inserire un numero.
            //Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.
            Console.WriteLine("Snack 5");
            int numeroPariDisapari;

            Console.WriteLine("Inserisci un numero e ti dirò se è pari o dispari");
            numeroPariDisapari = Convert.ToInt32(Console.ReadLine());

            if(numeroPariDisapari % 2  == 0)
            {
                Console.WriteLine($"Il numero {numeroPariDisapari} che hai inserito è PARI");
            }
            else
            {
                Console.WriteLine($"Il numero {numeroPariDisapari} che hai inserito è DISPARI");
            }

            //Snack 6
            //In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby.
            //Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.
            Console.WriteLine("Snack 6");
        
            string nomeInserito;
            string[] nomiInvitati = {
                "Jay Gatsby",
                "Daisy Buchanan",
                "Tom Buchanan",
                "Nick Carraway",
                "Jordan Baker",
                "Myrtle Wilson",
                "George Wilson",
                "Meyer Wolfsheim",
            };

            Console.WriteLine("Qual'è il tuo nome?");
            nomeInserito = Console.ReadLine();

            if (nomiInvitati.Contains(nomeInserito))
            {
                Console.WriteLine("Sei dentro");
            }
            else
            {
                Console.WriteLine("Sei fuori");
            }


            //Snack 7
            //Crea un array vuoto.
            //Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.

            Console.WriteLine("Snack 7");

            int[] arrayVuotoDispari = new int[6];
            int numeroInserito;

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Inserisci il {i + 1}' numero");
                numeroInserito = Convert.ToInt32(Console.ReadLine());

                if (numeroInserito % 2 == 1)
                {
                    arrayVuotoDispari[i] = numeroInserito;
                }

            }

            Console.WriteLine($"I tuoi numeri dispari sono: ");
            foreach (int numeri in arrayVuotoDispari)
            {
                if (numeri != 0)
                {
                    Console.WriteLine(numeri);
                }
            }

            //Snack 8
            //Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.

            Console.WriteLine("Snack 8");

            int[] arrayNumeri = { 1, 4, 5, 6, 7, 8, 9, 6, 4 };
            int sum = 0;

            Console.WriteLine("I tuoi numeri sono questi, adesso sommeremo quelli che sono in posizione dispari :");
            for (int i = 0; i < arrayNumeri.Length; i++)
            {
                Console.WriteLine(arrayNumeri[i]);
            }
            for (int i = 0; i < arrayNumeri.Length; i += 2)
            {
                sum += arrayNumeri[i];
            }

            Console.WriteLine($"La somma degli elementi in posizione dispari è: {sum}");


            //Snack 9
            //Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.
            //Continua a chiedere i numeri all’utente e a inserirli nell’array,
            //fino a quando la somma degli elementi è minore di 50.

            Console.WriteLine("Snack 9");

            int[] arrayEmpty = new int[10];
            int insertNumber;
            int somm = 0;

            for (int i = 0; i < arrayEmpty.Length; i++)
            {
                Console.WriteLine($"Inserisci il {i + 1}' numero fin quando non arrivi a 50");
                insertNumber = Convert.ToInt32(Console.ReadLine());

                arrayEmpty[i] = insertNumber;
                somm += insertNumber;

                if (somm >= 50)
                {

                    Console.WriteLine("La somma è maggiore o uguale di 50");
                    break;
                }
                else
                {
                    Console.WriteLine("La somma è minore di 50");
                }

            }


            //Snack 10
            //Fai inserire un numero, che chiameremo N, all’utente.
            //Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
            //Ogni volta che ne crei uno, stampalo a schermo.
        }
    }
}
