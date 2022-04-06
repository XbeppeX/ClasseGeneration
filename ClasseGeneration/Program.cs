int postiAula = 10;
int numeroAlunni = 0;
string[] arrayNomi = new string[postiAula];
string[] arrayCognomi = new string[postiAula];
int[] arrayEta = new int[postiAula];


//-------- Funzioni ----------
void StampaArrayStringhe(string[] array)
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

void StampaArrayNumeri(int[] array)
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

void StampaArrayDouble(double[] array)
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

void AggiungiAlunno(string nomi, string cognomi, int eta)
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
        arrayEta[numeroAlunni] = 0;
    } else
    {
        Console.WriteLine("Mi dispiace non hai più alunni");
    }
}

double CalcoloMedia(int somma, int numeroAlunni)
{
    double nuovoNumeroAlunni = Convert.ToDouble(numeroAlunni);
    double risultato = somma / nuovoNumeroAlunni;
    return risultato;
}


int SommaElementiArray(int[] array)
{
    
    int sum = 0;

    foreach (int item in array)
    {
        sum += item;
    }

    return sum;
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
            int etaAlunno = Convert.ToInt32(Console.ReadLine());
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
    StampaArrayStringhe(arrayNomi);
    Console.WriteLine("Cognomi alunni: ");
    StampaArrayStringhe(arrayCognomi);
    Console.WriteLine("Età alunni: ");
    StampaArrayNumeri(arrayEta);
    int sommaEta = SommaElementiArray(arrayEta);
    double media = CalcoloMedia(sommaEta, numeroAlunni);
    Console.WriteLine("Età media alunni: " + (double)media);


    /*
    StampaArrayDouble(CalcolaEtaMediaClasse(arrayEta));
    Console.WriteLine("Età media alunni: " + CalcolaEtaMediaClasse(arrayEta));

    double risultato = 55 / 2f;
    Console.WriteLine((double)risultato);

    double media1 = CalcoloMedia(55, 2);
    Console.WriteLine("Età media alunni: " + (double)media1);

    double CalcolaEtaMediaClasse(int[] array)
        {
            for (int i=0; i<array.Length; i++)
            {
                array[i] = CalcoloMedia(array[i], numeroAlunni);
            }
            return array;
        }
    */

}


