
// Inserisco le variabili del libro 
Console.WriteLine("Inserisci il titolo del libro");
string titoloLibro = Console.ReadLine();

Console.WriteLine("Inserisci l' autore del libro");
string autoreLibro = Console.ReadLine();

Console.WriteLine("Inserisci l' ISBN del libro");
string isbnLibro = Console.ReadLine();

Console.WriteLine("Inserisci il numero di pagine del libro");
int numPagineLibro = int.Parse(Console.ReadLine());

Console.WriteLine("Inserisci il peso del libro");
float pesoLibro = float.Parse(Console.ReadLine());

Console.WriteLine("Inserisci la prima dimensione del libro");
float dimensione1 = float.Parse(Console.ReadLine());

Console.WriteLine("Inserisci la seconda dimensione del libro");
float dimensione2 = float.Parse(Console.ReadLine());

Console.WriteLine("Inserisci la terza dimensione del libro");
float dimensione3 = float.Parse(Console.ReadLine());

Console.WriteLine("Inserisci la valutazione in stelle del libro");
float valutazioneStelle = float.Parse(Console.ReadLine());

Console.WriteLine("Inserisci il numero di recensioni del libro");
int numeroRecensioni = int.Parse(Console.ReadLine());

Console.WriteLine("Il libro è presente su kindle? (y='si' ; n='no')");
string isOnKindle = Console.ReadLine();

Console.WriteLine("E' disponibile la versione con copertina flessibile? (y='si' ; n='no') ");
string flexCoverAvailable = Console.ReadLine();




// Inizio a stampare le variabili
Console.WriteLine("-------- " + titoloLibro + " --------");
Console.WriteLine("di: " + autoreLibro);
Console.WriteLine("ISBN: " + isbnLibro);
Console.WriteLine("Numero Pagine: " + numPagineLibro);
Console.WriteLine("Peso: " + pesoLibro + " g");
Console.WriteLine("Dimensioni: " + dimensione1 + " cm, " + dimensione2 + " cm, " + dimensione3 + " cm, ");
Console.WriteLine("Valutazione: " + valutazioneStelle + " stelle");
Console.WriteLine("Numero Recensioni " + numeroRecensioni + " recensioni utente");
if (isOnKindle == "y")
{
    Console.WriteLine("Disponibile su kindle: Si");
}

else
{
    Console.WriteLine("Disponibile su kindle: No");
}

if (flexCoverAvailable == "y")
{
    Console.WriteLine("Copertina flessibile disponibile: Si");
}

else
{
    Console.WriteLine("Copertina flessibile disponibile: No");
}





