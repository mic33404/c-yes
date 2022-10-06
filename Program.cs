// See https://aka.ms/new-console-template for more information
string valg = "1";
while(valg != "5"){
    Console.WriteLine("Velkomen hit");
    Console.WriteLine("1.Legg inn ny ansatt");
    Console.WriteLine("2.Redigere ansatt");
    Console.WriteLine("3.Slett ansatt");
    Console.WriteLine("4.List ut alle ansatte");
    Console.WriteLine("5.Avslutt");
    Console.WriteLine("velg en av alternativan over");

    valg = Console.ReadLine();
    List<string> ansatt = new List<string>();
    List<List<string>> ansattlist = new List<List<string>>();

    if(valg=="1"){
        Console.WriteLine("fyll in valgan");
        string fornavn;
        Console.WriteLine("skrive in fornavn");
        fornavn = Console.ReadLine();
        string etternavn;
        Console.WriteLine("skrive in etternavn");
        etternavn = Console.ReadLine();
        string stillingstittel;
        Console.WriteLine("skrive in stillingstitttel");
        stillingstittel = Console.ReadLine();
        string avdeling;
        Console.WriteLine("skrive in avdeling");
        avdeling = Console.ReadLine();
        ansatt.Add(fornavn);
        ansatt.Add(etternavn);
        ansatt.Add(stillingstittel);
        ansatt.Add(avdeling);
        ansattlist.Add(ansatt);
        Console.WriteLine("1.til bake til start");
        Console.WriteLine("5.avslutt program");
        valg = Console.ReadLine();


    }
    else if(valg=="2"){
        Console.WriteLine("");
    }
    else if(valg=="3"){
        Console.WriteLine("hadde");
    }
    else if(valg=="4"){
        Console.WriteLine("du tok 4");
    }
    else if(valg=="5"){
        Console.WriteLine("du tok 5");
    }
}


