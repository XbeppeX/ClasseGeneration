int postiAula = 10;
int numeroAlunni = 0;
string[] arrayNomi = new string[postiAula];
string[] arrayCognomi = new string[postiAula];
string[] arrayEta = new string[postiAula];


//-------- Funzioni ----------
void StampaArray(string[] array)
{
    int ultimoIndiceArray = array.Length - 1;
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == ultimoIndiceArray)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
    Console.WriteLine("]");
}

void AggiungiAlunno(string nomi, string cognomi, string eta)
{
    if (numeroAlunni < postiAula)
    {
        arrayNomi[numeroAlunni] = nomi;
        arrayCognomi[numeroAlunni] = cognomi;
        arrayEta[numeroAlunni] = eta;
        numeroAlunni++;
    }else
    {
        Console.WriteLine("Mi dispiace non hai più posti a sedere");
    }
    
}

void DecrementoAlunno()
{
   if (numeroAlunni > 0)
    {
        numeroAlunni--;
        arrayNomi[numeroAlunni] = "";
        arrayCognomi[numeroAlunni] = "";
        arrayEta[numeroAlunni] = "";
    } else
    {
        Console.WriteLine("Mi dispiace non hai più alunni");
    }
}

//-------- Programma ---------

Console.WriteLine("Il tuo numero di posti in aula sono: " + postiAula);

while (true)
{
    Console.WriteLine("Dimmi se vuoi aggiungere o rimuovere un alunno [aggiungi/rimuovi]? ");
    string risposta = Console.ReadLine().ToLower();

    switch (risposta)
    {
        case "aggiungi":
            Console.WriteLine("Dimmi nome: ");
            string nomeAlunno = Console.ReadLine();
            Console.WriteLine("Dimmi cognome: ");
            string cognomeAlunno = Console.ReadLine();
            Console.WriteLine("Dimmi eta: ");
            string etaAlunno = Console.ReadLine();
            AggiungiAlunno(nomeAlunno, cognomeAlunno, etaAlunno);
            break;
        case "rimuovi":
            DecrementoAlunno();
            break;
        default:
            Console.WriteLine("Mi dispiace opzione non contemplata");
            break;
    }

    Console.WriteLine("Il numero di alunni è: " + numeroAlunni);
    Console.WriteLine("Nomi alunni: ");
    StampaArray(arrayNomi);
    Console.WriteLine("Cognomi alunni: ");
    StampaArray(arrayCognomi);
    Console.WriteLine("Età alunni: ");
    StampaArray(arrayEta);
}


