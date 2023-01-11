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

//komunikat złego loginu
error badlogin = new error();

//wyświetlanie klijentów
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
    //wyświetlenie ekranu powitalnego
    string odpowiedz = wellcome.welcomescreen();
    //czy odpowiedź użytkownika jest poprawna
    if(isCorrect.correct(odpowiedz))
    {
        //sprawdzanie jaką odpowiedź dał użytkownik
        switch (odpowiedz) 
        {
            case "1":
                {
                    
                    Console.Clear();
                    Console.WriteLine("ID | IMIĘ I NAZWISKO | NR KONTA | SALDO");
                    //wyświetlanie klijentów
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
                        //wyświetlenie danych zalogowanego klijenta
                        displayclients.display(logged[0].Id, logged[0].Name, logged[0].AccountNr, logged[0].AccountValue);
                        Console.WriteLine("wpisz numer konta na który chcesz zrobić przelew");
                        string pay = Console.ReadLine();
                        if (lstcliects.Exists(x => x.AccountNr == pay))
                        {
                            Console.Clear();
                            Console.WriteLine("podaj kwotę przelewu");
                            string value = Console.ReadLine();
                            //sprawdzanie czy podana wartoś jest liczbą i przekonwertowanie
                            if(int.TryParse(value, out int howMutch))
                                {
                                //sprawdzanie czy kliejnt ma wystarczająco środków
                                if (logged[0].AccountValue > howMutch)
                                {
                                    //pobranei indexów
                                    var index = lstcliects.FindIndex(c => c.Id == odp);
                                    var indexpay = lstcliects.FindIndex(c => c.AccountNr == pay);
                                    //zmiana bilansu kont klientów
                                    lstcliects[index].AccountValue -= howMutch;
                                    lstcliects[indexpay].AccountValue += howMutch;
                                    Console.Clear() ;
                                    Console.WriteLine("przelew wykonany poprawnie");

                                }
                            }
                        }
                        else
                        {
                            //komunikat złego numeru
                            badlogin.loginerror();
                        }
                    }
                    else
                    {
                        //komunikat złego numeru
                        badlogin.loginerror();
                    }
                    break;
                }
            default:
                //wyjście z pętli
                prog = false;
                break;


        }
    }
    else
    {
        //wyświetlenie erroru
        incorrect.bad();
    }
    
}




