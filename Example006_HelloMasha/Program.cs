Console.Write("Введите ваше имя: ");

string username = Console.ReadLine();

if(username.ToLower() == "марина")
{
    Console.WriteLine("Ура, это же Марина");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}


