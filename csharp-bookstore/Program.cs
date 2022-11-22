
// Inserisco le variabili del libro 
string titoloLibro = "-------- La guerra dei mondi --------";
string autoreLibro = "H. G. Wells";
string isbnLibro = "8834739183";
int numPagineLibro = 252;
int pesoLibro = 300;               //essendo hardcoding, assegno int anzichè float essendo un numero intero
float dimensione1 = 12.5f;
float dimensione2 = 2.8f;
int dimensione3 = 18;              //essendo hardcoding, assegno int anzichè float essendo un numero intero
float valutazioneStelle = 4.5f;
int numeroRecensioni = 126;
bool isOnKindle = true;
bool flexCoverAvailable = true;

// Inizio a stampare le variabili
Console.WriteLine(titoloLibro);
Console.WriteLine("di: " + autoreLibro);
Console.WriteLine("ISBN: " + isbnLibro);
Console.WriteLine("Numero Pagine: " + numPagineLibro);
Console.WriteLine("Peso: " + pesoLibro + " g");
Console.WriteLine("Dimensioni: " + dimensione1 + " cm, " + dimensione2 + " cm, " + dimensione3 + " cm, ");
Console.WriteLine("Valutazione: " + valutazioneStelle + " stelle");
Console.WriteLine("Numero Recensioni " + numeroRecensioni + " recensioni utente");

//Creo due if per printare "si" anziche "true"

if (isOnKindle == true)
{
    Console.WriteLine("Disponibile su kindle: Si");
}

if (flexCoverAvailable == true)
{
    Console.WriteLine("Copertina flessibile disponibile: Si");
}




