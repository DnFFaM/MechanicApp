using ØvelseCase2.Codes;
using ØvelseCase2.Codes.Enum;
using System.ComponentModel;

string tekstTilMenu;
EnumSH SearchC = EnumSH.Unkown;

KøreTøj køretøj = new();

Console.SetWindowSize(100, 30);
Console.BufferHeight = 100;

// Loop 
bool Loop = true;

// Personer 
//Kunden Person = new("Abdo", "Hansen", 77134414);

//Biler 
//BilInfo bilInfo = new("Aj4444", "BMW", "M6", EnumKøreTyper.Bil, "10/10/2015", "Bil");

// Hardcoded mekaniker
// Ekstra kommentar

while (Loop == true)
{
start:
    tekstTilMenu = ("Din Mekaniker App!!!\n\n");
    tekstTilMenu += ("\nTryk 1 For Opret Kunde.\n");
    tekstTilMenu += ("\nTryk 2 For Søg Efter Kunde.\n");
    tekstTilMenu += ("\nTryk 3 For Søg Efter Mekaniker.\n");
    tekstTilMenu += ("\n\nValg: ");
    Console.Write("{0}", tekstTilMenu);
    string? figur = Console.ReadLine();
    try
    {

        if (figur == "1")
        {
            SearchC = EnumSH.OpretKunden;
        }
        if (figur == "2")
        {
            SearchC = EnumSH.Kunden;
        }
        if (figur == "3")
        {
            SearchC = EnumSH.Mekaniker;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"There is something wrong in our application, please look at this message: {ex.Message}");
        Console.ReadKey();
        Console.Clear();
        goto start;
    }

    switch (SearchC)
    {
        case EnumSH.OpretKunden:
            {
                try
                {
                    Console.WriteLine("\nFirst Name: ");
                string? FirstName = Console.ReadLine();

                Console.WriteLine("\nLast Name: ");
                string? LastName = Console.ReadLine();
                
                Console.WriteLine("\nTlf: ");
                int Tlf = Convert.ToInt32(Console.ReadLine());
                

                Kunden kunde = new(FirstName,LastName,Tlf);

                

                Console.WriteLine("\nNummerPlade: ");
                string? NummerPlade = Console.ReadLine();
                
                Console.WriteLine("\nMærke: ");
                string? Mærke = Console.ReadLine();
                
                Console.WriteLine("\nModel: ");
                string? Model = Console.ReadLine();

                    Console.WriteLine("\nFormat (DD/MM/ÅR)");
                    Console.WriteLine("RegÅrgang: ");
                    string? RegistreringsÅrgang = Console.ReadLine();
                    string[] SynSplit = RegistreringsÅrgang.Split('/');
                    string day = SynSplit[0];
                    string month = SynSplit[1];
                    string year = SynSplit[2];
                    DateTime BrugerInput = new DateTime(Convert.ToInt16(year), Convert.ToInt16(month), Convert.ToInt16(day));
                    Console.WriteLine("\nAngive Køre Type: ");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine($"{EnumKøreTyper.Bil} | {EnumKøreTyper.MotroCykel} | {EnumKøreTyper.LastBil}");
                    Console.WriteLine("-----------------------------");
                    string? Type = Console.ReadLine();

                    if (Type == EnumKøreTyper.Bil.ToString())
                    {
                        køretøj.KøretøjList.Add(new KøreTøj(NummerPlade, Mærke, Model, RegistreringsÅrgang, EnumKøreTyper.Bil, kunde));
                    }

                    else if (Type == EnumKøreTyper.MotroCykel.ToString())
                    {
                        køretøj.KøretøjList.Add(new KøreTøj(NummerPlade, Mærke, Model, RegistreringsÅrgang, EnumKøreTyper.MotroCykel, kunde));
                    }
                    else if (Type == EnumKøreTyper.LastBil.ToString())
                    {
                        køretøj.KøretøjList.Add(new KøreTøj(NummerPlade, Mærke, Model, RegistreringsÅrgang, EnumKøreTyper.LastBil, kunde));
                    }
                    Console.Clear();

                    Console.WriteLine($"Kunden Oprettet : {FirstName} {LastName} TelfoneNummer: {Tlf}");
                    Console.WriteLine($"Med Bilen = {NummerPlade} | {RegistreringsÅrgang}  | {Mærke} | {Model}\n");
                    Console.ReadKey();

                    goto start;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("");
                    goto start;
                }
            }
        case EnumSH.Kunden:
            {
                try
                {
                Console.WriteLine("\nKundens For Navn: ");
                string? KundensForNavn = Console.ReadLine();

                Console.WriteLine("\nKundens Efter Navn");
                string? KundensEfterNavn = Console.ReadLine();

                List<KøreTøj> LSD = new Kunden().Søg(KundensForNavn, KundensEfterNavn, køretøj.KøretøjList);
                Console.WriteLine("-----------------------------------------------------------------------");
                    Console.WriteLine($"\n     Mekaniker: {LSD[0].KøretøjMekaniker.FirstName} {LSD[0].KøretøjMekaniker.LastName}, Tlf: {LSD[0].KøretøjMekaniker.Tlf}");

                    foreach (KøreTøj item in LSD)
                {
                    Console.WriteLine($"\n     -     {item.Model} {item.Mærke} | {item.NummmerPlade}");
                }
                Console.WriteLine("-----------------------------------------------------------------------");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                break;
            }
        case EnumSH.Mekaniker:
            {
                try
                {
                Console.WriteLine("\nMekaniker For Navn: ");
                string? MekanikerForNavn = Console.ReadLine();

                Console.WriteLine("\nMekaniker Efter Navn");
                string? MekanikerEfterNavn = Console.ReadLine();

                List<KøreTøj> LSD = new Mekaniker().Søg(MekanikerForNavn, MekanikerEfterNavn, køretøj.KøretøjList);

                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine($"\n     {LSD[0].KøretøjMekaniker.FirstName} {LSD[0].KøretøjMekaniker.LastName}, Har Føglende Biler");
                foreach (KøreTøj item in LSD)
                {
                    Console.WriteLine($"\n     -     {item.Mærke} {item.Model} | {item.NummmerPlade} | Ejer: {item.KøretypeEjer.FirstName} {item.KøretypeEjer.LastName}, Tlf: {item.KøretypeEjer.Tlf}");
                }
                Console.WriteLine("-----------------------------------------------------------------------");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                break;
                Console.Clear();
            }
           
    }
}