public class program {
    
    public static void Main ()
    {

        Console.WriteLine("inserire nome cliente");
        string nomeCliente = Console.ReadLine();

        Console.WriteLine("Quanti libri ha acquistato?");
        int numeroLibri = int.Parse(Console.ReadLine());

        Console.WriteLine("Sei uno studende del Pascal? (si/no)");
        string rispostaStudente = Console.ReadLine();

        Console.WriteLine("Quanto costa un libro?");
        double prezzoLibro = double.Parse(Console.ReadLine());

        for (int i = 1; i <= numeroLibri; i++)
        {
            Console.WriteLine("Inserire il nome del libro ");
            string nomeLibro = Console.ReadLine();
        }

        double prezzosubTotale = numeroLibri * prezzoLibro;
        
        Console.WriteLine("Che tipo di spedizioe vuoi? (standard/express)");
        string tipoSpedizione = Console.ReadLine();

        double prezzototale = 0;

        if (tipoSpedizione == "express")
        {
            prezzototale = prezzosubTotale + 5;

            Console.WriteLine($"Il nome del cliente è: {nomeCliente}, che ha acquistato {numeroLibri}. Il prezzo sub totale è: {prezzosubTotale}, e il prezzo totale è: {prezzototale} perchè si ha scelto la spedizione express");
        }
        else
        {
            Console.WriteLine($"Il nome del cliente è: {nomeCliente}, che ha acquistato {numeroLibri}. Il prezzo sub totale è: {prezzosubTotale}, e il prezzo totale è: {prezzototale} perchè si ha scelto la spedizione standard");
        }
    }

}
