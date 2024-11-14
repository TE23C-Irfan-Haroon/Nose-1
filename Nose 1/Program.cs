
// if (6 >= 3)
// {
//    Console.WriteLine("hello world");
// }
// Console.ReadLine();


// Console.WriteLine("USERNAME:");
// String username = Console.ReadLine().ToLower();

// if (username == "kalleanka")
// {
//     String password = ""; 

//     while (password != "12345")
//     {
//         Console.WriteLine("PASSWORD:");
//         password = Console.ReadLine();

//         if (password == "12345")
//         {
//             Console.WriteLine("Welcome");
//             Console.ReadLine();
//         }
//         else
//         {
//             Console.WriteLine("WRONG PASSWORD TRY AGAIN");
//         }
//     }
//     Console.WriteLine("Welcome!");
// }
// else
// {
//     Console.WriteLine("fuck off");
//     Console.ReadLine();
// }

// for (int num = 0; num < 32; num++) 
// {
// Console.WriteLine("Hello, World!");
// }
// Console.ReadLine();


// for (int num = 0; num < 5; num++)
// {
//     int answer2 = 0;
//     Console.WriteLine("Write a Number");
//     string answer = Console.ReadLine();

//     int.TryParse(answer, out answer2); 

//     if (answer2 > 5)
//     {
//         Console.WriteLine("högre än 5!");
//     }
// }

// bool succes = false;

// while (succes != true)
// {
//     Console.WriteLine("Write a Number");
//     string answer = Console.ReadLine();
//     int answer2;

//     succes = int.TryParse(answer, out answer2);
// }





using System.Formats.Asn1;

bool succes = false;
string answer;
int answer2;
int rightAnswer = Random.Shared

while (succes != true)
{
    Console.WriteLine("GISSA TALET!!!");
    answer = Console.ReadLine();
    succes = int.TryParse(answer, out answer2);
    
    if (answer2 == 69)
{
    Console.WriteLine("RÄTT GISSNING");
    Console.ReadLine();
}
if (succes != true)
{
    Console.WriteLine("FEL GISSNING FÖRSÖK IGEN");
    continue;
}
if (answer2 < 69)
{
    succes = false;
    Console.WriteLine("FEL GISSNING FÖRSÖK IGEN");
    Console.WriteLine("DIN GISSNING VAR FÖR LÅGT");
}
else if (answer2 > 69)
{
    succes = false;
    Console.WriteLine("FEL GISSNING FÖRSÖK IGEN");
    Console.WriteLine("DIN GISSNING VAR FÖR HÖGT");
}

}
