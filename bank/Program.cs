// See https://aka.ms/new-console-template for more information
using bank;
hello wellcome = new hello() ;
correctAnswer isCorrect = new correctAnswer();
while (true)
{
    string odpowiedz = wellcome.witam();
    if(isCorrect.correct(odpowiedz))
    {
        Console.WriteLine("tak");
    }
    else
    {
 
    }
}



