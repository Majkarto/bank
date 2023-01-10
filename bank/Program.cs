// See https://aka.ms/new-console-template for more information
using bank;
using System.Collections.Generic;
using System.IO;

//ekran powitalny
hello wellcome = new hello() ;

//komunikat przy złych danych
badansw incorrect= new badansw() ;
//sprawdzanie poprawności danych
correctAnswer isCorrect = new correctAnswer();


error badlogin = new error();


displayClient displayclients = new displayClient();


//dodanie klijentów
List<client> lstcliects = new List<client>();
lstcliects.Add(new client("1", "Jan Nowak", "001", 1457.23m));
lstcliects.Add(new client("2", "Agnieszka Kowalska", "002", 3600.18m));
lstcliects.Add(new client("3", "Robert Lewandowski", "003", 2745.03m));
lstcliects.Add(new client("4", "Zofia Plucińska", "004", 7344.00m));
lstcliects.Add(new client("5", "Grzegorz Braun", "005", 455.38m));
bool prog = true;
while (prog)
{
    string odpowiedz = wellcome.welcomescreen();
    if(isCorrect.correct(odpowiedz))
    {
        switch (odpowiedz) 
        {
            case "1":
                {
                    
                    Console.Clear();
                    Console.WriteLine("ID | IMIĘ I NAZWISKO | NR KONTA | SALDO");
                    foreach (var clients in lstcliects)
                    {
                        displayclients.display(clients.Id, clients.Name, clients.AccountNr, clients.AccountValue);
                    }
                }
                break;
            case "2":
                {
                    Console.Clear();
                    Console.Write("ZALOGUJ SIĘ WYBIERAJĄC ID KLIENTA: ");
                    string odp = Console.ReadLine();
                    if ((int.TryParse(odpowiedz, out int idCliect)) && (lstcliects.Exists(x => x.Id == odp)))
                    {
                        
                        var logged = lstcliects.Where(q => q.Id == odp).ToList();
                        Console.WriteLine("ZALOGOWANY KLIENT");
                        displayclients.display(logged[0].Id, logged[0].Name, logged[0].AccountNr, logged[0].AccountValue);
                        Console.WriteLine("wpisz numer konta na który chcesz zrobić przelew");
                        string pay = Console.ReadLine();
                        if (lstcliects.Exists(x => x.AccountNr == pay))
                        {
                            Console.Clear();
                            Console.WriteLine("podaj kwotę przelewu");
                            string value = Console.ReadLine();
                            if(int.TryParse(value, out int howMutch))
                                {
                                if (logged[0].AccountValue > howMutch)
                                    {
                                    var index = lstcliects.FindIndex(c => c.Id == odp);
                                    var indexpay = lstcliects.FindIndex(c => c.AccountNr == pay);
                                    lstcliects[index].AccountValue -= howMutch;
                                    lstcliects[indexpay].AccountValue += howMutch;
                                    Console.Clear() ;
                                    Console.WriteLine("przelew wykonany poprawnie");

                                }
                            }
                        }
                        else
                        {
                            badlogin.loginerror();
                        }
                    }
                    else
                    {
                        badlogin.loginerror();
                    }
                    break;
                }
            default:
                prog = false;
                break;


        }
    }
    else
    {
        incorrect.bad();
    }
    
}




